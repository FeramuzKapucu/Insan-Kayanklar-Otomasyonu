namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class ViewApplicableJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewApplicableJobs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.rchdesig = new System.Windows.Forms.RichTextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtkeys = new System.Windows.Forms.TextBox();
            this.txtlis = new System.Windows.Forms.TextBox();
            this.txtexp = new System.Windows.Forms.TextBox();
            this.txtplace = new System.Windows.Forms.TextBox();
            this.btnapply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(786, 242);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Designation : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salary : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(456, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Experience : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(494, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Place : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(489, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lisans : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(480, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Keyskill : ";
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttitle.ForeColor = System.Drawing.SystemColors.Window;
            this.txttitle.Location = new System.Drawing.Point(112, 19);
            this.txttitle.Name = "txttitle";
            this.txttitle.ReadOnly = true;
            this.txttitle.Size = new System.Drawing.Size(121, 22);
            this.txttitle.TabIndex = 8;
            // 
            // rchdesig
            // 
            this.rchdesig.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchdesig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchdesig.ForeColor = System.Drawing.SystemColors.Window;
            this.rchdesig.Location = new System.Drawing.Point(112, 52);
            this.rchdesig.Name = "rchdesig";
            this.rchdesig.ReadOnly = true;
            this.rchdesig.Size = new System.Drawing.Size(299, 96);
            this.rchdesig.TabIndex = 9;
            this.rchdesig.Text = "";
            // 
            // txtsalary
            // 
            this.txtsalary.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsalary.ForeColor = System.Drawing.SystemColors.Window;
            this.txtsalary.Location = new System.Drawing.Point(112, 157);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.ReadOnly = true;
            this.txtsalary.Size = new System.Drawing.Size(121, 22);
            this.txtsalary.TabIndex = 10;
            // 
            // txtkeys
            // 
            this.txtkeys.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtkeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkeys.ForeColor = System.Drawing.SystemColors.Window;
            this.txtkeys.Location = new System.Drawing.Point(584, 117);
            this.txtkeys.Name = "txtkeys";
            this.txtkeys.ReadOnly = true;
            this.txtkeys.Size = new System.Drawing.Size(121, 22);
            this.txtkeys.TabIndex = 11;
            // 
            // txtlis
            // 
            this.txtlis.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtlis.ForeColor = System.Drawing.SystemColors.Window;
            this.txtlis.Location = new System.Drawing.Point(584, 86);
            this.txtlis.Name = "txtlis";
            this.txtlis.ReadOnly = true;
            this.txtlis.Size = new System.Drawing.Size(121, 22);
            this.txtlis.TabIndex = 12;
            // 
            // txtexp
            // 
            this.txtexp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtexp.ForeColor = System.Drawing.SystemColors.Window;
            this.txtexp.Location = new System.Drawing.Point(584, 51);
            this.txtexp.Name = "txtexp";
            this.txtexp.ReadOnly = true;
            this.txtexp.Size = new System.Drawing.Size(121, 22);
            this.txtexp.TabIndex = 13;
            // 
            // txtplace
            // 
            this.txtplace.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtplace.ForeColor = System.Drawing.SystemColors.Window;
            this.txtplace.Location = new System.Drawing.Point(584, 18);
            this.txtplace.Name = "txtplace";
            this.txtplace.ReadOnly = true;
            this.txtplace.Size = new System.Drawing.Size(121, 22);
            this.txtplace.TabIndex = 14;
            // 
            // btnapply
            // 
            this.btnapply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnapply.Location = new System.Drawing.Point(595, 146);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(143, 54);
            this.btnapply.TabIndex = 15;
            this.btnapply.Text = "Apply For This Job";
            this.btnapply.UseVisualStyleBackColor = true;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // ViewApplicableJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnapply);
            this.Controls.Add(this.txtplace);
            this.Controls.Add(this.txtexp);
            this.Controls.Add(this.txtlis);
            this.Controls.Add(this.txtkeys);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.rchdesig);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "ViewApplicableJobs";
            this.Text = "ViewApplicableJobs";
            this.Load += new System.EventHandler(this.ViewApplicableJobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.RichTextBox rchdesig;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtkeys;
        private System.Windows.Forms.TextBox txtlis;
        private System.Windows.Forms.TextBox txtexp;
        private System.Windows.Forms.TextBox txtplace;
        private System.Windows.Forms.Button btnapply;
    }
}