using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic_Layer.Module.Class;

namespace Business_Logic_Layer.Module.Method
{
    public class Method_Common
    {
        public void ShowNotification(string Title, string Description)
        {
            Class_Common.Execute.E_Method = "MessageBox";
            Class_Common.MessageBox.Title = Title;
            Class_Common.MessageBox.Description = Description;
        }
        
    }
}
