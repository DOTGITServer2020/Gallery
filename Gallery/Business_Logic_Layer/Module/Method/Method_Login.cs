using System;
using System.Text;
using System.Security.Cryptography;
using System.Resources;
using System.Net;
using Business_Logic_Layer.Module.Class;
using Business_Logic_Layer.Module.Method;
using Business_Logic_Layer.Properties;
using Data_Access_Layer.Repository;

namespace Business_Logic_Layer.Module.Method
{
    public class Method_Login
    {
        #region  Business Logic and Data Access Layer Referance

        Method_Common Method_Common = new Method_Common();

        #endregion

        #region  Method

        public static string Encrypt(string input)
        {
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider
            {
                Key = UTF8Encoding.UTF8.GetBytes("gal1-dot1-tech20"),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = tripleDES.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string Decrypt(string input)
        {
            byte[] inputArray = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider
            {
                Key = UTF8Encoding.UTF8.GetBytes("gal1-dot1-tech20"),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
        
        public void LoginValidation()
        {
            if (Class_Login.LoginInfo.UserName == "User Name")
            {
                Method_Common.ShowNotification("Error", "Please enter the User Name");
            }
            else if (Class_Login.LoginInfo.Password == "Password")
            {
                Method_Common.ShowNotification("Error", "Please enter the Password");
            }
            else
            {
                ResourceManager RES_MNG = new ResourceManager(typeof(Resources));
                Class_Login.LoginInfo.UN = RES_MNG.GetString("UN");
                Class_Login.LoginInfo.PW = RES_MNG.GetString("PW");

                if (Encrypt(Class_Login.LoginInfo.UserName) == Class_Login.LoginInfo.UN)
                {
                    if (Encrypt(Class_Login.LoginInfo.Password) == Class_Login.LoginInfo.PW)
                    {
                        Class_Login.LoginInfo.isCredentialValid = 1;
                    }
                    else
                    {
                        Class_Login.LoginInfo.isCredentialValid = 0;
                    }
                }
                else
                {

                }

                if (Class_Login.LoginInfo.isCredentialValid == 0)
                {
                    Method_Common.ShowNotification("Error", "Invalid Login");
                }                                       
                else
                {
                    Class_Common.Execute.E_Method = "LoginSucessfull";
                    Repository_Class.localStorage.HostName = Dns.GetHostName();
                    Repository_Class.localStorage.IP = Dns.GetHostByName(Repository_Class.localStorage.HostName).AddressList[0].ToString();
                    Repository_Class.localStorage.MachineIdentity = Repository_Class.localStorage.HostName + " (" + Repository_Class.localStorage.IP + ")";
                    Repository_Class.localStorage.UserName = Class_Login.LoginInfo.UserName;
                }

            }
        }

        public void SessionValidation()
        {
            if (Repository_Class.localStorage.FunctionID == "0")
            {
                Method_Common.ShowNotification("Error", "Please Select Function");
            }
            else if (Repository_Class.localStorage.PMID == "0")
            {
                Method_Common.ShowNotification("Error", "Please Select Process");
            }
            else if (Repository_Class.localStorage.RMID == "0")
            {
                Method_Common.ShowNotification("Error", "Please Select Role");
            }
            else
            {
                Class_Common.Execute.E_Method = "SessionSelected";

            }
        }
        #endregion
    }
}
