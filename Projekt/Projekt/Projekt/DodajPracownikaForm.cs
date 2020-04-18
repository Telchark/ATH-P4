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
    public partial class DodajPracownikaForm : Form
    {
        public DodajPracownikaForm()
        {
            InitializeComponent();
        }

        private void PracownicyForm_Load(object sender, EventArgs e)
        {
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
                db.Pracownik.Add(new Pracownik { Imie = textBoxImie.Text, Nazwisko = textBoxNazwisko.Text, DataUr = dataUrodzenia.Value, PESEL = textBoxPesel.Text });
                db.SaveChanges();
                this.Close();
            }else
                MessageBox.Show("Błędne dane", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
