using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;

namespace DesktopMultiChat
{
    public partial class ChatForm : Form
    {
        private readonly HttpClient _httpClient;
        private HubConnection _hubConnection;
        private string globalClickName;

        public ChatForm()
        {
            InitializeComponent();
            // Khởi tạo HttpClient và thiết lập các sự kiện
            _httpClient = new HttpClient();
            showList.Items.Clear();

            // Sự kiện cho form đóng
            this.FormClosing += ChatForm_FormClosing;

            // Sự kiện khi chọn item từ showList
            showList.SelectedIndexChanged += ShowList_SelectedIndexChanged;

            // Sự kiện khi nhấn phím Enter
            inputTextbox.KeyDown += (sender, e) => EnterPress(inputTextbox, e);

            // Initialize SignalR connection
            InitializeSignalRConnection();
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EnterPress(TextBox textBox, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string message = textBox.Text;

                if (!string.IsNullOrWhiteSpace(message))
                {
                    // Gửi tin nhắn qua SignalR
                    SendMessage(globalClickName, message);


                    // Hiển thị tin nhắn của người dùng trong chat
                    showMess.AppendText($"{GlobalData.GlobalName}: {message}{Environment.NewLine}");

                    // Xóa nội dung trong hộp nhập
                    textBox.Clear();

                    // Ngăn tiếng kêu mặc định của phím Enter
                    e.SuppressKeyPress = true;
                }
            }
        }

        private async void InitializeSignalRConnection()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7066/chat") // Thay bằng URL của bạn
                .Build();

            // Xử lý tin nhắn nhận được từ SignalR
            _hubConnection.On<object>("ReceiveMessage", (message) =>
            {
                Invoke(new Action(() =>
                {
                    // Lấy thông tin người gửi và nội dung tin nhắn
                    var sender = message.GetType().GetProperty("Sender").GetValue(message, null);
                    var content = message.GetType().GetProperty("Content").GetValue(message, null);

                    // Hiển thị tin nhắn trong showMess
                    showMess.AppendText($"{sender}: {content}{Environment.NewLine}");
                }));
            });

            try
            {
                await _hubConnection.StartAsync();
                MessageBox.Show("SignalR Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối SignalR: {ex.Message}");
            }
        }

        private async void SendMessage(string receiver, string content)
        {
            if (_hubConnection.State == HubConnectionState.Connected)
            {
                try
                {
                    await _hubConnection.InvokeAsync("SendMessage", receiver, "Client", GlobalData.GlobalName, "Text", content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi gửi tin nhắn: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("SignalR chưa được kết nối");
            }
        }

        private async void accountBtn_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://localhost:7066/api/Accounts";
            try
            {
                // Lấy dữ liệu từ API
                HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseData = await response.Content.ReadAsStringAsync();
                var accounts = JsonSerializer.Deserialize<List<Account>>(responseData);

                // Xóa và thêm các account vào showList
                showList.Items.Clear();
                foreach (var account in accounts)
                {
                    showList.Items.Add(account.username);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void ShowList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showList.SelectedIndex >= 0)
            {
                // Lưu trữ tên người dùng được chọn
                globalClickName = showList.SelectedItem.ToString();
                nameLabel.Text = globalClickName;

                // Không cần gọi API để lấy tin nhắn, tin nhắn sẽ nhận qua SignalR
            }
        }

        public class Account
        {
            public string username { get; set; }
        }

        public class MessageDto
        {
            public string Sender { get; set; }
            public string Content { get; set; }
        }

        // Placeholder event handlers (can be implemented as needed)
        private void conversationBtn_Click(object sender, EventArgs e) { }
        private void roomBtn_Click(object sender, EventArgs e) { }
        private void inputTextbox_TextChanged(object sender, EventArgs e) { }
        private void sendFileBtn_Click(object sender, EventArgs e) { }
        private void sendImgBtn_Click(object sender, EventArgs e) { }
        private void showMess_TextChanged(object sender, EventArgs e) { }
        private void search_TextChanged(object sender, EventArgs e) { }
        private void showList_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void inputTextbox_KeyDown(object sender, KeyEventArgs e) { }
    }
}
