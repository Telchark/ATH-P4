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
    public partial class EdytujDokumentForm : Form
    {
        private DokumentyFrom f1;
        public EdytujDokumentForm(DokumentyFrom ParentForm)
        {
            InitializeComponent();
            f1 = ParentForm;
        }

        private void DodajDokumentForm_Load(object sender, EventArgs e)
        {
            textBoxNrDokumentu.Text = Regex.Replace(f1.NrDokumentu, @"\s+", "");
            textBoxNrDokumentu.Enabled = false;
            dataDokumentu.Value = f1.Data;
            textBoxWartosc.Text = Regex.Replace(Math.Round(f1.Wartosc,2).ToString(), @"\s+", "");
            textBoxOpis.Text = Regex.Replace(f1.Opis, @"\s+", "");
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(textBoxWartosc.Text, @"^\d+(?:[\.\,]\d+)?$") &&Math.Round(Decimal.Parse(textBoxWartosc.Text),2)>0))
            {
                var db = new SrodkiTrwaleEntities();
                var q = db.Dokument
                    .Where(x => x.NrDokumentu == f1.NrDokumentu).First<Dokument>();
                q.Data = dataDokumentu.Value;
                q.Kwota = decimal.Parse(textBoxWartosc.Text);
                q.Opis = textBoxOpis.Text;
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
