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
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dnevnik410A
{
    public partial class Form1 : Form
    {
        int br_sloga;
        DataTable tabela;
        public Form1()
        {
            InitializeComponent();
        }
        
        public void prikazi()
        {
            if (tabela.Rows.Count == 0)
            {
                IDtB.Text = "";
                imetB.Text = "";
                prezimetB.Text = "";
                adresatB.Text = "";
                jmbgtB.Text = "";
                mailtB.Text = "";
                lozinkatB.Text = "";
                ulogatB.Text = "";
            }
            else
            {
                IDtB.Text = tabela.Rows[br_sloga][0].ToString();
                imetB.Text = tabela.Rows[br_sloga][1].ToString();
                prezimetB.Text = tabela.Rows[br_sloga][2].ToString();
                adresatB.Text = tabela.Rows[br_sloga][3].ToString();
                jmbgtB.Text = tabela.Rows[br_sloga][4].ToString();
                mailtB.Text = tabela.Rows[br_sloga][5].ToString();
                lozinkatB.Text = tabela.Rows[br_sloga][6].ToString();
                ulogatB.Text = tabela.Rows[br_sloga][7].ToString();
            }
            if (br_sloga == tabela.Rows.Count - 1)
                button6.Enabled = false;
            else button6.Enabled = true;
            if (br_sloga == 0)
                button2.Enabled = false;
            else button2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            br_sloga = 0;
            SqlConnection veza = Konekcija.povezi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            prikazi();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            br_sloga = 0;
            prikazi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // PROMENI
            // UPDATE osoba
            // SET ime = 'first', prezime = 'last'
            // WHERE id = 12
            string naredba = "UPDATE osoba SET ";
            naredba += "ime='" + imetB.Text + "',";
            naredba += "prezime='" + prezimetB.Text + "',";
            naredba += "adresa='" + adresatB.Text + "',";
            naredba += "jmbg='" + jmbgtB.Text + "',";
            naredba += "email='" + mailtB.Text + "',";
            naredba += "pass='" + lozinkatB.Text + "',";
            naredba += "uloga='" + ulogatB.Text + "'";
            naredba += "WHERE id = " + IDtB.Text;
            SqlConnection veza = Konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            prikazi();
        }

        private void adresatB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            br_sloga++;
            prikazi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            br_sloga--;
            prikazi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            br_sloga = tabela.Rows.Count - 1;
            prikazi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dodaj
            //insert into osoba (ime, prezime, adresa, jmbg, email, pass, uloga)
            //values('Sofija', 'Djuric', 'Strumicka 9', '290309410005', 'sofijadjuric5@gmail.com', '251107', 1)
            string naredba = "insert into osoba values('";
            naredba = naredba + imetB.Text + "','";
            naredba = naredba + prezimetB.Text + "','";
            naredba = naredba + adresatB.Text + "','";
            naredba = naredba + jmbgtB.Text + "','";
            naredba = naredba + mailtB.Text + "','";
            naredba = naredba + lozinkatB.Text + "',1)";
            SqlConnection veza = new SqlConnection("Data Source=DESKTOP-8ADJLUH\\SQLEXPRESS;Initial catalog=dnevnik410A;Integrated security=true");
            SqlCommand komanda = new SqlCommand(naredba, veza);
            veza.Open();
            komanda.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            br_sloga = tabela.Rows.Count - 1;
            prikazi();
        }

        private void IDtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void prezimetB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (br_sloga == tabela.Rows.Count - 1)
            {
                br_sloga--;
            }
            string naredba = "DELETE FROM osoba WHERE id=" + IDtB.Text;
            SqlConnection veza = Konekcija.povezi();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception greska)
            {
                MessageBox.Show(greska.GetType().ToString());
            }
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            da.Fill(tabela);
            prikazi();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
