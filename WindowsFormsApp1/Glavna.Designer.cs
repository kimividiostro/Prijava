namespace PrijavaIspitaKPA
{
    partial class Glavna
    {
        private System.ComponentModel.IContainer components = null;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glavna));
            this.tbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bPrijaviSe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkGost = new System.Windows.Forms.LinkLabel();
            this.linkRegistruj = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKorisnickoIme
            // 
            this.tbKorisnickoIme.Location = new System.Drawing.Point(164, 90);
            this.tbKorisnickoIme.Name = "tbKorisnickoIme";
            this.tbKorisnickoIme.Size = new System.Drawing.Size(231, 26);
            this.tbKorisnickoIme.TabIndex = 0;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(164, 125);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(231, 26);
            this.tbLozinka.TabIndex = 1;
            this.tbLozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka";
            // 
            // bPrijaviSe
            // 
            this.bPrijaviSe.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrijaviSe.Location = new System.Drawing.Point(235, 157);
            this.bPrijaviSe.Name = "bPrijaviSe";
            this.bPrijaviSe.Size = new System.Drawing.Size(75, 23);
            this.bPrijaviSe.TabIndex = 4;
            this.bPrijaviSe.Text = "Prijavi se";
            this.bPrijaviSe.UseVisualStyleBackColor = true;
            this.bPrijaviSe.Click += new System.EventHandler(this.bPrijaviSe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 20F);
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kriminalističko-policijska Akademija";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(649, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 159);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // linkGost
            // 
            this.linkGost.AutoSize = true;
            this.linkGost.Location = new System.Drawing.Point(12, 202);
            this.linkGost.Name = "linkGost";
            this.linkGost.Size = new System.Drawing.Size(136, 18);
            this.linkGost.TabIndex = 8;
            this.linkGost.TabStop = true;
            this.linkGost.Text = "Prijavi se kao gost";
            this.linkGost.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGost_LinkClicked);
            // 
            // linkRegistruj
            // 
            this.linkRegistruj.AutoSize = true;
            this.linkRegistruj.Location = new System.Drawing.Point(12, 237);
            this.linkRegistruj.Name = "linkRegistruj";
            this.linkRegistruj.Size = new System.Drawing.Size(92, 18);
            this.linkRegistruj.TabIndex = 9;
            this.linkRegistruj.TabStop = true;
            this.linkRegistruj.Text = "Registruj se";
            this.linkRegistruj.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistruj_LinkClicked);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.linkRegistruj);
            this.Controls.Add(this.linkGost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bPrijaviSe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorisnickoIme);
            this.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Glavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kriminalističko-policijska Akademija";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKorisnickoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bPrijaviSe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkGost;
        private System.Windows.Forms.LinkLabel linkRegistruj;
    }
}

