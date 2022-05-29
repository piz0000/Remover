using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Remover
{
    public partial class DriveBrowserDialog : Form
    {
        public string SelectedDrive { get; set; } = string.Empty;

        public DriveBrowserDialog()
        {
            InitializeComponent();

            string[] list = DriveInfo.GetDrives().Select(name => name.Name).ToArray();

            for (int index = 0; index < list.Length; index++)
            {
                treeViewDrive.Nodes.Add(list[index]);
            }
        }

        void buttonOK_Click(object sender, EventArgs e)
        {
            SelectedDrive = treeViewDrive.SelectedNode.Text;
            DialogResult = DialogResult.OK;
        }

        void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
