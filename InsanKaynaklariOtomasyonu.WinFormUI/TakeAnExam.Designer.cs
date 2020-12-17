namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class TakeAnExam
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbskill = new System.Windows.Forms.ComboBox();
            this.btnexam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skill : ";
            // 
            // cmbskill
            // 
            this.cmbskill.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbskill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbskill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbskill.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbskill.FormattingEnabled = true;
            this.cmbskill.Location = new System.Drawing.Point(146, 68);
            this.cmbskill.Name = "cmbskill";
            this.cmbskill.Size = new System.Drawing.Size(121, 24);
            this.cmbskill.TabIndex = 1;
            // 
            // btnexam
            // 
            this.btnexam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnexam.Location = new System.Drawing.Point(337, 68);
            this.btnexam.Name = "btnexam";
            this.btnexam.Size = new System.Drawing.Size(160, 94);
            this.btnexam.TabIndex = 2;
            this.btnexam.Text = "Take An Exam";
            this.btnexam.UseVisualStyleBackColor = true;
            this.btnexam.Click += new System.EventHandler(this.btnexam_Click);
            // 
            // TakeAnExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 405);
            this.Controls.Add(this.btnexam);
            this.Controls.Add(this.cmbskill);
            this.Controls.Add(this.label1);
            this.Name = "TakeAnExam";
            this.Text = "TakeAnExam";
            this.Load += new System.EventHandler(this.TakeAnExam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbskill;
        private System.Windows.Forms.Button btnexam;
    }
}