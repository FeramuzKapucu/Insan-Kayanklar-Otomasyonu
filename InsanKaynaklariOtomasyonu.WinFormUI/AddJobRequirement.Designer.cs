namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class AddJobRequirement
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
            this.cmbkeyskill = new System.Windows.Forms.ComboBox();
            this.nudexperince = new System.Windows.Forms.NumericUpDown();
            this.btnekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblsalary = new System.Windows.Forms.Label();
            this.lblplace = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbgerekli = new System.Windows.Forms.RadioButton();
            this.rdbgereklidegil = new System.Windows.Forms.RadioButton();
            this.rchdesignation = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudexperince)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbkeyskill
            // 
            this.cmbkeyskill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbkeyskill.FormattingEnabled = true;
            this.cmbkeyskill.Location = new System.Drawing.Point(212, 326);
            this.cmbkeyskill.Name = "cmbkeyskill";
            this.cmbkeyskill.Size = new System.Drawing.Size(121, 21);
            this.cmbkeyskill.TabIndex = 32;
            // 
            // nudexperince
            // 
            this.nudexperince.Location = new System.Drawing.Point(212, 291);
            this.nudexperince.Name = "nudexperince";
            this.nudexperince.Size = new System.Drawing.Size(120, 20);
            this.nudexperince.TabIndex = 30;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(378, 310);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(130, 51);
            this.btnekle.TabIndex = 29;
            this.btnekle.Text = "Add Requirement";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(20, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Key Skil : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Experience : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(633, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Place : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(633, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Salary : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Designation : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Job ID : ";
            // 
            // cmbid
            // 
            this.cmbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbid.FormattingEnabled = true;
            this.cmbid.Location = new System.Drawing.Point(135, 16);
            this.cmbid.Name = "cmbid";
            this.cmbid.Size = new System.Drawing.Size(121, 21);
            this.cmbid.TabIndex = 19;
            this.cmbid.SelectedIndexChanged += new System.EventHandler(this.cmbid_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(307, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Title : ";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(395, 21);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(35, 13);
            this.lbltitle.TabIndex = 34;
            this.lbltitle.Text = "label8";
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Location = new System.Drawing.Point(715, 271);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(35, 13);
            this.lblsalary.TabIndex = 34;
            this.lblsalary.Text = "label8";
            // 
            // lblplace
            // 
            this.lblplace.AutoSize = true;
            this.lblplace.Location = new System.Drawing.Point(715, 324);
            this.lblplace.Name = "lblplace";
            this.lblplace.Size = new System.Drawing.Size(35, 13);
            this.lblplace.TabIndex = 34;
            this.lblplace.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(20, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Lisans Tamamlanmış : ";
            // 
            // rdbgerekli
            // 
            this.rdbgerekli.AutoSize = true;
            this.rdbgerekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbgerekli.Location = new System.Drawing.Point(212, 359);
            this.rdbgerekli.Name = "rdbgerekli";
            this.rdbgerekli.Size = new System.Drawing.Size(76, 20);
            this.rdbgerekli.TabIndex = 35;
            this.rdbgerekli.TabStop = true;
            this.rdbgerekli.Text = "Gerekli";
            this.rdbgerekli.UseVisualStyleBackColor = true;
            // 
            // rdbgereklidegil
            // 
            this.rdbgereklidegil.AutoSize = true;
            this.rdbgereklidegil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbgereklidegil.Location = new System.Drawing.Point(212, 392);
            this.rdbgereklidegil.Name = "rdbgereklidegil";
            this.rdbgereklidegil.Size = new System.Drawing.Size(121, 20);
            this.rdbgereklidegil.TabIndex = 35;
            this.rdbgereklidegil.TabStop = true;
            this.rdbgereklidegil.Text = "Gerekli Değil ";
            this.rdbgereklidegil.UseVisualStyleBackColor = true;
            // 
            // rchdesignation
            // 
            this.rchdesignation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchdesignation.ForeColor = System.Drawing.SystemColors.Window;
            this.rchdesignation.Location = new System.Drawing.Point(121, 57);
            this.rchdesignation.Name = "rchdesignation";
            this.rchdesignation.Size = new System.Drawing.Size(629, 198);
            this.rchdesignation.TabIndex = 36;
            this.rchdesignation.Text = "";
            // 
            // AddJobRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 473);
            this.Controls.Add(this.rchdesignation);
            this.Controls.Add(this.rdbgereklidegil);
            this.Controls.Add(this.rdbgerekli);
            this.Controls.Add(this.lblplace);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbkeyskill);
            this.Controls.Add(this.nudexperince);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbid);
            this.Controls.Add(this.label1);
            this.Name = "AddJobRequirement";
            this.Text = "AddJobRequirement";
            this.Load += new System.EventHandler(this.AddJobRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudexperince)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbkeyskill;
        private System.Windows.Forms.NumericUpDown nudexperince;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label lblplace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbgerekli;
        private System.Windows.Forms.RadioButton rdbgereklidegil;
        private System.Windows.Forms.RichTextBox rchdesignation;
    }
}