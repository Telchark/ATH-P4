namespace Projekt
{
    partial class DodajKlasyfikacjeForm
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
            this.textBoxGrupa = new System.Windows.Forms.TextBox();
            this.textBoxPodgrupa = new System.Windows.Forms.TextBox();
            this.textBoxRodzaj = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.lblGrupa = new System.Windows.Forms.Label();
            this.lblPodgrupa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWróć = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPodgrupa);
            this.groupBox1.Controls.Add(this.lblGrupa);
            this.groupBox1.Controls.Add(this.textBoxOpis);
            this.groupBox1.Controls.Add(this.textBoxRodzaj);
            this.groupBox1.Controls.Add(this.textBoxPodgrupa);
            this.groupBox1.Controls.Add(this.textBoxGrupa);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klasyfikacja";
            // 
            // textBoxGrupa
            // 
            this.textBoxGrupa.Location = new System.Drawing.Point(97, 19);
            this.textBoxGrupa.Name = "textBoxGrupa";
            this.textBoxGrupa.Size = new System.Drawing.Size(50, 20);
            this.textBoxGrupa.TabIndex = 1;
            // 
            // textBoxPodgrupa
            // 
            this.textBoxPodgrupa.Location = new System.Drawing.Point(97, 45);
            this.textBoxPodgrupa.Name = "textBoxPodgrupa";
            this.textBoxPodgrupa.Size = new System.Drawing.Size(50, 20);
            this.textBoxPodgrupa.TabIndex = 2;
            // 
            // textBoxRodzaj
            // 
            this.textBoxRodzaj.Location = new System.Drawing.Point(97, 71);
            this.textBoxRodzaj.Name = "textBoxRodzaj";
            this.textBoxRodzaj.Size = new System.Drawing.Size(50, 20);
            this.textBoxRodzaj.TabIndex = 3;
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(97, 99);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(209, 100);
            this.textBoxOpis.TabIndex = 4;
            // 
            // lblGrupa
            // 
            this.lblGrupa.AutoSize = true;
            this.lblGrupa.Location = new System.Drawing.Point(7, 19);
            this.lblGrupa.Name = "lblGrupa";
            this.lblGrupa.Size = new System.Drawing.Size(39, 13);
            this.lblGrupa.TabIndex = 5;
            this.lblGrupa.Text = "Grupa:";
            // 
            // lblPodgrupa
            // 
            this.lblPodgrupa.AutoSize = true;
            this.lblPodgrupa.Location = new System.Drawing.Point(7, 45);
            this.lblPodgrupa.Name = "lblPodgrupa";
            this.lblPodgrupa.Size = new System.Drawing.Size(56, 13);
            this.lblPodgrupa.TabIndex = 6;
            this.lblPodgrupa.Text = "Podgrupa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rodzaj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opis:";
            // 
            // btnWróć
            // 
            this.btnWróć.Location = new System.Drawing.Point(12, 234);
            this.btnWróć.Name = "btnWróć";
            this.btnWróć.Size = new System.Drawing.Size(127, 23);
            this.btnWróć.TabIndex = 1;
            this.btnWróć.Text = "Wróć";
            this.btnWróć.UseVisualStyleBackColor = true;
            this.btnWróć.Click += new System.EventHandler(this.btnWróć_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(198, 234);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(127, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajKlasyfikacjęForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 265);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnWróć);
            this.Controls.Add(this.groupBox1);
            this.Name = "DodajKlasyfikacjęForm";
            this.Text = "Dodaj Klasyfikację";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.TextBox textBoxRodzaj;
        private System.Windows.Forms.TextBox textBoxPodgrupa;
        private System.Windows.Forms.TextBox textBoxGrupa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPodgrupa;
        private System.Windows.Forms.Label lblGrupa;
        private System.Windows.Forms.Button btnWróć;
        private System.Windows.Forms.Button btnDodaj;
    }
}