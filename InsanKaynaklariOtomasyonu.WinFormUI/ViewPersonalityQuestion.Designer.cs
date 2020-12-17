namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class ViewPersonalityQuestion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rchperques = new System.Windows.Forms.RichTextBox();
            this.rdbolumlu = new System.Windows.Forms.RadioButton();
            this.rdbolumsuz = new System.Windows.Forms.RadioButton();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(808, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rchperques
            // 
            this.rchperques.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchperques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchperques.ForeColor = System.Drawing.SystemColors.Window;
            this.rchperques.Location = new System.Drawing.Point(0, 3);
            this.rchperques.Name = "rchperques";
            this.rchperques.Size = new System.Drawing.Size(624, 120);
            this.rchperques.TabIndex = 1;
            this.rchperques.Text = "";
            // 
            // rdbolumlu
            // 
            this.rdbolumlu.AutoSize = true;
            this.rdbolumlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbolumlu.Location = new System.Drawing.Point(106, 130);
            this.rdbolumlu.Name = "rdbolumlu";
            this.rdbolumlu.Size = new System.Drawing.Size(87, 20);
            this.rdbolumlu.TabIndex = 2;
            this.rdbolumlu.TabStop = true;
            this.rdbolumlu.Text = "OLUMLU";
            this.rdbolumlu.UseVisualStyleBackColor = true;
            // 
            // rdbolumsuz
            // 
            this.rdbolumsuz.AutoSize = true;
            this.rdbolumsuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbolumsuz.Location = new System.Drawing.Point(290, 130);
            this.rdbolumsuz.Name = "rdbolumsuz";
            this.rdbolumsuz.Size = new System.Drawing.Size(98, 20);
            this.rdbolumsuz.TabIndex = 3;
            this.rdbolumsuz.TabStop = true;
            this.rdbolumsuz.Text = "OLUMSUZ";
            this.rdbolumsuz.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdate.Location = new System.Drawing.Point(630, 12);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(151, 61);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update The Question";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.Location = new System.Drawing.Point(630, 79);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(150, 64);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete The Question";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // ViewPersonalityQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 448);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.rdbolumsuz);
            this.Controls.Add(this.rdbolumlu);
            this.Controls.Add(this.rchperques);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewPersonalityQuestion";
            this.Text = "ViewPersonalityQuestion";
            this.Load += new System.EventHandler(this.ViewPersonalityQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rchperques;
        private System.Windows.Forms.RadioButton rdbolumlu;
        private System.Windows.Forms.RadioButton rdbolumsuz;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}