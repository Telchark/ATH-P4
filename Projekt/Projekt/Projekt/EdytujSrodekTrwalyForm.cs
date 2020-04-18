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
    public partial class EdytujSrodekTrwalyForm : Form
    {
        private SrodkiTrwaleForm f1;
        public EdytujSrodekTrwalyForm(SrodkiTrwaleForm ParentForm)
        {
            InitializeComponent();
            f1 = ParentForm;
        }

        private void btnWróć_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajSrodekTrwalyForm_Load(object sender, EventArgs e)
        {
            var db = new SrodkiTrwaleEntities();
            var sTToEdit = db.SrodekTrwaly
                .Where(x => x.NrInwentarzowy == f1.NrInwentarzowy).FirstOrDefault<SrodekTrwaly>();
            textBoxNazwa.Text = Regex.Replace(sTToEdit.NazwaSrodka, @"\s+", "");
            var comboKategoriaQuery = db.Kategoria.Select(x => x.NazwaKategorii).ToArray();
            comboBoxKategoria.Items.AddRange(comboKategoriaQuery);
            comboBoxKategoria.SelectedItem = sTToEdit.Kategoria;
            var comboKlasyfikacjaQuery = db.KST.Select(x => x.Numer).Cast<string>().ToArray();
            comboBoxKŚT.Items.AddRange(comboKlasyfikacjaQuery);
            comboBoxKŚT.SelectedItem = sTToEdit.KST.ToString();
            var comboDokumentQuery = db.Dokument.Select(x => x.NrDokumentu).Cast<string>().ToArray();
            comboBoxDokument.Items.AddRange(comboDokumentQuery);
            comboBoxDokument.SelectedItem = sTToEdit.Dokument;
            var comboPracownikQuery = db.Pracownik.Select(x => x.IdPracownika).Cast<string>().ToArray();
            comboBoxOsobaOdp.Items.AddRange(comboPracownikQuery);
            comboBoxOsobaOdp.SelectedItem = sTToEdit.OsosbaOdp.ToString();
            comboBoxStan.SelectedItem = sTToEdit.Stan;
            textBoxMiejsce.Text = Regex.Replace(sTToEdit.MiejsceUzytkowania, @"\s+", "");
            dataZakupu.Value = sTToEdit.DataZakupu;
            dataLikwidacji.Value = (DateTime)sTToEdit.DataLikwidacji;
            textBoxPrzyczyna.Text = Regex.Replace(sTToEdit.PrzyczynaZbycia, @"\s+", "");

            var amorToEdit = db.Amortyzacja
                 .Where(x => x.NrInwentarzowy == f1.NrInwentarzowy).FirstOrDefault<Amortyzacja>();
            dataRozpAmor.Value = amorToEdit.DataRozpAmortyzacji;
            textBoxWartoscPoczatkowa.Text = amorToEdit.WartoscPoczatkowa.ToString();
            textBoxStawkaAmortyzacji.Text = amorToEdit.StawkaAmortyzacji.ToString();
            textBoxWspolczynnikAmortyzacji.Text = amorToEdit.WspolczynnikAmortyzacji.ToString();
            var comboMetodyQuery = db.MetodyAmortyzacji.Select(x => x.NazwaMetody).Cast<string>().ToArray();
            comboBoxMetoda.Items.AddRange(comboMetodyQuery);
            comboBoxMetoda.SelectedItem = amorToEdit.MetodaAmortyzacji;

            var seasonToEdit = db.Sezonowosc
                 .Where(x => x.NrInwentarzowy == f1.NrInwentarzowy).FirstOrDefault<Sezonowosc>();

            if (seasonToEdit.Styczen == true)
                checkedListBoxMiesiace.SetItemChecked(0, true);
            if (seasonToEdit.Luty == true)
                checkedListBoxMiesiace.SetItemChecked(1, true);
            if (seasonToEdit.Marzec == true)
                checkedListBoxMiesiace.SetItemChecked(2, true);
            if (seasonToEdit.Kwiecien == true)
                checkedListBoxMiesiace.SetItemChecked(3, true);
            if (seasonToEdit.Maj == true)
                checkedListBoxMiesiace.SetItemChecked(4, true);
            if (seasonToEdit.Czerwiec == true)
                checkedListBoxMiesiace.SetItemChecked(5, true);
            if (seasonToEdit.Lipiec == true)
                checkedListBoxMiesiace.SetItemChecked(6, true);
            if (seasonToEdit.Sierpien == true)
                checkedListBoxMiesiace.SetItemChecked(7, true);
            if (seasonToEdit.Wrzesien == true)
                checkedListBoxMiesiace.SetItemChecked(8, true);
            if (seasonToEdit.Pazdziernik == true)
                checkedListBoxMiesiace.SetItemChecked(9, true);
            if (seasonToEdit.Listopad == true)
                checkedListBoxMiesiace.SetItemChecked(10, true);
            if (seasonToEdit.Grudzien == true)
                checkedListBoxMiesiace.SetItemChecked(11, true);

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
                var editST = db.SrodekTrwaly
                                .Where(x => x.NrInwentarzowy == f1.NrInwentarzowy).FirstOrDefault<SrodekTrwaly>();
                editST.NazwaSrodka = textBoxNazwa.Text;
                editST.KST = int.Parse(comboBoxKŚT.SelectedItem.ToString());
                editST.OsosbaOdp = int.Parse(comboBoxOsobaOdp.SelectedItem.ToString());
                editST.MiejsceUzytkowania = textBoxMiejsce.Text;
                editST.DataZakupu = dataZakupu.Value;
                editST.DataLikwidacji = (DateTime?)dataLikwidacji.Value;
                editST.Stan = (string)comboBoxStan.SelectedItem;
                editST.PrzyczynaZbycia = textBoxPrzyczyna.Text;
                editST.Kategoria = (string)comboBoxKategoria.SelectedItem;
                editST.Dokument = (string)comboBoxDokument.SelectedItem;
                db.SaveChanges();
                var editAmor = db.Amortyzacja
                                .Where(x => x.NrInwentarzowy == f1.NrInwentarzowy).FirstOrDefault<Amortyzacja>();
                editAmor.DataRozpAmortyzacji = dataRozpAmor.Value;
                editAmor.WartoscPoczatkowa = Math.Round(Decimal.Parse(textBoxWartoscPoczatkowa.Text.Replace('.', ',')), 2);
                editAmor.StawkaAmortyzacji = Math.Round(Double.Parse(textBoxStawkaAmortyzacji.Text.Replace('.', ',')), 2);
                editAmor.WspolczynnikAmortyzacji = Math.Round(Double.Parse(textBoxWspolczynnikAmortyzacji.Text.Replace('.', ',')), 2);
                editAmor.MetodaAmortyzacji = (string)comboBoxMetoda.SelectedItem;
                db.SaveChanges();
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
                var editSez = db.Sezonowosc
                                .Where(x => x.NrInwentarzowy == f1.NrInwentarzowy).FirstOrDefault<Sezonowosc>();
                editSez.Styczen = miesiaceLista[0];
                editSez.Luty = miesiaceLista[1];
                editSez.Marzec = miesiaceLista[2];
                editSez.Kwiecien = miesiaceLista[3];
                editSez.Maj = miesiaceLista[4];
                editSez.Czerwiec = miesiaceLista[5];
                editSez.Lipiec = miesiaceLista[6];
                editSez.Sierpien = miesiaceLista[7];
                editSez.Wrzesien = miesiaceLista[8];
                editSez.Pazdziernik = miesiaceLista[9];
                editSez.Listopad = miesiaceLista[10];
                editSez.Grudzien = miesiaceLista[11];
                db.SaveChanges();
                this.Close();
            }
            else
                MessageBox.Show("Błędne dane", "Błąd",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
