namespace WindowsFormsApp1
{
    partial class NoviIspit
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
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.cbPredmet = new System.Windows.Forms.ComboBox();
            this.tbMesto = new System.Windows.Forms.TextBox();
            this.datum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bDodaj = new System.Windows.Forms.Button();
            this.vreme = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(84, 50);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(137, 20);
            this.tbSifra.TabIndex = 0;
            // 
            // cbPredmet
            // 
            this.cbPredmet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.Location = new System.Drawing.Point(84, 76);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(137, 21);
            this.cbPredmet.TabIndex = 1;
            // 
            // tbMesto
            // 
            this.tbMesto.Location = new System.Drawing.Point(84, 103);
            this.tbMesto.Name = "tbMesto";
            this.tbMesto.Size = new System.Drawing.Size(137, 20);
            this.tbMesto.TabIndex = 2;
            // 
            // datum
            // 
            this.datum.CustomFormat = "dd/MM/yy";
            this.datum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datum.Location = new System.Drawing.Point(84, 129);
            this.datum.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(137, 20);
            this.datum.TabIndex = 3;
            this.datum.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Šifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Predmet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mesto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum";
            // 
            // bDodaj
            // 
            this.bDodaj.Location = new System.Drawing.Point(94, 205);
            this.bDodaj.Name = "bDodaj";
            this.bDodaj.Size = new System.Drawing.Size(101, 30);
            this.bDodaj.TabIndex = 8;
            this.bDodaj.Text = "Dodaj";
            this.bDodaj.UseVisualStyleBackColor = true;
            this.bDodaj.Click += new System.EventHandler(this.bDodaj_Click);
            // 
            // vreme
            // 
            this.vreme.CustomFormat = "HH:mm";
            this.vreme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.vreme.Location = new System.Drawing.Point(84, 155);
            this.vreme.Name = "vreme";
            this.vreme.ShowUpDown = true;
            this.vreme.Size = new System.Drawing.Size(137, 20);
            this.vreme.TabIndex = 9;
            this.vreme.Value = new System.DateTime(2019, 1, 3, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vreme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(broj)";
            // 
            // NoviIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vreme);
            this.Controls.Add(this.bDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.tbMesto);
            this.Controls.Add(this.cbPredmet);
            this.Controls.Add(this.tbSifra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NoviIspit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi Ispit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.ComboBox cbPredmet;
        private System.Windows.Forms.TextBox tbMesto;
        private System.Windows.Forms.DateTimePicker datum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bDodaj;
        private System.Windows.Forms.DateTimePicker vreme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}