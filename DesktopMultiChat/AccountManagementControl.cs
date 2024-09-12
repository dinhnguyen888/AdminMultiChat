using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Flurl.Http;

namespace DesktopMultiChat
{
    public partial class AccountManagementControl : UserControl
    {
        private List<Account> _accounts;
        private bool _isAddingAccount = false; // Cờ để kiểm tra xem có đang thêm tài khoản hay không

        public AccountManagementControl()
        {
            InitializeComponent();
            LoadAccounts();
            SetupContextMenu();
            searchBox.TextChanged += SearchBox_TextChanged;

          
        }

        public class Account
        {
            public int ContactId { get; set; }
            public string FullName { get; set; }
            public string PhoneNumber { get; set; }
            public string Password { get; set; }
            public bool? IsAdmin { get; set; }
        }

        private async void LoadAccounts()
        {
            try
            {
                _accounts = await "https://localhost:7066/api/Admin/get-all-account"
                    .GetJsonAsync<List<Account>>();

                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accounts: " + ex.Message);
            }
        }

        private void SetupDataGridView()
        {
            viewAccount.DataSource = null;
            viewAccount.AutoGenerateColumns = false;
            viewAccount.Columns.Clear();

            viewAccount.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ContactId", HeaderText = "ID", Width = 50 });
            viewAccount.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Tên", Width = 150 });
            viewAccount.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "SDT", Width = 100 });
            viewAccount.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Password", HeaderText = "Mật khẩu", Width = 100 });
            viewAccount.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "IsAdmin", HeaderText = "Admin?", Width = 50 });
       
            viewAccount.DataSource = _accounts;
            viewAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewAccount.AllowUserToAddRows = true;

            viewAccount.CellContentClick += ViewAccount_CellContentClick;
        }

        private void SetupContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem addItem = new ToolStripMenuItem("Thêm");
            ToolStripMenuItem editItem = new ToolStripMenuItem("Sửa");
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Xóa");

            contextMenu.Items.AddRange(new[] { addItem, editItem, deleteItem });
            viewAccount.ContextMenuStrip = contextMenu;

            addItem.Click += AddItem_Click;
            editItem.Click += EditItem_Click;
            deleteItem.Click += DeleteItem_Click;

            viewAccount.CellMouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    // Nếu click chuột phải vào một hàng có sẵn
                    if (e.RowIndex >= 0)
                    {
                        viewAccount.ClearSelection();
                        viewAccount.Rows[e.RowIndex].Selected = true;
                        contextMenu.Show(Cursor.Position);
                    }
                    else
                    {
                        // Nếu click chuột phải vào vùng trống (không có hàng nào được chọn)
                        // Thêm hàng mới vào DataGridView
                        var newRowIndex = viewAccount.Rows.Add();
                        viewAccount.ClearSelection();
                        viewAccount.Rows[newRowIndex].Selected = true;
                        viewAccount.CurrentCell = viewAccount.Rows[newRowIndex].Cells[0]; // Đặt ô hiện tại để người dùng nhập liệu
                        viewAccount.BeginEdit(true); // Bắt đầu chỉnh sửa
                    }
                }
            };

        }

        private bool _isProcessing = false;

        private async void ViewAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_isProcessing)
                return;

            _isProcessing = true;

            try
            {
                // Check if the column is DataGridViewCheckBoxColumn and if the row index is valid
                if (viewAccount.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
                {
                    var account = viewAccount.Rows[e.RowIndex].DataBoundItem as Account;

                    if (account == null)
                    {
                        MessageBox.Show("không tìm thấy thông tin tài khoản hàng đã chọn.");
                        return;
                    }

                    try
                    {
                        // Send request
                        await $"https://localhost:7066/api/Admin/change-admin-permission/{account.ContactId}".PostJsonAsync(new { });
                        MessageBox.Show("Đổi quyền thành công.");
                        LoadAccounts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            finally
            {
                _isProcessing = false;
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            var newAccount = new Account
            {
                FullName = string.Empty,
                PhoneNumber = string.Empty,
                Password = string.Empty
            };

            _accounts.Insert(0, newAccount);

            viewAccount.DataSource = null;
            viewAccount.DataSource = _accounts;

            var newRow = viewAccount.Rows[0];
            newRow.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;

            viewAccount.CurrentCell = newRow.Cells[1];
            viewAccount.BeginEdit(true);

            // Đặt cờ thành true để cho biết đang trong quá trình thêm tài khoản
            _isAddingAccount = true;
           
        }

        // Ghi đè phương thức ProcessCmdKey chỉ khi đang thêm tài khoản
        


        private async void UpdateCurrentRowData(DataGridViewRow currentRow)
        {
            if (currentRow != null)
            {
                var account = currentRow.DataBoundItem as Account;
                if (account != null)
                {
                    try
                    {
                        var updatedAccount = new
                        {
                            FullName = account.FullName,
                            PhoneNumber = account.PhoneNumber,
                            Password = account.Password
                        };

                        var response = await $"https://localhost:7066/api/Admin/update-account/{account.ContactId}"
                            .PutJsonAsync(updatedAccount);

                        if ((int)response.StatusCode == 200)
                        {
                            MessageBox.Show("Cập nhật tài khoản thành công.");
                            LoadAccounts();
                        }
                        else
                        {
                            MessageBox.Show($"Cập nhật tài khoản thất bại. Mã trạng thái: {response.StatusCode}");
                        }
                    }
                    catch (FlurlHttpException ex)
                    {
                        MessageBox.Show($"Lỗi khi cập nhật tài khoản: {ex.Message}");
                    }
                }
            }
        }


        // Phương thức lưu dữ liệu của hàng hiện tại
        private async void SaveCurrentRowData(DataGridViewRow currentRow)
        {
            if (currentRow != null)
            {
                var account = currentRow.DataBoundItem as Account;
                if (account != null)
                {
                    try
                    {
                        var accountData = new
                        {
                            fullName = account.FullName,
                            phoneNumber = account.PhoneNumber,
                            password = account.Password
                        };

                        var response = await "https://localhost:7066/api/Register"
                            .PostJsonAsync(accountData);

                        if (response.StatusCode == 200)
                        {
                            MessageBox.Show($"Tài khoản đã lưu: {account.FullName}, {account.PhoneNumber}");
                           
                        }
                        else
                        {
                            MessageBox.Show($"Lỗi: {response.StatusCode}");
                        }
                        LoadAccounts();
                    }
                    catch (FlurlHttpException ex)
                    {
                        MessageBox.Show($"Lỗi gửi yêu cầu: {ex.Message}");
                        LoadAccounts();
                    }
                }
            }
        }

        // Thay đổi trong phương thức EditItem_Click chỉ thực hiện việc gửi data và thông báo
        private async void EditItem_Click(object sender, EventArgs e)
        {
            if (viewAccount.SelectedRows.Count == 1)
            {
                var selectedRow = viewAccount.SelectedRows[0];
                var account = selectedRow.DataBoundItem as Account;

                if (account == null)
                {
                    MessageBox.Show("Không nhận được thông tin ở hàng đã chọn.");
                    return;
                }

                // Gửi dữ liệu tài khoản để cập nhật
                try
                {
                    var updatedAccount = new
                    {
                        FullName = account.FullName,
                        PhoneNumber = account.PhoneNumber,
                        Password = account.Password
                    };

                    var response = await $"https://localhost:7066/api/Admin/update-account/{account.ContactId}"
                                         .PutJsonAsync(updatedAccount);

                    if ((int)response.StatusCode == 200)
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công.");
                        LoadAccounts(); // Tải lại danh sách sau khi cập nhật thành công
                    }
                    else
                    {
                        MessageBox.Show($"Cập nhật tài khoản thất bại. Mã trạng thái: {response.StatusCode}");
                    }
                }
                catch (FlurlHttpException ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật tài khoản: {ex.Message}");
                }

                // Không chỉnh sửa trong viewAccount, chỉ hiển thị thông báo.
            }
        }

        // Ghi đè phương thức ProcessCmdKey để xử lý hành động thêm và chỉnh sửa
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (_isAddingAccount)
            {
             
                if (keyData == Keys.Enter && viewAccount.IsCurrentCellInEditMode)
                {
                    if (viewAccount.CurrentCell.ColumnIndex == viewAccount.Columns[3].Index) // Kiểm tra nếu đã đến cột cuối
                    {
                        viewAccount.EndEdit();
                        var currentRow = viewAccount.CurrentRow;
                        if (currentRow != null)
                        {
                            currentRow.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        }
                        SaveCurrentRowData(currentRow);
                        _isAddingAccount = false; // Đặt lại cờ khi hoàn thành thêm tài khoản
                        return true;
                    }
                    else
                    {
                        viewAccount.CurrentCell = viewAccount.Rows[viewAccount.CurrentCell.RowIndex].Cells[viewAccount.CurrentCell.ColumnIndex + 1];
                        return true;
                    }
                }
            }

            // Nếu người dùng nhấn Enter để hoàn tất chỉnh sửa
            if (keyData == Keys.Enter && viewAccount.IsCurrentCellInEditMode)
            {
                if (viewAccount.CurrentCell.ColumnIndex == viewAccount.Columns[3].Index) // Cột cuối
                {
                    viewAccount.EndEdit();
                    var currentRow = viewAccount.CurrentRow;
                    if (currentRow != null)
                    {
                        currentRow.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    }
                    UpdateCurrentRowData(currentRow);
                    return true;
                }
                else if (viewAccount.CurrentCell.ColumnIndex < 3) // Chuyển qua cột tiếp theo nếu chưa đến cột cuối
                {
                    viewAccount.CurrentCell = viewAccount.Rows[viewAccount.CurrentCell.RowIndex].Cells[viewAccount.CurrentCell.ColumnIndex + 1];
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



        private async void DeleteItem_Click(object sender, EventArgs e)
        {
            if (viewAccount.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa?", "Confirm Delete", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    try
                    {
                        foreach (DataGridViewRow row in viewAccount.SelectedRows)
                        {
                            int accountId = Convert.ToInt32(row.Cells[0].Value);

                            var response = await $"https://localhost:7066/api/Admin/delete-account/{accountId}"
                                                .DeleteAsync();

                            if (response.StatusCode == 200)
                            {
                                MessageBox.Show($"Tài khoản đã được xóa với ID: {accountId}");
                                LoadAccounts();
                            }
                            else
                            {
                                MessageBox.Show($"Xóa thất bại. Status code: {response.StatusCode}");
                            }
                        }
                    }
                    catch (FlurlHttpException ex)
                    {
                        MessageBox.Show($"Lỗi xóa tài khoản: {ex.Message}");
                    }
                }
            }
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            LoadAccounts();
         
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var searchTerm = searchBox.Text.ToLower();
            var filteredAccounts = _accounts.Where(a => a.FullName.ToLower().Contains(searchTerm)).ToList();

            viewAccount.DataSource = null;
            viewAccount.DataSource = filteredAccounts;
        }
    }
}
