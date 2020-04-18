namespace Projekt
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSrodki = new System.Windows.Forms.Button();
            this.btnPrac = new System.Windows.Forms.Button();
            this.btnKat = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDokumenty = new System.Windows.Forms.Button();
            this.btnWyjdź = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSrodki
            // 
            this.btnSrodki.Location = new System.Drawing.Point(12, 12);
            this.btnSrodki.Name = "btnSrodki";
            this.btnSrodki.Size = new System.Drawing.Size(346, 37);
            this.btnSrodki.TabIndex = 0;
            this.btnSrodki.Text = "Środki Trwałe";
            this.btnSrodki.UseVisualStyleBackColor = true;
            this.btnSrodki.Click += new System.EventHandler(this.btnSrodki_Click);
            // 
            // btnPrac
            // 
            this.btnPrac.Location = new System.Drawing.Point(12, 55);
            this.btnPrac.Name = "btnPrac";
            this.btnPrac.Size = new System.Drawing.Size(346, 37);
            this.btnPrac.TabIndex = 1;
            this.btnPrac.Text = "Pracownicy";
            this.btnPrac.UseVisualStyleBackColor = true;
            this.btnPrac.Click += new System.EventHandler(this.btnPrac_Click);
            // 
            // btnKat
            // 
            this.btnKat.Location = new System.Drawing.Point(12, 98);
            this.btnKat.Name = "btnKat";
            this.btnKat.Size = new System.Drawing.Size(346, 37);
            this.btnKat.TabIndex = 2;
            this.btnKat.Text = "Kategorie";
            this.btnKat.UseVisualStyleBackColor = true;
            this.btnKat.Click += new System.EventHandler(this.btnKat_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(346, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Klasyfikacja Środków Trwałych";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDokumenty
            // 
            this.btnDokumenty.Location = new System.Drawing.Point(12, 184);
            this.btnDokumenty.Name = "btnDokumenty";
            this.btnDokumenty.Size = new System.Drawing.Size(346, 37);
            this.btnDokumenty.TabIndex = 5;
            this.btnDokumenty.Text = "Dokumenty";
            this.btnDokumenty.UseVisualStyleBackColor = true;
            this.btnDokumenty.Click += new System.EventHandler(this.btnDokumenty_Click);
            // 
            // btnWyjdź
            // 
            this.btnWyjdź.Location = new System.Drawing.Point(12, 242);
            this.btnWyjdź.Name = "btnWyjdź";
            this.btnWyjdź.Size = new System.Drawing.Size(346, 37);
            this.btnWyjdź.TabIndex = 6;
            this.btnWyjdź.Text = "Wyjdź";
            this.btnWyjdź.UseVisualStyleBackColor = true;
            this.btnWyjdź.Click += new System.EventHandler(this.btnWyjdź_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 291);
            this.Controls.Add(this.btnWyjdź);
            this.Controls.Add(this.btnDokumenty);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnKat);
            this.Controls.Add(this.btnPrac);
            this.Controls.Add(this.btnSrodki);
            this.MaximumSize = new System.Drawing.Size(386, 330);
            this.MinimumSize = new System.Drawing.Size(386, 330);
            this.Name = "MainForm";
            this.Text = "Środki Trwałe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSrodki;
        private System.Windows.Forms.Button btnPrac;
        private System.Windows.Forms.Button btnKat;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button btnDokumenty;

        private System.Windows.Forms.Button btnWyjdź;
    }
}

