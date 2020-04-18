namespace Projekt
{
    partial class DodajSrodekTrwalyForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxPrzyczyna = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxOsobaOdp = new System.Windows.Forms.ComboBox();
            this.comboBoxDokument = new System.Windows.Forms.ComboBox();
            this.comboBoxKŚT = new System.Windows.Forms.ComboBox();
            this.dataLikwidacji = new System.Windows.Forms.DateTimePicker();
            this.dataZakupu = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMiejsce = new System.Windows.Forms.TextBox();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxMetoda = new System.Windows.Forms.ComboBox();
            this.textBoxWspolczynnikAmortyzacji = new System.Windows.Forms.TextBox();
            this.textBoxStawkaAmortyzacji = new System.Windows.Forms.TextBox();
            this.textBoxWartoscPoczatkowa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataRozpAmor = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkedListBoxMiesiace = new System.Windows.Forms.CheckedListBox();
            this.btnWróć = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 322);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxPrzyczyna);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.comboBoxKategoria);
            this.tabPage1.Controls.Add(this.comboBoxOsobaOdp);
            this.tabPage1.Controls.Add(this.comboBoxDokument);
            this.tabPage1.Controls.Add(this.comboBoxKŚT);
            this.tabPage1.Controls.Add(this.dataLikwidacji);
            this.tabPage1.Controls.Add(this.dataZakupu);
            this.tabPage1.Controls.Add(this.comboBoxStan);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxMiejsce);
            this.tabPage1.Controls.Add(this.textBoxNazwa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Środek Trwały";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxPrzyczyna
            // 
            this.textBoxPrzyczyna.Location = new System.Drawing.Point(207, 230);
            this.textBoxPrzyczyna.Multiline = true;
            this.textBoxPrzyczyna.Name = "textBoxPrzyczyna";
            this.textBoxPrzyczyna.Size = new System.Drawing.Size(200, 60);
            this.textBoxPrzyczyna.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Przyczyna zbycia:";
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Location = new System.Drawing.Point(207, 28);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKategoria.TabIndex = 19;
            // 
            // comboBoxOsobaOdp
            // 
            this.comboBoxOsobaOdp.FormattingEnabled = true;
            this.comboBoxOsobaOdp.Location = new System.Drawing.Point(207, 78);
            this.comboBoxOsobaOdp.Name = "comboBoxOsobaOdp";
            this.comboBoxOsobaOdp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOsobaOdp.TabIndex = 18;
            // 
            // comboBoxDokument
            // 
            this.comboBoxDokument.FormattingEnabled = true;
            this.comboBoxDokument.Location = new System.Drawing.Point(207, 103);
            this.comboBoxDokument.Name = "comboBoxDokument";
            this.comboBoxDokument.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDokument.TabIndex = 17;
            // 
            // comboBoxKŚT
            // 
            this.comboBoxKŚT.FormattingEnabled = true;
            this.comboBoxKŚT.Location = new System.Drawing.Point(207, 53);
            this.comboBoxKŚT.Name = "comboBoxKŚT";
            this.comboBoxKŚT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKŚT.TabIndex = 16;
            // 
            // dataLikwidacji
            // 
            this.dataLikwidacji.Location = new System.Drawing.Point(207, 203);
            this.dataLikwidacji.Name = "dataLikwidacji";
            this.dataLikwidacji.Size = new System.Drawing.Size(200, 20);
            this.dataLikwidacji.TabIndex = 15;
            // 
            // dataZakupu
            // 
            this.dataZakupu.Location = new System.Drawing.Point(207, 178);
            this.dataZakupu.Name = "dataZakupu";
            this.dataZakupu.Size = new System.Drawing.Size(200, 20);
            this.dataZakupu.TabIndex = 14;
            // 
            // comboBoxStan
            // 
            this.comboBoxStan.FormattingEnabled = true;
            this.comboBoxStan.Items.AddRange(new object[] {
            "Zlikwidowany",
            "Zbyty",
            "W użyciu"});
            this.comboBoxStan.Location = new System.Drawing.Point(207, 128);
            this.comboBoxStan.Name = "comboBoxStan";
            this.comboBoxStan.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStan.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Data likwidacji:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Data zakupu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Miejsce użytkowania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stan:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dokument:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Osoba odpowiedzialna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "KŚT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa:";
            // 
            // textBoxMiejsce
            // 
            this.textBoxMiejsce.Location = new System.Drawing.Point(207, 153);
            this.textBoxMiejsce.Name = "textBoxMiejsce";
            this.textBoxMiejsce.Size = new System.Drawing.Size(121, 20);
            this.textBoxMiejsce.TabIndex = 3;
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(207, 3);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(121, 20);
            this.textBoxNazwa.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxMetoda);
            this.tabPage2.Controls.Add(this.textBoxWspolczynnikAmortyzacji);
            this.tabPage2.Controls.Add(this.textBoxStawkaAmortyzacji);
            this.tabPage2.Controls.Add(this.textBoxWartoscPoczatkowa);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataRozpAmor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Amortyzacja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxMetoda
            // 
            this.comboBoxMetoda.FormattingEnabled = true;
            this.comboBoxMetoda.Location = new System.Drawing.Point(169, 211);
            this.comboBoxMetoda.Name = "comboBoxMetoda";
            this.comboBoxMetoda.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMetoda.TabIndex = 9;
            // 
            // textBoxWspolczynnikAmortyzacji
            // 
            this.textBoxWspolczynnikAmortyzacji.Location = new System.Drawing.Point(169, 159);
            this.textBoxWspolczynnikAmortyzacji.Name = "textBoxWspolczynnikAmortyzacji";
            this.textBoxWspolczynnikAmortyzacji.Size = new System.Drawing.Size(200, 20);
            this.textBoxWspolczynnikAmortyzacji.TabIndex = 8;
            this.textBoxWspolczynnikAmortyzacji.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxStawkaAmortyzacji
            // 
            this.textBoxStawkaAmortyzacji.Location = new System.Drawing.Point(169, 104);
            this.textBoxStawkaAmortyzacji.Name = "textBoxStawkaAmortyzacji";
            this.textBoxStawkaAmortyzacji.Size = new System.Drawing.Size(200, 20);
            this.textBoxStawkaAmortyzacji.TabIndex = 7;
            this.textBoxStawkaAmortyzacji.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxWartoscPoczatkowa
            // 
            this.textBoxWartoscPoczatkowa.Location = new System.Drawing.Point(169, 55);
            this.textBoxWartoscPoczatkowa.Name = "textBoxWartoscPoczatkowa";
            this.textBoxWartoscPoczatkowa.Size = new System.Drawing.Size(200, 20);
            this.textBoxWartoscPoczatkowa.TabIndex = 6;
            this.textBoxWartoscPoczatkowa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Metoda amortyzacji:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Współczynnik amortyzacji:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Stawka amortyzacji:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Wartość początkowa:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Data rozpoczęcia amortyzacji:";
            // 
            // dataRozpAmor
            // 
            this.dataRozpAmor.Location = new System.Drawing.Point(169, 3);
            this.dataRozpAmor.Name = "dataRozpAmor";
            this.dataRozpAmor.Size = new System.Drawing.Size(200, 20);
            this.dataRozpAmor.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkedListBoxMiesiace);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(413, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sezonowość";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxMiesiace
            // 
            this.checkedListBoxMiesiace.FormattingEnabled = true;
            this.checkedListBoxMiesiace.Items.AddRange(new object[] {
            "Styczeń",
            "Luty",
            "Marzec",
            "Kwiecień",
            "Maj",
            "Czerwiec",
            "Lipiec",
            "Sierpień",
            "Wrzesień",
            "Październik",
            "Listopad",
            "Grudzień"});
            this.checkedListBoxMiesiace.Location = new System.Drawing.Point(6, 6);
            this.checkedListBoxMiesiace.Name = "checkedListBoxMiesiace";
            this.checkedListBoxMiesiace.Size = new System.Drawing.Size(85, 184);
            this.checkedListBoxMiesiace.TabIndex = 0;
            // 
            // btnWróć
            // 
            this.btnWróć.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWróć.Location = new System.Drawing.Point(12, 340);
            this.btnWróć.Name = "btnWróć";
            this.btnWróć.Size = new System.Drawing.Size(127, 23);
            this.btnWróć.TabIndex = 0;
            this.btnWróć.Text = "Wróć";
            this.btnWróć.UseVisualStyleBackColor = true;
            this.btnWróć.Click += new System.EventHandler(this.btnWróć_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodaj.Location = new System.Drawing.Point(302, 340);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(127, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajSrodekTrwalyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 375);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnWróć);
            this.Controls.Add(this.tabControl1);
            this.Name = "DodajSrodekTrwalyForm";
            this.Text = "Dodaj środek trwały";
            this.Load += new System.EventHandler(this.DodajSrodekTrwalyForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnWróć;
        private System.Windows.Forms.ComboBox comboBoxKategoria;
        private System.Windows.Forms.ComboBox comboBoxOsobaOdp;
        private System.Windows.Forms.ComboBox comboBoxDokument;
        private System.Windows.Forms.ComboBox comboBoxKŚT;
        private System.Windows.Forms.DateTimePicker dataLikwidacji;
        private System.Windows.Forms.DateTimePicker dataZakupu;
        private System.Windows.Forms.ComboBox comboBoxStan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMiejsce;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dataRozpAmor;
        private System.Windows.Forms.ComboBox comboBoxMetoda;
        private System.Windows.Forms.TextBox textBoxWspolczynnikAmortyzacji;
        private System.Windows.Forms.TextBox textBoxStawkaAmortyzacji;
        private System.Windows.Forms.TextBox textBoxWartoscPoczatkowa;
        private System.Windows.Forms.CheckedListBox checkedListBoxMiesiace;
        private System.Windows.Forms.TextBox textBoxPrzyczyna;
        private System.Windows.Forms.Label label15;
    }
}