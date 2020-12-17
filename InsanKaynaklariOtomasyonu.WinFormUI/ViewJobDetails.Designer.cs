namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class ViewJobDetails
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
            this.btndoapllicable = new System.Windows.Forms.Button();
            this.btnrmvapplicable = new System.Windows.Forms.Button();
            this.btnrmvreq = new System.Windows.Forms.Button();
            this.txtapplic = new System.Windows.Forms.TextBox();
            this.txtreq = new System.Windows.Forms.TextBox();
            this.txtplace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rchdesignation = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndoapllicable
            // 
            this.btndoapllicable.Location = new System.Drawing.Point(711, 9);
            this.btndoapllicable.Name = "btndoapllicable";
            this.btndoapllicable.Size = new System.Drawing.Size(120, 54);
            this.btndoapllicable.TabIndex = 31;
            this.btndoapllicable.Text = "Do The Job Applicable";
            this.btndoapllicable.UseVisualStyleBackColor = true;
            this.btndoapllicable.Click += new System.EventHandler(this.btndoapllicable_Click);
            // 
            // btnrmvapplicable
            // 
            this.btnrmvapplicable.Location = new System.Drawing.Point(711, 74);
            this.btnrmvapplicable.Name = "btnrmvapplicable";
            this.btnrmvapplicable.Size = new System.Drawing.Size(118, 58);
            this.btnrmvapplicable.TabIndex = 30;
            this.btnrmvapplicable.Text = "Remove From Applicable";
            this.btnrmvapplicable.UseVisualStyleBackColor = true;
            this.btnrmvapplicable.Click += new System.EventHandler(this.btnrmvapplicable_Click);
            // 
            // btnrmvreq
            // 
            this.btnrmvreq.Location = new System.Drawing.Point(587, 9);
            this.btnrmvreq.Name = "btnrmvreq";
            this.btnrmvreq.Size = new System.Drawing.Size(118, 54);
            this.btnrmvreq.TabIndex = 29;
            this.btnrmvreq.Text = "Remove Requirement ";
            this.btnrmvreq.UseVisualStyleBackColor = true;
            this.btnrmvreq.Click += new System.EventHandler(this.btnrmvreq_Click);
            // 
            // txtapplic
            // 
            this.txtapplic.Location = new System.Drawing.Point(483, 150);
            this.txtapplic.Name = "txtapplic";
            this.txtapplic.ReadOnly = true;
            this.txtapplic.Size = new System.Drawing.Size(100, 20);
            this.txtapplic.TabIndex = 28;
            // 
            // txtreq
            // 
            this.txtreq.Location = new System.Drawing.Point(483, 116);
            this.txtreq.Name = "txtreq";
            this.txtreq.ReadOnly = true;
            this.txtreq.Size = new System.Drawing.Size(100, 20);
            this.txtreq.TabIndex = 27;
            // 
            // txtplace
            // 
            this.txtplace.Location = new System.Drawing.Point(483, 80);
            this.txtplace.Name = "txtplace";
            this.txtplace.ReadOnly = true;
            this.txtplace.Size = new System.Drawing.Size(100, 20);
            this.txtplace.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(361, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Applicable : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(361, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Requirement Added : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(361, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Place : ";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(483, 43);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.ReadOnly = true;
            this.txtsalary.Size = new System.Drawing.Size(100, 20);
            this.txtsalary.TabIndex = 22;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(483, 12);
            this.txttitle.Name = "txttitle";
            this.txttitle.ReadOnly = true;
            this.txttitle.Size = new System.Drawing.Size(100, 20);
            this.txttitle.TabIndex = 21;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(74, 9);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(361, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Salary : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Designation : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Job ID : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(835, 291);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rchdesignation
            // 
            this.rchdesignation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchdesignation.ForeColor = System.Drawing.SystemColors.Window;
            this.rchdesignation.Location = new System.Drawing.Point(15, 53);
            this.rchdesignation.Name = "rchdesignation";
            this.rchdesignation.Size = new System.Drawing.Size(346, 113);
            this.rchdesignation.TabIndex = 32;
            this.rchdesignation.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(361, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Title : ";
            // 
            // ViewJobDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 462);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rchdesignation);
            this.Controls.Add(this.btndoapllicable);
            this.Controls.Add(this.btnrmvapplicable);
            this.Controls.Add(this.btnrmvreq);
            this.Controls.Add(this.txtapplic);
            this.Controls.Add(this.txtreq);
            this.Controls.Add(this.txtplace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewJobDetails";
            this.Text = "ViewJobDetails";
            this.Load += new System.EventHandler(this.ViewJobDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndoapllicable;
        private System.Windows.Forms.Button btnrmvapplicable;
        private System.Windows.Forms.Button btnrmvreq;
        private System.Windows.Forms.TextBox txtapplic;
        private System.Windows.Forms.TextBox txtreq;
        private System.Windows.Forms.TextBox txtplace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rchdesignation;
        private System.Windows.Forms.Label label7;
    }
}