
namespace AppDevTeamProject
{
    partial class listOfMatched
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listOfMatched));
            this.label1 = new System.Windows.Forms.Label();
            this.matchNameLabel = new System.Windows.Forms.Label();
            this.matchPrevBtn = new System.Windows.Forms.Button();
            this.matchVisitBtn = new System.Windows.Forms.Button();
            this.matchNextBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matchProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // matchNameLabel
            // 
            resources.ApplyResources(this.matchNameLabel, "matchNameLabel");
            this.matchNameLabel.AutoEllipsis = true;
            this.matchNameLabel.Name = "matchNameLabel";
            // 
            // matchPrevBtn
            // 
            resources.ApplyResources(this.matchPrevBtn, "matchPrevBtn");
            this.matchPrevBtn.Name = "matchPrevBtn";
            this.matchPrevBtn.UseVisualStyleBackColor = true;
            this.matchPrevBtn.Click += new System.EventHandler(this.matchPrevBtn_Click);
            // 
            // matchVisitBtn
            // 
            resources.ApplyResources(this.matchVisitBtn, "matchVisitBtn");
            this.matchVisitBtn.Name = "matchVisitBtn";
            this.matchVisitBtn.UseVisualStyleBackColor = true;
            this.matchVisitBtn.Click += new System.EventHandler(this.matchVisitBtn_Click);
            // 
            // matchNextBtn
            // 
            resources.ApplyResources(this.matchNextBtn, "matchNextBtn");
            this.matchNextBtn.Name = "matchNextBtn";
            this.matchNextBtn.UseVisualStyleBackColor = true;
            this.matchNextBtn.Click += new System.EventHandler(this.matchNextBtn_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.matchNameLabel);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // matchProfilePictureBox
            // 
            resources.ApplyResources(this.matchProfilePictureBox, "matchProfilePictureBox");
            this.matchProfilePictureBox.Name = "matchProfilePictureBox";
            this.matchProfilePictureBox.TabStop = false;
            // 
            // listOfMatched
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matchNextBtn);
            this.Controls.Add(this.matchVisitBtn);
            this.Controls.Add(this.matchPrevBtn);
            this.Controls.Add(this.matchProfilePictureBox);
            this.Controls.Add(this.label1);
            this.Name = "listOfMatched";
            this.Load += new System.EventHandler(this.ListOfMatched_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox matchProfilePictureBox;
        private System.Windows.Forms.Label matchNameLabel;
        private System.Windows.Forms.Button matchPrevBtn;
        private System.Windows.Forms.Button matchVisitBtn;
        private System.Windows.Forms.Button matchNextBtn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}