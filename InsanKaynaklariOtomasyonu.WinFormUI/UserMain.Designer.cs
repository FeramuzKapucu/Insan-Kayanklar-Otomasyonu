namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class UserMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePersonalInfromationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeApptitudeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicableJobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewApplicableJobsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.myApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeAnExamForASkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInformationToolStripMenuItem,
            this.ApplicableJobsToolStripMenuItem,
            this.takeAnExamForASkillToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateInformationToolStripMenuItem
            // 
            this.updateInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePersonalInfromationToolStripMenuItem,
            this.changeApptitudeInformationToolStripMenuItem});
            this.updateInformationToolStripMenuItem.Name = "updateInformationToolStripMenuItem";
            this.updateInformationToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.updateInformationToolStripMenuItem.Text = "Change User Informations";
            // 
            // changePersonalInfromationToolStripMenuItem
            // 
            this.changePersonalInfromationToolStripMenuItem.Name = "changePersonalInfromationToolStripMenuItem";
            this.changePersonalInfromationToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.changePersonalInfromationToolStripMenuItem.Text = "Change Personal Infromation";
            this.changePersonalInfromationToolStripMenuItem.Click += new System.EventHandler(this.changePersonalInfromationToolStripMenuItem_Click);
            // 
            // changeApptitudeInformationToolStripMenuItem
            // 
            this.changeApptitudeInformationToolStripMenuItem.Name = "changeApptitudeInformationToolStripMenuItem";
            this.changeApptitudeInformationToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.changeApptitudeInformationToolStripMenuItem.Text = "Change Apptitude Information";
            this.changeApptitudeInformationToolStripMenuItem.Click += new System.EventHandler(this.changeApptitudeInformationToolStripMenuItem_Click);
            // 
            // ApplicableJobsToolStripMenuItem
            // 
            this.ApplicableJobsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewApplicableJobsToolStripMenuItem1,
            this.myApplicationToolStripMenuItem,
            this.messagesToolStripMenuItem});
            this.ApplicableJobsToolStripMenuItem.Name = "ApplicableJobsToolStripMenuItem";
            this.ApplicableJobsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.ApplicableJobsToolStripMenuItem.Text = "Applicable Jobs";
            // 
            // viewApplicableJobsToolStripMenuItem1
            // 
            this.viewApplicableJobsToolStripMenuItem1.Name = "viewApplicableJobsToolStripMenuItem1";
            this.viewApplicableJobsToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.viewApplicableJobsToolStripMenuItem1.Text = "View Applicable Jobs";
            this.viewApplicableJobsToolStripMenuItem1.Click += new System.EventHandler(this.viewApplicableJobsToolStripMenuItem1_Click);
            // 
            // myApplicationToolStripMenuItem
            // 
            this.myApplicationToolStripMenuItem.Name = "myApplicationToolStripMenuItem";
            this.myApplicationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.myApplicationToolStripMenuItem.Text = "My Application";
            this.myApplicationToolStripMenuItem.Click += new System.EventHandler(this.myApplicationToolStripMenuItem_Click);
            // 
            // messagesToolStripMenuItem
            // 
            this.messagesToolStripMenuItem.Name = "messagesToolStripMenuItem";
            this.messagesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.messagesToolStripMenuItem.Text = "Messages ";
            this.messagesToolStripMenuItem.Click += new System.EventHandler(this.messagesToolStripMenuItem_Click);
            // 
            // takeAnExamForASkillToolStripMenuItem
            // 
            this.takeAnExamForASkillToolStripMenuItem.Name = "takeAnExamForASkillToolStripMenuItem";
            this.takeAnExamForASkillToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.takeAnExamForASkillToolStripMenuItem.Text = "Take An Exam For A Skill";
            this.takeAnExamForASkillToolStripMenuItem.Click += new System.EventHandler(this.takeAnExamForASkillToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 456);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserMain";
            this.Text = "MemberMain";
            this.Load += new System.EventHandler(this.UserMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeAnExamForASkillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePersonalInfromationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeApptitudeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ApplicableJobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewApplicableJobsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem myApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messagesToolStripMenuItem;
    }
}