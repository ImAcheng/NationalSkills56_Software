using SHLife_SD1.Mainpage.Review;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife_SD1.Mainpage {
    public partial class ReviewPage : UserControl {
        public ReviewPage() {
            InitializeComponent();
        }

        private string[] _ApplicationStatus = { "Pending", "Waiting For Fix", "Approved" };
        private string[] _DetailStatus = { "Pending", "Returned", "Approved" };

        // 補充: BindingList<T> 型別
        // BindingList<T> 為適用於需綁定於一物件參數的List
        // 內建 ResetItem 方法 可以用於重新繪製物件
        // 優點：無須重新讀取資料庫並重新綁定，效能佳
        // 缺點：撰寫較為費時
        // 若要增進撰寫速度可以直接重新搜索一次資料庫並綁定資料
        private BindingList<ApplicationViewModel> _ApplicationDataSource;
        private BindingList<DetailViewModel> _DetailDataSource;

        private Guid? _CurrentApplicationId = null;

        private async void ReviewPage_Load(object sender, EventArgs e) {
            dgvApplications.Font = GlobalAsset.DgvFont;
            dgvApplications.ReadOnly = true;
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.AutoGenerateColumns = false;

            dgvDetails.Font = GlobalAsset.DgvFont;
            dgvDetails.ReadOnly = true;
            dgvDetails.AllowUserToAddRows = false;
            dgvDetails.AutoGenerateColumns = false;

            cbStatus.SelectedIndex = 0;

            await SetApplications(false);
        }

        #region functions
        private async Task SetApplications(bool useFilter) {
            string official = tbOfficialName.Text.Trim();
            bool skipOfficial = string.IsNullOrEmpty(official);

            string applicant = tbApplicantName.Text.Trim();
            bool skipApplicant = string.IsNullOrEmpty(applicant);

            int status = cbStatus.SelectedIndex;
            bool skipStatus = status == 0;

            DateTime dateStart = dtpStart.Value.Date;
            DateTime dateEnd = dtpEnd.Value.Date.AddDays(1);

            using (var db = new SHLife_A07Entities()) {
                // 說明:
                // 透過 Database Linq 語法進行資料庫搜尋與排序
                // 搜尋後再透過額外的 C# Linq 選擇需要的資料 (此處稱為虛擬投影)
                // 最後再將其結果應用於指定的 DataGridView
                //
                // 由於某些功能不能在 Database Linq 中做使用
                // 所以兩者無法合併
                //
                // 註1:
                // 使用 AsNoTracking 阻止產生 EF追蹤旗標以增進效能
                // (僅搜索時才使用, 若要更改、刪除、新增資料, 則不能使用)
                //
                // 註2:
                // <DateTimeOffset>.ToStdString() 方法是我自己寫的擴充
                // 可以透過 [Ctrl + 左鍵點擊] 該方法查看其原始碼
                // 或直接查看 MyExtention.cs 內容

                var source = await db.OfficialAccountApplication
                    .AsNoTracking()
                    .Where(x => !useFilter || (
                        (skipOfficial || x.OfficialAccount.OfficialName.Contains(official)) &&
                        (skipApplicant || x.Account.Nickname.Contains(applicant)) &&
                        (skipStatus || x.Status == status) &&
                        x.CreateDateTime >= dateStart && x.CreateDateTime < dateEnd
                    ))
                    .OrderByDescending(x => x.CreateDateTime)
                    .ToListAsync();

                _ApplicationDataSource = new BindingList<ApplicationViewModel>(
                    source.Select(x => new ApplicationViewModel() {
                        colApplicationId = x.OfficialAccountApplicationId,
                        colApplicationNo = x.OfficialAccountApplicationNo,
                        colOfficialAccount = x.OfficialAccount.OfficialName,
                        colApplicant = x.Account.Nickname,
                        colStatus = _ApplicationStatus[x.Status - 1],
                        colReviewer = x.Account1?.Nickname ?? "-",
                        colRemark = x.Remark ?? "-",
                        colCreateTime = x.CreateDateTime.ToStdString(),
                        colUpdateTime = x.UpdateDateTime.ToStdString()
                }).ToList());
            }

            dgvApplications.DataSource = _ApplicationDataSource;
        }

        private async Task SetDetailPanel(Guid applicationId) {
            if (applicationId == null) return;

            using (var db = new SHLife_A07Entities()) {
                var application = await db.OfficialAccountApplication
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.OfficialAccountApplicationId == applicationId);

                var official = application.OfficialAccount;
                var applicant = application.Account;

                rtbOfficialInfo.Text = $"Official Account Info:\n" +
                    $"Name: {official.OfficialName}\n" +
                    $"Created: {official.CreateDateTime.ToStdString()}";

                rtbApplicantInfo.Text = $"Applicant Info:\n" +
                    $"Name: {applicant.Nickname}\n" +
                    $"Email: {applicant.Email}";

                var detailSrc = await db.ApplicationDetail
                    .AsNoTracking()
                    .Where(x => x.OfficialAccountApplicationId == applicationId)
                    .ToListAsync();

                _DetailDataSource = new BindingList<DetailViewModel>(
                    detailSrc.Select(x => new DetailViewModel() {
                    colDetailId = x.ApplicationDetailId,
                    colDetailNo = x.ApplicationDetailNo,
                    colType = x.Type,
                    colDReviewer = x.Account?.Nickname ?? "-",
                    colContent = x.Content,
                    colDStatus = _DetailStatus[x.Status - 1],
                    colComment = x.Comment ?? "-",
                    colDUpdate = x.UpdateDateTime.ToStdString()
                }).ToList());

                dgvDetails.DataSource = _DetailDataSource;
            }
        }

        private void ResetDetailPanel() {
            _CurrentApplicationId = null;
            rtbOfficialInfo.Clear();
            rtbApplicantInfo.Clear();
            _DetailDataSource = new BindingList<DetailViewModel>();
            dgvDetails.DataSource = _DetailDataSource;
        }
        #endregion

        private async void btnSearch_Click(object sender, EventArgs e) {
            ResetDetailPanel();
            await SetApplications(true);
        }

        private async void dgvApplications_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvApplications.Rows[e.RowIndex];
            _CurrentApplicationId = (Guid)row.Cells["colApplicationId"].Value;
            await SetDetailPanel((Guid)_CurrentApplicationId);
        }

        private void dgvDetails_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            e.ThrowException = false;
        }

        private async void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvDetails.Rows[e.RowIndex];
            Guid detailId = (Guid)row.Cells["colDetailId"].Value;
            DialogResult diagResult;

            if (e.ColumnIndex == 8) {
                DetailViewModel currentDetail = _DetailDataSource
                .SingleOrDefault(x => x.colDetailId == detailId);

                if (currentDetail.colDStatus != _DetailStatus[0]) {
                    MessageBox.Show("此筆資料已被審核，不可再次修改。");
                    return;
                }

                using (var diag = new DetailReviewForm(detailId)) {
                    diagResult = diag.ShowDialog();
                }

                if (diagResult == DialogResult.OK) {
                    int newStatus = 0, newApplicationStatus = 0;
                    string newComment = string.Empty, newApplicationComment = string.Empty;

                    using (var db = new SHLife_A07Entities()) {
                        var newDetail = await db.ApplicationDetail.AsNoTracking()
                            .FirstOrDefaultAsync(x => x.ApplicationDetailId == detailId);

                        newStatus = newDetail.Status;
                        newComment = newDetail.Comment;
                        newApplicationStatus = newDetail.OfficialAccountApplication.Status;
                        newApplicationComment = newDetail.OfficialAccountApplication.Remark;
                    }

                    if (currentDetail.colDStatus != _DetailStatus[newStatus - 1]) {
                        rtbOperationLogs.AppendText($"Detail: {detailId}\n" +
                            $"Status Changed: {currentDetail.colDStatus} -> {_DetailStatus[newStatus - 1]}\n");
                    }

                    if (currentDetail.colComment != newComment) {
                        rtbOperationLogs.AppendText($"Detail: {detailId}\n" +
                            $"Status Changed: {currentDetail.colComment} -> {newComment}\n");
                    }

                    ApplicationViewModel targetApplication = _ApplicationDataSource
                        .SingleOrDefault(x => x.colApplicationId == _CurrentApplicationId);
                    DetailViewModel targetDetail = _DetailDataSource.SingleOrDefault(x => x.colDetailId == detailId);

                    if (targetApplication == null) {
                        MessageBox.Show($"Data Error.\nCouldn't find targetApplication data in _ApplicationDataSource." +
                            $"\nID: {_CurrentApplicationId}", "SHLife",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    if (targetDetail == null) {
                        MessageBox.Show($"Data Error.\nCouldn't find targetDetail data in _DetailDataSource.\nID: {detailId}", "SHLife",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    targetDetail.colDStatus = _DetailStatus[newStatus - 1];
                    targetDetail.colComment = newComment;
                    targetApplication.colStatus = _ApplicationStatus[newApplicationStatus - 1];
                    targetApplication.colRemark = newApplicationComment;
                    _DetailDataSource.ResetItem(_DetailDataSource.IndexOf(targetDetail));
                    _ApplicationDataSource.ResetItem(_ApplicationDataSource.IndexOf(targetApplication));
                }
            }
        }
    }

    public class ApplicationViewModel {
        public Guid colApplicationId { get; set; }
        public long colApplicationNo { get; set; }
        public string colOfficialAccount { get; set; }
        public string colApplicant { get; set; }
        public string colStatus { get; set; }
        public string colReviewer { get; set; }
        public string colRemark { get; set; }
        public string colCreateTime { get; set; }
        public string colUpdateTime { get; set; }
    }

    public class DetailViewModel {
        public Guid colDetailId { get; set; }
        public long colDetailNo { get; set; }
        public int colType { get; set; }
        public string colDReviewer { get; set; } = string.Empty;
        public string colContent { get; set; }
        public string colDStatus { get; set; }
        public string colComment { get; set; } = string.Empty;
        public string colDUpdate { get; set; }
    }
}
