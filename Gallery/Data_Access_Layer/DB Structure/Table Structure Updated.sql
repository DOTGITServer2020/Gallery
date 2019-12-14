	CREATE DATABASE GALLERY;

	USE GALLERY;	

	CREATE TABLE Menu (
    MenuID INT PRIMARY KEY IDENTITY(1,1),
	MenuName VARCHAR(500),
	Isactive BIT
	);

	Begin
	INSERT INTO Menu VALUES ('Dashboard',1)
	INSERT INTO Menu VALUES ('Input',1)
	INSERT INTO Menu VALUES ('Analysis',1)
	INSERT INTO Menu VALUES ('Process',1)
	INSERT INTO Menu VALUES ('Audit',1)
	INSERT INTO Menu VALUES ('Output',1)
	INSERT INTO Menu VALUES ('Setting',1)
	End

	CREATE TABLE Functions (
	FunctionID INT PRIMARY KEY IDENTITY(1,1),
	FunctionName VARCHAR(100),
	Isactive BIT
	);

	-- SELECT * FROM Functions
	Begin 
	INSERT INTO Functions VALUES ('ADMINADMINISTRATION',1)
	INSERT INTO Functions VALUES ('CUSTOMER SERVICE',1)
	INSERT INTO Functions VALUES ('FINANCE',1)
	INSERT INTO Functions VALUES ('HUMAN RESOURCE',1)
	INSERT INTO Functions VALUES ('IT & SECURITY',1)
	INSERT INTO Functions VALUES ('TRAINING & DEVELOPMENT',1)
	INSERT INTO Functions VALUES ('OPERATIONAL EXCELLENCE',1)
	INSERT INTO Functions VALUES ('WFM & MIS',1)
	INSERT INTO Functions VALUES ('TOP MANAGEMENT',1)
	INSERT INTO Functions VALUES ('RISK & COMPLIANCE',1)
	INSERT INTO Functions VALUES ('TRAVEL DESK',1)
	INSERT INTO Functions VALUES ('QUALITY ASSURANCE',1)
	INSERT INTO Functions VALUES ('OPERATION',1)
	END 

	CREATE TABLE Process (
	ProcessID INT PRIMARY KEY IDENTITY(1,1),
	ProcessName VARCHAR(100),
	Isactive BIT
	);
	  	
	-- SELECT * FROM Process
	Begin 
	INSERT INTO Process VALUES ('SUPPORT',1)
	INSERT INTO Process VALUES ('PATIENT REGISTRATION',1)
	INSERT INTO Process VALUES ('ELIGIBILITY & BENEFITS CHECK',1)
	INSERT INTO Process VALUES ('MEDICAL TRANSCRIPTION',1)
	INSERT INTO Process VALUES ('PATIENT DEMOGRAPHICS',1)
	INSERT INTO Process VALUES ('REFFERAL & AUTHORIZATION',1)
	INSERT INTO Process VALUES ('CODING & BILLING',1)
	INSERT INTO Process VALUES ('CHARGE POSTING',1)
	INSERT INTO Process VALUES ('CLAIM SUBMISSION',1)
	INSERT INTO Process VALUES ('CLEARING HOUSE DENIALS',1)
	INSERT INTO Process VALUES ('PAYMENT POSTING',1)
	INSERT INTO Process VALUES ('DENIAL MANAGEMENT',1)
	INSERT INTO Process VALUES ('SECONDARY FILING',1)
	INSERT INTO Process VALUES ('ACCOUNT RECEIVABLE',1)
	INSERT INTO Process VALUES ('APPEAL PROCEDURE',1)
	INSERT INTO Process VALUES ('PATIENT BILLING & CALLER',1)
	INSERT INTO Process VALUES ('CREDIT BALANCE',1)
	END 

	CREATE TABLE Processmapping (
	PMID INT PRIMARY KEY IDENTITY(1,1),
	FunctionID INT,
	ProcessID INT,
	Isactive BIT
	);

	-- SELECT * FROM Processmapping
	Begin 
	INSERT INTO Processmapping  VALUES (1,1,1)
	INSERT INTO Processmapping  VALUES (2,1,1)
	INSERT INTO Processmapping  VALUES (3,1,1)
	INSERT INTO Processmapping  VALUES (4,1,1)
	INSERT INTO Processmapping  VALUES (5,1,1)
	INSERT INTO Processmapping  VALUES (6,1,1)
	INSERT INTO Processmapping  VALUES (7,1,1)
	INSERT INTO Processmapping  VALUES (8,1,1)
	INSERT INTO Processmapping  VALUES (9,1,1)
	INSERT INTO Processmapping  VALUES (10,1,1)
	INSERT INTO Processmapping  VALUES (11,1,1)
	INSERT INTO Processmapping  VALUES (12,1,1)
	INSERT INTO Processmapping  VALUES (13,2,1)
	INSERT INTO Processmapping  VALUES (13,3,1)
	INSERT INTO Processmapping  VALUES (13,4,1)
	INSERT INTO Processmapping  VALUES (13,5,1)
	INSERT INTO Processmapping  VALUES (13,6,1)
	INSERT INTO Processmapping  VALUES (13,7,1)
	INSERT INTO Processmapping  VALUES (13,8,1)
	INSERT INTO Processmapping  VALUES (13,9,1)
	INSERT INTO Processmapping  VALUES (13,10,1)
	INSERT INTO Processmapping  VALUES (13,11,1)
	INSERT INTO Processmapping  VALUES (13,12,1)
	INSERT INTO Processmapping  VALUES (13,13,1)
	INSERT INTO Processmapping  VALUES (13,14,1)
	INSERT INTO Processmapping  VALUES (13,15,1)
	INSERT INTO Processmapping  VALUES (13,16,1)
	INSERT INTO Processmapping  VALUES (13,17,1)
	END

	CREATE TABLE Roles (
    	RoleID INT PRIMARY KEY IDENTITY(1,1),
	RoleName VARCHAR(500),
	Isactive BIT
	);

	-- SELECT * FROM Roles

	Begin
	INSERT Roles VALUES ('OFFICE ASSISTANT',1)
	INSERT Roles VALUES ('JUNIOR EXECUTIVE',1)
	INSERT Roles VALUES ('EXECUTIVE',1)
	INSERT Roles VALUES ('SENIOR EXECUTIVE',1)
	INSERT Roles VALUES ('LEAD',1)
	INSERT Roles VALUES ('TEAM MANAGER',1)
	INSERT Roles VALUES ('ASSISTANT MANAGER',1)
	INSERT Roles VALUES ('MANAGER',1)
	INSERT Roles VALUES ('SENIOR MANAGER',1)
	INSERT Roles VALUES ('DEPUTY GENERAL MANAGER',1)
	INSERT Roles VALUES ('ASSOCIATE DIRECTOR',1)
	INSERT Roles VALUES ('DIRECTOR',1)
	INSERT Roles VALUES ('SENIOR DIRECTOR',1)
	INSERT Roles VALUES ('ASSOCIATE VICE PRESIDENT',1)
	INSERT Roles VALUES ('VICE PRESIDENT',1)
	INSERT Roles VALUES ('SENIOR VICE PRESIDENT',1)
	INSERT Roles VALUES ('JUNIOR ENGINEER',1)
	INSERT Roles VALUES ('SUPPORT ENGINEER',1)
	INSERT Roles VALUES ('ENGINEER',1)
	INSERT Roles VALUES ('SENIOR ENGINEER',1)
	INSERT Roles VALUES ('QUALITY ASSURANCE ENGINEER',1)
	INSERT Roles VALUES ('TECHNICAL SPECIALIST',1)
	INSERT Roles VALUES ('TECHNICAL MANAGER',1)
	INSERT Roles VALUES ('PROCESS TRAINER',1)
	INSERT Roles VALUES ('SENIOR TRAINER',1)
	INSERT Roles VALUES ('PROCESS EXECUTIVE',1)
	INSERT Roles VALUES ('SENIOR PROCESS EXECUTIVE',1)
	INSERT Roles VALUES ('CEO & COO',1)
	INSERT Roles VALUES ('QUALITY CONTROL ANALYST',1)
	INSERT Roles VALUES ('QUALITY REVIEW EXECUTIVE',1)
	INSERT Roles VALUES ('ASSOCIATE',1)
	INSERT Roles VALUES ('SENIOR ASSOCIATE',1)
	INSERT Roles VALUES ('DOMAIN EXPERT',1)
	INSERT Roles VALUES ('SUBJECT MATTER EXPERT',1)
	INSERT Roles VALUES ('PROCESS COACH',1)
	INSERT Roles VALUES ('TEAM LEAD',1)
	INSERT Roles VALUES ('PROCESS LEAD',1)
	INSERT Roles VALUES ('CODER',1)
	INSERT Roles VALUES ('SENIOR CODER',1)
	INSERT Roles VALUES ('ANALYST',1)
	INSERT Roles VALUES ('SENIOR ANALYST',1)
	INSERT Roles VALUES ('AR CALLER',1)
	INSERT Roles VALUES ('SENIOR AR CALLER',1)
	INSERT Roles VALUES ('PATIENT CALLER',1)
	INSERT Roles VALUES ('SENIOR PATIENT CALLER',1)
	END

	CREATE TABLE RoleMapping (
	RMID INT PRIMARY KEY IDENTITY(1,1),
	PMID INT,
	RoleID INT,
	Isactive BIT
	);
	
	-- SELECT * FROM RoleMapping
	Begin
	INSERT INTO RoleMapping VALUES (1,1,1)
	INSERT INTO RoleMapping VALUES (1,2,1)
	INSERT INTO RoleMapping VALUES (1,3,1)
	INSERT INTO RoleMapping VALUES (1,4,1)
	INSERT INTO RoleMapping VALUES (1,5,1)
	INSERT INTO RoleMapping VALUES (1,6,1)
	INSERT INTO RoleMapping VALUES (1,7,1)
	INSERT INTO RoleMapping VALUES (1,8,1)
	INSERT INTO RoleMapping VALUES (1,9,1)
	INSERT INTO RoleMapping VALUES (1,10,1)
	INSERT INTO RoleMapping VALUES (1,11,1)
	INSERT INTO RoleMapping VALUES (1,12,1)
	INSERT INTO RoleMapping VALUES (1,13,1)
	INSERT INTO RoleMapping VALUES (1,14,1)
	INSERT INTO RoleMapping VALUES (1,15,1)
	INSERT INTO RoleMapping VALUES (1,16,1)
	INSERT INTO RoleMapping VALUES (2,8,1)
	INSERT INTO RoleMapping VALUES (2,9,1)
	INSERT INTO RoleMapping VALUES (2,10,1)
	INSERT INTO RoleMapping VALUES (2,11,1)
	INSERT INTO RoleMapping VALUES (2,12,1)
	INSERT INTO RoleMapping VALUES (2,13,1)
	INSERT INTO RoleMapping VALUES (2,14,1)
	INSERT INTO RoleMapping VALUES (2,15,1)
	INSERT INTO RoleMapping VALUES (2,16,1)
	INSERT INTO RoleMapping VALUES (3,2,1)
	INSERT INTO RoleMapping VALUES (3,3,1)
	INSERT INTO RoleMapping VALUES (3,4,1)
	INSERT INTO RoleMapping VALUES (3,5,1)
	INSERT INTO RoleMapping VALUES (3,6,1)
	INSERT INTO RoleMapping VALUES (3,7,1)
	INSERT INTO RoleMapping VALUES (3,8,1)
	INSERT INTO RoleMapping VALUES (3,9,1)
	INSERT INTO RoleMapping VALUES (3,10,1)
	INSERT INTO RoleMapping VALUES (3,11,1)
	INSERT INTO RoleMapping VALUES (3,12,1)
	INSERT INTO RoleMapping VALUES (3,13,1)
	INSERT INTO RoleMapping VALUES (3,14,1)
	INSERT INTO RoleMapping VALUES (3,15,1)
	INSERT INTO RoleMapping VALUES (3,16,1)
	INSERT INTO RoleMapping VALUES (4,2,1)
	INSERT INTO RoleMapping VALUES (4,3,1)
	INSERT INTO RoleMapping VALUES (4,4,1)
	INSERT INTO RoleMapping VALUES (4,5,1)
	INSERT INTO RoleMapping VALUES (4,6,1)
	INSERT INTO RoleMapping VALUES (4,7,1)
	INSERT INTO RoleMapping VALUES (4,8,1)
	INSERT INTO RoleMapping VALUES (4,9,1)
	INSERT INTO RoleMapping VALUES (4,10,1)
	INSERT INTO RoleMapping VALUES (4,11,1)
	INSERT INTO RoleMapping VALUES (4,12,1)
	INSERT INTO RoleMapping VALUES (4,13,1)
	INSERT INTO RoleMapping VALUES (4,14,1)
	INSERT INTO RoleMapping VALUES (4,15,1)
	INSERT INTO RoleMapping VALUES (4,16,1)
	INSERT INTO RoleMapping VALUES (5,17,1)
	INSERT INTO RoleMapping VALUES (5,18,1)
	INSERT INTO RoleMapping VALUES (5,19,1)
	INSERT INTO RoleMapping VALUES (5,20,1)
	INSERT INTO RoleMapping VALUES (5,21,1)
	INSERT INTO RoleMapping VALUES (5,22,1)
	INSERT INTO RoleMapping VALUES (5,23,1)
	INSERT INTO RoleMapping VALUES (6,24,1)
	INSERT INTO RoleMapping VALUES (6,25,1)
	INSERT INTO RoleMapping VALUES (7,5,1)
	INSERT INTO RoleMapping VALUES (7,6,1)
	INSERT INTO RoleMapping VALUES (7,7,1)
	INSERT INTO RoleMapping VALUES (7,8,1)
	INSERT INTO RoleMapping VALUES (7,9,1)
	INSERT INTO RoleMapping VALUES (7,10,1)
	INSERT INTO RoleMapping VALUES (7,11,1)
	INSERT INTO RoleMapping VALUES (7,12,1)
	INSERT INTO RoleMapping VALUES (7,13,1)
	INSERT INTO RoleMapping VALUES (7,14,1)
	INSERT INTO RoleMapping VALUES (7,15,1)
	INSERT INTO RoleMapping VALUES (7,16,1)
	INSERT INTO RoleMapping VALUES (8,2,1)
	INSERT INTO RoleMapping VALUES (8,3,1)
	INSERT INTO RoleMapping VALUES (8,4,1)
	INSERT INTO RoleMapping VALUES (8,26,1)
	INSERT INTO RoleMapping VALUES (8,27,1)
	INSERT INTO RoleMapping VALUES (8,5,1)
	INSERT INTO RoleMapping VALUES (8,6,1)
	INSERT INTO RoleMapping VALUES (8,7,1)
	INSERT INTO RoleMapping VALUES (8,8,1)
	INSERT INTO RoleMapping VALUES (8,9,1)
	INSERT INTO RoleMapping VALUES (8,10,1)
	INSERT INTO RoleMapping VALUES (8,11,1)
	INSERT INTO RoleMapping VALUES (8,12,1)
	INSERT INTO RoleMapping VALUES (8,13,1)
	INSERT INTO RoleMapping VALUES (8,14,1)
	INSERT INTO RoleMapping VALUES (8,15,1)
	INSERT INTO RoleMapping VALUES (8,16,1)
	INSERT INTO RoleMapping VALUES (9,28,1)
	INSERT INTO RoleMapping VALUES (10,5,1)
	INSERT INTO RoleMapping VALUES (10,6,1)
	INSERT INTO RoleMapping VALUES (10,7,1)
	INSERT INTO RoleMapping VALUES (10,8,1)
	INSERT INTO RoleMapping VALUES (10,9,1)
	INSERT INTO RoleMapping VALUES (10,10,1)
	INSERT INTO RoleMapping VALUES (10,11,1)
	INSERT INTO RoleMapping VALUES (10,12,1)
	INSERT INTO RoleMapping VALUES (10,13,1)
	INSERT INTO RoleMapping VALUES (10,14,1)
	INSERT INTO RoleMapping VALUES (10,15,1)
	INSERT INTO RoleMapping VALUES (10,16,1)
	INSERT INTO RoleMapping VALUES (11,5,1)
	INSERT INTO RoleMapping VALUES (11,6,1)
	INSERT INTO RoleMapping VALUES (11,7,1)
	INSERT INTO RoleMapping VALUES (11,8,1)
	INSERT INTO RoleMapping VALUES (11,9,1)
	INSERT INTO RoleMapping VALUES (11,10,1)
	INSERT INTO RoleMapping VALUES (11,11,1)
	INSERT INTO RoleMapping VALUES (11,12,1)
	INSERT INTO RoleMapping VALUES (11,13,1)
	INSERT INTO RoleMapping VALUES (11,14,1)
	INSERT INTO RoleMapping VALUES (11,15,1)
	INSERT INTO RoleMapping VALUES (11,16,1)
	INSERT INTO RoleMapping VALUES (12,29,1)
	INSERT INTO RoleMapping VALUES (12,30,1)
	INSERT INTO RoleMapping VALUES (12,26,1)
	INSERT INTO RoleMapping VALUES (12,27,1)
	INSERT INTO RoleMapping VALUES (12,5,1)
	INSERT INTO RoleMapping VALUES (12,6,1)
	INSERT INTO RoleMapping VALUES (12,7,1)
	INSERT INTO RoleMapping VALUES (12,8,1)
	INSERT INTO RoleMapping VALUES (12,9,1)
	INSERT INTO RoleMapping VALUES (12,10,1)
	INSERT INTO RoleMapping VALUES (12,11,1)
	INSERT INTO RoleMapping VALUES (12,12,1)
	INSERT INTO RoleMapping VALUES (12,13,1)
	INSERT INTO RoleMapping VALUES (12,14,1)
	INSERT INTO RoleMapping VALUES (12,15,1)
	INSERT INTO RoleMapping VALUES (12,16,1)
	INSERT INTO RoleMapping VALUES (13,31,1)
	INSERT INTO RoleMapping VALUES (13,32,1)
	INSERT INTO RoleMapping VALUES (13,33,1)
	INSERT INTO RoleMapping VALUES (13,34,1)
	INSERT INTO RoleMapping VALUES (13,35,1)
	INSERT INTO RoleMapping VALUES (13,36,1)
	INSERT INTO RoleMapping VALUES (13,37,1)
	INSERT INTO RoleMapping VALUES (13,7,1)
	INSERT INTO RoleMapping VALUES (13,8,1)
	INSERT INTO RoleMapping VALUES (13,9,1)
	INSERT INTO RoleMapping VALUES (13,10,1)
	INSERT INTO RoleMapping VALUES (13,11,1)
	INSERT INTO RoleMapping VALUES (13,12,1)
	INSERT INTO RoleMapping VALUES (13,13,1)
	INSERT INTO RoleMapping VALUES (13,14,1)
	INSERT INTO RoleMapping VALUES (13,15,1)
	INSERT INTO RoleMapping VALUES (13,16,1)
	INSERT INTO RoleMapping VALUES (14,31,1)
	INSERT INTO RoleMapping VALUES (14,32,1)
	INSERT INTO RoleMapping VALUES (14,33,1)
	INSERT INTO RoleMapping VALUES (14,34,1)
	INSERT INTO RoleMapping VALUES (14,35,1)
	INSERT INTO RoleMapping VALUES (14,36,1)
	INSERT INTO RoleMapping VALUES (14,37,1)
	INSERT INTO RoleMapping VALUES (14,7,1)
	INSERT INTO RoleMapping VALUES (14,8,1)
	INSERT INTO RoleMapping VALUES (14,9,1)
	INSERT INTO RoleMapping VALUES (14,10,1)
	INSERT INTO RoleMapping VALUES (14,11,1)
	INSERT INTO RoleMapping VALUES (14,12,1)
	INSERT INTO RoleMapping VALUES (14,13,1)
	INSERT INTO RoleMapping VALUES (14,14,1)
	INSERT INTO RoleMapping VALUES (14,15,1)
	INSERT INTO RoleMapping VALUES (14,16,1)
	INSERT INTO RoleMapping VALUES (15,31,1)
	INSERT INTO RoleMapping VALUES (15,32,1)
	INSERT INTO RoleMapping VALUES (15,33,1)
	INSERT INTO RoleMapping VALUES (15,34,1)
	INSERT INTO RoleMapping VALUES (15,35,1)
	INSERT INTO RoleMapping VALUES (15,36,1)
	INSERT INTO RoleMapping VALUES (15,37,1)
	INSERT INTO RoleMapping VALUES (15,7,1)
	INSERT INTO RoleMapping VALUES (15,8,1)
	INSERT INTO RoleMapping VALUES (15,9,1)
	INSERT INTO RoleMapping VALUES (15,10,1)
	INSERT INTO RoleMapping VALUES (15,11,1)
	INSERT INTO RoleMapping VALUES (15,12,1)
	INSERT INTO RoleMapping VALUES (15,13,1)
	INSERT INTO RoleMapping VALUES (15,14,1)
	INSERT INTO RoleMapping VALUES (15,15,1)
	INSERT INTO RoleMapping VALUES (15,16,1)
	INSERT INTO RoleMapping VALUES (16,31,1)
	INSERT INTO RoleMapping VALUES (16,32,1)
	INSERT INTO RoleMapping VALUES (16,33,1)
	INSERT INTO RoleMapping VALUES (16,34,1)
	INSERT INTO RoleMapping VALUES (16,35,1)
	INSERT INTO RoleMapping VALUES (16,36,1)
	INSERT INTO RoleMapping VALUES (16,37,1)
	INSERT INTO RoleMapping VALUES (16,7,1)
	INSERT INTO RoleMapping VALUES (16,8,1)
	INSERT INTO RoleMapping VALUES (16,9,1)
	INSERT INTO RoleMapping VALUES (16,10,1)
	INSERT INTO RoleMapping VALUES (16,11,1)
	INSERT INTO RoleMapping VALUES (16,12,1)
	INSERT INTO RoleMapping VALUES (16,13,1)
	INSERT INTO RoleMapping VALUES (16,14,1)
	INSERT INTO RoleMapping VALUES (16,15,1)
	INSERT INTO RoleMapping VALUES (16,16,1)
	INSERT INTO RoleMapping VALUES (17,31,1)
	INSERT INTO RoleMapping VALUES (17,32,1)
	INSERT INTO RoleMapping VALUES (17,33,1)
	INSERT INTO RoleMapping VALUES (17,34,1)
	INSERT INTO RoleMapping VALUES (17,35,1)
	INSERT INTO RoleMapping VALUES (17,36,1)
	INSERT INTO RoleMapping VALUES (17,37,1)
	INSERT INTO RoleMapping VALUES (17,7,1)
	INSERT INTO RoleMapping VALUES (17,8,1)
	INSERT INTO RoleMapping VALUES (17,9,1)
	INSERT INTO RoleMapping VALUES (17,10,1)
	INSERT INTO RoleMapping VALUES (17,11,1)
	INSERT INTO RoleMapping VALUES (17,12,1)
	INSERT INTO RoleMapping VALUES (17,13,1)
	INSERT INTO RoleMapping VALUES (17,14,1)
	INSERT INTO RoleMapping VALUES (17,15,1)
	INSERT INTO RoleMapping VALUES (17,16,1)
	INSERT INTO RoleMapping VALUES (18,38,1)
	INSERT INTO RoleMapping VALUES (18,39,1)
	INSERT INTO RoleMapping VALUES (18,33,1)
	INSERT INTO RoleMapping VALUES (18,34,1)
	INSERT INTO RoleMapping VALUES (18,35,1)
	INSERT INTO RoleMapping VALUES (18,36,1)
	INSERT INTO RoleMapping VALUES (18,37,1)
	INSERT INTO RoleMapping VALUES (18,7,1)
	INSERT INTO RoleMapping VALUES (18,8,1)
	INSERT INTO RoleMapping VALUES (18,9,1)
	INSERT INTO RoleMapping VALUES (18,10,1)
	INSERT INTO RoleMapping VALUES (18,11,1)
	INSERT INTO RoleMapping VALUES (18,12,1)
	INSERT INTO RoleMapping VALUES (18,13,1)
	INSERT INTO RoleMapping VALUES (18,14,1)
	INSERT INTO RoleMapping VALUES (18,15,1)
	INSERT INTO RoleMapping VALUES (18,16,1)
	INSERT INTO RoleMapping VALUES (19,31,1)
	INSERT INTO RoleMapping VALUES (19,32,1)
	INSERT INTO RoleMapping VALUES (19,33,1)
	INSERT INTO RoleMapping VALUES (19,34,1)
	INSERT INTO RoleMapping VALUES (19,35,1)
	INSERT INTO RoleMapping VALUES (19,36,1)
	INSERT INTO RoleMapping VALUES (19,37,1)
	INSERT INTO RoleMapping VALUES (19,7,1)
	INSERT INTO RoleMapping VALUES (19,8,1)
	INSERT INTO RoleMapping VALUES (19,9,1)
	INSERT INTO RoleMapping VALUES (19,10,1)
	INSERT INTO RoleMapping VALUES (19,11,1)
	INSERT INTO RoleMapping VALUES (19,12,1)
	INSERT INTO RoleMapping VALUES (19,13,1)
	INSERT INTO RoleMapping VALUES (19,14,1)
	INSERT INTO RoleMapping VALUES (19,15,1)
	INSERT INTO RoleMapping VALUES (19,16,1)
	INSERT INTO RoleMapping VALUES (20,31,1)
	INSERT INTO RoleMapping VALUES (20,32,1)
	INSERT INTO RoleMapping VALUES (20,33,1)
	INSERT INTO RoleMapping VALUES (20,34,1)
	INSERT INTO RoleMapping VALUES (20,35,1)
	INSERT INTO RoleMapping VALUES (20,36,1)
	INSERT INTO RoleMapping VALUES (20,37,1)
	INSERT INTO RoleMapping VALUES (20,7,1)
	INSERT INTO RoleMapping VALUES (20,8,1)
	INSERT INTO RoleMapping VALUES (20,9,1)
	INSERT INTO RoleMapping VALUES (20,10,1)
	INSERT INTO RoleMapping VALUES (20,11,1)
	INSERT INTO RoleMapping VALUES (20,12,1)
	INSERT INTO RoleMapping VALUES (20,13,1)
	INSERT INTO RoleMapping VALUES (20,14,1)
	INSERT INTO RoleMapping VALUES (20,15,1)
	INSERT INTO RoleMapping VALUES (20,16,1)
	INSERT INTO RoleMapping VALUES (21,40,1)
	INSERT INTO RoleMapping VALUES (21,41,1)
	INSERT INTO RoleMapping VALUES (21,33,1)
	INSERT INTO RoleMapping VALUES (21,34,1)
	INSERT INTO RoleMapping VALUES (21,35,1)
	INSERT INTO RoleMapping VALUES (21,36,1)
	INSERT INTO RoleMapping VALUES (21,37,1)
	INSERT INTO RoleMapping VALUES (21,7,1)
	INSERT INTO RoleMapping VALUES (21,8,1)
	INSERT INTO RoleMapping VALUES (21,9,1)
	INSERT INTO RoleMapping VALUES (21,10,1)
	INSERT INTO RoleMapping VALUES (21,11,1)
	INSERT INTO RoleMapping VALUES (21,12,1)
	INSERT INTO RoleMapping VALUES (21,13,1)
	INSERT INTO RoleMapping VALUES (21,14,1)
	INSERT INTO RoleMapping VALUES (21,15,1)
	INSERT INTO RoleMapping VALUES (21,16,1)
	INSERT INTO RoleMapping VALUES (22,31,1)
	INSERT INTO RoleMapping VALUES (22,32,1)
	INSERT INTO RoleMapping VALUES (22,33,1)
	INSERT INTO RoleMapping VALUES (22,34,1)
	INSERT INTO RoleMapping VALUES (22,35,1)
	INSERT INTO RoleMapping VALUES (22,36,1)
	INSERT INTO RoleMapping VALUES (22,37,1)
	INSERT INTO RoleMapping VALUES (22,7,1)
	INSERT INTO RoleMapping VALUES (22,8,1)
	INSERT INTO RoleMapping VALUES (22,9,1)
	INSERT INTO RoleMapping VALUES (22,10,1)
	INSERT INTO RoleMapping VALUES (22,11,1)
	INSERT INTO RoleMapping VALUES (22,12,1)
	INSERT INTO RoleMapping VALUES (22,13,1)
	INSERT INTO RoleMapping VALUES (22,14,1)
	INSERT INTO RoleMapping VALUES (22,15,1)
	INSERT INTO RoleMapping VALUES (22,16,1)
	INSERT INTO RoleMapping VALUES (23,40,1)
	INSERT INTO RoleMapping VALUES (23,41,1)
	INSERT INTO RoleMapping VALUES (23,33,1)
	INSERT INTO RoleMapping VALUES (23,34,1)
	INSERT INTO RoleMapping VALUES (23,35,1)
	INSERT INTO RoleMapping VALUES (23,36,1)
	INSERT INTO RoleMapping VALUES (23,37,1)
	INSERT INTO RoleMapping VALUES (23,7,1)
	INSERT INTO RoleMapping VALUES (23,8,1)
	INSERT INTO RoleMapping VALUES (23,9,1)
	INSERT INTO RoleMapping VALUES (23,10,1)
	INSERT INTO RoleMapping VALUES (23,11,1)
	INSERT INTO RoleMapping VALUES (23,12,1)
	INSERT INTO RoleMapping VALUES (23,13,1)
	INSERT INTO RoleMapping VALUES (23,14,1)
	INSERT INTO RoleMapping VALUES (23,15,1)
	INSERT INTO RoleMapping VALUES (23,16,1)
	INSERT INTO RoleMapping VALUES (24,31,1)
	INSERT INTO RoleMapping VALUES (24,32,1)
	INSERT INTO RoleMapping VALUES (24,33,1)
	INSERT INTO RoleMapping VALUES (24,34,1)
	INSERT INTO RoleMapping VALUES (24,35,1)
	INSERT INTO RoleMapping VALUES (24,36,1)
	INSERT INTO RoleMapping VALUES (24,37,1)
	INSERT INTO RoleMapping VALUES (24,7,1)
	INSERT INTO RoleMapping VALUES (24,8,1)
	INSERT INTO RoleMapping VALUES (24,9,1)
	INSERT INTO RoleMapping VALUES (24,10,1)
	INSERT INTO RoleMapping VALUES (24,11,1)
	INSERT INTO RoleMapping VALUES (24,12,1)
	INSERT INTO RoleMapping VALUES (24,13,1)
	INSERT INTO RoleMapping VALUES (24,14,1)
	INSERT INTO RoleMapping VALUES (24,15,1)
	INSERT INTO RoleMapping VALUES (24,16,1)
	INSERT INTO RoleMapping VALUES (25,42,1)
	INSERT INTO RoleMapping VALUES (25,43,1)
	INSERT INTO RoleMapping VALUES (25,33,1)
	INSERT INTO RoleMapping VALUES (25,34,1)
	INSERT INTO RoleMapping VALUES (25,35,1)
	INSERT INTO RoleMapping VALUES (25,36,1)
	INSERT INTO RoleMapping VALUES (25,37,1)
	INSERT INTO RoleMapping VALUES (25,7,1)
	INSERT INTO RoleMapping VALUES (25,8,1)
	INSERT INTO RoleMapping VALUES (25,9,1)
	INSERT INTO RoleMapping VALUES (25,10,1)
	INSERT INTO RoleMapping VALUES (25,11,1)
	INSERT INTO RoleMapping VALUES (25,12,1)
	INSERT INTO RoleMapping VALUES (25,13,1)
	INSERT INTO RoleMapping VALUES (25,14,1)
	INSERT INTO RoleMapping VALUES (25,15,1)
	INSERT INTO RoleMapping VALUES (25,16,1)
	INSERT INTO RoleMapping VALUES (26,40,1)
	INSERT INTO RoleMapping VALUES (26,41,1)
	INSERT INTO RoleMapping VALUES (26,33,1)
	INSERT INTO RoleMapping VALUES (26,34,1)
	INSERT INTO RoleMapping VALUES (26,35,1)
	INSERT INTO RoleMapping VALUES (26,36,1)
	INSERT INTO RoleMapping VALUES (26,37,1)
	INSERT INTO RoleMapping VALUES (26,7,1)
	INSERT INTO RoleMapping VALUES (26,8,1)
	INSERT INTO RoleMapping VALUES (26,9,1)
	INSERT INTO RoleMapping VALUES (26,10,1)
	INSERT INTO RoleMapping VALUES (26,11,1)
	INSERT INTO RoleMapping VALUES (26,12,1)
	INSERT INTO RoleMapping VALUES (26,13,1)
	INSERT INTO RoleMapping VALUES (26,14,1)
	INSERT INTO RoleMapping VALUES (26,15,1)
	INSERT INTO RoleMapping VALUES (26,16,1)
	INSERT INTO RoleMapping VALUES (27,40,1)
	INSERT INTO RoleMapping VALUES (27,41,1)
	INSERT INTO RoleMapping VALUES (27,44,1)
	INSERT INTO RoleMapping VALUES (27,45,1)
	INSERT INTO RoleMapping VALUES (27,33,1)
	INSERT INTO RoleMapping VALUES (27,34,1)
	INSERT INTO RoleMapping VALUES (27,35,1)
	INSERT INTO RoleMapping VALUES (27,36,1)
	INSERT INTO RoleMapping VALUES (27,37,1)
	INSERT INTO RoleMapping VALUES (27,7,1)
	INSERT INTO RoleMapping VALUES (27,8,1)
	INSERT INTO RoleMapping VALUES (27,9,1)
	INSERT INTO RoleMapping VALUES (27,10,1)
	INSERT INTO RoleMapping VALUES (27,11,1)
	INSERT INTO RoleMapping VALUES (27,12,1)
	INSERT INTO RoleMapping VALUES (27,13,1)
	INSERT INTO RoleMapping VALUES (27,14,1)
	INSERT INTO RoleMapping VALUES (27,15,1)
	INSERT INTO RoleMapping VALUES (27,16,1)
	INSERT INTO RoleMapping VALUES (28,40,1)
	INSERT INTO RoleMapping VALUES (28,41,1)
	INSERT INTO RoleMapping VALUES (28,33,1)
	INSERT INTO RoleMapping VALUES (28,34,1)
	INSERT INTO RoleMapping VALUES (28,35,1)
	INSERT INTO RoleMapping VALUES (28,36,1)
	INSERT INTO RoleMapping VALUES (28,37,1)
	INSERT INTO RoleMapping VALUES (28,7,1)
	INSERT INTO RoleMapping VALUES (28,8,1)
	INSERT INTO RoleMapping VALUES (28,9,1)
	INSERT INTO RoleMapping VALUES (28,10,1)
	INSERT INTO RoleMapping VALUES (28,11,1)
	INSERT INTO RoleMapping VALUES (28,12,1)
	INSERT INTO RoleMapping VALUES (28,13,1)
	INSERT INTO RoleMapping VALUES (28,14,1)
	INSERT INTO RoleMapping VALUES (28,15,1)
	INSERT INTO RoleMapping VALUES (28,16,1)
	END

	CREATE TABLE MenuMapping (
	MMID INT PRIMARY KEY IDENTITY(1,1),
	FunctionID INT,
	ProcessID INT,
	RoleID INT,
	MenuID INT,
	SubMenuName VARCHAR(50),
	SMEMethod VARCHAR(100),
	Isactive BIT
	);

	-- SELECT * FROM MenuMapping

	CREATE TABLE InventoryColumn (
	ICID INT PRIMARY KEY IDENTITY(1,1),
	ColumnName VARCHAR(50),
	);

	-- SELECT * FROM InventoryColumn
	Begin
		INSERT INTO InventoryColumn VALUES ('COLUMN_A')
		INSERT INTO InventoryColumn VALUES ('COLUMN_B')
		INSERT INTO InventoryColumn VALUES ('COLUMN_C')
		INSERT INTO InventoryColumn VALUES ('COLUMN_D')
		INSERT INTO InventoryColumn VALUES ('COLUMN_E')
		INSERT INTO InventoryColumn VALUES ('COLUMN_F')
		INSERT INTO InventoryColumn VALUES ('COLUMN_G')
		INSERT INTO InventoryColumn VALUES ('COLUMN_H')
		INSERT INTO InventoryColumn VALUES ('COLUMN_I')
		INSERT INTO InventoryColumn VALUES ('COLUMN_J')
		INSERT INTO InventoryColumn VALUES ('COLUMN_K')
		INSERT INTO InventoryColumn VALUES ('COLUMN_L')
		INSERT INTO InventoryColumn VALUES ('COLUMN_M')
		INSERT INTO InventoryColumn VALUES ('COLUMN_N')
		INSERT INTO InventoryColumn VALUES ('COLUMN_O')
		INSERT INTO InventoryColumn VALUES ('COLUMN_P')
		INSERT INTO InventoryColumn VALUES ('COLUMN_Q')
		INSERT INTO InventoryColumn VALUES ('COLUMN_R')
		INSERT INTO InventoryColumn VALUES ('COLUMN_S')
		INSERT INTO InventoryColumn VALUES ('COLUMN_T')
		INSERT INTO InventoryColumn VALUES ('COLUMN_U')
		INSERT INTO InventoryColumn VALUES ('COLUMN_V')
		INSERT INTO InventoryColumn VALUES ('COLUMN_W')
		INSERT INTO InventoryColumn VALUES ('COLUMN_X')
		INSERT INTO InventoryColumn VALUES ('COLUMN_Y')
		INSERT INTO InventoryColumn VALUES ('COLUMN_Z')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AA')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AB')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AC')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AD')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AE')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AF')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AG')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AH')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AI')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AJ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AK')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AL')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AM')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AN')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AO')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AP')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AQ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AR')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AS')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AT')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AU')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AV')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AW')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AX')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AY')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AZ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BA')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BB')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BC')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BD')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BE')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BF')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BG')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BH')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BI')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BJ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BK')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BL')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BM')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BN')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BO')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BP')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BQ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BR')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BS')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BT')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BU')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BV')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BW')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BX')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BY')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BZ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CA')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CB')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CC')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CD')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CE')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CF')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CG')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CH')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CI')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CJ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CK')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CL')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CM')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CN')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CO')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CP')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CQ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CR')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CS')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CT')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CU')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CV')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CW')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CX')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CY')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CZ')
	End



	


  CREATE TABLE EmployeeMatrix (EMID INT PRIMARY KEY IDENTITY(1,1),
							[FullName] VARCHAR(50) NOT NULL , 
							[Status] varchar(10),
							[FatherName] Varchar(50) , 
							Gender varchar(6) NOT NULL , 
							[DOB] VARCHAR(20)  NOT NULL,
							[Location] varchar(20) NOT NULL,
							[Degree] varchar(10)  ,
							Qualification varchar(10),
							Phone Varchar(12) ,
							Address varchar(MAX),
							Grade varchar(10),
							Designation varchar(10),
							NTLG VARCHAR(50) UNIQUE ,
							MAILID Varchar(50) not null,
							Timing varchar(10),
							Type varchar(10),
							TLName varchar(50) , 
							TLID int ,
							SMName varchar(50),
							SMID INT,
							ADName varchar(50),
							ADID INT,
							DirectorID INT,
							DirectorName varchar(50),
							VicePresidentID INT,
							VicePresident  varchar(50),
							PresidentID Int, 
							President varchar(50),
							CEOID INT,
							CEO Varchar(50),
							Createdon Datetime Default GETDATE(),
							CreatedBy INT NOT NULL,
							LastModifiedOn DateTime ,
							LastModifiedBy InT
							)

