using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnevnik410A
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {

        }

        private void osobaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            sifarnik nova = new sifarnik("Osoba");
            nova.ShowDialog();
        }

        private void odeljenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik nova = new sifarnik("Odeljenje");
            nova.ShowDialog();
        }

        private void upisnicaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Upisnica nova = new Upisnica();
            nova.ShowDialog();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspodela nova = new Raspodela();
            nova.ShowDialog();
        }

        private void skolskaGodinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik nova = new sifarnik("Skolska_godina");
            nova.ShowDialog();
        }

        private void predmetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik nova = new sifarnik("Predmet");
            nova.ShowDialog();
        }

        private void smerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifarnik nova = new sifarnik("Smer");
            nova.ShowDialog();
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void datotekeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
