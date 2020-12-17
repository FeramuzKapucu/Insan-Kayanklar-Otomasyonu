namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class TakeAnExam2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.btnbasla = new System.Windows.Forms.Button();
            this.rcho4 = new System.Windows.Forms.RichTextBox();
            this.rcho3 = new System.Windows.Forms.RichTextBox();
            this.rcho2 = new System.Windows.Forms.RichTextBox();
            this.rcho1 = new System.Windows.Forms.RichTextBox();
            this.rchquestion = new System.Windows.Forms.RichTextBox();
            this.lblsayi = new System.Windows.Forms.Label();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.lblsn = new System.Windows.Forms.Label();
            this.lbltimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnnext = new System.Windows.Forms.Button();
            this.lblcevap = new System.Windows.Forms.Label();
            this.lblcevap2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btngeri
            // 
            this.btngeri.Location = new System.Drawing.Point(71, 38);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(119, 48);
            this.btngeri.TabIndex = 1;
            this.btngeri.Text = "Geri Dön";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // btnbasla
            // 
            this.btnbasla.Location = new System.Drawing.Point(272, 38);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(119, 48);
            this.btnbasla.TabIndex = 1;
            this.btnbasla.Text = "Sınava Başla";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // rcho4
            // 
            this.rcho4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rcho4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcho4.ForeColor = System.Drawing.SystemColors.Window;
            this.rcho4.Location = new System.Drawing.Point(71, 380);
            this.rcho4.Name = "rcho4";
            this.rcho4.ReadOnly = true;
            this.rcho4.Size = new System.Drawing.Size(706, 41);
            this.rcho4.TabIndex = 23;
            this.rcho4.Text = "";
            // 
            // rcho3
            // 
            this.rcho3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rcho3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcho3.ForeColor = System.Drawing.SystemColors.Window;
            this.rcho3.Location = new System.Drawing.Point(71, 333);
            this.rcho3.Name = "rcho3";
            this.rcho3.ReadOnly = true;
            this.rcho3.Size = new System.Drawing.Size(706, 41);
            this.rcho3.TabIndex = 22;
            this.rcho3.Text = "";
            // 
            // rcho2
            // 
            this.rcho2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rcho2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcho2.ForeColor = System.Drawing.SystemColors.Window;
            this.rcho2.Location = new System.Drawing.Point(71, 282);
            this.rcho2.Name = "rcho2";
            this.rcho2.ReadOnly = true;
            this.rcho2.Size = new System.Drawing.Size(706, 41);
            this.rcho2.TabIndex = 21;
            this.rcho2.Text = "";
            // 
            // rcho1
            // 
            this.rcho1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rcho1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcho1.ForeColor = System.Drawing.SystemColors.Window;
            this.rcho1.Location = new System.Drawing.Point(71, 235);
            this.rcho1.Name = "rcho1";
            this.rcho1.ReadOnly = true;
            this.rcho1.Size = new System.Drawing.Size(706, 41);
            this.rcho1.TabIndex = 20;
            this.rcho1.Text = "";
            // 
            // rchquestion
            // 
            this.rchquestion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchquestion.ForeColor = System.Drawing.SystemColors.Window;
            this.rchquestion.Location = new System.Drawing.Point(6, 62);
            this.rchquestion.Name = "rchquestion";
            this.rchquestion.ReadOnly = true;
            this.rchquestion.Size = new System.Drawing.Size(810, 162);
            this.rchquestion.TabIndex = 15;
            this.rchquestion.Text = "";
            // 
            // lblsayi
            // 
            this.lblsayi.AutoSize = true;
            this.lblsayi.Location = new System.Drawing.Point(13, 38);
            this.lblsayi.Name = "lblsayi";
            this.lblsayi.Size = new System.Drawing.Size(51, 16);
            this.lblsayi.TabIndex = 24;
            this.lblsayi.Text = "label6";
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(16, 245);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(49, 20);
            this.rdbA.TabIndex = 27;
            this.rdbA.TabStop = true;
            this.rdbA.Text = "A ) ";
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(15, 283);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(49, 20);
            this.rdbB.TabIndex = 27;
            this.rdbB.TabStop = true;
            this.rdbB.Text = "B ) ";
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(16, 334);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(49, 20);
            this.rdbC.TabIndex = 27;
            this.rdbC.TabStop = true;
            this.rdbC.Text = "C ) ";
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(16, 392);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(50, 20);
            this.rdbD.TabIndex = 27;
            this.rdbD.TabStop = true;
            this.rdbD.Text = "D ) ";
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // lblsn
            // 
            this.lblsn.AutoSize = true;
            this.lblsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsn.Location = new System.Drawing.Point(714, 9);
            this.lblsn.Name = "lblsn";
            this.lblsn.Size = new System.Drawing.Size(32, 16);
            this.lblsn.TabIndex = 29;
            this.lblsn.Text = ": sn";
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltimer.Location = new System.Drawing.Point(689, 9);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(24, 16);
            this.lbltimer.TabIndex = 28;
            this.lbltimer.Text = "90";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(481, 8);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(119, 48);
            this.btnnext.TabIndex = 30;
            this.btnnext.Text = "Next Question";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.Location = new System.Drawing.Point(398, 11);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(51, 16);
            this.lblcevap.TabIndex = 31;
            this.lblcevap.Text = "label2";
            this.lblcevap.Visible = false;
            // 
            // lblcevap2
            // 
            this.lblcevap2.AutoSize = true;
            this.lblcevap2.Location = new System.Drawing.Point(299, 13);
            this.lblcevap2.Name = "lblcevap2";
            this.lblcevap2.Size = new System.Drawing.Size(51, 16);
            this.lblcevap2.TabIndex = 32;
            this.lblcevap2.Text = "label2";
            this.lblcevap2.Visible = false;
            // 
            // TakeAnExam2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(819, 475);
            this.ControlBox = false;
            this.Controls.Add(this.lblcevap2);
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.lblsn);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.lblsayi);
            this.Controls.Add(this.rcho4);
            this.Controls.Add(this.rcho3);
            this.Controls.Add(this.rcho2);
            this.Controls.Add(this.rcho1);
            this.Controls.Add(this.rchquestion);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TakeAnExam2";
            this.Text = "TakeAnExam2";
            this.Load += new System.EventHandler(this.TakeAnExam2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.RichTextBox rcho4;
        private System.Windows.Forms.RichTextBox rcho3;
        private System.Windows.Forms.RichTextBox rcho2;
        private System.Windows.Forms.RichTextBox rcho1;
        private System.Windows.Forms.RichTextBox rchquestion;
        private System.Windows.Forms.Label lblsayi;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.Label lblsn;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lblcevap;
        private System.Windows.Forms.Label lblcevap2;
    }
}