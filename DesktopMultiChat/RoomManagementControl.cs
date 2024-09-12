using Flurl.Http; // Flurl namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopMultiChat
{
    public partial class RoomManagementControl : UserControl
    {
        public RoomManagementControl()
        {
            InitializeComponent();
            InitializeDataGridViews();
            LoadData();
         

            viewAccount.KeyDown += viewAccount_KeyDown;
            viewRoom.KeyDown += viewRoom_KeyDown;
            searchBox.TextChanged += SearchBox_TextChanged;
            viewRoom.CellValueChanged += ViewRoom_CellValueChanged;
            viewRoom.CellBeginEdit += ViewRoom_CellBeginEdit;
            restoreBtn.Visible = false;

        }

        // Model cho account
        public class Account
        {
            public int ContactId { get; set; }
            public string FullName { get; set; }
            public string PhoneNumber { get; set; }
        }

        // Model cho room
        public class Room
        {
            public int RoomId { get; set; }
            public string RoomName { get; set; }
            public int Quantity { get; set; }
            public List<string> Participants { get; set; } // Danh sách thành viên
            public List<int> MemberId { get; set; }
        }

        // Định nghĩa các cột cho DataGridView
        private void InitializeDataGridViews()
        {
            // Định nghĩa cột cho viewAccount
            viewAccount.Columns.Clear();
            viewAccount.Columns.Add("ID", "ID");
            viewAccount.Columns.Add("Tên", "Tên");
            viewAccount.Columns.Add("PhoneNumber", "SDT");
            viewAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewAccount.AllowUserToAddRows = false; // Không cho phép tự tạo hàng trống

            // Định nghĩa cột cho viewRoom
            viewRoom.Columns.Clear();
            viewRoom.Columns.Add("RoomId", "Room ID");
            viewRoom.Columns.Add("RoomName", "Tên Phòng");
            


            // Cột cho Participants
            var participantsColumn = new DataGridViewTextBoxColumn
            {
                Name = "Participants",
                HeaderText = "Thành Viên",
                Width = 250,
                DefaultCellStyle = { WrapMode = DataGridViewTriState.True }
            };
            viewRoom.Columns.Add(participantsColumn);

            // Cột cho MemberId
            var memberIdColumn = new DataGridViewTextBoxColumn
            {
                Name = "MemberId",
                HeaderText = "ID Thành Viên",
                Width = 250,
                DefaultCellStyle = { WrapMode = DataGridViewTriState.True }
            };
            viewRoom.Columns.Add(memberIdColumn);

            viewRoom.Columns.Add("Quantity", "Số Lượng");

            viewRoom.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viewRoom.AllowUserToAddRows = false;
            viewRoom.MultiSelect = true;
        }


        private async void LoadData()
        {
            await LoadAccountData();
            await LoadRoomData();
        }
 
        private async Task LoadAccountData()
        {
            try
            {
                var accounts = await "https://localhost:7066/api/Admin/get-all-account"
                    .GetJsonAsync<List<Account>>();

                // Xóa dữ liệu cũ trong viewAccount trước khi thêm mới
                viewAccount.Rows.Clear();

                // Hiển thị contactID và fullName
                foreach (var account in accounts)
                {
                    viewAccount.Rows.Add(account.ContactId, account.FullName,account.PhoneNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tài khoản: " + ex.Message);
            }
        }

        // Phương thức load dữ liệu từ API cho viewRoom

        private async Task LoadRoomData()
        {
            try
            {
                var rooms = await "https://localhost:7066/api/Admin/get-all-room"
                    .GetJsonAsync<List<Room>>();

                viewRoom.Rows.Clear();

                // Hiển thị RoomId, RoomName, Participants và Quantity
                foreach (var room in rooms)
                {
                    // Ghép danh sách thành viên thành chuỗi xuống dòng
                    string participants = string.Join(Environment.NewLine, room.Participants);
                    string memberIds = string.Join(Environment.NewLine, room.MemberId.Select(id => id.ToString()));

                    viewRoom.Rows.Add(room.RoomId, room.RoomName, participants, memberIds, room.Quantity);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message);
            }
        }


        // Sự kiện khi nhấn phím Enter để điều hướng trong viewRoom
        private void viewRoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if (e.Control && e.KeyCode == Keys.V)
                {
                    PasteDataIntoCell();
                    e.Handled = true;
                }
            }
            
        }

        private void PasteDataIntoCell()
        {
            if (viewRoom.CurrentCell != null && Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                viewRoom.CurrentCell.Value = clipboardText;
            }
        }

        // Xử lý sự kiện xóa nhiều dòng
        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (viewRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy danh sách các RoomId từ các hàng được chọn
            var selectedRoomIds = viewRoom.SelectedRows.Cast<DataGridViewRow>()
                .Select(row => row.Cells["RoomId"].Value.ToString())
                .ToList();

            foreach (var roomId in selectedRoomIds)
            {
                try
                {
                    var response = await $"https://localhost:7066/api/Admin/delete-room/{roomId}".DeleteAsync();

                    if (response.StatusCode == 200)
                    {
                        MessageBox.Show($"Xóa phòng {roomId} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var result = await response.GetStringAsync();
                        MessageBox.Show($"Xóa phòng {roomId} thất bại. Lỗi: {result}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FlurlHttpException ex)
                {
                    MessageBox.Show($"Lỗi khi xóa phòng {roomId}: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Tải lại dữ liệu sau khi xóa
            await LoadRoomData();
        }







        private async void AddBtn_Click(object sender, EventArgs e)
        {
            // Hiển thị form ở giữa màn hình
            AddRoomForm addRoomForm = new AddRoomForm();
            addRoomForm.StartPosition = FormStartPosition.CenterScreen;
            addRoomForm.FormClosed += async (s, args) =>
            {
                // Sau khi form đóng, tải lại dữ liệu
                await LoadRoomData();
            };
            // Hiển thị form dưới dạng bình thường (non-modal)
            addRoomForm.Show();
           
        }


        private bool isRoomDataChanged = false;
        private Dictionary<int, Room> originalData = new Dictionary<int, Room>();

        private void ViewRoom_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           
            int rowIndex = e.RowIndex;
            var row = viewRoom.Rows[rowIndex];

            // Lưu dữ liệu của hàng trước khi thay đổi
            if (!originalData.ContainsKey(rowIndex))
            {
                originalData[rowIndex] = new Room
                {
                    RoomId = Convert.ToInt32(row.Cells["RoomId"].Value),
                    RoomName = row.Cells["RoomName"].Value.ToString(),
                    Participants = row.Cells["Participants"].Value.ToString().Split(',').ToList(),
                    Quantity = Convert.ToInt32(row.Cells["Quantity"].Value)
                };
            }
        }


        private void ViewRoom_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            restoreBtn.Visible = true;
            isRoomDataChanged = true;
            int rowIndex = e.RowIndex;
            var row = viewRoom.Rows[rowIndex];

            // Lấy dữ liệu mới sau khi thay đổi
            var changedData = new Room
            {
                RoomId = Convert.ToInt32(row.Cells["RoomId"].Value),
                RoomName = row.Cells["RoomName"].Value?.ToString() ?? string.Empty,
                Participants = row.Cells["Participants"].Value?.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList() ?? new List<string>(),
                MemberId = row.Cells["MemberId"].Value?.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None).Select(int.Parse).ToList() ?? new List<int>(),
                Quantity = Convert.ToInt32(row.Cells["Quantity"].Value)
            };

            // Log dữ liệu đã thay đổi
            Console.WriteLine($"Dữ liệu thay đổi tại RowIndex: {rowIndex}");
            Console.WriteLine($"- RoomId: {changedData.RoomId}");
            Console.WriteLine($"- RoomName: {changedData.RoomName}");
            Console.WriteLine($"- Participants: {string.Join(", ", changedData.Participants)}");
            Console.WriteLine($"- MemberId: {string.Join(", ", changedData.MemberId)}");
            Console.WriteLine($"- Quantity: {changedData.Quantity}");

            // Cập nhật lại dữ liệu ban đầu với giá trị mới
            originalData[rowIndex] = changedData;
        }



        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (isRoomDataChanged)
            {
                // Duyệt qua các hàng đã thay đổi và gửi yêu cầu HTTP
                foreach (var kvp in originalData)
                {
                    var changedRoom = kvp.Value;

                    // Chuẩn bị dữ liệu JSON để gửi với memberIds là mảng số nguyên
                    var requestData = new
                    {
                        conversationId = changedRoom.RoomId,
                        conversationName = changedRoom.RoomName,
                        // Chuyển đổi từ chuỗi memberId thành mảng số nguyên
                        memberIds = changedRoom.MemberId.ToArray()
                    };

                    try
                    {
                        // Gửi yêu cầu HTTP POST đến API bằng Flurl
                        var response = await "https://localhost:7066/api/Admin/edit-room"
                            .PutJsonAsync(requestData);

                        // Kiểm tra kết quả trả về từ API
                        if (response.StatusCode == 200)
                        {
                            MessageBox.Show("Cập nhật phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi cập nhật phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi khi gửi yêu cầu HTTP
                        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Reset lại biến sau khi xử lý xong
                isRoomDataChanged = false;
            }
            else
            {
                MessageBox.Show("Không có thay đổi nào trong dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        // Sự kiện tìm kiếm
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower();

            if (accountRadio.Checked)
            {
                // Tìm kiếm trong viewAccount
                foreach (DataGridViewRow row in viewAccount.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool isVisible = row.Cells["Tên"].Value != null &&
                                         row.Cells["Tên"].Value.ToString().ToLower().Contains(searchText);
                        row.Visible = isVisible;
                    }
                }
            }
            else if (roomRadio.Checked)
            {
                // Tìm kiếm trong viewRoom
                foreach (DataGridViewRow row in viewRoom.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        bool isVisible = row.Cells["RoomName"].Value != null &&
                                         row.Cells["RoomName"].Value.ToString().ToLower().Contains(searchText);
                        row.Visible = isVisible;
                    }
                }
            }
        }

        // Xử lý sao chép ID từ viewAccount
        private void viewAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyIdFromViewAccount();
            }
        }

        // Copy tất cả các ID từ các hàng đã chọn trong viewAccount
        private void CopyIdFromViewAccount()
        {
            if (viewAccount.SelectedCells.Count > 0)
            {
                Clipboard.SetDataObject(viewAccount.GetClipboardContent());
            }
        }

        private async void restoreBtn_Click(object sender, EventArgs e)
        {
            await LoadRoomData(); 
            restoreBtn.Visible = false;
        }
    }
}
