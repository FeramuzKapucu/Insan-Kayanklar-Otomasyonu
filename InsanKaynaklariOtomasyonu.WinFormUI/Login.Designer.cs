namespace InsanKaynaklariOtomasyonu.WinFormUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnuser = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnuser
            // 
            this.btnuser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnuser.BackgroundImage")));
            this.btnuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnuser.ForeColor = System.Drawing.Color.Yellow;
            this.btnuser.Location = new System.Drawing.Point(487, 257);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(188, 97);
            this.btnuser.TabIndex = 4;
            this.btnuser.Text = "Member Login";
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadmin.BackgroundImage")));
            this.btnadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadmin.ForeColor = System.Drawing.Color.Black;
            this.btnadmin.Location = new System.Drawing.Point(152, 257);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(188, 97);
            this.btnadmin.TabIndex = 2;
            this.btnadmin.Text = "Admin Login";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(946, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 426);
            this.Controls.Add(this.btnuser);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

