namespace Projekt
{
    partial class KategorieForm
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
            this.btnDodajKategorię = new System.Windows.Forms.Button();
            this.btnWłączEdycję = new System.Windows.Forms.Button();
            this.btnUsuń = new System.Windows.Forms.Button();
            this.btnWróć = new System.Windows.Forms.Button();
            this.dataGridViewKategorie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajKategorię
            // 
            this.btnDodajKategorię.Location = new System.Drawing.Point(12, 7);
            this.btnDodajKategorię.Name = "btnDodajKategorię";
            this.btnDodajKategorię.Size = new System.Drawing.Size(148, 30);
            this.btnDodajKategorię.TabIndex = 0;
            this.btnDodajKategorię.Text = "Dodaj";
            this.btnDodajKategorię.UseVisualStyleBackColor = true;
            this.btnDodajKategorię.Click += new System.EventHandler(this.btnDodajKategorię_Click);
            // 
            // btnWłączEdycję
            // 
            this.btnWłączEdycję.Location = new System.Drawing.Point(12, 43);
            this.btnWłączEdycję.Name = "btnWłączEdycję";
            this.btnWłączEdycję.Size = new System.Drawing.Size(148, 30);
            this.btnWłączEdycję.TabIndex = 1;
            this.btnWłączEdycję.Text = "Edytuj wybrany rekord";
            this.btnWłączEdycję.UseVisualStyleBackColor = true;
            this.btnWłączEdycję.Click += new System.EventHandler(this.btnWłączEdycję_Click);
            // 
            // btnUsuń
            // 
            this.btnUsuń.Location = new System.Drawing.Point(12, 79);
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
            this.btnWróć.Location = new System.Drawing.Point(12, 185);
            this.btnWróć.Name = "btnWróć";
            this.btnWróć.Size = new System.Drawing.Size(148, 30);
            this.btnWróć.TabIndex = 3;
            this.btnWróć.Text = "Wróć";
            this.btnWróć.UseVisualStyleBackColor = true;
            this.btnWróć.Click += new System.EventHandler(this.btnWróć_Click);
            // 
            // dataGridViewKategorie
            // 
            this.dataGridViewKategorie.AllowUserToAddRows = false;
            this.dataGridViewKategorie.AllowUserToDeleteRows = false;
            this.dataGridViewKategorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategorie.Location = new System.Drawing.Point(166, 7);
            this.dataGridViewKategorie.Name = "dataGridViewKategorie";
            this.dataGridViewKategorie.ReadOnly = true;
            this.dataGridViewKategorie.Size = new System.Drawing.Size(419, 208);
            this.dataGridViewKategorie.TabIndex = 4;
            // 
            // KategorieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 227);
            this.Controls.Add(this.dataGridViewKategorie);
            this.Controls.Add(this.btnWróć);
            this.Controls.Add(this.btnUsuń);
            this.Controls.Add(this.btnWłączEdycję);
            this.Controls.Add(this.btnDodajKategorię);
            this.MinimumSize = new System.Drawing.Size(559, 266);
            this.Name = "KategorieForm";
            this.Text = "Kategorie";
            this.Load += new System.EventHandler(this.KategorieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajKategorię;
        private System.Windows.Forms.Button btnWłączEdycję;
        private System.Windows.Forms.Button btnUsuń;
        private System.Windows.Forms.Button btnWróć;
        private System.Windows.Forms.DataGridView dataGridViewKategorie;
    }
}