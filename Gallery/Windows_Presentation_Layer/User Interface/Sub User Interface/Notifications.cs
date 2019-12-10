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

namespace Windows_Presentation_Layer.User_Interface.Sub_User_Interface
{
    public partial class Notifications : Form
    {
        private static readonly List<Notifications> OpenNotifications = new List<Notifications>();
        private bool _allowFocus;
        private readonly FormAnimator _animator;
        private IntPtr _currentForegroundWindow;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MessageType"></param>
        /// <param name="body"></param>
        /// <param name="duration"></param>
        /// <param name="animation"></param>
        /// <param name="direction"></param>
        /// 

        public Notifications(string MessageType, string body, int duration, FormAnimator.AnimationMethod animation, FormAnimator.AnimationDirection direction)
        {
            InitializeComponent();

            if (duration < 0)
                duration = int.MaxValue;
            else
                duration = duration * 1000;

            lifeTimer.Interval = duration;

            if (MessageType == "Success")
            {
                this.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Success;
            }
            else if (MessageType == "Error")
            {
                this.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Error;
            }
            else if (MessageType == "Warning")
            {
                this.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Warning;
            }
            else if (MessageType == "Info")
            {
                this.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Info;
            }


            labelBody.Text = body;

            _animator = new FormAnimator(this, animation, direction, 500);

            Region = Region.FromHrgn(NativeMethods.CreateRoundRectRgn(0, 0, Width - 5, Height - 5, 20, 20));
        }

        #region Methods


        //Triger Program
        //private void ShowNotification()
        //{
        //    int duration = 3;

        //    var animationMethod = FormAnimator.AnimationMethod.Slide;
        //    foreach (FormAnimator.AnimationMethod method in Enum.GetValues(typeof(FormAnimator.AnimationMethod)))
        //    {
        //        if (string.Equals(method.ToString(), "Slide")) //(Roll,Center,Slide,Fade)
        //        {
        //            animationMethod = method;
        //            break;
        //        }
        //    }

        //    var animationDirection = FormAnimator.AnimationDirection.Up;
        //    foreach (FormAnimator.AnimationDirection direction in Enum.GetValues(typeof(FormAnimator.AnimationDirection)))
        //    {
        //        if (string.Equals(direction.ToString(), "Up")) //(Up,Down,Right,Left)
        //        {
        //            animationDirection = direction;
        //            break;
        //        }
        //    }

        //    var toastNotification = new Notification("Success", "Uploaded SucessFully", duration, animationMethod, animationDirection);
        //    toastNotification.Show();
        //}

        /// <summary>
        /// Displays the form
        /// </summary>
        /// <remarks>
        /// Required to allow the form to determine the current foreground window before being displayed
        /// </remarks>
        public new void Show()
        {
            // Determine the current foreground window so it can be reactivated each time this form tries to get the focus
            _currentForegroundWindow = NativeMethods.GetForegroundWindow();

            base.Show();
        }

        #endregion // Methods

        #region Event Handlers

        private void Notification_Load(object sender, EventArgs e)
        {
            // Display the form just above the system tray.
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width,
                                      Screen.PrimaryScreen.WorkingArea.Height - Height);

            // Move each open form upwards to make room for this one
            foreach (Notifications openForm in OpenNotifications)
            {
                openForm.Top -= Height;
            }

            OpenNotifications.Add(this);
            lifeTimer.Start();
        }

        private void Notification_Activated(object sender, EventArgs e)
        {
            // Prevent the form taking focus when it is initially shown
            if (!_allowFocus)
            {
                // Activate the window that previously had focus
                NativeMethods.SetForegroundWindow(_currentForegroundWindow);
            }
        }

        private void Notification_Shown(object sender, EventArgs e)
        {
            // Once the animation has completed the form can receive focus
            _allowFocus = true;

            // Close the form by sliding down.
            _animator.Duration = 500;
            _animator.Direction = FormAnimator.AnimationDirection.Down;
        }

        private void Notification_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Move down any open forms above this one
            foreach (Notifications openForm in OpenNotifications)
            {
                if (openForm == this)
                {
                    // Remaining forms are below this one
                    break;
                }
                openForm.Top += Height;
            }

            OpenNotifications.Remove(this);
        }

        private void lifeTimer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelRO_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion // Event Handlers
               
    }
}
