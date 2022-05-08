
namespace AppDevTeamProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications));
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.notificationsViewBtn = new System.Windows.Forms.Button();
            this.notificationsCancelBtn = new System.Windows.Forms.Button();
            this.notifMatchCounLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notificationsLabel
            // 
            resources.ApplyResources(this.notificationsLabel, "notificationsLabel");
            this.notificationsLabel.Name = "notificationsLabel";
            // 
            // notificationsViewBtn
            // 
            resources.ApplyResources(this.notificationsViewBtn, "notificationsViewBtn");
            this.notificationsViewBtn.Name = "notificationsViewBtn";
            this.notificationsViewBtn.UseVisualStyleBackColor = true;
            this.notificationsViewBtn.Click += new System.EventHandler(this.notificationsViewBtn_Click);
            // 
            // notificationsCancelBtn
            // 
            resources.ApplyResources(this.notificationsCancelBtn, "notificationsCancelBtn");
            this.notificationsCancelBtn.Name = "notificationsCancelBtn";
            this.notificationsCancelBtn.UseVisualStyleBackColor = true;
            this.notificationsCancelBtn.Click += new System.EventHandler(this.notificationsCancelBtn_Click);
            // 
            // notifMatchCounLabel
            // 
            resources.ApplyResources(this.notifMatchCounLabel, "notifMatchCounLabel");
            this.notifMatchCounLabel.Name = "notifMatchCounLabel";
            // 
            // Notifications
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notificationsCancelBtn);
            this.Controls.Add(this.notificationsViewBtn);
            this.Controls.Add(this.notifMatchCounLabel);
            this.Controls.Add(this.notificationsLabel);
            this.Name = "Notifications";
            this.Load += new System.EventHandler(this.Notifications_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.Button notificationsViewBtn;
        private System.Windows.Forms.Button notificationsCancelBtn;
        private System.Windows.Forms.Label notifMatchCounLabel;
    }
}