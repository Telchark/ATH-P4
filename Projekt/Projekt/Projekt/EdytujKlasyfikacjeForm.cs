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
    public partial class EdytujKlasyfikacjeForm : Form
    {
        private KlasyfikacjaForm f1;
        public EdytujKlasyfikacjeForm(KlasyfikacjaForm ParentForm)
        {
            InitializeComponent();
            f1 = ParentForm;
        }

        private void btnWróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(textBoxGrupa.Text, @"^[0-9]+$") && textBoxGrupa.Text.Length == 1) && (Regex.IsMatch(textBoxPodgrupa.Text, @"^[0-9]+$") && textBoxPodgrupa.Text.Length == 1) && (Regex.IsMatch(textBoxRodzaj.Text, @"^[0-9]+$") && textBoxRodzaj.Text.Length == 1))
            {
                var db = new SrodkiTrwaleEntities();
                var q = db.KST
                    .Where(x => x.Numer == f1.Numer).First<KST>();
                q.Opis = textBoxOpis.Text;
                db.SaveChanges();
                this.Close();
            }
            else
                MessageBox.Show("Błędne dane", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EdytujKlasyfikacjeForm_Load(object sender, EventArgs e)
        {
            textBoxGrupa.Text = f1.Grupa.ToString();
            textBoxGrupa.Enabled = false;
            textBoxPodgrupa.Text = f1.Podgrupa.ToString();
            textBoxPodgrupa.Enabled = false;
            textBoxRodzaj.Text = f1.Rodzaj.ToString();
            textBoxRodzaj.Enabled = false;
            textBoxOpis.Text = Regex.Replace(f1.OpisKlasyfikacji, @"\s+", "");
        }
    }
}
