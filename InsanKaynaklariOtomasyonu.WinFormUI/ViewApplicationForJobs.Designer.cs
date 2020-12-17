namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class ViewApplicationForJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewApplicationForJobs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewUsersProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToUserForThisJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbjobs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlistall = new System.Windows.Forms.Button();
            this.sortrequi = new System.Windows.Forms.Button();
            this.sortskill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblexperince = new System.Windows.Forms.Label();
            this.lblkey = new System.Windows.Forms.Label();
            this.lbllis = new System.Windows.Forms.Label();
            this.sortperso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(808, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUsersProfileToolStripMenuItem,
            this.sendMessageToUserForThisJobToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(258, 70);
            // 
            // viewUsersProfileToolStripMenuItem
            // 
            this.viewUsersProfileToolStripMenuItem.Name = "viewUsersProfileToolStripMenuItem";
            this.viewUsersProfileToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.viewUsersProfileToolStripMenuItem.Text = "View User\'s Profile";
            this.viewUsersProfileToolStripMenuItem.Click += new System.EventHandler(this.viewUsersProfileToolStripMenuItem_Click);
            // 
            // sendMessageToUserForThisJobToolStripMenuItem
            // 
            this.sendMessageToUserForThisJobToolStripMenuItem.Name = "sendMessageToUserForThisJobToolStripMenuItem";
            this.sendMessageToUserForThisJobToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.sendMessageToUserForThisJobToolStripMenuItem.Text = "Send Message To User For This Job";
            this.sendMessageToUserForThisJobToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToUserForThisJobToolStripMenuItem_Click);
            // 
            // cmbjobs
            // 
            this.cmbjobs.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbjobs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbjobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbjobs.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbjobs.FormattingEnabled = true;
            this.cmbjobs.Location = new System.Drawing.Point(188, 26);
            this.cmbjobs.Name = "cmbjobs";
            this.cmbjobs.Size = new System.Drawing.Size(121, 24);
            this.cmbjobs.TabIndex = 1;
            this.cmbjobs.SelectedIndexChanged += new System.EventHandler(this.cmbjobs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter Jobs By JobID : ";
            // 
            // btnlistall
            // 
            this.btnlistall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistall.Location = new System.Drawing.Point(57, 68);
            this.btnlistall.Name = "btnlistall";
            this.btnlistall.Size = new System.Drawing.Size(124, 45);
            this.btnlistall.TabIndex = 3;
            this.btnlistall.Text = "List All Application";
            this.btnlistall.UseVisualStyleBackColor = true;
            this.btnlistall.Click += new System.EventHandler(this.btnlistall_Click);
            // 
            // sortrequi
            // 
            this.sortrequi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sortrequi.Location = new System.Drawing.Point(636, 56);
            this.sortrequi.Name = "sortrequi";
            this.sortrequi.Size = new System.Drawing.Size(134, 41);
            this.sortrequi.TabIndex = 4;
            this.sortrequi.Text = "Sort By Requirement Point";
            this.sortrequi.UseVisualStyleBackColor = true;
            this.sortrequi.Click += new System.EventHandler(this.sortrequi_Click);
            // 
            // sortskill
            // 
            this.sortskill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sortskill.Location = new System.Drawing.Point(636, 103);
            this.sortskill.Name = "sortskill";
            this.sortskill.Size = new System.Drawing.Size(134, 42);
            this.sortskill.TabIndex = 5;
            this.sortskill.Text = "Sort By Skill Point";
            this.sortskill.UseVisualStyleBackColor = true;
            this.sortskill.Click += new System.EventHandler(this.sortskill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(357, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(319, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Experince : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(332, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "KeySkill : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(343, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lisans : ";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltitle.Location = new System.Drawing.Point(424, 20);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(0, 16);
            this.lbltitle.TabIndex = 10;
            // 
            // lblexperince
            // 
            this.lblexperince.AutoSize = true;
            this.lblexperince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblexperince.Location = new System.Drawing.Point(424, 53);
            this.lblexperince.Name = "lblexperince";
            this.lblexperince.Size = new System.Drawing.Size(0, 16);
            this.lblexperince.TabIndex = 11;
            // 
            // lblkey
            // 
            this.lblkey.AutoSize = true;
            this.lblkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkey.Location = new System.Drawing.Point(424, 76);
            this.lblkey.Name = "lblkey";
            this.lblkey.Size = new System.Drawing.Size(0, 16);
            this.lblkey.TabIndex = 12;
            // 
            // lbllis
            // 
            this.lbllis.AutoSize = true;
            this.lbllis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbllis.Location = new System.Drawing.Point(424, 101);
            this.lbllis.Name = "lbllis";
            this.lbllis.Size = new System.Drawing.Size(0, 16);
            this.lbllis.TabIndex = 13;
            // 
            // sortperso
            // 
            this.sortperso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sortperso.Location = new System.Drawing.Point(636, 6);
            this.sortperso.Name = "sortperso";
            this.sortperso.Size = new System.Drawing.Size(134, 44);
            this.sortperso.TabIndex = 14;
            this.sortperso.Text = "Sort By Personality Point";
            this.sortperso.UseVisualStyleBackColor = true;
            this.sortperso.Click += new System.EventHandler(this.sortperso_Click);
            // 
            // ViewApplicationForJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 498);
            this.Controls.Add(this.sortperso);
            this.Controls.Add(this.lbllis);
            this.Controls.Add(this.lblkey);
            this.Controls.Add(this.lblexperince);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sortskill);
            this.Controls.Add(this.sortrequi);
            this.Controls.Add(this.btnlistall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbjobs);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewApplicationForJobs";
            this.Text = "ViewApplicationForJobs";
            this.Load += new System.EventHandler(this.ViewApplicationForJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbjobs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlistall;
        private System.Windows.Forms.Button sortrequi;
        private System.Windows.Forms.Button sortskill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblexperince;
        private System.Windows.Forms.Label lblkey;
        private System.Windows.Forms.Label lbllis;
        private System.Windows.Forms.Button sortperso;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewUsersProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToUserForThisJobToolStripMenuItem;
    }
}