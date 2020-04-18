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
    public partial class DodajSrodekTrwalyForm : Form
    {
        public DodajSrodekTrwalyForm()
        {
            InitializeComponent();
        }

        private void btnWróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajSrodekTrwalyForm_Load(object sender, EventArgs e)
        {
            var db = new SrodkiTrwaleEntities();
            var comboKategoriaQuery = db.Kategoria.Select(x => x.NazwaKategorii).ToArray();
            comboBoxKategoria.Items.AddRange(comboKategoriaQuery);
            var comboKlasyfikacjaQuery = db.KST.Select(x => x.Numer).Cast<string>().ToArray();
            comboBoxKŚT.Items.AddRange(comboKlasyfikacjaQuery);
            var comboDokumentQuery = db.Dokument.Select(x => x.NrDokumentu).Cast<string>().ToArray();
            comboBoxDokument.Items.AddRange(comboDokumentQuery);
            var comboPracownikQuery = db.Pracownik.Select(x => x.IdPracownika).Cast<string>().ToArray();
            comboBoxOsobaOdp.Items.AddRange(comboPracownikQuery);
            var comboMetodyQuery = db.MetodyAmortyzacji.Select(x => x.NazwaMetody).Cast<string>().ToArray();
            comboBoxMetoda.Items.AddRange(comboMetodyQuery);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(textBoxNazwa.Text, @"^[\s\p{L}]+$"))
                && (Regex.IsMatch(textBoxWartoscPoczatkowa.Text, @"^\d+(?:[\.\,]\d+)?$") && Decimal.Parse(textBoxWartoscPoczatkowa.Text.Replace('.', ',')) > 0)
                && (Regex.IsMatch(textBoxWspolczynnikAmortyzacji.Text, @"^\d+(?:[\.\,]\d+)?$") && Double.Parse(textBoxWspolczynnikAmortyzacji.Text.Replace('.', ',')) > 0)
                && (Regex.IsMatch(textBoxStawkaAmortyzacji.Text, @"^\d+(?:[\.\,]\d+)?$") && Double.Parse(textBoxStawkaAmortyzacji.Text.Replace('.', ',')) > 0)
                )
            {
                var db = new SrodkiTrwaleEntities();
                var nowy = new SrodekTrwaly()
                {
                    NazwaSrodka = textBoxNazwa.Text,
                    KST = int.Parse((string)comboBoxKŚT.SelectedItem),
                    OsosbaOdp = int.Parse((string)comboBoxOsobaOdp.SelectedItem),
                    MiejsceUzytkowania = textBoxMiejsce.Text,
                    DataZakupu = dataZakupu.Value,
                    DataLikwidacji = (DateTime?)dataLikwidacji.Value,
                    Stan = (string)comboBoxStan.SelectedItem,
                    PrzyczynaZbycia = textBoxPrzyczyna.Text,
                    Kategoria = (string)comboBoxKategoria.SelectedItem,
                    Dokument = (string)comboBoxDokument.SelectedItem
                };

                db.SrodekTrwaly.Add(nowy);
                db.SaveChanges();
                var ids = db.SrodekTrwaly.Select(x => x.NrInwentarzowy).ToList();
                int curId = ids[ids.Count - 1];
                db.Amortyzacja.Add(new Amortyzacja
                {
                    NrInwentarzowy = curId,
                    DataRozpAmortyzacji = dataRozpAmor.Value,
                    WartoscPoczatkowa = Math.Round(Decimal.Parse(textBoxWartoscPoczatkowa.Text.Replace('.', ',')), 2),
                    StawkaAmortyzacji = Math.Round(Double.Parse(textBoxStawkaAmortyzacji.Text.Replace('.', ',')), 2),
                    WspolczynnikAmortyzacji = Math.Round(Double.Parse(textBoxWspolczynnikAmortyzacji.Text.Replace('.', ',')), 2),
                    MetodaAmortyzacji = (string)comboBoxMetoda.SelectedItem,
                });
                bool?[] miesiaceLista = new bool?[12];
                for (int i = 0; i < 12; i++)
                {
                    miesiaceLista[i] = false;
                }
                foreach (int indexChecked in checkedListBoxMiesiace.CheckedIndices)
                {
                    if (checkedListBoxMiesiace.GetItemCheckState(indexChecked).ToString() == "Checked")
                        miesiaceLista[indexChecked] = true;
                }
                db.Sezonowosc.Add(new Sezonowosc()
                {
                    NrInwentarzowy = curId,
                    Styczen = miesiaceLista[0],
                    Luty = miesiaceLista[1],
                    Marzec = miesiaceLista[2],
                    Kwiecien = miesiaceLista[3],
                    Maj = miesiaceLista[4],
                    Czerwiec = miesiaceLista[5],
                    Lipiec = miesiaceLista[6],
                    Sierpien = miesiaceLista[7],
                    Wrzesien = miesiaceLista[8],
                    Pazdziernik = miesiaceLista[9],
                    Listopad = miesiaceLista[10],
                    Grudzien = miesiaceLista[11],
                });
                db.SaveChanges();
                this.Close();
            }
            else
                MessageBox.Show("Błędne dane", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
