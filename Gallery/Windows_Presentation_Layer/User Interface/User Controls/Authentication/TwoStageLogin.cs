using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Presentation_Layer.Properties;
using System.Resources;
using Business_Logic_Layer.Module.Class;
using Business_Logic_Layer.Module.Method;
using Data_Access_Layer.Repository;

namespace Windows_Presentation_Layer.User_Interface.User_Controls.Authentication
{
    public partial class TwoStageLogin : UserControl
    {
        #region  Business Logic and Data Access Layer Referance

        Repository_DataMapper Repository_DataMapper = new Repository_DataMapper();
        Method_Login Method_Login = new Method_Login();
        Method_Common Method_Common = new Method_Common();

        #endregion

        #region  Method

        public TwoStageLogin()
        {
            InitializeComponent();
        }

        public void LoadFunction()
        {
            DataSet dsFunction = new DataSet();
            dsFunction = Repository_DataMapper.LoadFunction();
            DataRow r = dsFunction.Tables[0].NewRow(); r["FunctionID"] = 0; r["FunctionName"] = "-Select-";
            dsFunction.Tables[0].Rows.InsertAt(r, 0);
            CB_Function.DataSource = dsFunction.Tables[0];
            CB_Function.DisplayMember = "FunctionName";
            CB_Function.ValueMember = "FunctionID";
            CB_Function.SelectedValue = 0;
        }

        public void LoadProcess(string FunctionID)
        {
            DataSet dsProcess = new DataSet();
            dsProcess = Repository_DataMapper.LoadProcess(FunctionID);
            DataRow r = dsProcess.Tables[0].NewRow(); r["PMID"] = 0; r["ProcessName"] = "-Select-";
            dsProcess.Tables[0].Rows.InsertAt(r, 0);
            CB_Process.DataSource = dsProcess.Tables[0];
            CB_Process.DisplayMember = "ProcessName";
            CB_Process.ValueMember = "PMID";
            CB_Process.SelectedValue = 0;
        }

        public void LoadRoles(string PMID)
        {
            DataSet dsRoles = new DataSet();
            dsRoles = Repository_DataMapper.LoadRole(PMID);
            DataRow r = dsRoles.Tables[0].NewRow(); r["RMID"] = 0; r["RoleName"] = "-Select-";
            dsRoles.Tables[0].Rows.InsertAt(r, 0);
            CB_Role.DataSource = dsRoles.Tables[0];
            CB_Role.DisplayMember = "RoleName";
            CB_Role.ValueMember = "RMID";
            CB_Role.SelectedValue = 0;
        }

        #endregion

        #region  Event

        private void TB_UserName_Enter(object sender, EventArgs e)
        {
            L_UserName.Visible = true;
            if (TB_UserName.Text == "User Name") { TB_UserName.Text = null; }
        }

        private void TB_UserName_Leave(object sender, EventArgs e)
        {
            L_UserName.Visible = false;
            if (TB_UserName.TextLength == 0) { TB_UserName.Text = "User Name"; }
        }

        private void TB_Password_Leave(object sender, EventArgs e)
        {
            L_Password.Visible = false;
            if (TB_Password.TextLength == 0) { TB_Password.Text = "Password"; TB_Password.PasswordChar = '\0'; }
        }

        private void TB_Password_Enter(object sender, EventArgs e)
        {
            L_Password.Visible = true;
            if (TB_Password.Text == "Password") { TB_Password.Text = null; TB_Password.PasswordChar = '*'; }
        }

        private void RB_Login_MouseDown(object sender, MouseEventArgs e)
        {
            Class_Login.LoginInfo.UserName = TB_UserName.Text;
            Class_Login.LoginInfo.Password = TB_Password.Text;
            Method_Login.LoginValidation();
            if (Class_Common.Execute.E_Method == "LoginSucessfull")
            {
                LoadFunction();
                Timer_Slider.Start();
            }
            else
            {
                TabStop = true; TabStop = false;
            }
        }

        private void Timer_Slider_Tick(object sender, EventArgs e)
        {
            Point SliderPoint = P_Slider.Location;
            Point LoginPoint = P_Login.Location;
            Point SessionPoint = P_Session.Location;
            Point L_Stage1Point = L_Stage1.Location;
            Point L_Stage2Point = L_Stage2.Location;
            Point L_Stage2PointTemp = L_Stage2.Location;

            if (SliderPoint.X <= LoginPoint.X)
            {
                Timer_Slider.Stop();
                TabStop = true; TabStop = false;
            }
            else
            {
                if (SliderPoint.X - 30 <= LoginPoint.X)
                {
                    P_Slider.Location = LoginPoint;
                    this.Refresh();

                    this.L_Stage2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.L_Stage2.ForeColor = System.Drawing.Color.White;
                    L_Stage2Point.X = L_Stage1Point.X;
                    this.L_Stage2.Location = L_Stage2Point;

                    this.L_Stage1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.L_Stage1.ForeColor = System.Drawing.Color.WhiteSmoke;
                    L_Stage1Point.X = L_Stage2PointTemp.X;
                    this.L_Stage1.Location = L_Stage1Point;
                }
                else
                {
                    SliderPoint.X = SliderPoint.X - 30;
                    P_Slider.Location = SliderPoint;
                    this.Refresh();
                }
            }
        }

        private void TB_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Class_Login.LoginInfo.UserName = TB_UserName.Text;
                Class_Login.LoginInfo.Password = TB_Password.Text;
                Method_Login.LoginValidation();
                if (Class_Common.Execute.E_Method == "LoginSucessfull")
                {
                    LoadFunction();
                    Timer_Slider.Start();
                }
                else
                {
                    TabStop = true; TabStop = false;
                }
            }
        }

        private void L_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void L_SClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RB_Select_MouseDown(object sender, MouseEventArgs e)
        {
            Repository_Class.localStorage.Function = CB_Function.Text;
            Repository_Class.localStorage.Process = CB_Process.Text;
            Repository_Class.localStorage.Role = CB_Role.Text;
            Repository_Class.localStorage.FunctionID = CB_Function.SelectedValue.ToString();
            Repository_Class.localStorage.PMID = CB_Process.SelectedValue.ToString();
            Repository_Class.localStorage.RMID = CB_Role.SelectedValue.ToString();
            Method_Login.SessionValidation();
            TabStop = true; TabStop = false;
        }

        private void CB_Process_Enter(object sender, EventArgs e)
        {
            if (CB_Function.SelectedValue.ToString() != "0")
            {
                LoadProcess(CB_Function.SelectedValue.ToString());
            }
            else
            {
                Method_Common.ShowNotification("Error", "Please Select Function");
                TabStop = true; TabStop = false;
            }

        }

        private void CB_Role_Enter(object sender, EventArgs e)
        {
            if (CB_Process.SelectedValue.ToString() != "0")
            {
                LoadRoles(CB_Process.SelectedValue.ToString());
            }
            else
            {
                Method_Common.ShowNotification("Error", "Please Select Process");
                TabStop = true; TabStop = false;
            }
        }

        private void CB_Function_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CB_Function.SelectedValue.ToString() != "0")
            {
                CB_Process.Enabled = true;
            }
            else
            {
                CB_Process.Enabled = false;
            }
        }

        private void CB_Process_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CB_Process.SelectedValue.ToString() != "0")
            {
                CB_Role.Enabled = true;
            }
            else
            {
                CB_Role.Enabled = false;
            }
        }

        #endregion


    }
}
