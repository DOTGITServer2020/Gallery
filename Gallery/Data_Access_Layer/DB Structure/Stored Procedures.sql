CREATE PROCEDURE GetClient

--EXEC GetClient;

AS
BEGIN
    SELECT 
		ClientID,
		ClientName
    FROM 
        Client
    ORDER BY 
        ClientName;
END;

CREATE PROCEDURE GetPractice

--EXEC GetPractice;

AS
BEGIN
    SELECT 
		PracticeID,
		PracticeName
    FROM 
        Practice
    ORDER BY 
        PracticeName;
END;

CREATE PROCEDURE GetSubPractice

--EXEC GetSubPractice;

AS
BEGIN
    SELECT 
		SubPracticeID,
		SubPracticeName
    FROM 
        SubPractice
    ORDER BY 
        SubPracticeName;
END;

CREATE PROCEDURE GetClientPracticeSubPractice

--EXEC GetClientPracticeSubPractice;

AS
BEGIN
	EXEC GetClient;
	EXEC GetPractice;
    EXEC GetSubPractice;
END;


CREATE PROCEDURE GetClientMaping

--EXEC GetClientMaping 1;

@Isactive INT

AS
BEGIN
	 SELECT 
		CM.CMapID,
		CM.ClientID,
		C.ClientName,
		CM.PracticeID,
		P.PracticeName,
		CM.SubPracticeID,
		S.SubPracticeName
    FROM 
        ClientMaping CM
		INNER JOIN Client C ON C.ClientID = CM.ClientID
		INNER JOIN Practice P ON P.PracticeID = CM.PracticeID
		INNER JOIN SubPractice S ON S.SubPracticeID = CM.SubPracticeID
	WHERE
		CM.Isactive = @Isactive
    ORDER BY 
        CM.CMapID;
END;

CREATE PROCEDURE CheckIsClientMapingExist

--EXEC CheckIsClientMapingExist 1,1,1;

@CID INT,
@PID INT,
@SPID INT

AS
BEGIN
	 SELECT 
		COUNT(CMapID)[Result]		
    FROM 
        ClientMaping 
	WHERE
		ClientID = @CID AND
		PracticeID = @PID AND
		SubPracticeID = @SPID
END;

CREATE PROCEDURE CheckIsClientExist

--EXEC CheckIsClientExist 'DevClient';

@CName VARCHAR(500)

AS
BEGIN
	 SELECT 
		COUNT(ClientID)[Result]		
    FROM 
        Client
	WHERE
		ClientName = @CName		
END;

CREATE PROCEDURE CheckIsPracticeExist

--EXEC CheckIsPracticeExist 'DevPractice';

@PName VARCHAR(500)

AS
BEGIN
	 SELECT 
		COUNT(PracticeID)[Result]		
    FROM 
        Practice
	WHERE
		PracticeName = @PName		
END;

CREATE PROCEDURE CheckIsSubPracticeExist

--EXEC CheckIsSubPracticeExist 'DevSubPractice';

@PName VARCHAR(500)

AS
BEGIN
	 SELECT 
		COUNT(SubPracticeID)[Result]		
    FROM 
        SubPractice
	WHERE
		SubPracticeName = @PName		
END;

CREATE PROCEDURE CheckIsEmployeeIDExist

--EXEC CheckIsEmployeeIDExist 'DOT_Addmin';

@EmployeeID VARCHAR(500)

AS
BEGIN
	 SELECT 
		COUNT(UserID)[Result]		
    FROM 
        Users
	WHERE
		EmployeeID = @EmployeeID		
END;

CREATE PROCEDURE GetUsers

--EXEC GetUsers;

AS
BEGIN
    SELECT
		UserID,
		(EmployeeID + ' - ' + EmployeeName) As Users
    FROM 
        Users
    ORDER BY 
        EmployeeID
END;

CREATE PROCEDURE CheckIsUserAccessExist

--EXEC CheckIsUserAccessExist 1,1;

@UserID INT,
@CMapID INT

AS
BEGIN
	 SELECT 
		COUNT(UserID)[Result]		
    FROM 
        UserAccess
	WHERE
		UserID = @UserID AND
		CMapID = @CMapID
END;
