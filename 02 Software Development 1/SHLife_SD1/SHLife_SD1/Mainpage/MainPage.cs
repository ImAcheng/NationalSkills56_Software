using System;
using System.Windows.Forms;

namespace SHLife_SD1.Mainpage {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private UserControl CurrentPage;

        private void MainPage_Load(object sender, EventArgs e) {
            if (AppSession.PermissionLevel != 3)
                btnGoVerification.Visible = false;
        }

        private void btnGoReview_Click(object sender, EventArgs e) {
            CurrentPage?.Dispose();
            CurrentPage = new ReviewPage() {
                Parent = panelMain,
                Dock = DockStyle.Fill
            };
        }

        private void btnGoBrowse_Click(object sender, EventArgs e) {
            CurrentPage?.Dispose();
            CurrentPage = new BrowsePage() {
                Parent = panelMain,
                Dock = DockStyle.Fill
            };
        }

        private void btnGoPost_Click(object sender, EventArgs e) {
            CurrentPage?.Dispose();
            CurrentPage = new PostPage() {
                Parent = panelMain,
                Dock = DockStyle.Fill
            };
        }

        private void btnGoVerification_Click(object sender, EventArgs e) {

        }
    }
}
