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

    public partial class KategorieForm: Form
    {
        public string NazwaKategorii { get; set; }
        public string OpisKategorii { get; set; }
        public KategorieForm()
        {
            InitializeComponent();
        }
        private void btnWróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajKategorię_Click(object sender, EventArgs e)
        {
            var dodajKategorie = new DodajKategorieForm();
            dodajKategorie.ShowDialog();
            var db = new SrodkiTrwaleEntities();
            var showAll = db.Kategoria.Select(x => new { x.NazwaKategorii, x.OpisKategorii }).ToList();
            dataGridViewKategorie.DataSource = showAll;
        }

        private void btnWłączEdycję_Click(object sender, EventArgs e)
        {
            if (dataGridViewKategorie.SelectedRows.Count > 0)
            {
                var db = new SrodkiTrwaleEntities();
            var wybrany = dataGridViewKategorie.SelectedRows[0].Cells[0].Value.ToString() ;
            var rekordDoEdycji = db.Kategoria.Select(x => new { x.NazwaKategorii, x.OpisKategorii })
                .Where(x=>x.NazwaKategorii==wybrany).ToArray();
            NazwaKategorii = rekordDoEdycji[0].NazwaKategorii;
            OpisKategorii = rekordDoEdycji[0].OpisKategorii;
            var edytujKategorie = new EdytujKategorieForm(this);
            edytujKategorie.ShowDialog();
            var showAll = db.Kategoria.Select(x => new { x.NazwaKategorii, x.OpisKategorii }).ToList();
                dataGridViewKategorie.DataSource = showAll;
            }
            else
                MessageBox.Show("Wybierz rekord", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnUsuń_Click(object sender, EventArgs e)
        {
            if (dataGridViewKategorie.SelectedRows.Count > 0)
            {
                var db = new SrodkiTrwaleEntities();
            var usunKategorie = dataGridViewKategorie.SelectedRows;
            db.Configuration.ValidateOnSaveEnabled = false;
            for (int i = 0; i < usunKategorie.Count; i++)
            {
                var remove = new Kategoria()
                {
                    NazwaKategorii = (string)usunKategorie[i].Cells[0].Value,
                };
                db.Kategoria.Attach(remove);
                db.Entry(remove).State = EntityState.Deleted;
                db.SaveChanges();
            }
            var q = db.Kategoria.Select(x => new { x.NazwaKategorii, x.OpisKategorii }).ToList();
            dataGridViewKategorie.DataSource = q;
            }
            else
                MessageBox.Show("Wybierz rekordy", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void KategorieForm_Load(object sender, EventArgs e)
        {
            var db = new SrodkiTrwaleEntities();
            var showAll = db.Kategoria.Select(x => new { x.NazwaKategorii, x.OpisKategorii }).ToList();
            dataGridViewKategorie.DataSource = showAll;
        }
    }
}
