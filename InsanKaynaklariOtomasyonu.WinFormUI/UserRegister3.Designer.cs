namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class UserRegister3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegister3));
            this.label1 = new System.Windows.Forms.Label();
            this.lblsoru = new System.Windows.Forms.Label();
            this.rchquestion = new System.Windows.Forms.RichTextBox();
            this.rdbhayır = new System.Windows.Forms.RadioButton();
            this.rdbnotr = new System.Windows.Forms.RadioButton();
            this.rdbkısmen = new System.Windows.Forms.RadioButton();
            this.rdbevet = new System.Windows.Forms.RadioButton();
            this.prob = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnnext = new System.Windows.Forms.Button();
            this.lbltimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcevap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question : ";
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoru.Location = new System.Drawing.Point(90, 23);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(51, 16);
            this.lblsoru.TabIndex = 1;
            this.lblsoru.Text = "label2";
            // 
            // rchquestion
            // 
            this.rchquestion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.rchquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchquestion.ForeColor = System.Drawing.SystemColors.Window;
            this.rchquestion.Location = new System.Drawing.Point(5, 56);
            this.rchquestion.Name = "rchquestion";
            this.rchquestion.Size = new System.Drawing.Size(696, 139);
            this.rchquestion.TabIndex = 2;
            this.rchquestion.Text = "";
            // 
            // rdbhayır
            // 
            this.rdbhayır.AutoSize = true;
            this.rdbhayır.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbhayır.Location = new System.Drawing.Point(53, 199);
            this.rdbhayır.Name = "rdbhayır";
            this.rdbhayır.Size = new System.Drawing.Size(72, 20);
            this.rdbhayır.TabIndex = 0;
            this.rdbhayır.TabStop = true;
            this.rdbhayır.Text = "HAYIR";
            this.rdbhayır.UseVisualStyleBackColor = true;
            // 
            // rdbnotr
            // 
            this.rdbnotr.AutoSize = true;
            this.rdbnotr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbnotr.Location = new System.Drawing.Point(209, 199);
            this.rdbnotr.Name = "rdbnotr";
            this.rdbnotr.Size = new System.Drawing.Size(69, 20);
            this.rdbnotr.TabIndex = 1;
            this.rdbnotr.TabStop = true;
            this.rdbnotr.Text = "NÖTR";
            this.rdbnotr.UseVisualStyleBackColor = true;
            // 
            // rdbkısmen
            // 
            this.rdbkısmen.AutoSize = true;
            this.rdbkısmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbkısmen.Location = new System.Drawing.Point(339, 199);
            this.rdbkısmen.Name = "rdbkısmen";
            this.rdbkısmen.Size = new System.Drawing.Size(82, 20);
            this.rdbkısmen.TabIndex = 2;
            this.rdbkısmen.TabStop = true;
            this.rdbkısmen.Text = "KISMEN";
            this.rdbkısmen.UseVisualStyleBackColor = true;
            // 
            // rdbevet
            // 
            this.rdbevet.AutoSize = true;
            this.rdbevet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbevet.Location = new System.Drawing.Point(476, 201);
            this.rdbevet.Name = "rdbevet";
            this.rdbevet.Size = new System.Drawing.Size(66, 20);
            this.rdbevet.TabIndex = 3;
            this.rdbevet.TabStop = true;
            this.rdbevet.Text = "EVET";
            this.rdbevet.UseVisualStyleBackColor = true;
            // 
            // prob
            // 
            this.prob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.prob.Location = new System.Drawing.Point(6, 335);
            this.prob.Maximum = 90;
            this.prob.Name = "prob";
            this.prob.Size = new System.Drawing.Size(695, 23);
            this.prob.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnext.Location = new System.Drawing.Point(500, 237);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(165, 70);
            this.btnnext.TabIndex = 4;
            this.btnnext.Text = "Next Question";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltimer.Location = new System.Drawing.Point(599, 13);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(28, 16);
            this.lbltimer.TabIndex = 9;
            this.lbltimer.Text = "60 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(633, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = ": sn";
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.Location = new System.Drawing.Point(32, 258);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(35, 13);
            this.lblcevap.TabIndex = 11;
            this.lblcevap.Text = "label2";
            // 
            // UserRegister3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 447);
            this.ControlBox = false;
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.prob);
            this.Controls.Add(this.rdbevet);
            this.Controls.Add(this.rdbkısmen);
            this.Controls.Add(this.rdbnotr);
            this.Controls.Add(this.rdbhayır);
            this.Controls.Add(this.rchquestion);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UserRegister3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberRegister3";
            this.Load += new System.EventHandler(this.UserRegister3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsoru;
        private System.Windows.Forms.RichTextBox rchquestion;
        private System.Windows.Forms.RadioButton rdbhayır;
        private System.Windows.Forms.RadioButton rdbnotr;
        private System.Windows.Forms.RadioButton rdbkısmen;
        private System.Windows.Forms.RadioButton rdbevet;
        private System.Windows.Forms.ProgressBar prob;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcevap;
    }
}