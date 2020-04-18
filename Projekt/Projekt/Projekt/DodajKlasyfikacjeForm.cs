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
    public partial class DodajKlasyfikacjeForm : Form
    {
        public DodajKlasyfikacjeForm()
        {
            InitializeComponent();
        }

        private void btnWróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(textBoxGrupa.Text, @"^[0-9]+$")&& textBoxGrupa.Text.Length==1) && (Regex.IsMatch(textBoxPodgrupa.Text, @"^[0-9]+$")&& textBoxPodgrupa.Text.Length == 1) && (Regex.IsMatch(textBoxRodzaj.Text, @"^[0-9]+$") && textBoxRodzaj.Text.Length == 1))
            {
                var db = new SrodkiTrwaleEntities();
                string numer = textBoxGrupa.Text + textBoxPodgrupa.Text + textBoxRodzaj.Text;
                db.KST.Add(new KST {Numer=Int32.Parse(numer), Grupa = Int32.Parse(textBoxGrupa.Text), Podgrupa = Int32.Parse(textBoxPodgrupa.Text), Rodzaj = Int32.Parse(textBoxRodzaj.Text), Opis = textBoxOpis.Text });
                db.SaveChanges();
                this.Close();
            }
            else
                MessageBox.Show("Błędne dane", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
