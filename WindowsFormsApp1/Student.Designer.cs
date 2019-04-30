namespace PrijavaIspitaKPA
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPredmeti = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listIspiti = new System.Windows.Forms.ListBox();
            this.bPrijaviIspit = new System.Windows.Forms.Button();
            this.lIme = new System.Windows.Forms.Label();
            this.lPrezime = new System.Windows.Forms.Label();
            this.lBrojIndeksa = new System.Windows.Forms.Label();
            this.lSifra = new System.Windows.Forms.Label();
            this.lProfesor = new System.Windows.Forms.Label();
            this.lNazivKursa = new System.Windows.Forms.Label();
            this.lbTerminiIspita = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Predmeti";
            // 
            // cbPredmeti
            // 
            this.cbPredmeti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPredmeti.FormattingEnabled = true;
            this.cbPredmeti.Location = new System.Drawing.Point(16, 213);
            this.cbPredmeti.Name = "cbPredmeti";
            this.cbPredmeti.Size = new System.Drawing.Size(235, 21);
            this.cbPredmeti.TabIndex = 3;
            this.cbPredmeti.SelectedIndexChanged += new System.EventHandler(this.cbPredmeti_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prijavljeni ispiti";
            // 
            // listIspiti
            // 
            this.listIspiti.FormattingEnabled = true;
            this.listIspiti.Location = new System.Drawing.Point(257, 213);
            this.listIspiti.Name = "listIspiti";
            this.listIspiti.Size = new System.Drawing.Size(250, 108);
            this.listIspiti.TabIndex = 5;
            // 
            // bPrijaviIspit
            // 
            this.bPrijaviIspit.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrijaviIspit.Location = new System.Drawing.Point(16, 240);
            this.bPrijaviIspit.Name = "bPrijaviIspit";
            this.bPrijaviIspit.Size = new System.Drawing.Size(88, 23);
            this.bPrijaviIspit.TabIndex = 6;
            this.bPrijaviIspit.Text = "Prijavi ispit";
            this.bPrijaviIspit.UseVisualStyleBackColor = true;
            this.bPrijaviIspit.Click += new System.EventHandler(this.bPrijaviIspit_Click);
            // 
            // lIme
            // 
            this.lIme.AutoSize = true;
            this.lIme.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIme.Location = new System.Drawing.Point(266, 12);
            this.lIme.Name = "lIme";
            this.lIme.Size = new System.Drawing.Size(62, 33);
            this.lIme.TabIndex = 7;
            this.lIme.Text = "ime";
            // 
            // lPrezime
            // 
            this.lPrezime.AutoSize = true;
            this.lPrezime.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrezime.Location = new System.Drawing.Point(266, 52);
            this.lPrezime.Name = "lPrezime";
            this.lPrezime.Size = new System.Drawing.Size(117, 33);
            this.lPrezime.TabIndex = 8;
            this.lPrezime.Text = "prezime";
            // 
            // lBrojIndeksa
            // 
            this.lBrojIndeksa.AutoSize = true;
            this.lBrojIndeksa.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBrojIndeksa.Location = new System.Drawing.Point(266, 89);
            this.lBrojIndeksa.Name = "lBrojIndeksa";
            this.lBrojIndeksa.Size = new System.Drawing.Size(100, 33);
            this.lBrojIndeksa.TabIndex = 9;
            this.lBrojIndeksa.Text = "indeks";
            // 
            // lSifra
            // 
            this.lSifra.AutoSize = true;
            this.lSifra.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSifra.Location = new System.Drawing.Point(12, 299);
            this.lSifra.Name = "lSifra";
            this.lSifra.Size = new System.Drawing.Size(111, 23);
            this.lSifra.TabIndex = 10;
            this.lSifra.Text = "Šifra kursa: ";
            // 
            // lProfesor
            // 
            this.lProfesor.AutoSize = true;
            this.lProfesor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProfesor.Location = new System.Drawing.Point(12, 349);
            this.lProfesor.Name = "lProfesor";
            this.lProfesor.Size = new System.Drawing.Size(93, 23);
            this.lProfesor.TabIndex = 11;
            this.lProfesor.Text = "Profesor: ";
            // 
            // lNazivKursa
            // 
            this.lNazivKursa.AutoSize = true;
            this.lNazivKursa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNazivKursa.Location = new System.Drawing.Point(12, 324);
            this.lNazivKursa.Name = "lNazivKursa";
            this.lNazivKursa.Size = new System.Drawing.Size(120, 23);
            this.lNazivKursa.TabIndex = 12;
            this.lNazivKursa.Text = "Naziv kursa: ";
            // 
            // lbTerminiIspita
            // 
            this.lbTerminiIspita.FormattingEnabled = true;
            this.lbTerminiIspita.Location = new System.Drawing.Point(513, 69);
            this.lbTerminiIspita.Name = "lbTerminiIspita";
            this.lbTerminiIspita.Size = new System.Drawing.Size(275, 303);
            this.lbTerminiIspita.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Termini ispita";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTerminiIspita);
            this.Controls.Add(this.lNazivKursa);
            this.Controls.Add(this.lProfesor);
            this.Controls.Add(this.lSifra);
            this.Controls.Add(this.lBrojIndeksa);
            this.Controls.Add(this.lPrezime);
            this.Controls.Add(this.lIme);
            this.Controls.Add(this.bPrijaviIspit);
            this.Controls.Add(this.listIspiti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPredmeti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPredmeti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listIspiti;
        private System.Windows.Forms.Button bPrijaviIspit;
        private System.Windows.Forms.Label lIme;
        private System.Windows.Forms.Label lPrezime;
        private System.Windows.Forms.Label lBrojIndeksa;
        private System.Windows.Forms.Label lSifra;
        private System.Windows.Forms.Label lProfesor;
        private System.Windows.Forms.Label lNazivKursa;
        private System.Windows.Forms.ListBox lbTerminiIspita;
        private System.Windows.Forms.Label label4;
    }
}