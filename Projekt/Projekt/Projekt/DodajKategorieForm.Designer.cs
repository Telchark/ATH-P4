namespace Projekt
{
    partial class DodajKategorieForm
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
            this.Kategoria = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.btnWróć = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.Kategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kategoria
            // 
            this.Kategoria.Controls.Add(this.label2);
            this.Kategoria.Controls.Add(this.label1);
            this.Kategoria.Controls.Add(this.textBoxOpis);
            this.Kategoria.Controls.Add(this.textBoxNazwa);
            this.Kategoria.Location = new System.Drawing.Point(13, 13);
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.Size = new System.Drawing.Size(304, 209);
            this.Kategoria.TabIndex = 0;
            this.Kategoria.TabStop = false;
            this.Kategoria.Text = "Kategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa:";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(92, 93);
            this.textBoxOpis.MaximumSize = new System.Drawing.Size(200, 100);
            this.textBoxOpis.MinimumSize = new System.Drawing.Size(200, 100);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(200, 100);
            this.textBoxOpis.TabIndex = 1;
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(92, 36);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(200, 20);
            this.textBoxNazwa.TabIndex = 0;
            // 
            // btnWróć
            // 
            this.btnWróć.Location = new System.Drawing.Point(12, 230);
            this.btnWróć.Name = "btnWróć";
            this.btnWróć.Size = new System.Drawing.Size(127, 23);
            this.btnWróć.TabIndex = 1;
            this.btnWróć.Text = "Wróć";
            this.btnWróć.UseVisualStyleBackColor = true;
            this.btnWróć.Click += new System.EventHandler(this.btnWróć_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(190, 230);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(127, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajKategorieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 261);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnWróć);
            this.Controls.Add(this.Kategoria);
            this.MaximumSize = new System.Drawing.Size(345, 300);
            this.MinimumSize = new System.Drawing.Size(345, 300);
            this.Name = "DodajKategorieForm";
            this.Text = "Dodaj kategorię";
            this.Kategoria.ResumeLayout(false);
            this.Kategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Kategoria;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWróć;
        private System.Windows.Forms.Button btnDodaj;
    }
}