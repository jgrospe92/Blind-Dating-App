
namespace AppDevTeamProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextbox = new System.Windows.Forms.TextBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alertInvalidAccountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // loginUsernameTextBox
            // 
            resources.ApplyResources(this.loginUsernameTextBox, "loginUsernameTextBox");
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            // 
            // loginPasswordTextbox
            // 
            resources.ApplyResources(this.loginPasswordTextbox, "loginPasswordTextbox");
            this.loginPasswordTextbox.Name = "loginPasswordTextbox";
            this.loginPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // logInBtn
            // 
            resources.ApplyResources(this.logInBtn, "logInBtn");
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // alertInvalidAccountLabel
            // 
            resources.ApplyResources(this.alertInvalidAccountLabel, "alertInvalidAccountLabel");
            this.alertInvalidAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.alertInvalidAccountLabel.ForeColor = System.Drawing.Color.Red;
            this.alertInvalidAccountLabel.Name = "alertInvalidAccountLabel";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alertInvalidAccountLabel);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.loginPasswordTextbox);
            this.Controls.Add(this.loginUsernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextbox;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label alertInvalidAccountLabel;
    }
}