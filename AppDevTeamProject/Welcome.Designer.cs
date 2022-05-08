
namespace AppDevTeamProject
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.newUserBtn = new System.Windows.Forms.Button();
            this.alreadyMemberBtn = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUserBtn
            // 
            resources.ApplyResources(this.newUserBtn, "newUserBtn");
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // alreadyMemberBtn
            // 
            resources.ApplyResources(this.alreadyMemberBtn, "alreadyMemberBtn");
            this.alreadyMemberBtn.Name = "alreadyMemberBtn";
            this.alreadyMemberBtn.UseVisualStyleBackColor = true;
            this.alreadyMemberBtn.Click += new System.EventHandler(this.alreadyMemberBtn_Click);
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2"),
            resources.GetString("languageComboBox.Items3")});
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // infoBtn
            // 
            resources.ApplyResources(this.infoBtn, "infoBtn");
            this.infoBtn.BackColor = System.Drawing.Color.Transparent;
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.UseVisualStyleBackColor = false;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // Welcome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.alreadyMemberBtn);
            this.Controls.Add(this.newUserBtn);
            this.Name = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.Button alreadyMemberBtn;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button infoBtn;
    }
}

