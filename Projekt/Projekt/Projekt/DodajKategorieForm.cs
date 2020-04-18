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
    public partial class DodajKategorieForm : Form
    {
        public DodajKategorieForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(textBoxNazwa.Text, @"^[\s\p{L}]+$")))
            {
                var db = new SrodkiTrwaleEntities();
                db.Kategoria.Add(new Kategoria { NazwaKategorii=textBoxNazwa.Text, OpisKategorii=textBoxOpis.Text });
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
    }
}
