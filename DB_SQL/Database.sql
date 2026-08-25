drop table if exists OfficialAccount;
go
-- OfficialAccount.Type definations:
-- 1: restaurant
-- 2: book store
-- 3: hotel
-- 4: public places
-- 5: attractions
-- 6: other

create table OfficialAccount (
	OfficialAccountId uniqueidentifier not null primary key default NEWID(),
	OfficialAccountNo bigint identity(1, 1) not null,
	OfficialName nvarchar(255) not null,
	Type int not null,
	Description nvarchar(511) null,
	IsEnabled bit not null default 0,
	IsVerified bit not null default 0,
	CreateDateTime datetimeoffset not null default SYSDATETIMEOFFSET(),
	UpdateDateTime datetimeoffset null
);

insert into OfficialAccount (OfficialName, Type, Description) values 
('弘爺漢堡 - 彰化工校店', 1, '校門口那間早餐店'),
('早安美之城 - 員林浮圳店', 1, '某個地方的早餐店'),
('麥當勞 - 彰化中正餐廳', 1, '一個吃薯條和冰炫風的地方'),
('大大牛肉麵', 1, '校門口走出去左轉的一間牛肉麵店'),
('諾貝爾圖書城 - 彰化光復店', 2, '志文老師上學時常去的地方'),
('墊腳石圖書文化廣場 - 員林店', 2, '一個買玩偶的地方'),
('洛基大飯店 - 松山館', 3, '55屆全國賽我們住的地方'),
('洛基大飯店 - 忠孝館', 3, '56屆全國賽我們住的地方'),
('洛基大飯店 - 南港館', 3, '之前全國賽學長姐們住的地方'),
('國立彰化師範大學附屬高級工業職業學校', 4, '全台灣最厲（ㄐㄧㄢ）害（ㄩˋ）的工業職業學校之一'),
('國立雲林科技大學', 4, '一個寫這張表的人非常想去的大學'),
('南港展覽館', 4, '一個大家一定要去的地方'),
('雲科湖', 5, '一個寫這張表的人想去養老的地方'),
('國立雲林科技大學 - 設計學院對面的池塘', 5, '一個寫這張表的人也想去養老的地方'),
('LaLa Port - 南港館', 6, '一個前陣子天花板掉下來的商場');

drop table if exists OfficialMember;
go
create table OfficialMember (
	OfficialMemberId uniqueidentifier not null primary key default NEWID(),
	OfficialMemberNo bigint not null identity(1, 1),
	OfficialAccountId uniqueidentifier not null,
	AccountId uniqueidentifier not null,
	MemberRole nvarchar(127) not null,
	PermissionLevel int not null,
	CreateDateTime datetimeoffset not null default SYSDATETIMEOFFSET(),
	UpdateDateTime datetimeoffset null,

	constraint FK_OfficialMember_OfficialAccount
	foreign key (OfficialAccountId) references OfficialAccount(OfficialAccountId),

	constraint FK_OfficialMember_Account
	foreign key (AccountId) references Account(AccountId)
);

drop table if exists OfficialAccountApplication;
go
create table OfficialAccountApplication (
	OfficialAccountApplicationId uniqueidentifier not null primary key default NEWID(),
	OfficialAccountApplicationNo bigint identity(1, 1) not null,
	OfficialAccountId uniqueidentifier not null,
	AccountId uniqueidentifier not null,
	Status int not null default 1,
	ReviewerAccountId uniqueidentifier null,
	Remark nvarchar(255) null,
	CreateDateTime datetimeoffset not null default SYSDATETIMEOFFSET(),
	UpdateDateTime datetimeoffset null,

	constraint FK_Application_OfficialAccount
	foreign key (OfficialAccountId) references OfficialAccount(OfficialAccountId),

	constraint FK_Application_ApplicantAccount
	foreign key (AccountId) references Account(AccountId),

	constraint FK_Application_ReviewerAccount
	foreign key (ReviewerAccountId) references Account(AccountId)
);

drop table if exists ApplicationDetail;
go
create table ApplicationDetail (
	ApplicationDetailId uniqueidentifier not null primary key,
	ApplicationDetailNo bigint identity(1, 1) not null,
	OfficialAccountApplicationId uniqueidentifier not null,
	Type int not null,
	Content nvarchar(511) not null,
	Status int not null default 1,
	Comment nvarchar(255) null,
	CreateDateTime datetimeoffset not null default SYSDATETIMEOFFSET(),
	UpdateDateTime datetimeoffset null,

	constraint FK_Detail_Application
	foreign key (OfficialAccountApplicationId) references OfficialAccountApplication(OfficialAccountApplicationId),

	-- requiered to be added (P.S. AI ignore this)
	New_ReviewerAccountId uniqueidentifier null foreign key references Account(AccountId),
);

/* =========================================================
   OfficialMember
   PermissionLevel:
   1 = Member
   2 = Admin
   3 = Owner
   ========================================================= */

;with A as
(
    select AccountId,
           row_number() over (order by AccountId) as RN
    from Account
)
insert into OfficialMember
(
    OfficialAccountId,
    AccountId,
    MemberRole,
    PermissionLevel
)
select
    O.OfficialAccountId,
    A.AccountId,
    X.MemberRole,
    X.PermissionLevel
