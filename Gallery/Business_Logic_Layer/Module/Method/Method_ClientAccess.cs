using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic_Layer.Module.Class;
using Data_Access_Layer.Repository;

namespace Business_Logic_Layer.Module.Method
{
    public class Method_ClientAccess
    {
        #region  Business Logic and Data Access Layer Referance

        Repository_DataMapper Repository_DataMapper = new Repository_DataMapper();
        Method_Common Method_Common = new Method_Common();

        #endregion

        #region  Method

        public void MapClientPracticeSubPractice(dynamic dyn_Data)
        {
            if (Class_ClientAccess.ClientInfo.ClientID == "0")
            {
                Method_Common.ShowNotification("Error", "Please Select The Client");
            }
            else if (Class_ClientAccess.ClientInfo.PracticeID == "0")
            {
                Method_Common.ShowNotification("Error", "Please Select The Practice");
            }
            else if (Class_ClientAccess.ClientInfo.SubPracticeID == "0")
            {
                Method_Common.ShowNotification("Error", "Please Select The SubPractice");
            }
            else
            {
                Repository_DataMapper.CheckIsClientMappingExist(dyn_Data);
                if (Repository_Class.Repository.dv == "1")
                {
                    Method_Common.ShowNotification("Error", "Client Maping Exist");
                }
                else
                {
                    Repository_DataMapper.MapClientPracticeSubPractice(dyn_Data);
                    Method_Common.ShowNotification("Success", "Updated Sucessfully");
                }
            }
        }

        #endregion

    }
}
