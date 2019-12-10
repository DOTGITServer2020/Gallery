
	CREATE TABLE CredentialInfo (
    CredentialID INT PRIMARY KEY IDENTITY(1,1),
    UserId INT,
	OldCredential VARCHAR(500),
	CurrentCredential VARCHAR(500),
	CreatedBy VARCHAR(500),
	CreatedFrom VARCHAR(500),
	CreatedOn DATETIME,
	Iscurrent BIT
	);	

	CREATE TABLE Client (
    ClientID INT PRIMARY KEY IDENTITY(1,1),
	ClientName VARCHAR(500),
	CreatedBy VARCHAR(500),
	CreatedFrom VARCHAR(500),
	CreatedOn DATETIME
	);

	INSERT Client VALUES ('DevClient','DOT_Admin','Default',GETDATE())
	INSERT Client VALUES ('DevQAClient','DOT_Admin','Default',GETDATE())
	INSERT Client VALUES ('DemoClient','DOT_Admin','Default',GETDATE())

	CREATE TABLE Practice (
    PracticeID INT PRIMARY KEY IDENTITY(1,1),
	PracticeName VARCHAR(500),
	CreatedBy VARCHAR(500),
	CreatedFrom VARCHAR(500),
	CreatedOn DATETIME
	);

	INSERT Practice VALUES ('DevPractice','DOT_Admin','Default',GETDATE())
	INSERT Practice VALUES ('DevQAPractice','DOT_Admin','Default',GETDATE())
	INSERT Practice VALUES ('DemoPractice','DOT_Admin','Default',GETDATE())

	CREATE TABLE SubPractice (
    SubPracticeID INT PRIMARY KEY IDENTITY(1,1),
	SubPracticeName VARCHAR(500),
	CreatedBy VARCHAR(500),
	CreatedFrom VARCHAR(500),
	CreatedOn DATETIME
	);

	INSERT SubPractice VALUES ('DevSubPractice','DOT_Admin','Default',GETDATE())
	INSERT SubPractice VALUES ('DevQASubPractice','DOT_Admin','Default',GETDATE())
	INSERT SubPractice VALUES ('DemoSubPractice','DOT_Admin','Default',GETDATE())

	CREATE TABLE ClientMaping (
    CMapID INT PRIMARY KEY IDENTITY(1,1),
	ClientID INT,
	PracticeID INT,
	SubPracticeID INT,
	CreatedBy VARCHAR(500),
	CreatedFrom VARCHAR(500),
	CreatedOn DATETIME,
	Isactive BIT
	);

	INSERT ClientMaping VALUES (1,1,1,'DOT_Admin','Default',GETDATE(),1)
	INSERT ClientMaping VALUES (2,2,2,'DOT_Admin','Default',GETDATE(),1)
	INSERT ClientMaping VALUES (3,3,3,'DOT_Admin','Default',GETDATE(),1)
	
	
	

	CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
	EmployeeID VARCHAR(50),
	EmployeeName VARCHAR(100),
	CreatedBy VARCHAR(500),
	CreatedFrom VARCHAR(500),
	CreatedOn DATETIME,
	Isactive BIT
	);

	INSERT INTO Users VALUES ('DOT_Admin','Admin','DOT_Admin','Default',GETDATE(),1)

	CREATE TABLE UserAccess (
    UserAccessID INT PRIMARY KEY IDENTITY(1,1),
	CMapID INT,
	UserID INT,
	ManagerID INT,
	TeamLeaderID INT,
	QCAID INT,
	TenurityID INT,
	ClientLogin VARCHAR(500),
	RoleID INT,
	IsPreAudit BIT,
	CreatedBy VARCHAR(500),
	CreatedFrom VARCHAR(500),
	CreatedOn DATETIME,
	Isactive BIT
	);

	--INSERT INTO UserAccess (CMapID,UserID,TeamLeaderID,ManagerID,QCAID,TenurityID,ClientLogin,RoleID,IsPreAudit,CreatedBy,CreatedFrom,CreatedOn,Isactive) VALUES ()

	CREATE TABLE UserTargetHistory (
	UTHID INT PRIMARY KEY IDENTITY(1,1),
	CMapID INT,
	UserID INT,
	RoleID INT,
	[Target] VARCHAR(3),
	EffectiveFrom DATETIME,
	TermedOn DATETIME,
	CreatedBy VARCHAR(500),
	CreatedFrom VARCHAR(500),
	CreatedOn DATETIME,
	Isactive BIT
	);

	CREATE TABLE UserSamplingtHistory (
	UTHID INT PRIMARY KEY IDENTITY(1,1),
	CMapID INT,
	UserID INT,
	RoleID INT,
	Sampling VARCHAR(3),
	EffectiveFrom DATETIME,
	TermedOn DATETIME,
	CreatedBy VARCHAR(500),
	CreatedFrom VARCHAR(500),
	CreatedOn DATETIME,
	Isactive BIT
	);
	   	 
	



