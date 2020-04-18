using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class PracownicyForm : Form
    {
        public int IdPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime? DataUr { get; set; }
        public string Pesel { get; set; }
        public PracownicyForm()
        {
            InitializeComponent();
        }
        private void PracownicyForm_Load(object sender, EventArgs e)
        {
            var db = new SrodkiTrwaleEntities();
            var showAll = db.Pracownik.Select(x => new { x.IdPracownika, x.Imie, x.Nazwisko, x.DataUr, x.PESEL }).ToList();
            dataGridViewPracownicy.DataSource = showAll;
        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            var dodajPracownika = new DodajPracownikaForm();
            dodajPracownika.ShowDialog();
            var db = new SrodkiTrwaleEntities();
            var showAll = db.Pracownik.Select(x => new { x.IdPracownika, x.Imie, x.Nazwisko, x.DataUr, x.PESEL }).ToList();
            dataGridViewPracownicy.DataSource = showAll;
        }

        private void btnWróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWłączEdycję_Click(object sender, EventArgs e)
        {
            if (dataGridViewPracownicy.SelectedRows.Count > 0)
            {
                var db = new SrodkiTrwaleEntities();
                var wybrany = (int)dataGridViewPracownicy.SelectedRows[0].Cells[0].Value;
                var rekordDoEdycji = db.Pracownik.Select(x => new { x.IdPracownika, x.Imie, x.Nazwisko, x.DataUr, x.PESEL })
                    .Where(x => x.IdPracownika == wybrany).ToArray();
                IdPracownika = rekordDoEdycji[0].IdPracownika;
                Imie = rekordDoEdycji[0].Imie;
                Nazwisko = rekordDoEdycji[0].Nazwisko;
                DataUr = rekordDoEdycji[0].DataUr;
                Pesel = rekordDoEdycji[0].PESEL;
                var edytujPracownika = new EdytujPracownikaForm(this);
                edytujPracownika.ShowDialog();
                var showAll = db.Pracownik.Select(x => new { x.IdPracownika, x.Imie, x.Nazwisko, x.DataUr, x.PESEL }).ToList();
                dataGridViewPracownicy.DataSource = showAll;
            }
            else
                MessageBox.Show("Wybierz rekord", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUsuń_Click(object sender, EventArgs e)
        {
            if (dataGridViewPracownicy.SelectedRows.Count > 0)
            {
                var dialogRes = MessageBox.Show("Czy chcesz usunąć wybrane rekordy?", "", MessageBoxButtons.YesNo);
                if (dialogRes == DialogResult.Yes)
                {
                    var db = new SrodkiTrwaleEntities();
                    var usunPracownika = dataGridViewPracownicy.SelectedRows;
                    db.Configuration.ValidateOnSaveEnabled = false;
                    for (int i = 0; i < usunPracownika.Count; i++)
                    {
                        var remove = new Pracownik()
                        {
                            IdPracownika = (int)usunPracownika[i].Cells[0].Value,
                        };
                        db.Pracownik.Attach(remove);
                        db.Entry(remove).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    var q = db.Pracownik.Select(x => new { x.IdPracownika, x.Imie, x.Nazwisko, x.DataUr, x.PESEL }).ToList();
                    dataGridViewPracownicy.DataSource = q;
                }
            }
            else
                MessageBox.Show("Wybierz rekordy", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
