using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Newtonsoft.Json;

namespace DesktopMultiChat
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        public class LoginResponse
        {
            public string Message { get; set; }
            public string FullName { get; set; }
            public int Id { get; set; }
            public string PhoneNumber { get; set; }
        }


        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            
            string phone = PhoneBox.Text;
            string password = PassBox.Text;

            try
            {
                // Call Api with Flurl
                var response = await "https://localhost:7066/api/Admin/login"
                    .PostJsonAsync(new { PhoneNumber = phone, Password = password })
                    .ReceiveJson<LoginResponse>(); // 

                if (response.Message == "Login successful.")
                {
                    var managementForm = new ManagementForm();
                    managementForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại: " + response.Message);
                }
            }
            catch (FlurlHttpException ex)
            {
                // Handle error
                var error = await ex.GetResponseStringAsync();
                MessageBox.Show("Đăng nhập thất bại: " + error);
            }
            catch (Exception ex)
            {
                // exxception handle
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }


}

    

