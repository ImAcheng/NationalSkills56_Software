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

namespace SHLife_SD1.Mainpage {
    public partial class BrowsePage : UserControl {
        public BrowsePage() {
            InitializeComponent();
        }

        BindingList<OfficialViewModel> _OfficialDataSource;
        BindingList<MemberViewModel> _MemberDataSource;

        private async void BrowsePage_Load(object sender, EventArgs e) {
            dgvOfficials.Font = GlobalAsset.DgvFont;
            dgvOfficials.ReadOnly = true;
            dgvOfficials.AllowUserToAddRows = false;
            dgvOfficials.AutoGenerateColumns = false;

            // 自動調節 DataGridView 欄位寬度 (*僅參考用 正式比賽請不要花時間在這部份上)
            foreach (DataGridViewColumn col in dgvOfficials.Columns) {
                var headerWidth = TextRenderer.MeasureText(
                    col.HeaderText, GlobalAsset.DgvFont).Width + 10;

                col.MinimumWidth = headerWidth;
            }

            dgvMembers.Font = GlobalAsset.DgvFont;
            dgvMembers.ReadOnly = true;
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AutoGenerateColumns = false;

            foreach (DataGridViewColumn col in dgvMembers.Columns) {
                var headerWidth = TextRenderer.MeasureText(
                    col.HeaderText, GlobalAsset.DgvFont).Width + 10;

                col.MinimumWidth = headerWidth;
            }

            await _SetOfficials(false);
        }

        #region functions
        // 此處有兩種 ViewModel 創建模式
        // _SetOfficials 使用傳值後再轉成需要的資料
        // _SetMembers 使用直接設定

        private async Task _SetOfficials(bool useFilter) {
            string name = tbOfficial.Text.Trim().ToLower();
            bool skipName = string.IsNullOrEmpty(name);

            bool enabled = ckEnabled.Checked;
            bool verified = ckVerified.Checked;

            DateTime dateStart = dtpStart.Value.Date;
            DateTime dateEnd = dtpEnd.Value.Date.AddDays(1);

            using (var db = new SHLife_A07Entities()) {
                var source = await db.OfficialAccount.AsNoTracking()
                    .Where(x => !useFilter || (
                        (skipName || x.OfficialName.ToLower().Contains(name)) &&
                        x.IsEnabled == enabled && x.IsVerified == verified &&
                        x.CreateDateTime >= dateStart && x.CreateDateTime < dateEnd
                    )).ToListAsync();

                var filteredId = source.Select(x => x.OfficialAccountId).ToHashSet();

                var countMap = await db.OfficialMember.AsNoTracking()
                    .Where(x => filteredId.Contains(x.OfficialAccountId) && x.DeletionDateTime == null)
                    .GroupBy(x => x.OfficialAccountId)
                    .Select(x => new { x.Key, Count = x.Count() })
                    .ToDictionaryAsync(x => x.Key, x => x.Count);

                _OfficialDataSource = new BindingList<OfficialViewModel>(
                    source.Select(x => new OfficialViewModel(
                        x,
                        countMap.TryGetValue(x.OfficialAccountId, out var cnt) ? cnt : 0
                    )).ToList()
                );
            }

            dgvOfficials.DataSource = _OfficialDataSource;
        }

        private async Task _SetMembers(Guid targetId) {
            using (var db = new SHLife_A07Entities()) {
                var source = await db.OfficialMember
                    .AsNoTracking()
                    .Where(x => x.OfficialAccountId == targetId)
                    .ToListAsync();

                _MemberDataSource = new BindingList<MemberViewModel>(
                    source.Select(x => new MemberViewModel() {
                        colMemberId  = x.OfficialMemberId,
                        colMemberNo  = x.OfficialMemberNo,
                        colAccount   = x.Account.Nickname,
                        colEmail     = x.Account.Email,
                        colRole      = x.MemberRole,
                        colAvailable = x.DeletionDateTime == null ? "Yes" : "No",
                        colUpdated   = x.UpdateDateTime.ToStdString(),
                        colDeletion  = x.DeletionDateTime.ToStdString()
                }).ToList());
            }

            dgvMembers.DataSource = _MemberDataSource;
        }

        private void _ClearMembers() {
            _MemberDataSource?.Clear();
            _MemberDataSource?.ResetBindings();
        }
        #endregion

        private async void btnSearch_Click(object sender, EventArgs e) {
            _ClearMembers();
            await _SetOfficials(true);
        }

        private async void dgvOfficials_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvOfficials.Rows[e.RowIndex];
            Guid officialId = (Guid)row.Cells["colOfficialId"].Value;
            await _SetMembers(officialId);
        }
    }

    public class OfficialViewModel {
        public Guid colOfficialId { get; set; }
        public long colOfficialNo { get; set; }
        public string colOfficialName { get; set; }
        public string colOfficialType { get; set; }
        public string colDescription { get; set; }
        public string colEnabled { get; set; }
        public string colVerified { get; set; }
        public int colAvailables { get; set; }
        public string colCreateTime { get; set; }

        private static readonly string[] _Types = { "Restaurant", "Book Store", "Hotel", "School" , "Public Place", "Other" };

        public OfficialViewModel(OfficialAccount official, int availableCount) {
            colOfficialId = official.OfficialAccountId;
            colOfficialNo = official.OfficialAccountNo;
            colOfficialName = official.OfficialName;
            colOfficialType = _Types[official.Type - 1];
            colDescription = official.Description;
            colEnabled = official.IsEnabled ? "Yes" : "No";
            colVerified = official.IsVerified ? "Yes" : "No";
            colAvailables = availableCount;
            colCreateTime = official.CreateDateTime.ToStdString();
        }
    }

    public class MemberViewModel {
        public Guid colMemberId { get; set; }
        public long colMemberNo { get; set; }
        public string colAccount { get; set; }
        public string colEmail { get; set; }
        public string colRole { get; set; }
        public string colAvailable { get; set; }
        public string colUpdated { get; set; }
        public string colDeletion { get; set; }
    }
}
