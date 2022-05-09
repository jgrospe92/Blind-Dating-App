
namespace AppDevTeamProject
{
    partial class FilteredSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilteredSearch));
            this.matchPrevBtn = new System.Windows.Forms.Button();
            this.matchNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matchNextBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filteredTag = new System.Windows.Forms.Label();
            this.matchProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // matchPrevBtn
            // 
            resources.ApplyResources(this.matchPrevBtn, "matchPrevBtn");
            this.matchPrevBtn.Name = "matchPrevBtn";
            this.matchPrevBtn.UseVisualStyleBackColor = true;
            this.matchPrevBtn.Click += new System.EventHandler(this.matchPrevBtn_Click);
            // 
            // matchNameLabel
            // 
            resources.ApplyResources(this.matchNameLabel, "matchNameLabel");
            this.matchNameLabel.AutoEllipsis = true;
            this.matchNameLabel.Name = "matchNameLabel";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.matchNameLabel);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // matchNextBtn
            // 
            resources.ApplyResources(this.matchNextBtn, "matchNextBtn");
            this.matchNextBtn.Name = "matchNextBtn";
            this.matchNextBtn.UseVisualStyleBackColor = true;
            this.matchNextBtn.Click += new System.EventHandler(this.matchNextBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // filteredTag
            // 
            resources.ApplyResources(this.filteredTag, "filteredTag");
            this.filteredTag.Name = "filteredTag";
            // 
            // matchProfilePictureBox
            // 
            resources.ApplyResources(this.matchProfilePictureBox, "matchProfilePictureBox");
            this.matchProfilePictureBox.Name = "matchProfilePictureBox";
            this.matchProfilePictureBox.TabStop = false;
            // 
            // FilteredSearch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filteredTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matchPrevBtn);
            this.Controls.Add(this.matchProfilePictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matchNextBtn);
            this.Name = "FilteredSearch";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button matchPrevBtn;
        private System.Windows.Forms.PictureBox matchProfilePictureBox;
        private System.Windows.Forms.Label matchNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button matchNextBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label filteredTag;
    }
}