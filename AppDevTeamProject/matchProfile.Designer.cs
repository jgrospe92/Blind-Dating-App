
namespace AppDevTeamProject
{
    partial class matchProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(matchProfile));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.matchedPictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mpReportBtn = new System.Windows.Forms.Button();
            this.matchedAcceptBtn = new System.Windows.Forms.Button();
            this.matchedDeclineBtn = new System.Windows.Forms.Button();
            this.matchedProfSendBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matchedLocationTextBox = new System.Windows.Forms.TextBox();
            this.matchedGenderTextBox = new System.Windows.Forms.TextBox();
            this.matchedAgeTextBox = new System.Windows.Forms.TextBox();
            this.matchedLastNameTextBox = new System.Windows.Forms.TextBox();
            this.locationlbl = new System.Windows.Forms.Label();
            this.matchedFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.genderlbl = new System.Windows.Forms.Label();
            this.matchedTraitsTextBox = new System.Windows.Forms.TextBox();
            this.matchedLikesTextBox = new System.Windows.Forms.TextBox();
            this.agelbl = new System.Windows.Forms.Label();
            this.traitslbl = new System.Windows.Forms.Label();
            this.likeslbl = new System.Windows.Forms.Label();
            this.lNamelbl = new System.Windows.Forms.Label();
            this.fNamelbl = new System.Windows.Forms.Label();
            this.bioTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchedPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.matchedPictureBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // matchedPictureBox
            // 
            resources.ApplyResources(this.matchedPictureBox, "matchedPictureBox");
            this.matchedPictureBox.Name = "matchedPictureBox";
            this.matchedPictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            resources.ApplyResources(this.contextMenuStrip2, "contextMenuStrip2");
            // 
            // mpReportBtn
            // 
            resources.ApplyResources(this.mpReportBtn, "mpReportBtn");
            this.mpReportBtn.Name = "mpReportBtn";
            this.mpReportBtn.UseVisualStyleBackColor = true;
            this.mpReportBtn.Click += new System.EventHandler(this.mpReportBtn_Click);
            // 
            // matchedAcceptBtn
            // 
            resources.ApplyResources(this.matchedAcceptBtn, "matchedAcceptBtn");
            this.matchedAcceptBtn.Name = "matchedAcceptBtn";
            this.matchedAcceptBtn.UseVisualStyleBackColor = true;
            this.matchedAcceptBtn.Click += new System.EventHandler(this.thumbsDownBtn_Click);
            // 
            // matchedDeclineBtn
            // 
            resources.ApplyResources(this.matchedDeclineBtn, "matchedDeclineBtn");
            this.matchedDeclineBtn.Name = "matchedDeclineBtn";
            this.matchedDeclineBtn.UseVisualStyleBackColor = true;
            this.matchedDeclineBtn.Click += new System.EventHandler(this.thumbsUpBtn_Click);
            // 
            // matchedProfSendBtn
            // 
            resources.ApplyResources(this.matchedProfSendBtn, "matchedProfSendBtn");
            this.matchedProfSendBtn.Name = "matchedProfSendBtn";
            this.matchedProfSendBtn.UseVisualStyleBackColor = true;
            this.matchedProfSendBtn.Click += new System.EventHandler(this.matchedProfSendBtnNow);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.matchedLocationTextBox);
            this.groupBox1.Controls.Add(this.matchedGenderTextBox);
            this.groupBox1.Controls.Add(this.matchedAgeTextBox);
            this.groupBox1.Controls.Add(this.matchedLastNameTextBox);
            this.groupBox1.Controls.Add(this.locationlbl);
            this.groupBox1.Controls.Add(this.matchedFirstNameTextBox);
            this.groupBox1.Controls.Add(this.genderlbl);
            this.groupBox1.Controls.Add(this.matchedTraitsTextBox);
            this.groupBox1.Controls.Add(this.matchedLikesTextBox);
            this.groupBox1.Controls.Add(this.agelbl);
            this.groupBox1.Controls.Add(this.traitslbl);
            this.groupBox1.Controls.Add(this.likeslbl);
            this.groupBox1.Controls.Add(this.lNamelbl);
            this.groupBox1.Controls.Add(this.fNamelbl);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // matchedLocationTextBox
            // 
            this.matchedLocationTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.matchedLocationTextBox, "matchedLocationTextBox");
            this.matchedLocationTextBox.Name = "matchedLocationTextBox";
            this.matchedLocationTextBox.ReadOnly = true;
            // 
            // matchedGenderTextBox
            // 
            resources.ApplyResources(this.matchedGenderTextBox, "matchedGenderTextBox");
            this.matchedGenderTextBox.Name = "matchedGenderTextBox";
            this.matchedGenderTextBox.ReadOnly = true;
            // 
            // matchedAgeTextBox
            // 
            resources.ApplyResources(this.matchedAgeTextBox, "matchedAgeTextBox");
            this.matchedAgeTextBox.Name = "matchedAgeTextBox";
            this.matchedAgeTextBox.ReadOnly = true;
            // 
            // matchedLastNameTextBox
            // 
            resources.ApplyResources(this.matchedLastNameTextBox, "matchedLastNameTextBox");
            this.matchedLastNameTextBox.Name = "matchedLastNameTextBox";
            this.matchedLastNameTextBox.ReadOnly = true;
            // 
            // locationlbl
            // 
            resources.ApplyResources(this.locationlbl, "locationlbl");
            this.locationlbl.Name = "locationlbl";
            // 
            // matchedFirstNameTextBox
            // 
            resources.ApplyResources(this.matchedFirstNameTextBox, "matchedFirstNameTextBox");
            this.matchedFirstNameTextBox.Name = "matchedFirstNameTextBox";
            this.matchedFirstNameTextBox.ReadOnly = true;
            // 
            // genderlbl
            // 
            resources.ApplyResources(this.genderlbl, "genderlbl");
            this.genderlbl.Name = "genderlbl";
            // 
            // matchedTraitsTextBox
            // 
            resources.ApplyResources(this.matchedTraitsTextBox, "matchedTraitsTextBox");
            this.matchedTraitsTextBox.Name = "matchedTraitsTextBox";
            this.matchedTraitsTextBox.ReadOnly = true;
            // 
            // matchedLikesTextBox
            // 
            resources.ApplyResources(this.matchedLikesTextBox, "matchedLikesTextBox");
            this.matchedLikesTextBox.Name = "matchedLikesTextBox";
            this.matchedLikesTextBox.ReadOnly = true;
            // 
            // agelbl
            // 
            resources.ApplyResources(this.agelbl, "agelbl");
            this.agelbl.Name = "agelbl";
            // 
            // traitslbl
            // 
            resources.ApplyResources(this.traitslbl, "traitslbl");
            this.traitslbl.Name = "traitslbl";
            // 
            // likeslbl
            // 
            resources.ApplyResources(this.likeslbl, "likeslbl");
            this.likeslbl.Name = "likeslbl";
            // 
            // lNamelbl
            // 
            resources.ApplyResources(this.lNamelbl, "lNamelbl");
            this.lNamelbl.Name = "lNamelbl";
            // 
            // fNamelbl
            // 
            resources.ApplyResources(this.fNamelbl, "fNamelbl");
            this.fNamelbl.Name = "fNamelbl";
            // 
            // bioTextBox
            // 
            this.bioTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.bioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.bioTextBox, "bioTextBox");
            this.bioTextBox.Name = "bioTextBox";
            // 
            // matchProfile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bioTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matchedProfSendBtn);
            this.Controls.Add(this.matchedDeclineBtn);
            this.Controls.Add(this.matchedAcceptBtn);
            this.Controls.Add(this.mpReportBtn);
            this.Controls.Add(this.groupBox2);
            this.Name = "matchProfile";
            this.Load += new System.EventHandler(this.matchProfile_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchedPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button mpReportBtn;
        private System.Windows.Forms.Button matchedAcceptBtn;
        private System.Windows.Forms.Button matchedDeclineBtn;
        private System.Windows.Forms.PictureBox matchedPictureBox;
        private System.Windows.Forms.Button matchedProfSendBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox matchedLocationTextBox;
        private System.Windows.Forms.TextBox matchedGenderTextBox;
        private System.Windows.Forms.TextBox matchedAgeTextBox;
        private System.Windows.Forms.TextBox matchedLastNameTextBox;
        private System.Windows.Forms.Label locationlbl;
        private System.Windows.Forms.TextBox matchedFirstNameTextBox;
        private System.Windows.Forms.Label genderlbl;
        private System.Windows.Forms.TextBox matchedTraitsTextBox;
        private System.Windows.Forms.TextBox matchedLikesTextBox;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.Label traitslbl;
        private System.Windows.Forms.Label likeslbl;
        private System.Windows.Forms.Label lNamelbl;
        private System.Windows.Forms.Label fNamelbl;
        private System.Windows.Forms.TextBox bioTextBox;
    }
}