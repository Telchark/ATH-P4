namespace Zombie
{
    partial class formZombie
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
            this.tBZombies = new System.Windows.Forms.TextBox();
            this.tBHumans = new System.Windows.Forms.TextBox();
            this.tBSoldiers = new System.Windows.Forms.TextBox();
            this.lblZombies = new System.Windows.Forms.Label();
            this.lblHumans = new System.Windows.Forms.Label();
            this.lblSoldiers = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNextTurn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBZombies
            // 
            this.tBZombies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBZombies.Location = new System.Drawing.Point(665, 34);
            this.tBZombies.Name = "tBZombies";
            this.tBZombies.Size = new System.Drawing.Size(31, 20);
            this.tBZombies.TabIndex = 0;
            // 
            // tBHumans
            // 
            this.tBHumans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBHumans.Location = new System.Drawing.Point(665, 60);
            this.tBHumans.Name = "tBHumans";
            this.tBHumans.Size = new System.Drawing.Size(31, 20);
            this.tBHumans.TabIndex = 1;
            // 
            // tBSoldiers
            // 
            this.tBSoldiers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSoldiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBSoldiers.Location = new System.Drawing.Point(665, 87);
            this.tBSoldiers.Name = "tBSoldiers";
            this.tBSoldiers.Size = new System.Drawing.Size(31, 20);
            this.tBSoldiers.TabIndex = 2;
            // 
            // lblZombies
            // 
            this.lblZombies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZombies.AutoSize = true;
            this.lblZombies.Location = new System.Drawing.Point(582, 34);
            this.lblZombies.Name = "lblZombies";
            this.lblZombies.Size = new System.Drawing.Size(68, 13);
            this.lblZombies.TabIndex = 3;
            this.lblZombies.Text = "Ilość zombie:";
            // 
            // lblHumans
            // 
            this.lblHumans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHumans.AutoSize = true;
            this.lblHumans.Location = new System.Drawing.Point(582, 60);
            this.lblHumans.Name = "lblHumans";
            this.lblHumans.Size = new System.Drawing.Size(56, 13);
            this.lblHumans.TabIndex = 4;
            this.lblHumans.Text = "Ilość ludzi:";
            // 
            // lblSoldiers
            // 
            this.lblSoldiers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoldiers.AutoSize = true;
            this.lblSoldiers.Location = new System.Drawing.Point(582, 87);
            this.lblSoldiers.Name = "lblSoldiers";
            this.lblSoldiers.Size = new System.Drawing.Size(77, 13);
            this.lblSoldiers.TabIndex = 5;
            this.lblSoldiers.Text = "Ilość żołnierzy:";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(604, 117);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnNextTurn
            // 
            this.btnNextTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextTurn.Location = new System.Drawing.Point(585, 161);
            this.btnNextTurn.Name = "btnNextTurn";
            this.btnNextTurn.Size = new System.Drawing.Size(111, 33);
            this.btnNextTurn.TabIndex = 7;
            this.btnNextTurn.Text = "Następna tura";
            this.btnNextTurn.UseVisualStyleBackColor = true;
            this.btnNextTurn.Click += new System.EventHandler(this.btnNextTurn_Click);
            // 
            // formZombie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 531);
            this.Controls.Add(this.btnNextTurn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSoldiers);
            this.Controls.Add(this.lblHumans);
            this.Controls.Add(this.lblZombies);
            this.Controls.Add(this.tBSoldiers);
            this.Controls.Add(this.tBHumans);
            this.Controls.Add(this.tBZombies);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "formZombie";
            this.Text = "Zombie Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBZombies;
        private System.Windows.Forms.TextBox tBHumans;
        private System.Windows.Forms.TextBox tBSoldiers;
        private System.Windows.Forms.Label lblZombies;
        private System.Windows.Forms.Label lblHumans;
        private System.Windows.Forms.Label lblSoldiers;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNextTurn;
    }
}

