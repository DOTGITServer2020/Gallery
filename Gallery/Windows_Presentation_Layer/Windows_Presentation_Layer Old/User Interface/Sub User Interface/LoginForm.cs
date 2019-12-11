using Business_Logic_Layer.Module.Class;
using Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Presentation_Layer.User_Interface.Main_User_Interface;

namespace Windows_Presentation_Layer.User_Interface.Sub_User_Interface
{
    public partial class LoginForm : Form
    {
        #region  Method

        public LoginForm()
        {
            InitializeComponent();
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

        public void SessionSelected()
        {
            Theme frm = new Theme(this);
            frm.Show();
        }

        #endregion

        #region  Tab Stop Changed Event

        private void TwoStageLogin_TabStopChanged(object sender, EventArgs e)
        {
            if (TwoStageLogin.TabStop == true)
            {
                if (Class_Common.Execute.E_Method == "MessageBox") { ShowNotification(); }
                else if (Class_Common.Execute.E_Method == "SessionSelected") { SessionSelected(); }
            }
        }

        #endregion
    }
}
