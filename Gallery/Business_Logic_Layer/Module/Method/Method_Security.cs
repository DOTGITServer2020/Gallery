using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic_Layer.Module.Class;
using Data_Access_Layer.Repository;

namespace Business_Logic_Layer.Module.Method
{
    public class Method_Security
    {
        #region  Business Logic and Data Access Layer Referance

        Method_Common Method_Common = new Method_Common();

        #endregion

        #region  Method

        public void LoginValidation()
        {
            if (Class_Security.SecurityInfo.CurrentPassword == "Current Password")
            {
                Method_Common.ShowNotification("Error", "Please enter the Current Password");
            }
            else if (Class_Security.SecurityInfo.NewPassword == "New Password")
            {
                Method_Common.ShowNotification("Error", "Please enter the New Password");
            }
            else if (Class_Security.SecurityInfo.ConformPassword == "Conform Password")
            {
                Method_Common.ShowNotification("Error", "Please enter the Conform Password");
            }
            else
            {
                
            }
        }

        #endregion
    }
}
