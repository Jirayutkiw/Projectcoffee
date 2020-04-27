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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FORM products";
            sql = "INSERT INTO products (ProductName, Price, ProductDetail) VALUES ('" + textBox1.Text + "','" + textBox2 + "','" + textBox3 + "')";
            MySqlConnection con = new MySqlConnection("datasource=localhost;Initial Catalog='coffy';username=coffys;password=12345678");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
