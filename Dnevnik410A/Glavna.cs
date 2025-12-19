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
            Form1 nova = new Form1();
            nova.ShowDialog();
        }

        private void odeljenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
