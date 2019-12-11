using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Windows_Presentation_Layer.User_Interface.Main_User_Interface
{
    public partial class Home : MaterialForm
    {
        Form opener;

        public Home(Sub_User_Interface.Login login)
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
                );

            opener = login;
            login.Hide();
            L_Selected.Text = "Welcome";
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void B_Dashboard_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = B_Selector.Location;
                Selected.Y = Clicked.Y;
                B_Selector.Location = Selected;
                L_Selected.Text = "Dashboard";
                MS_Dashboard.Show(this.PointToScreen(new Point(76, Clicked.Y + 66)));
            }               
        }

        private void B_Input_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = B_Selector.Location;
                Selected.Y = Clicked.Y;
                B_Selector.Location = Selected;
                L_Selected.Text = "Input";
                MS_Input.Show(this.PointToScreen(new Point(76, Clicked.Y + 66)));
            }


        }

        private void B_Analysis_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = B_Selector.Location;
                Selected.Y = Clicked.Y;
                B_Selector.Location = Selected;
                L_Selected.Text = "Analysis";
                MS_Analysis.Show(this.PointToScreen(new Point(76, Clicked.Y + 66)));
            }

        }

        private void B_Process_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = B_Selector.Location;
                Selected.Y = Clicked.Y;
                B_Selector.Location = Selected;
                L_Selected.Text = "Process";
                MS_Process.Show(this.PointToScreen(new Point(76, Clicked.Y + 66)));
            }

        }

        private void B_Audit_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = B_Selector.Location;
                Selected.Y = Clicked.Y;
                B_Selector.Location = Selected;
                L_Selected.Text = "Audit";
                MS_Audit.Show(this.PointToScreen(new Point(76, Clicked.Y + 66)));
            }

        }

        private void B_Output_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = B_Selector.Location;
                Selected.Y = Clicked.Y;
                B_Selector.Location = Selected;
                L_Selected.Text = "Output";
                MS_Output.Show(this.PointToScreen(new Point(76, Clicked.Y + 66)));
            }

        }

        private void B_Setting_Click(object sender, EventArgs e)
        {
            {
                var Sender = (Button)sender;
                Point Clicked = Sender.Location;
                Point Selected = B_Selector.Location;
                Selected.Y = Clicked.Y;
                B_Selector.Location = Selected;
                L_Selected.Text = "Setting";
                MS_Setting.Show(this.PointToScreen(new Point(76, Clicked.Y + 66)));
            }          

        }
        
        private void B_Message_Click(object sender, EventArgs e)
        {
            
        }

        private void B_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
