using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM customers";
            sql = "INSERT INTO customers (CustomerName,CustomerTelNo) VALUES ( '"+ textBox1.Text +"' , '"+textBox2.Text+"' )";

            MySqlConnection con = new MySqlConnection("host=localhost;user=coffys;password=12345678;database=coffy");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
