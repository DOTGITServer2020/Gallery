namespace Windows_Presentation_Layer.User_Interface.Sub_User_Interface
{
    partial class Notifications
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
            this.components = new System.ComponentModel.Container();
            this.labelBody = new System.Windows.Forms.Label();
            this.lifeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelBody
            // 
            this.labelBody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBody.BackColor = System.Drawing.Color.Transparent;
            this.labelBody.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBody.ForeColor = System.Drawing.Color.Gray;
            this.labelBody.Location = new System.Drawing.Point(19, 36);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(282, 46);
            this.labelBody.TabIndex = 2;
            this.labelBody.Text = "Message Body";
            this.labelBody.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lifeTimer
            // 
            this.lifeTimer.Tick += new System.EventHandler(this.lifeTimer_Tick);
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Windows_Presentation_Layer.Properties.Resources.Success;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 80);
            this.ControlBox = false;
            this.Controls.Add(this.labelBody);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notifications";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Notification_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notification_FormClosed);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.Shown += new System.EventHandler(this.Notification_Shown);
            this.Click += new System.EventHandler(this.Notification_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Timer lifeTimer;
    }
}