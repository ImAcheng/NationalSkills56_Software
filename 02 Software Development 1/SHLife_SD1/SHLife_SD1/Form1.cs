using SHLife_SD1.Login;
using SHLife_SD1.Mainpage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife_SD1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // objects
        private Timer systemTimer = new Timer() {
            Interval = 1000,
            Enabled = true
        };

        private Timer apiTimer = new Timer() {
            Interval = 5000,
            Enabled = true
        };

        public static HttpClient apiClient = new HttpClient();

        // pages & form
        public static Form1 instance;
        public static LoginPage loginPage = new LoginPage();
        public static MainPage mainPage;

        private void Form1_Load(object sender, EventArgs e) {
            instance = this;

            // events
            systemTimer.Tick += SystemTimer_Tick;
            apiTimer.Tick += ApiTimer_Tick;

            // form components
            lbTime.Text = DateTime.Now.ToString("'Time': yyyy-MM-dd HH:mm:ss");

            loginPage.Parent = panelMain;
            loginPage.Dock = DockStyle.Fill;
        }

        private void SystemTimer_Tick(object sender, EventArgs e) {
            lbTime.Text = DateTime.Now.ToString("'Time': yyyy-MM-dd HH:mm:ss");
        }

        private async void ApiTimer_Tick(object sender, EventArgs e) {
            try {
                await apiClient.GetAsync("http://localhost:5000");

                lbApiStatus.Text = "Connected";
                lbApiStatus.ForeColor = Color.FromArgb(0, 176, 80);
            }
            catch {
                lbApiStatus.Text = "Disconnected";
                lbApiStatus.ForeColor = Color.Red;
            }
        }

        #region Window Control
        private bool _IsWinBarMouseDown = false;
        private Point _MouseStartPos = new Point(0, 0);

        private void btnWindowClose_Click(object sender, EventArgs e) {
            this.Close();
            Environment.Exit(0);
        }

        private void btnWindowMax_Click(object sender, EventArgs e) {
            // No actions
        }

        private void btnWindowMin_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void lbWindowTitle_MouseDown(object sender, MouseEventArgs e) {
            _IsWinBarMouseDown = true;
            _MouseStartPos = e.Location;
        }

        private void lbWindowTitle_MouseUp(object sender, MouseEventArgs e) {
            _IsWinBarMouseDown = false;
        }

        private void lbWindowTitle_MouseMove(object sender, MouseEventArgs e) {
            if (!_IsWinBarMouseDown) return;

            this.Location = new Point(this.Location.X + (e.X - _MouseStartPos.X),
                                     this.Location.Y + (e.Y - _MouseStartPos.Y));
        }
        #endregion

        #region Login & Logout
        public void SetLogin(Account account) {
            string roleText = string.Empty; // "" (standard way)

            switch (account.Role) {
                case "1":
                    roleText = "User";
                    break;
                case "2":
                    roleText = "Reviewer";
                    break;
                case "3":
                    roleText = "Administrator";
                    break;
                default:
                    roleText = "Unknow";
                    break;
            }

            lbNameRole.Text = $"Currently Login: {account.Nickname}\n" +
                $"Role: {roleText}";

            AppSession.CurrentAccount = account;
            
            // use Int32.TryParse to parse a string to a signed 32-bits integer
            // also prevent format exception
            if (!Int32.TryParse(account.Role, out AppSession.PermissionLevel)) {
                MessageBox.Show("Incorrect format of account role.", 
                    "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnLogInOut.Text = "Logout";

            MessageBox.Show($"Hello, {account.Nickname}, welcome back.");

            mainPage = new MainPage() {
                Parent = panelMain,
                Dock = DockStyle.Fill
            };
            loginPage.Dispose();
        }

        private void Logout() {
            AppSession.CurrentAccount = null;
            AppSession.PermissionLevel = 0;

            MessageBox.Show("Sign out successfully.");

            lbNameRole.Text = "Currently Login: Anonymous";
            btnLogInOut.Text = "Login";

            loginPage = new LoginPage() {
                Parent = panelMain,
                Dock = DockStyle.Fill
            };
            mainPage.Dispose();
        }

        private void btnLogInOut_Click(object sender, EventArgs e) {
            if (AppSession.CurrentAccount == null) {
                loginPage?.RefocusToEmail();
            }
            else {
                Logout();
            }
        }
        #endregion
    }
}
