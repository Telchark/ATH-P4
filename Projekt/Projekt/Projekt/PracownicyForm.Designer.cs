namespace Projekt
{
    partial class PracownicyForm
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
            this.dataGridViewPracownicy = new System.Windows.Forms.DataGridView();
            this.btnDodajPracownika = new System.Windows.Forms.Button();
            this.btnWłączEdycję = new System.Windows.Forms.Button();
            this.btnWróć = new System.Windows.Forms.Button();
            this.btnUsuń = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPracownicy
            // 
            this.dataGridViewPracownicy.AllowUserToAddRows = false;
            this.dataGridViewPracownicy.AllowUserToDeleteRows = false;
            this.dataGridViewPracownicy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPracownicy.Location = new System.Drawing.Point(167, 13);
            this.dataGridViewPracownicy.Name = "dataGridViewPracownicy";
            this.dataGridViewPracownicy.ReadOnly = true;
            this.dataGridViewPracownicy.Size = new System.Drawing.Size(543, 283);
            this.dataGridViewPracownicy.TabIndex = 0;
            // 
            // btnDodajPracownika
            // 
            this.btnDodajPracownika.Location = new System.Drawing.Point(13, 13);
            this.btnDodajPracownika.Name = "btnDodajPracownika";
            this.btnDodajPracownika.Size = new System.Drawing.Size(148, 30);
            this.btnDodajPracownika.TabIndex = 1;
            this.btnDodajPracownika.Text = "Dodaj";
            this.btnDodajPracownika.UseVisualStyleBackColor = true;
            this.btnDodajPracownika.Click += new System.EventHandler(this.btnDodajPracownika_Click);
            // 
            // btnWłączEdycję
            // 
            this.btnWłączEdycję.Location = new System.Drawing.Point(13, 49);
            this.btnWłączEdycję.Name = "btnWłączEdycję";
            this.btnWłączEdycję.Size = new System.Drawing.Size(148, 30);
            this.btnWłączEdycję.TabIndex = 2;
            this.btnWłączEdycję.Text = "Edytuj wybrane rekordy";
            this.btnWłączEdycję.UseVisualStyleBackColor = true;
            this.btnWłączEdycję.Click += new System.EventHandler(this.btnWłączEdycję_Click);
            // 
            // btnWróć
            // 
            this.btnWróć.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWróć.Location = new System.Drawing.Point(12, 263);
            this.btnWróć.Name = "btnWróć";
            this.btnWróć.Size = new System.Drawing.Size(148, 34);
            this.btnWróć.TabIndex = 4;
            this.btnWróć.Text = "Wróć";
            this.btnWróć.UseVisualStyleBackColor = true;
            this.btnWróć.Click += new System.EventHandler(this.btnWróć_Click);
            // 
            // btnUsuń
            // 
            this.btnUsuń.Location = new System.Drawing.Point(13, 85);
            this.btnUsuń.Name = "btnUsuń";
            this.btnUsuń.Size = new System.Drawing.Size(148, 30);
            this.btnUsuń.TabIndex = 5;
            this.btnUsuń.Text = "Usuń zaznaczone rekordy";
            this.btnUsuń.UseVisualStyleBackColor = true;
            this.btnUsuń.Click += new System.EventHandler(this.btnUsuń_Click);
            // 
            // PracownicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 308);
            this.Controls.Add(this.btnUsuń);
            this.Controls.Add(this.btnWróć);
            this.Controls.Add(this.btnWłączEdycję);
            this.Controls.Add(this.btnDodajPracownika);
            this.Controls.Add(this.dataGridViewPracownicy);
            this.Name = "PracownicyForm";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.PracownicyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPracownicy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPracownicy;
        private System.Windows.Forms.Button btnDodajPracownika;
        private System.Windows.Forms.Button btnWłączEdycję;
        private System.Windows.Forms.Button btnWróć;
        private System.Windows.Forms.Button btnUsuń;
    }
}