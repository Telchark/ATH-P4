using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSrodki_Click(object sender, EventArgs e)
        {
            var Srodki = new SrodkiTrwaleForm();
            Srodki.ShowDialog();
        }


        private void btnPrac_Click(object sender, EventArgs e)
        {
            var Pracownicy = new PracownicyForm();
            Pracownicy.ShowDialog();
        }

        private void btnWyjdź_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKat_Click(object sender, EventArgs e)
        {
            var Kategorie = new KategorieForm();
            Kategorie.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Klasyfikajce = new KlasyfikacjaForm();
            Klasyfikajce.ShowDialog();
        }

        private void btnDokumenty_Click(object sender, EventArgs e)
        {
            var Dokumenty = new DokumentyFrom();
            Dokumenty.ShowDialog();
        }
    }
}
