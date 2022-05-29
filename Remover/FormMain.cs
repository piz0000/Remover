using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remover
{
    public partial class FormMain : Form
    {
        List<RemoveDrive> Drives = new List<RemoveDrive>();
        List<RemoveFolder> Folders = new List<RemoveFolder>();

        enum SelectDriveFolder { None, Drive, Folder, Except }
        SelectDriveFolder Selected = SelectDriveFolder.None;

        int SelectedRow = -1;

        /// <summary>
        /// 자동 시작
        /// </summary>
        bool IsAutoStart = false;
        /// <summary>
        /// 제거 스레드 신호
        /// </summary>
        bool IsRunning { get => RemoveBase.IsRunning; set => RemoveBase.IsRunning = value; }
        /// <summary>
        /// 항목 업데이트 신호
        /// </summary>
        bool IsConfirm = true;

        /// <summary>
        /// 종료 신호
        /// </summary>
        bool IsClose = false;
        NotifyIcon IconNotify = new NotifyIcon();
        MenuItem[] MenuItems = new MenuItem[3];

        ToolTip TipDrvie = new ToolTip();
        ToolTip TipFolder = new ToolTip();
        ToolTip TipExtension = new ToolTip();
        ToolTip TipExtensionTextBox = new ToolTip();
        ToolTip TipStartDate = new ToolTip();


        public FormMain()
        {
            InitializeComponent();

            int index = 0;
            MenuItems[index] = new MenuItem();
            MenuItems[index].Checked = IsAutoStart;
            MenuItems[index].Click += NotifyIcon_Click;
            MenuItems[index].Text = "Auto Start";
            index++;
            MenuItems[index] = new MenuItem();
            MenuItems[index].Click += NotifyIcon_Click;
            MenuItems[index].Text = "Open";
            index++;
            MenuItems[index] = new MenuItem();
            MenuItems[index].Click += NotifyIcon_Click;
            MenuItems[index].Text = "Exit";
            index++;

            IconNotify.ContextMenu = new ContextMenu();
            IconNotify.ContextMenu.MenuItems.AddRange(MenuItems);
            IconNotify.Icon = Properties.Resources.removeIcon;
            IconNotify.Visible = true;
            IconNotify.MouseClick += IconNotify_MouseClick;

            ReadObject();

            buttonAdd.Enabled = false;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;

            TipDrvie.SetToolTip(buttonDrive, "등록 드라이브의 용량이 High% 이상이면 Low% 이하까지 설정 확장자의 파일들을 제거 (가장 오래전 생성된 파일부터 제거)");
            TipFolder.SetToolTip(buttonFolder, "등록 폴더의 설정 확장자의 파일들을 제거 (가장 오래전 생성된 파일부터 제거)");
            TipExtension.SetToolTip(buttonExcept, "등록 폴더의 하위 폴더 및 파일들은 제거 대상에서 제외 (Drive, Folder 영향)");
            TipExtensionTextBox.SetToolTip(label1, "Extensions use semicolons." + Environment.NewLine + "ex) bmp;jpeg;txt;");
            TipExtensionTextBox.SetToolTip(textBoxExtensions, "Extensions use semicolons." + Environment.NewLine + "ex) bmp;jpeg;txt;");

            string tipStr = "Removal exclusion period" + Environment.NewLine;
            tipStr += "-1 : All date ragne" + Environment.NewLine;
            tipStr += "0  : today create file no removal" + Environment.NewLine;
            tipStr += "more : startday ~ today create file no removal";
            TipStartDate.SetToolTip(labelDayRange, tipStr);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            ShowInTaskbar = false;
            Opacity = 0;

            if (IsAutoStart)
                ButtonStart_Click(buttonStart, EventArgs.Empty);
            else
                ButtonStop_Click(buttonStop, EventArgs.Empty);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (IsClose)
            {
                IconNotify.Visible = false;
                IconNotify.Dispose();
            }
            else
            {
                e.Cancel = true;

                IconNotify.Visible = true;

                ShowInTaskbar = false;
                Opacity = 0;
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (e.KeyChar == (char)Keys.Escape)
            {
                ShowInTaskbar = false;
                Opacity = 0;
            }
        }

        void IconNotify_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowInTaskbar = true;
                Opacity = 1;
            }
        }
        void NotifyIcon_Click(object sender, EventArgs e)
        {
            MenuItem item = sender as MenuItem;

            if (item.Text == "Open")
            {
                ShowInTaskbar = true;
                Opacity = 1;
            }
            else if (item.Text == "Exit")
            {
                IsClose = true;
                Close();
            }
            else if (item.Text == "Auto Start")
            {
                IsAutoStart = !IsAutoStart;
                item.Checked = IsAutoStart;
                WriteObject();
            }
        }

        void ButtonDrive_Click(object sender, EventArgs e)
        {
            Selected = SelectDriveFolder.Drive;

            buttonAdd.Enabled = true;
            buttonUpdate.Enabled = true;

            tlpDrive.Visible = true;
            tlpFolder.Visible = false;
            tlpExtension.Visible = true;
            tlpButtons.SendToBack();

            dgvList.Rows.Clear();
            foreach (RemoveDrive drive in Drives)
                dgvList.Rows.Add(drive.Name + "  [" + drive.GetPercentage() + "% Used]", drive.Name);

            if (Drives.Count >= 1)
                DGVList_CellClick(dgvList, new DataGridViewCellEventArgs(0, 0));
            else
                textBoxExtensions.Text = "";
        }
        void ButtonFolder_Click(object sender, EventArgs e)
        {
            Selected = SelectDriveFolder.Folder;

            buttonAdd.Enabled = true;
            buttonUpdate.Enabled = true;

            tlpDrive.Visible = false;
            tlpFolder.Visible = true;
            tlpExtension.Visible = true;
            tlpButtons.SendToBack();

            dgvList.Rows.Clear();
            foreach (RemoveFolder folder in Folders)
                dgvList.Rows.Add(folder.Name, folder.Name);

            if (Folders.Count >= 1)
                DGVList_CellClick(dgvList, new DataGridViewCellEventArgs(0, 0));
            else
                textBoxExtensions.Text = "";
        }
        void ButtonExcept_Click(object sender, EventArgs e)
        {
            Selected = SelectDriveFolder.Except;

            buttonAdd.Enabled = true;
            buttonUpdate.Enabled = false;

            tlpDrive.Visible = false;
            tlpFolder.Visible = false;
            tlpExtension.Visible = false;
            tlpButtons.SendToBack();

            dgvList.Rows.Clear();
            foreach (string exStr in RemoveExcept.Excepts)
                dgvList.Rows.Add(exStr, exStr);
        }

        void ButtonAdd_Click(object sender, EventArgs e)
        {
            switch (Selected)
            {
                case SelectDriveFolder.Drive:
                    using (DriveBrowserDialog dbd = new DriveBrowserDialog())
                    {
                        if (dbd.ShowDialog() == DialogResult.OK)
                        {
                            foreach (RemoveDrive compare in Drives)
                                if (compare.Name == dbd.SelectedDrive)
                                    return;

                            RemoveDrive drive = new RemoveDrive();
                            drive.Name = dbd.SelectedDrive;
                            Drives.Add(drive);
                        }
                        else
                        {
                            return;
                        }
                    }
                    break;

                case SelectDriveFolder.Folder:
                    using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                    {
                        fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                        if (fbd.ShowDialog() == DialogResult.OK)
                        {
                            foreach (RemoveFolder compare in Folders)
                                if (compare.Name == fbd.SelectedPath)
                                    return;

                            RemoveFolder folder = new RemoveFolder();
                            folder.Name = fbd.SelectedPath;
                            Folders.Add(folder);
                        }
                        else
                        {
                            return;
                        }
                    }
                    break;

                case SelectDriveFolder.Except:
                    using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                    {
                        fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                        if (fbd.ShowDialog() == DialogResult.OK)
                        {
                            if (RemoveExcept.Excepts.Contains(fbd.SelectedPath))
                                return;

                            RemoveExcept.Excepts.Add(fbd.SelectedPath);
                        }
                        else
                        {
                            return;
                        }
                    }
                    break;

                default:
                    return;
            }

            WriteObject();

            ReadObject();

            DGVList_CellClick(dgvList, new DataGridViewCellEventArgs(0, dgvList.Rows.Count - 1));

            dgvList.CurrentCell = dgvList.Rows[dgvList.Rows.Count - 1].Cells[0];
        }
        void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedRow <= -1)
                return;

            string key = dgvList.Rows[SelectedRow].Cells[1].Value.ToString();
            if (string.IsNullOrEmpty(key))
                return;

            switch (Selected)
            {
                case SelectDriveFolder.Drive:
                    foreach (RemoveDrive drive in Drives)
                    {
                        if (drive.Name == key)
                        {
                            drive.PercentageLow = Convert.ToInt32(nmPercentageLow.Value);
                            drive.PercentageHigh = Convert.ToInt32(nmPercentageHigh.Value);

                            drive.Extensions.Clear();
                            drive.SetExtension(textBoxExtensions.Text);

                            break;
                        }
                    }
                    break;

                case SelectDriveFolder.Folder:
                    foreach (RemoveFolder folder in Folders)
                    {
                        if (folder.Name == key)
                        {
                            folder.IsSubDirectory = checkBoxSubDirectory.Checked;
                            folder.StartDate = Convert.ToInt32(nmStartDay.Value);

                            folder.Extensions.Clear();
                            folder.SetExtension(textBoxExtensions.Text);

                            break;
                        }
                    }
                    break;

                default:
                    return;
            }

            WriteObject();

            ReadObject();

            DGVList_CellClick(dgvList, new DataGridViewCellEventArgs(0, SelectedRow));

            dgvList.CurrentCell = dgvList.Rows[SelectedRow].Cells[0];
        }
        void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (SelectedRow <= -1)
            {
                return;
            }

            string key = dgvList.Rows[SelectedRow].Cells[1].Value.ToString();
            if (string.IsNullOrEmpty(key))
            {
                return;
            }

            switch (Selected)
            {
                case SelectDriveFolder.Drive:
                    foreach (RemoveDrive drive in Drives)
                    {
                        if (drive.Name == key)
                        {
                            Drives.Remove(drive);
                            break;
                        }
                    }
                    break;

                case SelectDriveFolder.Folder:
                    foreach (RemoveFolder folder in Folders)
                    {
                        if (folder.Name == key)
                        {
                            Folders.Remove(folder);
                            break;
                        }
                    }
                    break;

                case SelectDriveFolder.Except:
                    RemoveExcept.Excepts.Remove(key);
                    break;

                default:
                    return;
            }

            WriteObject();

            ReadObject();

            SelectedRow = -1;

            dgvList.ClearSelection();
        }

        void ButtonStart_Click(object sender, EventArgs e)
        {
            if (IsRunning == false)
            {
                IsRunning = true;

                IsAutoStart = true;
                UpdateAutoStartView();
                WriteObject();

                buttonStart.BackColor = Color.Lime;
                buttonStart.ForeColor = Color.Black;

                buttonStop.BackColor = Color.FromArgb(60, 60, 60);
                buttonStop.ForeColor = Color.White;

                Task.Run(() => Work());
            }
        }
        void ButtonStop_Click(object sender, EventArgs e)
        {
            IsRunning = false;

            IsAutoStart = false;
            UpdateAutoStartView();
            WriteObject();

            buttonStart.BackColor = Color.FromArgb(60, 60, 60);
            buttonStart.ForeColor = Color.White;

            buttonStop.BackColor = Color.Lime;
            buttonStop.ForeColor = Color.Black;
        }

        void DGVList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = -1;

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (Selected != SelectDriveFolder.None)
                    buttonDelete.Enabled = true;
                else
                    return;

                SelectedRow = e.RowIndex;

                string key = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (string.IsNullOrEmpty(key))
                {
                    SelectedRow = -1;
                    return;
                }

                switch (Selected)
                {
                    case SelectDriveFolder.Drive:
                        foreach (RemoveDrive drive in Drives)
                        {
                            if (drive.Name == key)
                            {
                                nmPercentageLow.Value = Convert.ToDecimal(drive.PercentageLow);
                                nmPercentageHigh.Value = Convert.ToDecimal(drive.PercentageHigh);

                                textBoxExtensions.Text = drive.GetExtension();
                                break;
                            }
                        }
                        break;

                    case SelectDriveFolder.Folder:
                        foreach (RemoveFolder folder in Folders)
                        {
                            if (folder.Name == key)
                            {
                                checkBoxSubDirectory.Checked = folder.IsSubDirectory;
                                nmStartDay.Value = folder.StartDate;
                                labelDayRange.Text = "Removal exclusion period" + Environment.NewLine;

                                DateTime dtStd = folder.StartDateTime;
                                if (dtStd > DateTime.Now)
                                {
                                    labelDayRange.Text += dtStd.ToString("yyyy-MM-dd") + " ~ " + dtStd.ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    labelDayRange.Text += dtStd.ToString("yyyy-MM-dd") + " ~ " + DateTime.Now.ToString("yyyy-MM-dd");
                                }

                                textBoxExtensions.Text = folder.GetExtension();
                                break;
                            }
                        }
                        break;

                    default:
                        return;
                }
            }
        }

        void UpdateAutoStartView()
        {
            for (int index = 0; index < MenuItems.Length; index++)
            {
                if (MenuItems[index].Text == "Auto Start")
                {
                    MenuItems[index].Checked = IsAutoStart;
                    break;
                }
            }
        }

        void WriteObject()
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Kind", "App");
            dic.Add("AutoStart", IsAutoStart.ToString());
            list.Add(dic);

            for (int index = 0; index < Drives.Count; index++)
                list.Add(Drives[index].GetParam());

            for (int index = 0; index < Folders.Count; index++)
                list.Add(Folders[index].GetParam());

            list.Add(RemoveExcept.GetParam());

            if (DataContractSerialize.WriteObject(ref list, AppDomain.CurrentDomain.BaseDirectory + "\\Remover.xml"))
            {
                switch (Selected)
                {
                    case SelectDriveFolder.Drive:
                        ButtonDrive_Click(buttonDrive, EventArgs.Empty);
                        break;

                    case SelectDriveFolder.Folder:
                        ButtonFolder_Click(buttonFolder, EventArgs.Empty);
                        break;

                    case SelectDriveFolder.Except:
                        ButtonExcept_Click(buttonExcept, EventArgs.Empty);
                        break;
                }

                IsConfirm = true;

                Text = "Remove " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }
        void ReadObject()
        {
            ReadObject(out List<RemoveDrive> drives, out List<RemoveFolder> folders);
            if (drives != null && folders != null)
            {
                Drives = drives;
                Folders = folders;

                switch (Selected)
                {
                    case SelectDriveFolder.Drive:
                        ButtonDrive_Click(buttonDrive, EventArgs.Empty);
                        break;

                    case SelectDriveFolder.Folder:
                        ButtonFolder_Click(buttonFolder, EventArgs.Empty);
                        break;

                    case SelectDriveFolder.Except:
                        ButtonExcept_Click(buttonExcept, EventArgs.Empty);
                        break;

                    case SelectDriveFolder.None:
                        tlpFolder.Visible = false;
                        tlpDrive.Visible = false;

                        dgvList.Rows.Clear();
                        foreach (RemoveDrive drive in Drives)
                            dgvList.Rows.Add(drive.Name + "  [" + drive.GetPercentage() + "% Used]");

                        foreach (RemoveFolder folder in Folders)
                            dgvList.Rows.Add(folder.Name);

                        foreach (string str in RemoveExcept.Excepts)
                            dgvList.Rows.Add(str);

                        break;
                }
            }
        }
        void ReadObject(out List<RemoveDrive> drives, out List<RemoveFolder> folders)
        {
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();

            if (DataContractSerialize.ReadObject(ref list, AppDomain.CurrentDomain.BaseDirectory + "\\Remover.xml"))
            {
                drives = new List<RemoveDrive>();
                folders = new List<RemoveFolder>();

                foreach (Dictionary<string, string> dic in list)
                {
                    switch (dic["Kind"])
                    {
                        case "App":
                            IsAutoStart = Convert.ToBoolean(dic["AutoStart"]);
                            UpdateAutoStartView();
                            break;

                        case nameof(RemoveDrive):
                            RemoveDrive drive = new RemoveDrive();
                            drive.SetParam(dic);
                            drives.Add(drive);
                            break;

                        case nameof(RemoveFolder):
                            RemoveFolder folder = new RemoveFolder();
                            folder.SetParam(dic);
                            folders.Add(folder);
                            break;

                        case nameof(RemoveExcept):
                            RemoveExcept.SetParam(dic);
                            break;
                    }
                }
            }
            else
            {
                drives = null;
                folders = null;
            }
        }

        void Work()
        {
            List<RemoveDrive> drives = null;
            List<RemoveFolder> folders = null;

            while (IsRunning)
            {
                //10초에 한번 작동
                Task.Delay(10000).Wait();

                //설정 항목 불러오기
                if (IsConfirm || drives == null || folders == null)
                {
                    ReadObject(out drives, out folders);

                    IsConfirm = false;
                }

                if (drives != null)
                    foreach (RemoveDrive drive in drives)
                        drive.Remove();

                if (folders != null)
                    foreach (RemoveFolder folder in folders)
                        folder.Remove();

                Invoke((MethodInvoker)delegate
                {
                    Text = "Remove " + " [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]";
                });
            }
        }

    }
}