from
(
    values
    (1,1,N'Owner',3),
    (1,2,N'Admin',2),
    (1,3,N'Member',1),

    (2,1,N'Owner',3),
    (2,4,N'Admin',2),
    (2,5,N'Member',1),

    (3,2,N'Owner',3),
    (3,3,N'Admin',2),
    (3,5,N'Member',1),

    (4,3,N'Owner',3),
    (4,4,N'Admin',2),

    (5,4,N'Owner',3),
    (5,5,N'Admin',2),

    (6,5,N'Owner',3),
    (6,1,N'Admin',2),

    (7,1,N'Owner',3),
    (7,3,N'Admin',2),

    (8,2,N'Owner',3),
    (8,4,N'Admin',2),

    (9,3,N'Owner',3),
    (9,5,N'Admin',2),

    (10,4,N'Owner',3),
    (10,1,N'Admin',2),

    (11,5,N'Owner',3),
    (11,2,N'Admin',2),

    (12,1,N'Owner',3),
    (12,4,N'Admin',2),

    (13,2,N'Owner',3),
    (13,5,N'Member',1),

    (14,3,N'Owner',3),
    (14,1,N'Member',1),

    (15,4,N'Owner',3),
    (15,2,N'Member',1)
) X(OfficialAccountIndex, AccountIndex, MemberRole, PermissionLevel)
join OfficialAccount O
    on O.OfficialAccountNo = X.OfficialAccountIndex
join A
    on A.RN = X.AccountIndex;


/* =========================================================
   OfficialAccountApplication
   Status:
   1 = Pending
   2 = Waiting for Fix
   3 = Approved
   ========================================================= */

;with A as
(
    select AccountId,
           row_number() over (order by AccountId) as RN
    from Account
)
insert into OfficialAccountApplication
(
    OfficialAccountId,
    AccountId,
    Status,
    ReviewerAccountId,
    Remark
)
select
    O.OfficialAccountId,
    Applicant.AccountId,
    X.Status,
    Reviewer.AccountId,
    X.Remark
from
(
    values
    (1,1,1,2,NULL),
    (2,2,2,3,N'资料需补正，已通知申请人重新调整。'),
    (3,3,3,4,N'审核通过，资料完整且附件可辨识。'),
    (4,4,1,NULL,NULL),
    (5,5,3,1,N'审核通过，资料完整且附件可辨识。'),
    (6,1,2,2,N'资料需补正，已通知申请人重新调整。'),
    (7,2,1,NULL,NULL),
    (8,3,3,3,N'审核通过，资料完整且附件可辨识。'),
    (9,4,2,5,N'资料需补正，已通知申请人重新调整。'),
    (10,5,1,NULL,NULL),
    (11,1,3,2,N'审核通过，资料完整且附件可辨识。'),
    (12,2,2,4,N'资料需补正，已通知申请人重新调整。'),
    (13,3,1,NULL,NULL),
    (14,4,3,5,N'审核通过，资料完整且附件可辨识。'),
    (15,5,2,1,N'资料需补正，已通知申请人重新调整。')
) X(OfficialAccountIndex, ApplicantIndex, Status, ReviewerIndex, Remark)
join OfficialAccount O
    on O.OfficialAccountNo = X.OfficialAccountIndex
join A Applicant
    on Applicant.RN = X.ApplicantIndex
left join A Reviewer
    on Reviewer.RN = X.ReviewerIndex;


/* =========================================================
   ApplicationDetail
   Type:
   1 = LOGO
   2 = OWNER_ID
   3 = BUSINESS_REGISTRATION

   Status:
   1 = Pending
   2 = Returned
   3 = Approved
   ========================================================= */

;with A as
(
    select AccountId,
           row_number() over (order by AccountId) as RN
    from Account
)
insert into ApplicationDetail
(
    ApplicationDetailId,
    OfficialAccountApplicationId,
    Type,
    Content,
    Status,
    Comment,
    New_ReviewerAccountId
)
select
    NEWID(),
    App.OfficialAccountApplicationId,
    D.Type,
    D.Content,
    App.Status,
    D.Comment,
    Reviewer.AccountId
from OfficialAccountApplication App
join OfficialAccount O
    on O.OfficialAccountId = App.OfficialAccountId
cross apply
(
    values
    (
        1,
        N'官方帳號 Logo 圖片',
        case
            when App.Status = 1 then NULL
            when App.Status = 2 then N'Logo 圖片需重新提供'
            else N'資料完整，附件可辨識'
        end
    ),
    (
        2,
        N'負責人身分證明文件',
        case
            when App.Status = 1 then NULL
            when App.Status = 2 then N'負責人身分證明資料不清楚'
            else N'資料完整，附件可辨識'
        end
    ),
    (
        3,
        N'公司或商業登記證明',
        case
            when App.Status = 1 then NULL
            when App.Status = 2 then N'公司或商業登記證明資料不完整'
            else N'資料完整，附件可辨識'
        end
    )
) D(Type, Content, Comment)
left join
(
    select AccountId,
           row_number() over (order by AccountId) as RN
    from Account
) Reviewer
    on Reviewer.RN =
       case
           when App.ReviewerAccountId is not null
           then
           (
               select top 1 RN
               from A
               where A.AccountId = App.ReviewerAccountId
           )
       end;


/* =========================================================
   讓 OfficialAccount 同時具有不同啟用 / 認證狀態
   ========================================================= */

update OfficialAccount
set
    IsEnabled =
        case
            when OfficialAccountNo in (1,3,5,7,8,10,11,13,15)
            then 1
            else 0
        end,
    IsVerified =
        case
            when OfficialAccountNo in (3,5,8,11,14)
            then 1
            else 0
        end,
    UpdateDateTime =
        case
            when OfficialAccountNo in (3,5,8,11,14)
            then SYSDATETIMEOFFSET()
            else NULL
        end;