using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife_SD1.Login {
    public partial class LoginPage : UserControl {
        public LoginPage() {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e) {
            // components
            tbPassword.UseSystemPasswordChar = true;
        }

        private async void btnLogin_Click(object sender, EventArgs e) {
            btnLogin.Enabled = false;

            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) {
                _ResetContent("Email / Password cannot be empty.");
                return;
            }

            LoginResult loginResult = await LoginWith(email, password);

            if (!loginResult.Success) {
                _ResetContent(loginResult.Message);
                return;
            }

            Form1.instance.SetLogin(loginResult.Account);
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void _ResetContent(string errorMessage) {
            lbErrors.Text = errorMessage;
            tbEmail.Clear();
            tbPassword.Clear();
            btnLogin.Enabled = true;
        }

        private async Task<LoginResult> LoginWith(string email, string password) {
            Account account;

            using (var db = new SHLife_A07Entities()) {
                account = await db.Account
                    .AsNoTracking()
                    .FirstOrDefaultAsync(u => u.Email == email && u.Password == password);

                if (account == null || account.Role == "1") {
                    return new LoginResult() {
                        Success = false,
                        Message = "Cannot login with your credential."
                    };
                }

                if (account.LockDateTime != null) {
                    return new LoginResult() {
                        Success = false,
                        Message = "Your account has been locked."
                    };
                }
            }

            return new LoginResult() {
                Success = true,
                Message = $"Hello, {account.Nickname}, welcome back.",
                Account = account
            };
        }

        public void RefocusToEmail() {
            tbEmail.Focus();
        }
    }

    public class LoginResult {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Account Account { get; set; } = null;
    }
}
