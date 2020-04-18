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
    public partial class KlasyfikacjaForm : Form
    {
        public int Numer { get; set; }
        public int Grupa { get; set; }
        public int Podgrupa { get; set; }
        public int Rodzaj { get; set; }
        public string OpisKlasyfikacji { get; set; }
        public KlasyfikacjaForm()
        {
            InitializeComponent();
        }

        private void btnWróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (dataGridViewKlasyfikacje.SelectedRows.Count > 0)
            {
                var dialogRes = MessageBox.Show("Czy chcesz usunąć wybrane rekordy?", "", MessageBoxButtons.YesNo);
                if (dialogRes == DialogResult.Yes)
                {
                    var db = new SrodkiTrwaleEntities();
                    var usunKlasyfikacje = dataGridViewKlasyfikacje.SelectedRows;
                    db.Configuration.ValidateOnSaveEnabled = false;
                    for (int i = 0; i < usunKlasyfikacje.Count; i++)
                    {
                        var remove = new KST()
                        {
                            Numer = (int)usunKlasyfikacje[i].Cells[0].Value
                        };
                        db.KST.Attach(remove);
                        db.Entry(remove).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    var q = db.KST.Select(x => new { x.Numer, x.Grupa, x.Podgrupa, x.Rodzaj, x.Opis }).ToList();
                    dataGridViewKlasyfikacje.DataSource = q;
                }
            }
            else
                MessageBox.Show("Wybierz rekordy", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajKlasyfikacje = new DodajKlasyfikacjeForm();
            dodajKlasyfikacje.ShowDialog();
            var db = new SrodkiTrwaleEntities();
            var q = db.KST.Select(x => new { x.Numer, x.Grupa, x.Podgrupa, x.Rodzaj, x.Opis }).ToList();
            dataGridViewKlasyfikacje.DataSource = q;
        }

        private void KlasyfikacjaForm_Load(object sender, EventArgs e)
        {
            var db = new SrodkiTrwaleEntities();
            var q = db.KST.Select(x => new { x.Numer, x.Grupa, x.Podgrupa, x.Rodzaj, x.Opis }).ToList();
            dataGridViewKlasyfikacje.DataSource = q;
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (dataGridViewKlasyfikacje.SelectedRows.Count > 0)
            {
                var db = new SrodkiTrwaleEntities();
            var wybrany = (int)dataGridViewKlasyfikacje.SelectedRows[0].Cells[0].Value;
            var rekordDoEdycji = db.KST.Select(x => new { x.Numer, x.Rodzaj,x.Grupa,x.Podgrupa,x.Opis }).Where(x => x.Numer==wybrany).ToArray();
            Numer = rekordDoEdycji[0].Numer;
            Grupa = rekordDoEdycji[0].Grupa;
            Podgrupa = rekordDoEdycji[0].Podgrupa;
            Rodzaj = rekordDoEdycji[0].Rodzaj;
            OpisKlasyfikacji = rekordDoEdycji[0].Opis;
            var edytujKlasyfikacje = new EdytujKlasyfikacjeForm(this);
            edytujKlasyfikacje.ShowDialog();
            var q = db.KST.Select(x => new { x.Numer, x.Grupa, x.Podgrupa, x.Rodzaj, x.Opis }).ToList();
            dataGridViewKlasyfikacje.DataSource = q;
            }
            else
                MessageBox.Show("Wybierz rekord", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
