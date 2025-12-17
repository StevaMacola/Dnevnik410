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
    public partial class Raspodela : Form
    {
        public Raspodela()
        {
            InitializeComponent();
        }

        private void Raspodela_Load(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.povezi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM raspodela", veza);
            DataTable raspodela = new DataTable();


            SqlDataAdapter ne = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable sk_godina = new DataTable();
            da.Fill(sk_godina);
            comboBox1.DataSource = sk_godina;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "naziv";
            comboBox1.SelectedValue = raspodela.Rows[0]["godina_id"].ToString();    
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = 5;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
