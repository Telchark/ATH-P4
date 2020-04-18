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
    public partial class DodajDokumentForm : Form
    {
        public DodajDokumentForm()
        {
            InitializeComponent();
        }

        private void DodajDokumentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(textBoxWartosc.Text, @"^\d+(?:[\.\,]\d+)?$") &&Math.Round(Decimal.Parse(textBoxWartosc.Text),2)>0))
  
            {
                var db = new SrodkiTrwaleEntities();
                db.Dokument.Add(new Dokument { NrDokumentu=textBoxNrDokumentu.Text, Data=dataDokumentu.Value, Kwota= Math.Round(Decimal.Parse(textBoxWartosc.Text), 2), Opis=textBoxOpis.Text });
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
