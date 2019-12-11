namespace Windows_Presentation_Layer.User_Interface.Sub_User_Interface
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.P_ScreenConrol = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.TwoStageLogin = new Windows_Presentation_Layer.User_Interface.User_Controls.Authentication.TwoStageLogin();
            this.P_ScreenConrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_ScreenConrol
            // 
            this.P_ScreenConrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_ScreenConrol.BackColor = System.Drawing.Color.White;
            this.P_ScreenConrol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_ScreenConrol.Controls.Add(this.TwoStageLogin);
            this.P_ScreenConrol.Location = new System.Drawing.Point(91, 85);
            this.P_ScreenConrol.Name = "P_ScreenConrol";
            this.P_ScreenConrol.Size = new System.Drawing.Size(1186, 575);
            this.P_ScreenConrol.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.panel10.Location = new System.Drawing.Point(92, 86);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1186, 575);
            this.panel10.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.panel11.Location = new System.Drawing.Point(93, 87);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1186, 575);
            this.panel11.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.BackColor = System.Drawing.Color.LightGray;
            this.panel12.Location = new System.Drawing.Point(94, 88);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1186, 575);
            this.panel12.TabIndex = 7;
            // 
            // TwoStageLogin
            // 
            this.TwoStageLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TwoStageLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TwoStageLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoStageLogin.Location = new System.Drawing.Point(0, 0);
            this.TwoStageLogin.Name = "TwoStageLogin";
            this.TwoStageLogin.Size = new System.Drawing.Size(1184, 573);
            this.TwoStageLogin.TabIndex = 0;
            this.TwoStageLogin.TabStopChanged += new System.EventHandler(this.TwoStageLogin_TabStopChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Header;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.P_ScreenConrol);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.P_ScreenConrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_ScreenConrol;
        private User_Controls.Authentication.TwoStageLogin TwoStageLogin;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
    }
}