CREATE TABLE Client(ClientID INT PRIMARY KEY IDENTITY(1,1),
						ClientName VARCHAR(20) NOT NULL , 
						CreatedOn DateTIme default GETDATE(),
						CreatedBy Varchar(50))

CREATE TABLE Practice(PracticeID INT PRIMARY KEY IDENTITY(1,1),
						PracticeName VARCHAR(20) NOT NULL , 
						CreatedOn DateTIme default GETDATE(),
						CreatedBy INT )

CREATE TABLE SubPractice(SubPracticeID INT PRIMARY KEY IDENTITY(1,1),
						SubPracticeName VARCHAR(20) NOT NULL , 
						CreatedOn DateTIme default GETDATE(),
						CreatedBy INT )

CREATE TABLE ClientMapping(CMID INT PRIMARY KEY IDENTITY(1,1),
							ClientID int NOT NULL , 
							LocationID int NOT null,
							PracticeID INT NOT NULL , 
							IsActive Bit default 1,
							CreatedOn DateTime Default GetDate())




Create Table ClientConfiguration (CCID INT PRIMARY KEY IDENTity(1,1),
								CMID INT NOT NULL,
								IsManualEntry BIT ,
								EffectiveFrom DateTime,
								EffectiveTo DateTime,
								IsActive BIT DEFAULT 1,
								CreatedOn DateTime Default GetDate(),
								CreatedBy INT)

	Create table ClientAccessMapping(FAMID INT primary key identity(1,1) ,
								EMPID INT NOT NULL	,
								CMID INT NOT NULL	,
								RMID INT NOT NULL	,
								IsActive Bit default 1)




	CREATE TABLE AdditionalUserAccess(AUAID INT primary key identity(1,1) ,
										IsPreAudit Bit default 0,
										UserTarget int,
										SamplingPercentage int,
										QAID int,
										Tenurity int,
										LoginID Varchar(50),
										EffectiveFrom DateTime,
										EffectiveTo DateTime,
										IsActive BIT DEFAULT 1,
										DeActivatedBy INT ,
										CreatedOn DateTime Default GetDate(),
										CreatedBy Varchar(50))

	CREATE TABLE ATBColumn (
				ATBCID INT PRIMARY KEY IDENTITY(1,1),
				ColumnName VARCHAR(50),
				);

	
	Begin
		INSERT INTO InventoryColumn VALUES ('COLUMN_A')
		INSERT INTO InventoryColumn VALUES ('COLUMN_B')
		INSERT INTO InventoryColumn VALUES ('COLUMN_C')
		INSERT INTO InventoryColumn VALUES ('COLUMN_D')
		INSERT INTO InventoryColumn VALUES ('COLUMN_E')
		INSERT INTO InventoryColumn VALUES ('COLUMN_F')
		INSERT INTO InventoryColumn VALUES ('COLUMN_G')
		INSERT INTO InventoryColumn VALUES ('COLUMN_H')
		INSERT INTO InventoryColumn VALUES ('COLUMN_I')
		INSERT INTO InventoryColumn VALUES ('COLUMN_J')
		INSERT INTO InventoryColumn VALUES ('COLUMN_K')
		INSERT INTO InventoryColumn VALUES ('COLUMN_L')
		INSERT INTO InventoryColumn VALUES ('COLUMN_M')
		INSERT INTO InventoryColumn VALUES ('COLUMN_N')
		INSERT INTO InventoryColumn VALUES ('COLUMN_O')
		INSERT INTO InventoryColumn VALUES ('COLUMN_P')
		INSERT INTO InventoryColumn VALUES ('COLUMN_Q')
		INSERT INTO InventoryColumn VALUES ('COLUMN_R')
		INSERT INTO InventoryColumn VALUES ('COLUMN_S')
		INSERT INTO InventoryColumn VALUES ('COLUMN_T')
		INSERT INTO InventoryColumn VALUES ('COLUMN_U')
		INSERT INTO InventoryColumn VALUES ('COLUMN_V')
		INSERT INTO InventoryColumn VALUES ('COLUMN_W')
		INSERT INTO InventoryColumn VALUES ('COLUMN_X')
		INSERT INTO InventoryColumn VALUES ('COLUMN_Y')
		INSERT INTO InventoryColumn VALUES ('COLUMN_Z')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AA')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AB')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AC')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AD')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AE')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AF')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AG')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AH')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AI')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AJ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AK')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AL')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AM')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AN')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AO')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AP')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AQ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AR')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AS')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AT')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AU')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AV')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AW')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AX')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AY')
		INSERT INTO InventoryColumn VALUES ('COLUMN_AZ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BA')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BB')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BC')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BD')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BE')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BF')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BG')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BH')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BI')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BJ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BK')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BL')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BM')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BN')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BO')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BP')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BQ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BR')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BS')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BT')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BU')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BV')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BW')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BX')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BY')
		INSERT INTO InventoryColumn VALUES ('COLUMN_BZ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CA')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CB')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CC')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CD')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CE')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CF')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CG')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CH')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CI')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CJ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CK')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CL')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CM')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CN')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CO')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CP')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CQ')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CR')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CS')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CT')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CU')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CV')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CW')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CX')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CY')
		INSERT INTO InventoryColumn VALUES ('COLUMN_CZ')
	End


	Create Table ATBColumnMapping( ACMID INT PRIMARY KEY IDENTITY(1,1),
									CMID INT ,
									ATBColumnID INT Not Null,
									ATBColumnName Varchar(75) NOT NULL,
									IsUnique Bit ,
									IsMandate BIT,
									IsDateField BIT,
									IsCurrency Bit,
									IsNumber Bit,
									IsAgingFiled BIT,
									IsGroupBy BIT,
									IsWorkLevel Bit,
									ColumnOrder INT,
									
									IsActive BIT DEFAULT 1,
									CreatedOn DateTime Default GetDate(),
									CreatedBy INT
										)

	Create Table Scenario( ScenarioID  INT PRIMARY KEY IDENTITY(1,1),
									ScenarioName Varchar(100) NOT nuLL Unique,
									
									)

	Create Table SubScenario( SubScenarioID  INT PRIMARY KEY IDENTITY(1,1),
									SubScenarioName Varchar(100) NOT nuLL Unique,
									)

		Create Table [Action]( ActionID  INT PRIMARY KEY IDENTITY(1,1),
									ActionName Varchar(100) NOT nuLL Unique,
									)

		Create Table [ScenarioMapping]( ScenarioMappingID  INT PRIMARY KEY IDENTITY(1,1),
							CMID INT NOT NULL,
							ScenarioID INT Not NUll,
							SubScenarioID INT Not NUll,
							ActionID INT Not NUll,
							IsTickler BIT ,
							FactorizedCount decimal ,
							IsProduction Bit,
							IsActive BIT DEFAULT 1,
							CreatedOn DateTime Default GetDate(),
							CreatedBy INT)


		Create Table ErrorCategory( ErrorCategoryID  INT PRIMARY KEY IDENTITY(1,1),
									ErrorCategoryName Varchar(100) NOT nuLL Unique,
									
									)

						Create Table SubErrorCategory( SubErrorCategoryID  INT PRIMARY KEY IDENTITY(1,1),
									SubErrorCategoryName Varchar(100) NOT nuLL Unique,
									)
						Create Table MicroErrorCategory( MicroErrorCategoryID  INT PRIMARY KEY IDENTITY(1,1),
						MicroErrorCategoryName Varchar(100) NOT nuLL Unique,
						)
						Create Table NanoErrorCategory( NanoErrorCategoryID  INT PRIMARY KEY IDENTITY(1,1),
									NanoErrorCategoryName Varchar(100) NOT nuLL Unique,
									)

						Create Table [errorMapping]( ErrorMappingID  INT PRIMARY KEY IDENTITY(1,1),
									CMID INT NOT NULL,
									ErrorCategoryID INT Not NUll,
									SubErrorCategoryID INT Not NUll,
									MicroErrorCategoryID INT Not NUll,
									NanoErrorCategoryID BIT ,
									ErrorWeightage decimal ,
									IsActive BIT DEFAULT 1,
									CreatedOn DateTime Default GetDate(),
									CreatedBy INT)


			Create Table ManulaEntry(MEID   INT PRIMARY KEY IDENTITY(1,1),
										ACMID INT ,
										Type VARCHAR(50),
										Ismandatory bit,
										ManualEntryColumnOrder int,
										IsActive BIT DEFAULT 1,
										CreatedOn DateTime Default GetDate(),
										CreatedBy INT)	
			
			CREAte TABLE DropDownitems(DDID INT PRIMARY KEY IDENTITY(1,1),
										MEID int,
										ACID int ,
										[Name] varchar(75),
										IsActive bit
								)


			Create Table AdditionalCapture(ACID   INT PRIMARY KEY IDENTITY(1,1),
										Type VARCHAR(50),
										Name Varchar(50),
										Ismandatory bit,
										ColumnOrder int,
										IsActive BIT DEFAULT 1,
										CreatedOn DateTime Default GetDate(),
										CreatedBy INT)	



		CReate Table UploadType(TypeId  INT  PRIMARY KEY IDENTITY(1,1),
							[Type] varchar(50),
							IsActive bit Default 1
								)

