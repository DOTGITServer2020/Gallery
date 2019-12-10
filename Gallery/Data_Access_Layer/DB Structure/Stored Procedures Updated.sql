CREATE PROCEDURE GetFunctions

--EXEC GetFunctions;

AS
BEGIN
    SELECT 
		FunctionID,
		FunctionName
    FROM 
        Functions
	WHERE
		Isactive = 1
    ORDER BY 
        FunctionName;
END;

CREATE PROCEDURE GetProcess

@json NVARCHAR(max)

AS
BEGIN

DECLARE @FunctionID INT

SET @FunctionID = (
				SELECT
						FunctionID
				FROM 
					OPENJSON(@json)
					WITH (
					  FunctionID INT '$.FunctionID'
						 ) AS jsonValues
				)
    SELECT 
		PM.PMID,
		P.ProcessName
    FROM 
        Process P
		INNER JOIN Processmapping PM ON PM.ProcessID = P.ProcessID
	WHERE
		PM.FunctionID = @FunctionID AND PM.Isactive = 1 AND P.Isactive = 1
    ORDER BY 
        P.ProcessName;
END;


CREATE PROCEDURE GetRoles

@json NVARCHAR(max)

AS
BEGIN

DECLARE @PMID INT

SET @PMID = (
				SELECT
						PMID
				FROM 
					OPENJSON(@json)
					WITH (
					  PMID INT '$.PMID'
						 ) AS jsonValues
				)
    SELECT 
		RM.RMID,
		R.RoleName
    FROM 
        Roles R
		INNER JOIN RoleMapping RM ON RM.RoleID = R.RoleID
	WHERE
		RM.PMID = @PMID AND RM.Isactive = 1 AND R.Isactive = 1		
    ORDER BY 
        R.RoleName
END;


CREATE PROCEDURE GetSubMenu

@json NVARCHAR(max)
	
AS
BEGIN

DECLARE @FunctionID INT
DECLARE @PMID INT
DECLARE @RMID INT
DECLARE @ProcessID INT
DECLARE @RoleID INT
DECLARE @MenuName  VARCHAR(20)
DECLARE @MenuID INT

SET @FunctionID = (
				SELECT
						FunctionID
				FROM 
					OPENJSON(@json)
					WITH (
					  FunctionID INT '$.FunctionID'
						 ) AS jsonValues
				)

SET @PMID = (
				SELECT
						PMID
				FROM 
					OPENJSON(@json)
					WITH (
					  PMID INT '$.PMID'
						 ) AS jsonValues
				)

SET @RMID = (
				SELECT
						RMID
				FROM 
					OPENJSON(@json)
					WITH (
					  RMID INT '$.RMID'
						 ) AS jsonValues
				)

SET @MenuName = (
				SELECT
						MenuName
				FROM 
					OPENJSON(@json)
					WITH (
					  MenuName VARCHAR(20) '$.MenuName'
						 ) AS jsonValues
				)
	

SET @MenuID = (
				SELECT 
					MenuID 
				FROM 
					Menu 
				WHERE 
					MenuName = @MenuName
			  )

SET @ProcessID = (
				SELECT 
					ProcessID 
				FROM 
					Processmapping 
				WHERE 
					PMID = @PMID
			  )

SET @RoleID = (
				SELECT 
					RoleID  
				FROM 
					Rolemapping 
				WHERE 
					RMID = @RMID
			  )

	SELECT 
		SubMenuName,
		SMEMethod
	FROM 
		Navigator
	WHERE
		FunctionID = @FunctionID AND
		ProcessID = @ProcessID AND
		RoleID = @RoleID AND
		MenuID = @MenuID AND
		Isactive = 1
END;


