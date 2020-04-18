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
    public partial class EdytujPracownikaForm : Form
    {
        private PracownicyForm f1;
        public EdytujPracownikaForm(PracownicyForm ParentForm)
        {
            InitializeComponent();
            f1 = ParentForm;
        }

        private void PracownicyForm_Load(object sender, EventArgs e)
        {
            textBoxImie.Text =Regex.Replace(f1.Imie, @"\s+", "");
            textBoxNazwisko.Text =Regex.Replace(f1.Nazwisko, @"\s+", "");
            textBoxPesel.Text =Regex.Replace(f1.Pesel, @"\s+", "");
            dataUrodzenia.Value = f1.DataUr.Value;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(textBoxImie.Text, @"^[\s\p{L}]+$")) && (Regex.IsMatch(textBoxNazwisko.Text, @"^[\s\p{L}]+$")) && (DateTime.Now.Year - dataUrodzenia.Value.Year >= 18) && (Regex.IsMatch(textBoxPesel.Text, @"^[0-9]+$") && textBoxPesel.Text.Length == 11))
            {
                var db = new SrodkiTrwaleEntities();
                var q = db.Pracownik
                    .Where(x => x.IdPracownika == f1.IdPracownika).First<Pracownik>();
                q.Imie = textBoxImie.Text;
                q.Nazwisko = textBoxNazwisko.Text;
                q.DataUr = dataUrodzenia.Value;
                q.PESEL = textBoxPesel.Text;
                db.SaveChanges();
                this.Close();
            }
            else
                MessageBox.Show("Błędne dane", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
