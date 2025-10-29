using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dnevnik410A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string CS = "Data Source=DESKTOP-ASD8HJ9\\SQLEXPRESS;Initial catalog=dnevnik410A;Integrated security=true";
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter DA = new SqlDataAdapter("Select * from osoba", veza);
            DataTable tabela = new DataTable();
            DA.Fill(tabela);
            IDtB.Text = tabela.Rows[0][0].ToString();
            imetB.Text = tabela.Rows[0][1].ToString();
            prezimetB.Text = tabela.Rows[0][2].ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
