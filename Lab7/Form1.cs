using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(10000, "P4", "Powiadomienie", ToolTipIcon.Info);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<1000)
            progressBar1.Value++;
            if(progressBar3.Value<100)
            progressBar3.Value++;
        }
    }
}