INSERT INTO UploadType Values(  'Auto')
				INSERT INTO UploadType Values(  'ATB')
				INSERT INTO UploadType Values(  'Manual')


		Create Table ATBUpload( ATBUploadID INT  PRIMARY KEY IDENTITY(1,1),
									CMID Int not Null,
									[FileName] Varchar(100) Not null,
									[FileReNamed] Varchar(100) Not null,
									TypeID Int Not NUll,									
									IsUploaded Bit ,
									UploadedCount INT,
									ValidCount INT,
									CarryForwardCount INT,
									ManualClosedCount INT,
									ManualEntryCount INT,
									DuplicateCount Int,
									ErrorCount INT,
									IsPriority bit,
									[Priority] varchar(50),
									IsArchived bit,
									UploadedBy INT ,
									CreatedOn DateTime Default GetDate(),
									CreatedBy INT)	


Create Table Tenure(TenureID INT PRIMARY KEY IDENTITY(1,1),
								Category Varchar(50) )

					Insert into tenure values('0-6 Months'
					Insert into tenure values('6-12 Months')
					Insert into tenure values('12+ Months')

	Create Table Inventory( InventoryId INT PRIMARY KEY IDENTITY(1,1),
							CMID INT not null,
							ATBID int not null,
							AssignedTo int,
							AssignedBy int,
							Assignedon int,
							QueueID int,
							UniqueID Varchar(75),
							IsInvoicePriority Bit,
							InvoicePriority varchar(100),
									COLUMN_A varchar2(max) ,
		COLUMN_B varchar2(max) ,
		COLUMN_C varchar2(max) ,
		COLUMN_D varchar2(max) ,
		COLUMN_E varchar2(max) ,
		COLUMN_F varchar2(max) ,
		COLUMN_G varchar2(max) ,
		COLUMN_H varchar2(max) ,
		COLUMN_I varchar2(max) ,
		COLUMN_J varchar2(max) ,
		COLUMN_K varchar2(max) ,
		COLUMN_L varchar2(max) ,
		COLUMN_M varchar2(max) ,
		COLUMN_N varchar2(max) ,
		COLUMN_O varchar2(max) ,
		COLUMN_P varchar2(max) ,
		COLUMN_Q varchar2(max) ,
		COLUMN_R varchar2(max) ,
		COLUMN_S varchar2(max) ,
		COLUMN_T varchar2(max) ,
		COLUMN_U varchar2(max) ,
		COLUMN_V varchar2(max) ,
		COLUMN_W varchar2(max) ,
		COLUMN_X varchar2(max) ,
		COLUMN_Y varchar2(max) ,
		COLUMN_Z varchar2(max) ,
		COLUMN_AA varchar2(max) ,
		COLUMN_AB varchar2(max) ,
		COLUMN_AC varchar2(max) ,
		COLUMN_AD varchar2(max) ,
		COLUMN_AE varchar2(max) ,
		COLUMN_AF varchar2(max) ,
		COLUMN_AG varchar2(max) ,
		COLUMN_AH varchar2(max) ,
		COLUMN_AI varchar2(max) ,
		COLUMN_AJ varchar2(max) ,
		COLUMN_AK varchar2(max) ,
		COLUMN_AL varchar2(max) ,
		COLUMN_AM varchar2(max) ,
		COLUMN_AN varchar2(max) ,
		COLUMN_AO varchar2(max) ,
		COLUMN_AP varchar2(max) ,
		COLUMN_AQ varchar2(max) ,
		COLUMN_AR varchar2(max) ,
		COLUMN_AS varchar2(max) ,
		COLUMN_AT varchar2(max) ,
		COLUMN_AU varchar2(max) ,
		COLUMN_AV varchar2(max) ,
		COLUMN_AW varchar2(max) ,
		COLUMN_AX varchar2(max) ,
		COLUMN_AY varchar2(max) ,
		COLUMN_AZ varchar2(max) ,
		COLUMN_BA varchar2(max) ,
		COLUMN_BB varchar2(max) ,
		COLUMN_BC varchar2(max) ,
		COLUMN_BD varchar2(max) ,
		COLUMN_BE varchar2(max) ,
		COLUMN_BF varchar2(max) ,
		COLUMN_BG varchar2(max) ,
		COLUMN_BH varchar2(max) ,
		COLUMN_BI varchar2(max) ,
		COLUMN_BJ varchar2(max) ,
		COLUMN_BK varchar2(max) ,
		COLUMN_BL varchar2(max) ,
		COLUMN_BM varchar2(max) ,
		COLUMN_BN varchar2(max) ,
		COLUMN_BO varchar2(max) ,
		COLUMN_BP varchar2(max) ,
		COLUMN_BQ varchar2(max) ,
		COLUMN_BR varchar2(max) ,
		COLUMN_BS varchar2(max) ,
		COLUMN_BT varchar2(max) ,
		COLUMN_BU varchar2(max) ,
		COLUMN_BV varchar2(max) ,
		COLUMN_BW varchar2(max) ,
		COLUMN_BX varchar2(max) ,
		COLUMN_BY varchar2(max) ,
		COLUMN_BZ varchar2(max) ,
		COLUMN_CA varchar2(max) ,
		COLUMN_CB varchar2(max) ,
		COLUMN_CC varchar2(max) ,
		COLUMN_CD varchar2(max) ,
		COLUMN_CE varchar2(max) ,
		COLUMN_CF varchar2(max) ,
		COLUMN_CG varchar2(max) ,
		COLUMN_CH varchar2(max) ,
		COLUMN_CI varchar2(max) ,
		COLUMN_CJ varchar2(max) ,
		COLUMN_CK varchar2(max) ,
		COLUMN_CL varchar2(max) ,
		COLUMN_CM varchar2(max) ,
		COLUMN_CN varchar2(max) ,
		COLUMN_CO varchar2(max) ,
		COLUMN_CP varchar2(max) ,
		COLUMN_CQ varchar2(max) ,
		COLUMN_CR varchar2(max) ,
		COLUMN_CS varchar2(max) ,
		COLUMN_CT varchar2(max) ,
		COLUMN_CU varchar2(max) ,
		COLUMN_CV varchar2(max) ,
		COLUMN_CW varchar2(max) ,
		COLUMN_CX varchar2(max) ,
	COLUMN_CY  varchar2(max) ,
	COLUMN_CZ  varchar2(max),
	RuleID INT,
	
	)

	CarryForwadedFrom int
	IsCarryForwaded BIT,
	CarryForwadedon DateTIME,
	ManualClosed BIt,
	IsManualATBID INT,
	ManualClosedOn dateTime

