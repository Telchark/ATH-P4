namespace Projekt
{
    partial class EdytujDokumentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataDokumentu = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.textBoxWartosc = new System.Windows.Forms.TextBox();
            this.textBoxNrDokumentu = new System.Windows.Forms.TextBox();
            this.btnWróć = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataDokumentu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxOpis);
            this.groupBox1.Controls.Add(this.textBoxWartosc);
            this.groupBox1.Controls.Add(this.textBoxNrDokumentu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dokument";
            // 
            // dataDokumentu
            // 
            this.dataDokumentu.Location = new System.Drawing.Point(134, 98);
            this.dataDokumentu.Name = "dataDokumentu";
            this.dataDokumentu.Size = new System.Drawing.Size(200, 20);
            this.dataDokumentu.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opis:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wartość: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numer Dokumentu: ";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(134, 138);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(200, 100);
            this.textBoxOpis.TabIndex = 3;
            // 
            // textBoxWartosc
            // 
            this.textBoxWartosc.Location = new System.Drawing.Point(134, 58);
            this.textBoxWartosc.Name = "textBoxWartosc";
            this.textBoxWartosc.Size = new System.Drawing.Size(200, 20);
            this.textBoxWartosc.TabIndex = 2;
            this.textBoxWartosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNrDokumentu
            // 
            this.textBoxNrDokumentu.Location = new System.Drawing.Point(134, 19);
            this.textBoxNrDokumentu.Name = "textBoxNrDokumentu";
            this.textBoxNrDokumentu.Size = new System.Drawing.Size(200, 20);
            this.textBoxNrDokumentu.TabIndex = 0;
            // 
            // btnWróć
            // 
            this.btnWróć.Location = new System.Drawing.Point(12, 267);
            this.btnWróć.Name = "btnWróć";
            this.btnWróć.Size = new System.Drawing.Size(127, 23);
            this.btnWróć.TabIndex = 1;
            this.btnWróć.Text = "Wróć";
            this.btnWróć.UseVisualStyleBackColor = true;
            this.btnWróć.Click += new System.EventHandler(this.btnWróć_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(233, 267);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(127, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Zatwierdź";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // EdytujDokumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 298);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnWróć);
            this.Controls.Add(this.groupBox1);
            this.Name = "EdytujDokumentForm";
            this.Text = "Edytuj dokument";
            this.Load += new System.EventHandler(this.DodajDokumentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dataDokumentu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.TextBox textBoxWartosc;
        private System.Windows.Forms.TextBox textBoxNrDokumentu;
        private System.Windows.Forms.Button btnWróć;
        private System.Windows.Forms.Button btnDodaj;
    }
}