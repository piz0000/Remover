
namespace Remover
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.nmStartDay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmPercentageHigh = new System.Windows.Forms.NumericUpDown();
            this.tlpDrive = new System.Windows.Forms.TableLayoutPanel();
            this.nmPercentageLow = new System.Windows.Forms.NumericUpDown();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonDrive = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExcept = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ColumnFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpFolder = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDayRange = new System.Windows.Forms.Label();
            this.checkBoxSubDirectory = new System.Windows.Forms.CheckBox();
            this.tlpList = new System.Windows.Forms.TableLayoutPanel();
            this.tlpExtension = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExtensions = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmStartDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPercentageHigh)).BeginInit();
            this.tlpDrive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPercentageLow)).BeginInit();
            this.tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tlpFolder.SuspendLayout();
            this.tlpList.SuspendLayout();
            this.tlpExtension.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Percentage Low";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmStartDay
            // 
            this.nmStartDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nmStartDay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmStartDay.Location = new System.Drawing.Point(211, 22);
            this.nmStartDay.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmStartDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nmStartDay.Name = "nmStartDay";
            this.nmStartDay.Size = new System.Drawing.Size(96, 26);
            this.nmStartDay.TabIndex = 5;
            this.nmStartDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmStartDay.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(262, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Percentage High";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmPercentageHigh
            // 
            this.nmPercentageHigh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nmPercentageHigh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPercentageHigh.Location = new System.Drawing.Point(262, 38);
            this.nmPercentageHigh.Name = "nmPercentageHigh";
            this.nmPercentageHigh.Size = new System.Drawing.Size(251, 26);
            this.nmPercentageHigh.TabIndex = 5;
            this.nmPercentageHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmPercentageHigh.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // tlpDrive
            // 
            this.tlpDrive.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDrive.ColumnCount = 2;
            this.tlpDrive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDrive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDrive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDrive.Controls.Add(this.label2, 0, 0);
            this.tlpDrive.Controls.Add(this.nmPercentageHigh, 1, 1);
            this.tlpDrive.Controls.Add(this.label3, 1, 0);
            this.tlpDrive.Controls.Add(this.nmPercentageLow, 0, 1);
            this.tlpDrive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpDrive.Location = new System.Drawing.Point(113, 306);
            this.tlpDrive.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDrive.Name = "tlpDrive";
            this.tlpDrive.Padding = new System.Windows.Forms.Padding(1);
            this.tlpDrive.RowCount = 2;
            this.tlpDrive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDrive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDrive.Size = new System.Drawing.Size(518, 70);
            this.tlpDrive.TabIndex = 8;
            // 
            // nmPercentageLow
            // 
            this.nmPercentageLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nmPercentageLow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPercentageLow.Location = new System.Drawing.Point(5, 38);
            this.nmPercentageLow.Name = "nmPercentageLow";
            this.nmPercentageLow.Size = new System.Drawing.Size(250, 26);
            this.nmPercentageLow.TabIndex = 5;
            this.nmPercentageLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmPercentageLow.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Controls.Add(this.buttonUpdate, 0, 5);
            this.tlpButtons.Controls.Add(this.buttonAdd, 0, 4);
            this.tlpButtons.Controls.Add(this.buttonStop, 0, 9);
            this.tlpButtons.Controls.Add(this.buttonStart, 0, 8);
            this.tlpButtons.Controls.Add(this.buttonDrive, 0, 0);
            this.tlpButtons.Controls.Add(this.buttonFolder, 0, 1);
            this.tlpButtons.Controls.Add(this.buttonDelete, 0, 6);
            this.tlpButtons.Controls.Add(this.buttonExcept, 0, 2);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpButtons.Location = new System.Drawing.Point(3, 3);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 10;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpButtons.Size = new System.Drawing.Size(110, 373);
            this.tlpButtons.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(3, 189);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(104, 39);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(3, 144);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 39);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Location = new System.Drawing.Point(3, 330);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(104, 40);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(3, 285);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 39);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonDrive
            // 
            this.buttonDrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDrive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrive.Location = new System.Drawing.Point(3, 3);
            this.buttonDrive.Name = "buttonDrive";
            this.buttonDrive.Size = new System.Drawing.Size(104, 39);
            this.buttonDrive.TabIndex = 1;
            this.buttonDrive.Text = "Drive";
            this.buttonDrive.UseVisualStyleBackColor = true;
            this.buttonDrive.Click += new System.EventHandler(this.ButtonDrive_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFolder.Location = new System.Drawing.Point(3, 48);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(104, 39);
            this.buttonFolder.TabIndex = 1;
            this.buttonFolder.Text = "Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.ButtonFolder_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(3, 234);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 39);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonExcept
            // 
            this.buttonExcept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExcept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcept.Location = new System.Drawing.Point(3, 93);
            this.buttonExcept.Name = "buttonExcept";
            this.buttonExcept.Size = new System.Drawing.Size(104, 39);
            this.buttonExcept.TabIndex = 1;
            this.buttonExcept.Text = "Except";
            this.buttonExcept.UseVisualStyleBackColor = true;
            this.buttonExcept.Click += new System.EventHandler(this.ButtonExcept_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.ColumnHeadersVisible = false;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFolder,
            this.ColumnKey});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 3);
            this.dgvList.Margin = new System.Windows.Forms.Padding(0);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvList.Size = new System.Drawing.Size(518, 192);
            this.dgvList.TabIndex = 10;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVList_CellClick);
            // 
            // ColumnFolder
            // 
            this.ColumnFolder.FillWeight = 174.6193F;
            this.ColumnFolder.HeaderText = "Path";
            this.ColumnFolder.Name = "ColumnFolder";
            this.ColumnFolder.ReadOnly = true;
            // 
            // ColumnKey
            // 
            this.ColumnKey.HeaderText = "Key";
            this.ColumnKey.Name = "ColumnKey";
            this.ColumnKey.ReadOnly = true;
            this.ColumnKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnKey.Visible = false;
            // 
            // tlpFolder
            // 
            this.tlpFolder.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpFolder.ColumnCount = 5;
            this.tlpFolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFolder.Controls.Add(this.nmStartDay, 2, 0);
            this.tlpFolder.Controls.Add(this.label6, 1, 0);
            this.tlpFolder.Controls.Add(this.labelDayRange, 3, 0);
            this.tlpFolder.Controls.Add(this.checkBoxSubDirectory, 0, 0);
            this.tlpFolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFolder.Location = new System.Drawing.Point(113, 236);
            this.tlpFolder.Margin = new System.Windows.Forms.Padding(0);
            this.tlpFolder.Name = "tlpFolder";
            this.tlpFolder.Padding = new System.Windows.Forms.Padding(1);
            this.tlpFolder.RowCount = 1;
            this.tlpFolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFolder.Size = new System.Drawing.Size(518, 70);
            this.tlpFolder.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(108, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 60);
            this.label6.TabIndex = 4;
            this.label6.Text = "Start Day";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDayRange
            // 
            this.labelDayRange.AutoSize = true;
            this.tlpFolder.SetColumnSpan(this.labelDayRange, 2);
            this.labelDayRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDayRange.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDayRange.Location = new System.Drawing.Point(314, 2);
            this.labelDayRange.Name = "labelDayRange";
            this.labelDayRange.Size = new System.Drawing.Size(199, 66);
            this.labelDayRange.TabIndex = 4;
            this.labelDayRange.Text = "Removal exclusion period\r\n0000-00-00 ~ 9999-99-99";
            this.labelDayRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxSubDirectory
            // 
            this.checkBoxSubDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkBoxSubDirectory.AutoSize = true;
            this.checkBoxSubDirectory.Location = new System.Drawing.Point(22, 5);
            this.checkBoxSubDirectory.Name = "checkBoxSubDirectory";
            this.checkBoxSubDirectory.Size = new System.Drawing.Size(61, 60);
            this.checkBoxSubDirectory.TabIndex = 3;
            this.checkBoxSubDirectory.Text = "SubDir";
            this.checkBoxSubDirectory.UseVisualStyleBackColor = true;
            // 
            // tlpList
            // 
            this.tlpList.ColumnCount = 1;
            this.tlpList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.Controls.Add(this.dgvList, 0, 0);
            this.tlpList.Controls.Add(this.tlpExtension, 0, 1);
            this.tlpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpList.Location = new System.Drawing.Point(113, 3);
            this.tlpList.Margin = new System.Windows.Forms.Padding(0);
            this.tlpList.Name = "tlpList";
            this.tlpList.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tlpList.RowCount = 2;
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpList.Size = new System.Drawing.Size(518, 233);
            this.tlpList.TabIndex = 13;
            // 
            // tlpExtension
            // 
            this.tlpExtension.ColumnCount = 2;
            this.tlpExtension.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpExtension.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExtension.Controls.Add(this.label1, 0, 0);
            this.tlpExtension.Controls.Add(this.textBoxExtensions, 1, 0);
            this.tlpExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExtension.Location = new System.Drawing.Point(0, 195);
            this.tlpExtension.Margin = new System.Windows.Forms.Padding(0);
            this.tlpExtension.Name = "tlpExtension";
            this.tlpExtension.Padding = new System.Windows.Forms.Padding(1);
            this.tlpExtension.RowCount = 1;
            this.tlpExtension.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExtension.Size = new System.Drawing.Size(518, 35);
            this.tlpExtension.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Extension";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxExtensions
            // 
            this.textBoxExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtensions.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxExtensions.Location = new System.Drawing.Point(104, 4);
            this.textBoxExtensions.Name = "textBoxExtensions";
            this.textBoxExtensions.Size = new System.Drawing.Size(410, 26);
            this.textBoxExtensions.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(634, 379);
            this.Controls.Add(this.tlpList);
            this.Controls.Add(this.tlpFolder);
            this.Controls.Add(this.tlpDrive);
            this.Controls.Add(this.tlpButtons);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove";
            ((System.ComponentModel.ISupportInitialize)(this.nmStartDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPercentageHigh)).EndInit();
            this.tlpDrive.ResumeLayout(false);
            this.tlpDrive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPercentageLow)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tlpFolder.ResumeLayout(false);
            this.tlpFolder.PerformLayout();
            this.tlpList.ResumeLayout(false);
            this.tlpExtension.ResumeLayout(false);
            this.tlpExtension.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmStartDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmPercentageHigh;
        private System.Windows.Forms.TableLayoutPanel tlpDrive;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TableLayoutPanel tlpFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDayRange;
        private System.Windows.Forms.NumericUpDown nmPercentageLow;
        private System.Windows.Forms.CheckBox checkBoxSubDirectory;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonDrive;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.TableLayoutPanel tlpList;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKey;
        private System.Windows.Forms.Button buttonExcept;
        private System.Windows.Forms.TableLayoutPanel tlpExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExtensions;
    }
}

