using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class EdytujKategorieForm : Form
    {
        private KategorieForm f1;
        public EdytujKategorieForm(KategorieForm ParentForm)
        {
            InitializeComponent();
            f1 = ParentForm;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(textBoxNazwa.Text, @"^[\s\p{L}]+$")))
            {
                var db = new SrodkiTrwaleEntities();
                var q = db.Kategoria
                    .Where(x => x.NazwaKategorii == f1.NazwaKategorii).First<Kategoria>();
                q.OpisKategorii = textBoxOpis.Text;
                db.SaveChanges();
                this.Close();
            }
            else
                MessageBox.Show("Błędne dane", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnWróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EdytujKategorieForm_Load(object sender, EventArgs e)
        {
            textBoxNazwa.Text = f1.NazwaKategorii;
            textBoxNazwa.Enabled = false;
            textBoxOpis.Text = Regex.Replace(f1.OpisKategorii, @"\s+", "");
        }
    }
}
