using Business_Logic_Layer.Module.Class;
using Business_Logic_Layer.Module.Method;
using Data_Access_Layer.Repository;
using Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Presentation_Layer.User_Interface.Main_User_Interface
{
    public partial class Theme : Form
    {
        #region  Business Logic and Data Access Layer Referance

        Repository_DataMapper Repository_DataMapper = new Repository_DataMapper();

        #endregion

        #region  Method

        [DllImport("User32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int w, int h, bool Repaint);

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            base.SetBoundsCore(x, y, width, height, specified);
            MoveWindow(Handle, x, y, width, height, true);
        }

        Form opener;

        public Theme(Sub_User_Interface.LoginForm loginForm)
        {
            InitializeComponent();
            opener = loginForm;
            loginForm.Hide();
            P_MidLeft.Width = 15;
            Point P_RightPoint = P_Right.Location;
            P_Right.Width = 0;
            P_RightPoint.X = P_RightPoint.X + 200;

            {// Load Login Information From Local Storage
                L_UserName.Text = Class_Login.LoginInfo.UserName;
                L_Role.Text = Repository_Class.localStorage.Role;
                L_Process.Text = Repository_Class.localStorage.Process;
                L_Function.Text = Repository_Class.localStorage.Function;
            }

            {// Load Dashboard Menu
                DataSet dsSubMenu = new DataSet();
                dsSubMenu = Repository_DataMapper.GetSubMenu(L_Selected.Text);
                DGV_SubMenu.DataSource = dsSubMenu.Tables[0];
                DGV_SubMenu.Columns[1].Visible = false;
            }
        }

        private void ShowNotification()
        {
            int duration = 3;

            var animationMethod = FormAnimator.AnimationMethod.Slide;
            foreach (FormAnimator.AnimationMethod method in Enum.GetValues(typeof(FormAnimator.AnimationMethod)))
            {
                if (string.Equals(method.ToString(), "Slide")) //(Roll,Center,Slide,Fade)
                {
                    animationMethod = method;
                    break;
                }
            }

            var animationDirection = FormAnimator.AnimationDirection.Up;
            foreach (FormAnimator.AnimationDirection direction in Enum.GetValues(typeof(FormAnimator.AnimationDirection)))
            {
                if (string.Equals(direction.ToString(), "Up")) //(Up,Down,Right,Left)
                {
                    animationDirection = direction;
                    break;
                }
            }

            var toastNotification = new Windows_Presentation_Layer.User_Interface.Sub_User_Interface.Notifications(Class_Common.MessageBox.Title, Class_Common.MessageBox.Description, duration, animationMethod, animationDirection);
            toastNotification.Show();
        }

        #endregion

        #region  Event

        private void B_HideMidLeftPanel_Click(object sender, EventArgs e)
        {
            DGV_SubMenu.Visible = false;
            L_Function.Visible = false;
            L_Process.Visible = false;
            P_MidLeft.Width = 15;
            B_HideMidLeftPanel.Visible = false;
            B_ShowMidLeftPanel.Visible = true;
        }

        private void B_ShowMidLeftPanel_Click(object sender, EventArgs e)
        {
            P_MidLeft.Width = 150;
            L_Function.Visible = true;
            L_Process.Visible = true;
            DGV_SubMenu.Visible = true;
            B_ShowMidLeftPanel.Visible = false;
            B_HideMidLeftPanel.Visible = true;
        }

        private void B_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void B_Search_Click(object sender, EventArgs e)
        {
            if (P_Search.Visible == true)
            {
                P_Search.Visible = false;
            }
            else
            {
                P_Search.Visible = true;
            }
        }

        private void B_Message_Click(object sender, EventArgs e)
        {
            Point P_RightPoint = P_Right.Location;

            if (P_Right.Width == 0)
            {
                P_Right.Width = 200;
                P_RightPoint.X = P_RightPoint.X - 200;
                P_Right.Location = P_RightPoint;
            }
            else
            {
                P_Right.Width = 0;
                P_RightPoint.X = P_RightPoint.X + 200;
                P_Right.Location = P_RightPoint;
            }
        }

        private void B_Logout_MouseHover(object sender, EventArgs e)
        {
            L_Logout.Visible = true;
        }

        private void B_Logout_MouseLeave(object sender, EventArgs e)
        {
            L_Logout.Visible = false;
        }

        private void B_Search_MouseHover(object sender, EventArgs e)
        {
            L_Search.Visible = true;
        }

        private void B_Search_MouseLeave(object sender, EventArgs e)
        {
            L_Search.Visible = false;
        }

        private void B_Message_MouseHover(object sender, EventArgs e)
        {
            L_Notice.Visible = true;
        }

        private void B_Message_MouseLeave(object sender, EventArgs e)
        {
            L_Notice.Visible = false;
        }

        private void B_Client_MouseHover(object sender, EventArgs e)
        {
            L_Home.Visible = true;
        }

        private void B_Client_MouseLeave(object sender, EventArgs e)
        {
            L_Home.Visible = false;
        }

        private void B_Role_MouseHover(object sender, EventArgs e)
        {
            L_SelectRole.Visible = true;
        }

        private void B_Role_MouseLeave(object sender, EventArgs e)
        {
            L_SelectRole.Visible = false;
        }

        private void B_Dashboard_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = P_Selected.Location;
                Selected.Y = Clicked.Y;
                P_Selected.Location = Selected;
                L_Selected.Text = "Dashboard";
            }
            {
                DataSet dsSubMenu = new DataSet();
                dsSubMenu = Repository_DataMapper.GetSubMenu(L_Selected.Text);
                DGV_SubMenu.DataSource = dsSubMenu.Tables[0];
                DGV_SubMenu.Columns[1].Visible = false;
            }

        }

        private void B_Input_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = P_Selected.Location;
                Selected.Y = Clicked.Y;
                P_Selected.Location = Selected;
                L_Selected.Text = "Input";
            }
            {
                DataSet dsSubMenu = new DataSet();
                dsSubMenu = Repository_DataMapper.GetSubMenu(L_Selected.Text);
                DGV_SubMenu.DataSource = dsSubMenu.Tables[0];
                DGV_SubMenu.Columns[1].Visible = false;
            }


        }

        private void B_Analysis_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = P_Selected.Location;
                Selected.Y = Clicked.Y;
                P_Selected.Location = Selected;
                L_Selected.Text = "Analysis";
            }
            {
                DataSet dsSubMenu = new DataSet();
                dsSubMenu = Repository_DataMapper.GetSubMenu(L_Selected.Text);
                DGV_SubMenu.DataSource = dsSubMenu.Tables[0];
                DGV_SubMenu.Columns[1].Visible = false;
            }

        }

        private void B_Process_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = P_Selected.Location;
                Selected.Y = Clicked.Y;
                P_Selected.Location = Selected;
                L_Selected.Text = "Process";
            }
            {
                DataSet dsSubMenu = new DataSet();
                dsSubMenu = Repository_DataMapper.GetSubMenu(L_Selected.Text);
                DGV_SubMenu.DataSource = dsSubMenu.Tables[0];
                DGV_SubMenu.Columns[1].Visible = false;
            }

        }

        private void B_Audit_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = P_Selected.Location;
                Selected.Y = Clicked.Y;
                P_Selected.Location = Selected;
                L_Selected.Text = "Audit";
            }
            {
                DataSet dsSubMenu = new DataSet();
                dsSubMenu = Repository_DataMapper.GetSubMenu(L_Selected.Text);
                DGV_SubMenu.DataSource = dsSubMenu.Tables[0];
                DGV_SubMenu.Columns[1].Visible = false;
            }

        }

        private void B_Output_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = P_Selected.Location;
                Selected.Y = Clicked.Y;
                P_Selected.Location = Selected;
                L_Selected.Text = "Output";
            }
            {
                DataSet dsSubMenu = new DataSet();
                dsSubMenu = Repository_DataMapper.GetSubMenu(L_Selected.Text);
                DGV_SubMenu.DataSource = dsSubMenu.Tables[0];
                DGV_SubMenu.Columns[1].Visible = false;
            }

        }

        private void B_Setting_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = P_Selected.Location;
                Selected.Y = Clicked.Y;
                P_Selected.Location = Selected;
                L_Selected.Text = "Setting";
            }
            {
                DataSet dsSubMenu = new DataSet();
                dsSubMenu = Repository_DataMapper.GetSubMenu(L_Selected.Text);
                DGV_SubMenu.DataSource = dsSubMenu.Tables[0];
                DGV_SubMenu.Columns[1].Visible = false;
            }

        }

        #endregion
    }
}
