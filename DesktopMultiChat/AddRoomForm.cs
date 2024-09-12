using System;
using System.Linq;
using System.Windows.Forms;
using Flurl.Http;
using System.Threading.Tasks;

namespace DesktopMultiChat
{
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
            memberBox.KeyDown += MemberBox_KeyDown; // Gắn sự kiện KeyDown cho memberBox
        }

        // Giả sử memberBox là một TextBox hoặc RichTextBox
        private void MemberBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // Kiểm tra nếu nhấn Ctrl + V
            {
                // Kiểm tra nếu clipboard có chứa văn bản
                if (Clipboard.ContainsText())
                {
                    string clipboardText = Clipboard.GetText(); // Lấy dữ liệu từ clipboard

                    // Xóa khoảng trắng và xuống dòng, sau đó chèn dấu phẩy giữa các giá trị
                    var processedText = string.Join(", ", clipboardText
                        .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));

                    memberBox.Text = processedText; // Dán dữ liệu đã xử lý vào memberBox
                    e.Handled = true; // Ngăn chặn hành vi dán mặc định
                }
            }
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            string roomName = roomNameBox.Text;
            string memberText = memberBox.Text;

            // Chuyển đổi danh sách thành số nguyên
            var memberIds = memberText.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(id => int.TryParse(id, out var result) ? result : (int?)null)
                .Where(id => id.HasValue)
                .Select(id => id.Value)
                .ToList();

            var requestData = new
            {
                conversationName = roomName,
                memberIds = memberIds
            };

            string url = "https://localhost:7066/api/Admin/add-room";

            try
            {
                // Sử dụng Flurl để gửi POST request
                var response = await url
                    .PostJsonAsync(requestData);

                MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FlurlHttpException ex)
            {
                MessageBox.Show($"Failed to add room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
