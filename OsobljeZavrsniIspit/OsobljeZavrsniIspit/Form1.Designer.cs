namespace OsobljeZavrsniIspit
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.cmbZanimanje = new System.Windows.Forms.ComboBox();
            this.textBoxPodatci = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnObrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zanimanje:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(107, 10);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 26);
            this.txtIme.TabIndex = 3;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(107, 44);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 26);
            this.txtPrezime.TabIndex = 4;
            // 
            // cmbZanimanje
            // 
            this.cmbZanimanje.FormattingEnabled = true;
            this.cmbZanimanje.Items.AddRange(new object[] {
            "Učenik",
            "Profesor",
            "Tehničko Osoblje"});
            this.cmbZanimanje.Location = new System.Drawing.Point(107, 81);
            this.cmbZanimanje.Name = "cmbZanimanje";
            this.cmbZanimanje.Size = new System.Drawing.Size(121, 28);
            this.cmbZanimanje.TabIndex = 5;
            // 
            // textBoxPodatci
            // 
            this.textBoxPodatci.Location = new System.Drawing.Point(265, 10);
            this.textBoxPodatci.Multiline = true;
            this.textBoxPodatci.Name = "textBoxPodatci";
            this.textBoxPodatci.Size = new System.Drawing.Size(523, 428);
            this.textBoxPodatci.TabIndex = 6;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(17, 161);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(211, 45);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj Osobu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(17, 212);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(211, 45);
            this.btnIspis.TabIndex = 8;
            this.btnIspis.Text = "Prikaži Osobe";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filter:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Any",
            "Samo Učenici",
            "Samo Učitelji",
            "Samo Tehničko Osoblje"});
            this.cmbFilter.Location = new System.Drawing.Point(107, 115);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 28);
            this.cmbFilter.TabIndex = 10;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(17, 264);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(211, 49);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Filtriraj";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(17, 320);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(211, 50);
            this.btnObrada.TabIndex = 12;
            this.btnObrada.Text = "Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.textBoxPodatci);
            this.Controls.Add(this.cmbZanimanje);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox cmbZanimanje;
        private System.Windows.Forms.TextBox textBoxPodatci;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnObrada;
    }
}

