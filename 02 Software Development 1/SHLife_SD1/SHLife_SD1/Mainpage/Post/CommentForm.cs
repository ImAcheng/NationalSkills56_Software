using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife_SD1.Mainpage.Post {
    public partial class CommentForm : Form {
        private readonly Guid _PostId;

        public CommentForm(Guid postId) {
            InitializeComponent();
            _PostId = postId;
        }

        private async void CommentForm_Load(object sender, EventArgs e) {
            dgvPosts.Font = GlobalAsset.DgvFont;
            dgvPosts.ReadOnly = true;
            dgvPosts.AllowUserToAddRows = false;
            dgvPosts.AutoGenerateColumns = false;
            dgvPosts.AllowUserToResizeRows = false;

            // fill data
            await LoadData();

            this.Text = "SHLife Operation Management System";
        }

        private async Task LoadData() {
            // because the data amount is so big,
            // we do a pre-select in db query 
            // than use another select to use our .ToStdString() extention
            // this can prevent UI frozen

            using (var db = new SHLife_A07Entities()) {
                var source = await db.PostComment
                    .AsNoTracking()
                    .Where(x => x.PostId == _PostId)
                    .Select(x => new {
                        PostCommentNo = x.PostCommentNo,
                        colAccount = x.Account.Nickname,
                        Message = x.Message,
                        CreateDateTime = x.CreateDateTime
                    })
                    .ToListAsync();

                var result = source.Select(x => new {
                    x.PostCommentNo,
                    x.colAccount,
                    x.Message,
                    CreateDateTime = x.CreateDateTime.ToStdString()
                }).ToList();

                dgvPosts.DataSource = result;
            }
        }

        private void CommentForm_FormClosing(object sender, FormClosingEventArgs e) {
            dgvPosts.DataSource = null;
            dgvPosts.Dispose();
        }
    }
}
