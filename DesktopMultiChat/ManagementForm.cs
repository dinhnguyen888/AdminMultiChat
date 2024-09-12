using System;
using System.Windows.Forms;
using Flurl.Http;

namespace DesktopMultiChat
{
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
            this.FormClosing += ManagementForm_FormClosing;
            var roomManagementControl = new RoomManagementControl
            {
                Dock = DockStyle.Fill
            };
            viewPanel.Controls.Add(roomManagementControl);
        }

        private void ManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Khởi tạo RoomManagementControl
            var roomManagementControl = new RoomManagementControl
            {
                Dock = DockStyle.Fill
            };

            // Xóa các control cũ trong viewPanel và thêm control mới
            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(roomManagementControl);
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Khởi tạo AccountManagementControl
            var accountManagementControl = new AccountManagementControl
            {
                Dock = DockStyle.Fill
            };

            // Xóa các control cũ trong viewPanel và thêm control mới
            viewPanel.Controls.Clear();
            viewPanel.Controls.Add(accountManagementControl);
        }

    }
}
