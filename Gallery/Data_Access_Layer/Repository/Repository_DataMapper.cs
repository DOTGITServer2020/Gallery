using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Repository;

namespace Data_Access_Layer.Repository
{
    public class Repository_DataMapper
    {
        #region  Business Logic and Data Access Layer Referance

        Repository_SqlHandler Repository_SqlHandler = new Repository_SqlHandler();

        #endregion

        #region  Method Old

        public DataSet LoadClientMaping(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Read";
            Repository_Class.Repository.SQLQuery = "EXEC GetClientMaping " + dyn_Data.ClientStatus;
            return Repository_SqlHandler.SQL_Handler();
        }

        public DataSet LoadClient()
        {
            Repository_Class.Repository.SQLMethod = "SP";
            Repository_Class.Repository.SQLCommand = "Select";
            Repository_Class.Repository.SQLQuery = "GetClient";
            return Repository_SqlHandler.SQL_Handler();
        }

        public DataSet LoadPractice()
        {
            Repository_Class.Repository.SQLMethod = "SP";
            Repository_Class.Repository.SQLCommand = "Select";
            Repository_Class.Repository.SQLQuery = "GetPractice";
            return Repository_SqlHandler.SQL_Handler();
        }

        public DataSet LoadSubPractice()
        {
            Repository_Class.Repository.SQLMethod = "SP";
            Repository_Class.Repository.SQLCommand = "Select";
            Repository_Class.Repository.SQLQuery = "GetSubPractice";
            return Repository_SqlHandler.SQL_Handler();
        }

        public void AddClient(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Modify";
            Repository_Class.Repository.SQLCommand = "Insert";
            Repository_Class.Repository.SQLQuery = "INSERT INTO Client VALUES ('" + dyn_Data.ClientName + "','" + Repository_Class.localStorage.UserName + "','" + Repository_Class.localStorage.MachineIdentity + "',GETDATE())";
            Repository_SqlHandler.SQL_Handler();
        }

        public void AddPractice(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Modify";
            Repository_Class.Repository.SQLCommand = "Insert";
            Repository_Class.Repository.SQLQuery = "INSERT INTO Practice VALUES ('" + dyn_Data.PracticeName + "','" + Repository_Class.localStorage.UserName + "','" + Repository_Class.localStorage.MachineIdentity + "',GETDATE())";
            Repository_SqlHandler.SQL_Handler();
        }

        public void AddSubPractice(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Modify";
            Repository_Class.Repository.SQLCommand = "Insert";
            Repository_Class.Repository.SQLQuery = "INSERT INTO SubPractice VALUES ('" + dyn_Data.SubPracticeName + "','" + Repository_Class.localStorage.UserName + "','" + Repository_Class.localStorage.MachineIdentity + "',GETDATE())";
            Repository_SqlHandler.SQL_Handler();
        }

        public void MapClientPracticeSubPractice(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Modify";
            Repository_Class.Repository.SQLCommand = "Insert";
            Repository_Class.Repository.SQLQuery = "INSERT INTO ClientMaping VALUES (" + dyn_Data.ClientID + "," + dyn_Data.PracticeID + "," + dyn_Data.SubPracticeID + ",'" + Repository_Class.localStorage.UserName + "','" + Repository_Class.localStorage.MachineIdentity + "',GETDATE(),1)";
            Repository_SqlHandler.SQL_Handler();
        }

       public void CheckIsClientExist(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Single";
            Repository_Class.Repository.SQLQuery = "EXEC CheckIsClientExist '" + dyn_Data.ClientName + "'";
            Repository_SqlHandler.SQL_Handler();
        }

        public void CheckIsPracticeExist(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Single";
            Repository_Class.Repository.SQLQuery = "EXEC CheckIsPracticeExist '" + dyn_Data.PracticeName + "'";
            Repository_SqlHandler.SQL_Handler();
        }

        public void CheckIsSubPracticeExist(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Single";
            Repository_Class.Repository.SQLQuery = "EXEC CheckIsSubPracticeExist '" + dyn_Data.SubPracticeName + "'";
            Repository_SqlHandler.SQL_Handler();
        }

