namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class AddPersonalityQuestion
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rchquestion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbolumlu = new System.Windows.Forms.RadioButton();
            this.rdbolumsuz = new System.Windows.Forms.RadioButton();
            this.btnekle = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(12, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(764, 116);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "UYARI !!!";
            // 
            // rchquestion
            // 
            this.rchquestion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchquestion.ForeColor = System.Drawing.SystemColors.Window;
            this.rchquestion.Location = new System.Drawing.Point(12, 192);
            this.rchquestion.Name = "rchquestion";
            this.rchquestion.Size = new System.Drawing.Size(764, 132);
            this.rchquestion.TabIndex = 0;
            this.rchquestion.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "QUESTION : ";
            // 
            // rdbolumlu
            // 
            this.rdbolumlu.AutoSize = true;
            this.rdbolumlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbolumlu.Location = new System.Drawing.Point(34, 346);
            this.rdbolumlu.Name = "rdbolumlu";
            this.rdbolumlu.Size = new System.Drawing.Size(100, 24);
            this.rdbolumlu.TabIndex = 1;
            this.rdbolumlu.TabStop = true;
            this.rdbolumlu.Text = "OLUMLU";
            this.rdbolumlu.UseVisualStyleBackColor = true;
            // 
            // rdbolumsuz
            // 
            this.rdbolumsuz.AutoSize = true;
            this.rdbolumsuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbolumsuz.Location = new System.Drawing.Point(248, 346);
            this.rdbolumsuz.Name = "rdbolumsuz";
            this.rdbolumsuz.Size = new System.Drawing.Size(113, 24);
            this.rdbolumsuz.TabIndex = 2;
            this.rdbolumsuz.TabStop = true;
            this.rdbolumsuz.Text = "OLUMSUZ";
            this.rdbolumsuz.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnekle.Location = new System.Drawing.Point(438, 346);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(159, 68);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Add Question";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddPersonalityQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 499);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.rdbolumsuz);
            this.Controls.Add(this.rdbolumlu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchquestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "AddPersonalityQuestion";
            this.Text = "AddPersonalityQuestion";
            this.Load += new System.EventHandler(this.AddPersonalityQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rchquestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbolumlu;
        private System.Windows.Forms.RadioButton rdbolumsuz;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}