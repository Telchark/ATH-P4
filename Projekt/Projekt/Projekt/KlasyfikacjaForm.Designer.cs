namespace Projekt
{
    partial class KlasyfikacjaForm
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
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnWróć = new System.Windows.Forms.Button();
            this.dataGridViewKlasyfikacje = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlasyfikacje)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 13);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(148, 30);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(12, 49);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(148, 30);
            this.btnEdytuj.TabIndex = 1;
            this.btnEdytuj.Text = "Edytuj wybrany rekord";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(12, 85);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(148, 30);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń wybrane rekordy";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnWróć
            // 
            this.btnWróć.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWróć.Location = new System.Drawing.Point(12, 235);
            this.btnWróć.Name = "btnWróć";
            this.btnWróć.Size = new System.Drawing.Size(148, 30);
            this.btnWróć.TabIndex = 3;
            this.btnWróć.Text = "Wróć";
            this.btnWróć.UseVisualStyleBackColor = true;
            this.btnWróć.Click += new System.EventHandler(this.btnWróć_Click);
            // 
            // dataGridViewKlasyfikacje
            // 
            this.dataGridViewKlasyfikacje.AllowUserToAddRows = false;
            this.dataGridViewKlasyfikacje.AllowUserToDeleteRows = false;
            this.dataGridViewKlasyfikacje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKlasyfikacje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlasyfikacje.Location = new System.Drawing.Point(166, 13);
            this.dataGridViewKlasyfikacje.Name = "dataGridViewKlasyfikacje";
            this.dataGridViewKlasyfikacje.ReadOnly = true;
            this.dataGridViewKlasyfikacje.Size = new System.Drawing.Size(515, 252);
            this.dataGridViewKlasyfikacje.TabIndex = 4;
            // 
            // KlasyfikacjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 277);
            this.Controls.Add(this.dataGridViewKlasyfikacje);
            this.Controls.Add(this.btnWróć);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Name = "KlasyfikacjaForm";
            this.Text = "Klasyfikacja Środków Trwałych";
            this.Load += new System.EventHandler(this.KlasyfikacjaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlasyfikacje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnWróć;
        private System.Windows.Forms.DataGridView dataGridViewKlasyfikacje;
    }
}