using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace coffy_new
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection Connection = new MySqlConnection("datasource=localhost;Initial Catalog='coffy';username=coffys;password=12345678");
        private void Form5_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * Form products";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, Connection);
            adapter.Fill(table);
            dataGridViewproduct.DataSource = table;
        }
    }
}
