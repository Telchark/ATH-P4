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
    public partial class SrodkiTrwaleForm : Form
    {
        public int NrInwentarzowy { get; set; }
        public SrodkiTrwaleForm()
        {
            InitializeComponent();
        }

        private void btnDodajSrodek_Click(object sender, EventArgs e)
        {
            var dodajSrodek = new DodajSrodekTrwalyForm();
            dodajSrodek.ShowDialog();
            var db = new SrodkiTrwaleEntities();
            var showAll = db.SrodekTrwaly.Select(x => new { x.NazwaSrodka, x.NrInwentarzowy, x.KST, x.Kategoria, x.MiejsceUzytkowania, x.Dokument, x.DataZakupu, x.DataLikwidacji, x.Stan }).ToList();
            dataGridViewSrodkiTrwale.DataSource = showAll;
        }

        private void btnWróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SrodkiTrwaleForm_Load(object sender, EventArgs e)
        {
            var db = new SrodkiTrwaleEntities();
            var showAll = db.SrodekTrwaly.Select(x => new { x.NazwaSrodka, x.NrInwentarzowy, x.KST, x.Kategoria, x.MiejsceUzytkowania, x.Dokument, x.DataZakupu, x.DataLikwidacji, x.Stan }).ToList();
            dataGridViewSrodkiTrwale.DataSource = showAll;
        }

        private void btnUsuń_Click(object sender, EventArgs e)
        {
            if (dataGridViewSrodkiTrwale.SelectedRows.Count > 0)
            {
                var dialogRes = MessageBox.Show("Czy chcesz usunąć wybrane rekordy?", "", MessageBoxButtons.YesNo);
                if (dialogRes == DialogResult.Yes)
                {
                    var db = new SrodkiTrwaleEntities();
                    var usunSrodek = dataGridViewSrodkiTrwale.SelectedRows;
                    for (int i = 0; i < usunSrodek.Count; i++)
                    {
                        var id = (int)usunSrodek[i].Cells[1].Value;
                        var removeAm = db.Amortyzacja.Single(x => x.NrInwentarzowy == id);
                        db.Amortyzacja.Remove(removeAm);
                        db.SaveChanges();
                        var removeSz = db.Sezonowosc.Single(x => x.NrInwentarzowy == id);
                        db.Sezonowosc.Remove(removeSz);
                        db.SaveChanges();
                        var removeSt = db.SrodekTrwaly.Single(x => x.NrInwentarzowy == id);
                        db.SrodekTrwaly.Remove(removeSt);
                        db.SaveChanges();
                    }
                    var showAll = db.SrodekTrwaly.Select(x => new { x.NazwaSrodka, x.NrInwentarzowy, x.KST, x.Kategoria, x.MiejsceUzytkowania, x.Dokument, x.DataZakupu, x.DataLikwidacji, x.Stan }).ToList();
                    dataGridViewSrodkiTrwale.DataSource = showAll;
                }
            }
            else
                MessageBox.Show("Wybierz rekordy", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            var db = new SrodkiTrwaleEntities();
            if (dataGridViewSrodkiTrwale.SelectedRows.Count > 0)
            {
                var wybrany = (int)dataGridViewSrodkiTrwale.SelectedRows[0].Cells[1].Value;
                NrInwentarzowy = wybrany;
                var edytujSrodekTrwaly = new EdytujSrodekTrwalyForm(this);
                edytujSrodekTrwaly.ShowDialog();
                var showAll = db.SrodekTrwaly.Select(x => new { x.NazwaSrodka, x.NrInwentarzowy, x.KST, x.Kategoria, x.MiejsceUzytkowania, x.Dokument, x.DataZakupu, x.DataLikwidacji, x.Stan }).ToList();
                dataGridViewSrodkiTrwale.DataSource = showAll;
            }
            else
                MessageBox.Show("Wybierz rekord", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
