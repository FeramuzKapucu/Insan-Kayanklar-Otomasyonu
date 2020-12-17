namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class AddJob
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
            this.txttitle = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.nudsalary = new System.Windows.Forms.NumericUpDown();
            this.txtplace = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rchdesignation = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudsalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txttitle.ForeColor = System.Drawing.SystemColors.Window;
            this.txttitle.Location = new System.Drawing.Point(182, 73);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(228, 20);
            this.txttitle.TabIndex = 15;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(529, 306);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(114, 55);
            this.btnekle.TabIndex = 14;
            this.btnekle.Text = "Add Job";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // nudsalary
            // 
            this.nudsalary.BackColor = System.Drawing.SystemColors.HotTrack;
            this.nudsalary.ForeColor = System.Drawing.SystemColors.Window;
            this.nudsalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudsalary.Location = new System.Drawing.Point(167, 296);
            this.nudsalary.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nudsalary.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudsalary.Name = "nudsalary";
            this.nudsalary.Size = new System.Drawing.Size(228, 20);
            this.nudsalary.TabIndex = 8;
            this.nudsalary.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtplace
            // 
            this.txtplace.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtplace.ForeColor = System.Drawing.SystemColors.Window;
            this.txtplace.Location = new System.Drawing.Point(167, 329);
            this.txtplace.Name = "txtplace";
            this.txtplace.Size = new System.Drawing.Size(228, 20);
            this.txtplace.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(182, 31);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(228, 20);
            this.txtid.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(25, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Place : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Salary : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Designation : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Job ID : ";
            // 
            // rchdesignation
            // 
            this.rchdesignation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchdesignation.ForeColor = System.Drawing.SystemColors.Window;
            this.rchdesignation.Location = new System.Drawing.Point(167, 115);
            this.rchdesignation.Name = "rchdesignation";
            this.rchdesignation.Size = new System.Drawing.Size(539, 145);
            this.rchdesignation.TabIndex = 16;
            this.rchdesignation.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(25, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Title : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 465);
            this.Controls.Add(this.rchdesignation);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.nudsalary);
            this.Controls.Add(this.txtplace);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddJob";
            this.Text = "AddJob";
            this.Load += new System.EventHandler(this.AddJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudsalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.NumericUpDown nudsalary;
        private System.Windows.Forms.TextBox txtplace;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchdesignation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}