        public void CheckIsClientMappingExist(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Single";
            Repository_Class.Repository.SQLQuery = "EXEC CheckIsClientMapingExist " + dyn_Data.ClientID + "," + dyn_Data.PracticeID + "," + dyn_Data.SubPracticeID;
            Repository_SqlHandler.SQL_Handler();
        }

        public void ActivateClientMaping(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Modify";
            Repository_Class.Repository.SQLCommand = "Update";
            Repository_Class.Repository.SQLQuery = "UPDATE ClientMaping SET IsActive = 1 Where CMapID = " + dyn_Data.CMapID;
            Repository_SqlHandler.SQL_Handler();
        }

        public void DeActivateClientMaping(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Modify";
            Repository_Class.Repository.SQLCommand = "Update";
            Repository_Class.Repository.SQLQuery = "UPDATE ClientMaping SET IsActive = 0 Where CMapID = " + dyn_Data.CMapID;
            Repository_SqlHandler.SQL_Handler();
        }

        public void AddEmployee(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Modify";
            Repository_Class.Repository.SQLCommand = "Insert";
            Repository_Class.Repository.SQLQuery = "INSERT INTO Users VALUES ('" + dyn_Data.EmployeeID + "','" + dyn_Data.EmployeeName + "','" + Repository_Class.localStorage.UserName + "','" + Repository_Class.localStorage.MachineIdentity + "',GETDATE(),1)";
            Repository_SqlHandler.SQL_Handler();
        }

        public void CheckIsEmployeeIDExist(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Single";
            Repository_Class.Repository.SQLQuery = "EXEC CheckIsEmployeeIDExist '" + dyn_Data.EmployeeID + "'";
            Repository_SqlHandler.SQL_Handler();
        }

        public DataSet LoadUsers()
        {
            Repository_Class.Repository.SQLMethod = "SP";
            Repository_Class.Repository.SQLCommand = "Select";
            Repository_Class.Repository.SQLQuery = "GetUsers";
            return Repository_SqlHandler.SQL_Handler();
        }

        public void CheckIsUserAccessExist(dynamic dyn_Data)
        {
            Repository_Class.Repository.SQLMethod = "Single";
            Repository_Class.Repository.SQLQuery = "EXEC CheckIsUserAccessExist " + dyn_Data.UserID + ", " + dyn_Data.CMapID;
            Repository_SqlHandler.SQL_Handler();
        }



        #endregion

        #region  Method New

        #region  Theme

        public DataSet GetSubMenu(string MenuName)
        {
            Repository_Class.Repository.SQLMethod = "SP";
            Repository_Class.Repository.SQLCommand = "Select";
            Repository_Class.Repository.SQLQuery = "GetSubMenu";
            Repository_Class.Repository.SQLParameterValue = "{\"FunctionID\":\"" + Repository_Class.localStorage.FunctionID + "\",\"PMID\":\"" + Repository_Class.localStorage.PMID + "\",\"RMID\":\"" + Repository_Class.localStorage.RMID + "\",\"MenuName\":\"" + MenuName + "\"}";
            return Repository_SqlHandler.SQL_Handler();
        }

        #endregion

        #region  TwoStageLogin

        public DataSet LoadFunction()
        {
            Repository_Class.Repository.SQLMethod = "SP";
            Repository_Class.Repository.SQLCommand = "Select";
            Repository_Class.Repository.SQLQuery = "GetFunctions";
            return Repository_SqlHandler.SQL_Handler();
        }

        public DataSet LoadProcess(string FunctionID)
        {
            Repository_Class.Repository.SQLMethod = "SP";
            Repository_Class.Repository.SQLCommand = "Select";
            Repository_Class.Repository.SQLQuery = "GetProcess";
            Repository_Class.Repository.SQLParameterValue = "{\"FunctionID\":\"" + FunctionID + "\"}";
            return Repository_SqlHandler.SQL_Handler();
        }

        public DataSet LoadRole(string PMID)
        {
            Repository_Class.Repository.SQLMethod = "SP";
            Repository_Class.Repository.SQLCommand = "Select";
            Repository_Class.Repository.SQLQuery = "GetRoles";
            Repository_Class.Repository.SQLParameterValue = "{\"PMID\":\"" + PMID + "\"}";
            return Repository_SqlHandler.SQL_Handler();
        }
        #endregion

        #endregion
    }
}
