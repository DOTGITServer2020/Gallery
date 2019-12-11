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
using Windows_Presentation_Layer.User_Interface.Main_User_Interface;

namespace Windows_Presentation_Layer.User_Interface.Sub_User_Interface
{
    public partial class Login : MaterialForm
    {
        public Login()
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
            B_Selector.AutoSize = false;
            this.MaximizedBounds = Screen.GetWorkingArea(this);
        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            SessionSelected();
        }

        public void SessionSelected()
        {
            Home frm = new Home(this);
            frm.Show();
        }
    }
}
