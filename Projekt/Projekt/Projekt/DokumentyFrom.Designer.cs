namespace Projekt
{
    partial class DokumentyFrom
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsuń = new System.Windows.Forms.Button();
            this.btnWróć = new System.Windows.Forms.Button();
            this.dataGridViewDokumenty = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDokumenty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(148, 30);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(12, 48);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(148, 30);
            this.btnEdytuj.TabIndex = 1;
            this.btnEdytuj.Text = "Edytuj wybrany rekord";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsuń
            // 
            this.btnUsuń.Location = new System.Drawing.Point(12, 84);
            this.btnUsuń.Name = "btnUsuń";
            this.btnUsuń.Size = new System.Drawing.Size(148, 30);
            this.btnUsuń.TabIndex = 2;
            this.btnUsuń.Text = "Usuń wybrane rekordy";
            this.btnUsuń.UseVisualStyleBackColor = true;
            this.btnUsuń.Click += new System.EventHandler(this.btnUsuń_Click);
            // 
            // btnWróć
            // 
            this.btnWróć.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWróć.Location = new System.Drawing.Point(12, 232);
            this.btnWróć.Name = "btnWróć";
            this.btnWróć.Size = new System.Drawing.Size(148, 30);
            this.btnWróć.TabIndex = 3;
            this.btnWróć.Text = "Wróć";
            this.btnWróć.UseVisualStyleBackColor = true;
            this.btnWróć.Click += new System.EventHandler(this.btnWróć_Click);
            // 
            // dataGridViewDokumenty
            // 
            this.dataGridViewDokumenty.AllowUserToAddRows = false;
            this.dataGridViewDokumenty.AllowUserToDeleteRows = false;
            this.dataGridViewDokumenty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDokumenty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDokumenty.Location = new System.Drawing.Point(166, 12);
            this.dataGridViewDokumenty.Name = "dataGridViewDokumenty";
            this.dataGridViewDokumenty.ReadOnly = true;
            this.dataGridViewDokumenty.Size = new System.Drawing.Size(517, 250);
            this.dataGridViewDokumenty.TabIndex = 4;
            // 
            // DokumentyFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 274);
            this.Controls.Add(this.dataGridViewDokumenty);
            this.Controls.Add(this.btnWróć);
            this.Controls.Add(this.btnUsuń);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Name = "DokumentyFrom";
            this.Text = "Dokumenty";
            this.Load += new System.EventHandler(this.DokumentyFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDokumenty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsuń;
        private System.Windows.Forms.Button btnWróć;
        private System.Windows.Forms.DataGridView dataGridViewDokumenty;
    }
}