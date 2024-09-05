using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DesktopMultiChat
{
  
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            // Kiểm tra thông tin đầu vào
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var loginDto = new
            {
                Username = username,
                Password = password
            };

            try
            {
                var result = await LoginAsync(loginDto);

                if (result != null)
                {
                    GlobalData.GlobalName = result.Username;
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở form ChatForm
                    ChatForm chatForm = new ChatForm();
                    chatForm.Show();
                   this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to log in: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<AccountDto> LoginAsync(object loginDto)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7066/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent(JsonConvert.SerializeObject(loginDto), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("api/Accounts/login", content);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var account = JsonConvert.DeserializeObject<AccountDto>(json);
                    return account;
                }
                return null;
            }
        }
    }

    public class AccountDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }
}
