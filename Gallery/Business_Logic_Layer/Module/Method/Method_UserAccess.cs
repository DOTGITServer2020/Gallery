using Business_Logic_Layer.Module.Class;
using Data_Access_Layer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Module.Method
{
    public class Method_UserAccess
    {
        #region  Business Logic and Data Access Layer Referance

        Repository_DataMapper Repository_DataMapper = new Repository_DataMapper();
        Method_Common Method_Common = new Method_Common();

        #endregion

        #region  Method
        public void AddEmployee(dynamic dyn_Data)
        {
            string EmployeeID = dyn_Data.EmployeeID;
            string EmployeeName = dyn_Data.EmployeeName;
            if (EmployeeID.Length == 0)
            {
                Method_Common.ShowNotification("Error", "Employee Id Missing");
            }
            else if (EmployeeName.Length == 0)
            {
                Method_Common.ShowNotification("Error", "Employee Name Missing");
            }
            else
            {
                Repository_DataMapper.CheckIsEmployeeIDExist(dyn_Data);
                if (Repository_Class.Repository.dv == "1")
                {
                    Method_Common.ShowNotification("Error", "Exployee Exist");
                }
                else
                {
                    Repository_DataMapper.AddEmployee(dyn_Data);
                    Method_Common.ShowNotification("Success", "Employee Added");
                }
            }
        }
        #endregion
    }
}
