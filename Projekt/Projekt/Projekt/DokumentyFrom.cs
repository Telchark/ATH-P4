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
    public partial class DokumentyFrom : Form
    {
        public string NrDokumentu { get; set; }
        public DateTime Data { get; set; }
        public decimal Wartosc { get; set; }
        public string Opis { get; set; }
        public DokumentyFrom()
        {
            InitializeComponent();
        }

        private void btnUsuń_Click(object sender, EventArgs e)
        {
            if (dataGridViewDokumenty.SelectedRows.Count > 0)
            {
                var dialogRes = MessageBox.Show("Czy chcesz usunąć wybrane rekordy?", "", MessageBoxButtons.YesNo);
                if (dialogRes == DialogResult.Yes)
                {
                    var db = new SrodkiTrwaleEntities();
                    var usunDokument = dataGridViewDokumenty.SelectedRows;
                    db.Configuration.ValidateOnSaveEnabled = false;
                    for (int i = 0; i < usunDokument.Count; i++)
                    {
                        var remove = new Dokument()
                        {
                            NrDokumentu = (string)usunDokument[i].Cells[0].Value,
                        };
                        db.Dokument.Attach(remove);
                        db.Entry(remove).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    var showAll = db.Dokument.Select(x => new { x.NrDokumentu, x.Data, x.Kwota, x.Opis }).ToList();
                    dataGridViewDokumenty.DataSource = showAll;
                    dataGridViewDokumenty.Columns[2].DefaultCellStyle.Format = "N2";
                }
            }
            else
                MessageBox.Show("Wybierz rekordy", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void DokumentyFrom_Load(object sender, EventArgs e)
        {
            var db = new SrodkiTrwaleEntities();
            var showAll = db.Dokument.Select(x => new { x.NrDokumentu, x.Data, x.Kwota, x.Opis }).ToList();
            dataGridViewDokumenty.DataSource = showAll;
            dataGridViewDokumenty.Columns[2].DefaultCellStyle.Format = "N2";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajDokument = new DodajDokumentForm();
            dodajDokument.ShowDialog();
            var db = new SrodkiTrwaleEntities();
            var showAll = db.Dokument.Select(x => new { x.NrDokumentu, x.Kwota, x.Data, x.Opis }).ToList();
            dataGridViewDokumenty.DataSource = showAll;
            dataGridViewDokumenty.Columns[2].DefaultCellStyle.Format = "N2";
        }

        private void btnWróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (dataGridViewDokumenty.SelectedRows.Count > 0)
            {
                var db = new SrodkiTrwaleEntities();
                var wybrany = dataGridViewDokumenty.SelectedRows[0].Cells[0].Value.ToString();
                var rekordDoEdycji = db.Dokument.Select(x => new { x.NrDokumentu, x.Data, x.Kwota, x.Opis })
                    .Where(x => x.NrDokumentu == wybrany).ToArray();
                NrDokumentu = rekordDoEdycji[0].NrDokumentu;
                Data = rekordDoEdycji[0].Data;
                Wartosc = rekordDoEdycji[0].Kwota;
                Opis = rekordDoEdycji[0].Opis;
                var edytujDokument = new EdytujDokumentForm(this);
                edytujDokument.ShowDialog();
                var showAll = db.Dokument.Select(x => new { x.NrDokumentu, x.Kwota, x.Data, x.Opis }).ToList();
                dataGridViewDokumenty.DataSource = showAll;
                dataGridViewDokumenty.Columns[2].DefaultCellStyle.Format = "N2";
            }
            else
                MessageBox.Show("Wybierz rekord", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
