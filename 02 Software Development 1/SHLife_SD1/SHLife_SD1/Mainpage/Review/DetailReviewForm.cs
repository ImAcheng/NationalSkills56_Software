using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SHLife_SD1.Mainpage.Review {
    public partial class DetailReviewForm : Form {
        private readonly Guid _DetailId;

        public DetailReviewForm(Guid DetailId) {
            InitializeComponent();

            _DetailId = DetailId;
        }

        // this can be simply be replaced by number
        private enum DetailStatus {
            Pending = 1,
            Return = 2,
            Approve = 3
        }

        private async void btnApprove_Click(object sender, EventArgs e) {
            string comment = tbComment.Text.Trim();
            await _SetDetailStatus((int)DetailStatus.Approve, comment);
        }

        private async void btnReturn_Click(object sender, EventArgs e) {
            string comment = tbComment.Text.Trim();
            await _SetDetailStatus((int)DetailStatus.Return, comment);
        }

        private async Task _SetDetailStatus(int newStatus, string comment) {
            using (var db = new SHLife_A07Entities())
            using (var transcation = db.Database.BeginTransaction()) {
                try {
                    ApplicationDetail detail = await db.ApplicationDetail
                    .FirstOrDefaultAsync(x => x.ApplicationDetailId == _DetailId);

                    OfficialAccountApplication application = detail.OfficialAccountApplication;

                    // this shouldn't be happended
                    // but in case to prevent some specific situations, u konw
                    if (detail == null) {
                        MessageBox.Show("Invalid Detail Data.", "SHLife",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        DialogResult = DialogResult.Abort;

                        return;
                    }

                    detail.Status = newStatus;
                    detail.Comment = comment;
                    detail.New_ReviewerAccountId = AppSession.CurrentAccount.AccountId;
                    detail.UpdateDateTime = DateTimeOffset.Now;

                    await db.SaveChangesAsync();

                    if (application.ApplicationDetail.All(x => x.Status == 3)) {
                        application.Status = 3;
                        application.Remark = "审核通过，资料完整且附件可辨识。";
                        application.OfficialAccount.IsEnabled = true;
                    }
                    else if (newStatus == 2) {
                        application.Status = 2;
                        application.Remark = "资料需补正，已通知申请人重新调整。";
                    }
                    else {
                        application.Status = 1;
                        application.Remark = null;
                    }

                    application.ReviewerAccountId = AppSession.CurrentAccount.AccountId;
                    application.UpdateDateTime = DateTimeOffset.Now;

                    transcation.Commit();
                    await db.SaveChangesAsync();

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "SHLife",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    transcation.Rollback();
                }
            }
        }

        private async Task AddDataAsync(int newStatus, string comment) {
            using (var db = new SHLife_A07Entities()) {
                ApplicationDetail detail = new ApplicationDetail() {
                    ApplicationDetailId = Guid.NewGuid(),
                    // ... 填入 Not Null 資料
                };

                db.ApplicationDetail.Add(detail);

                await db.SaveChangesAsync();
            }
        }
    }
}
