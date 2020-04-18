namespace Projekt
{
    partial class EdytujPracownikaForm
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
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.lblDataUr = new System.Windows.Forms.Label();
            this.lblImię = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblPesel = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(104, 28);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(200, 20);
            this.textBoxImie.TabIndex = 0;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(104, 70);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(200, 20);
            this.textBoxNazwisko.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataUrodzenia);
            this.groupBox1.Controls.Add(this.textBoxImie);
            this.groupBox1.Controls.Add(this.textBoxPesel);
            this.groupBox1.Controls.Add(this.textBoxNazwisko);
            this.groupBox1.Controls.Add(this.lblDataUr);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pracownik";
            // 
            // dataUrodzenia
            // 
            this.dataUrodzenia.Location = new System.Drawing.Point(104, 112);
            this.dataUrodzenia.Name = "dataUrodzenia";
            this.dataUrodzenia.Size = new System.Drawing.Size(200, 20);
            this.dataUrodzenia.TabIndex = 8;
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(104, 151);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(200, 20);
            this.textBoxPesel.TabIndex = 9;
            // 
            // lblDataUr
            // 
            this.lblDataUr.AutoSize = true;
            this.lblDataUr.Location = new System.Drawing.Point(25, 112);
            this.lblDataUr.Name = "lblDataUr";
            this.lblDataUr.Size = new System.Drawing.Size(82, 13);
            this.lblDataUr.TabIndex = 6;
            this.lblDataUr.Text = "Data urodzenia:";
            // 
            // lblImię
            // 
            this.lblImię.AutoSize = true;
            this.lblImię.Location = new System.Drawing.Point(37, 40);
            this.lblImię.Name = "lblImię";
            this.lblImię.Size = new System.Drawing.Size(29, 13);
            this.lblImię.TabIndex = 4;
            this.lblImię.Text = "Imię:";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Location = new System.Drawing.Point(37, 82);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(56, 13);
            this.lblNazwisko.TabIndex = 5;
            this.lblNazwisko.Text = "Nazwisko:";
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Location = new System.Drawing.Point(37, 166);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(44, 13);
            this.lblPesel.TabIndex = 7;
            this.lblPesel.Text = "PESEL:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(205, 207);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(127, 23);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Zatwierdź";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(12, 207);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(127, 23);
            this.btnAnuluj.TabIndex = 9;
            this.btnAnuluj.Text = "Wróć";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // EdytujPracownikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 241);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblPesel);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImię);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 280);
            this.Name = "EdytujPracownikaForm";
            this.Text = "Edytuj pracownika";
            this.Load += new System.EventHandler(this.PracownicyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dataUrodzenia;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Label lblImię;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblDataUr;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}