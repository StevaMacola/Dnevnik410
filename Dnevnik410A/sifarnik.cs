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
    public partial class sifarnik : Form
    {
        SqlDataAdapter Adapter;
        DataTable podaci;
        string ime_tabela;

        public sifarnik(string Tabela)
        {
            ime_tabela = Tabela;
            InitializeComponent();
        }

        private void sifarnik_Load(object sender, EventArgs e)
        {
            Adapter = new SqlDataAdapter("SELECT * FROM "+ime_tabela, Konekcija.povezi());
            podaci = new DataTable();
            Adapter.Fill(podaci);
            dataGridView1.DataSource = podaci;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable menjamo = podaci.GetChanges();
            //DataRowState: Modified - promenjeni, Added - dodati, Deleted - obrisani, Unchanged - nepromenjeni
            Adapter.UpdateCommand = new SqlCommandBuilder(Adapter).GetUpdateCommand();
            if (menjamo != null)
            {
                Adapter.Update(menjamo);
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
