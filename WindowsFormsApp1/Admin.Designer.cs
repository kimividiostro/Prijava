namespace PrijavaIspitaKPA
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbStudenti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listPrijavljeniIspiti = new System.Windows.Forms.ListBox();
            this.listIspiti = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bDodajIspit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 105);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbStudenti
            // 
            this.cbStudenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudenti.FormattingEnabled = true;
            this.cbStudenti.Location = new System.Drawing.Point(12, 190);
            this.cbStudenti.Name = "cbStudenti";
            this.cbStudenti.Size = new System.Drawing.Size(203, 21);
            this.cbStudenti.TabIndex = 2;
            this.cbStudenti.SelectedIndexChanged += new System.EventHandler(this.cbStudenti_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Studenti";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prijavljeni ispiti";
            // 
            // listPrijavljeniIspiti
            // 
            this.listPrijavljeniIspiti.FormattingEnabled = true;
            this.listPrijavljeniIspiti.Location = new System.Drawing.Point(221, 190);
            this.listPrijavljeniIspiti.Name = "listPrijavljeniIspiti";
            this.listPrijavljeniIspiti.Size = new System.Drawing.Size(252, 121);
            this.listPrijavljeniIspiti.TabIndex = 5;
            // 
            // listIspiti
            // 
            this.listIspiti.FormattingEnabled = true;
            this.listIspiti.Location = new System.Drawing.Point(524, 45);
            this.listIspiti.Name = "listIspiti";
            this.listIspiti.Size = new System.Drawing.Size(264, 251);
            this.listIspiti.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ispiti";
            // 
            // bDodajIspit
            // 
            this.bDodajIspit.Location = new System.Drawing.Point(586, 311);
            this.bDodajIspit.Name = "bDodajIspit";
            this.bDodajIspit.Size = new System.Drawing.Size(159, 46);
            this.bDodajIspit.TabIndex = 8;
            this.bDodajIspit.Text = "Zakaži ispit";
            this.bDodajIspit.UseVisualStyleBackColor = true;
            this.bDodajIspit.Click += new System.EventHandler(this.bDodajIspit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDodajIspit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listIspiti);
            this.Controls.Add(this.listPrijavljeniIspiti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStudenti);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbStudenti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listPrijavljeniIspiti;
        private System.Windows.Forms.ListBox listIspiti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bDodajIspit;
    }
}