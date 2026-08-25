using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife_SD1.Mainpage {
    public partial class PostPage : UserControl {
        public PostPage() {
            InitializeComponent();
        }

        private BindingList<PostViewModel> _PostDataSource;

        private async void PostPage_Load(object sender, EventArgs e) {
            dgvPosts.Font = GlobalAsset.DgvFont;
            dgvPosts.ReadOnly = true;
            dgvPosts.AllowUserToAddRows = false;
            dgvPosts.AutoGenerateColumns = false;
            dgvPosts.AllowUserToResizeRows = false; // 阻止使用者調整 Row 高度 (*僅參考用 競賽不要弄)

            cbMedia.SelectedIndex = 0;
            panelDetail.Hide();

            await _SetPosts(false);
        }

        #region functions
        private async Task _SetPosts(bool useFilter) {
            string keyword = tbKeyword.Text.Trim().ToLower();
            bool skipKeyword = string.IsNullOrEmpty(keyword);

            string nickname = tbNickname.Text.Trim().ToLower();
            bool skipNickname = string.IsNullOrEmpty(nickname);

            int mediaType = cbMedia.SelectedIndex;

            DateTime dateStart = dtpStart.Value.Date;
            DateTime dateEnd = dtpEnd.Value.Date.AddDays(1);

            using (var db = new SHLife_A07Entities()) {
                var source = await db.Post
                    .AsNoTracking()
                    .Where(x => !useFilter || (
                        (skipKeyword || x.Message.ToLower().Contains(keyword) || x.PostComment.Any(c => c.Message.ToLower().Contains(keyword))) &&
                        (skipNickname || x.Account.Nickname.ToLower().Contains(nickname)) &&
                        (mediaType == 0 ? true : mediaType == 1 ? 
                            db.PostMedia.Any(m => m.PostId == x.PostId) : !db.PostMedia.Any(m => m.PostId == x.PostId)) &&
                        x.CreateDateTime >= dateStart && x.CreateDateTime < dateEnd
                    )).OrderByDescending(x => x.CreateDateTime).ToListAsync();

                _PostDataSource = new BindingList<PostViewModel>(
                    source.Select(x => new PostViewModel() {
                        colPostId = x.PostId,
                        colPostNo = x.PostNo,
                        colPostNickname = x.Account.Nickname,
                        colMessage = _CutString(x.Message, 50),
                        colCreation = x.CreateDateTime.ToStdString()
                }).ToList());
            }

            dgvPosts.DataSource = _PostDataSource;
        }

        private static string _CutString(string value, int length, string afterString = "...") {
            // Summary:
            // Cut a string by length and put afterString at the end.

            return value.Length <= length ? value : value.Remove(length) + afterString;
        }

        private async Task _SetPostDetail(Guid postId) {
            using (var db = new SHLife_A07Entities()) {
                var post = await db.Post.SingleOrDefaultAsync(x => x.PostId == postId);

                if (post == null) {
                    MessageBox.Show("Post data not found.", "SHLife",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                lbPostNo.Text = $"Post No.: {post.PostNo}";
                lbEmail.Text = $"Post Email: {post.Account.Email}";
                lbNickname.Text = $"Post Nickname: {post.Account.Nickname}";
                lbCreation.Text = $"Creation: {post.CreateDateTime.ToStdString()}";

                llbComments.Text = $"Comment: {await db.PostComment.CountAsync(x => x.PostId == postId)}";
                llbMedias.Text = $"Media: {await db.PostMedia.CountAsync(x => x.PostId == postId)}";
                llbOperations.Text = $"Operation: {await db.PostOperation.CountAsync(x => x.PostId == postId)}";

                tbPostMessage.Text = post.Message;
            }
        }

        private void _ResetAiContent() {
            tbAiSummary.Clear();
            lbAiStatus.Text = string.Empty;
        }
        #endregion

        private async void btnSearch_Click(object sender, EventArgs e) {
            _ResetAiContent();
            panelDetail.Hide();
            await _SetPosts(true);
        }

        private async void dgvPosts_CellClick(object sender, DataGridViewCellEventArgs e) {
            _ResetAiContent();
            panelDetail.Show();
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvPosts.Rows[e.RowIndex];
            Guid postId = (Guid)row.Cells["colPostId"].Value;
            await _SetPostDetail(postId);
        }

        private void llbComments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void llbMedias_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void llbOperations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }
    }

    public class PostViewModel {
        public Guid colPostId { get; set; }
        public long colPostNo { get; set; }
        public string colPostNickname { get; set; }
        public string colMessage { get; set; }
        public string colCreation { get; set; }
    }
}
