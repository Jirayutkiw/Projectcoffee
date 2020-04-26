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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection Connection = new MySqlConnection("datasource=localhost;Initial Catalog='coffy';username=coffys;password=12345678");
        private void Form2_Load(object sender, EventArgs e)
        {
            
            string sql = "SELECT * FORM customers";
            sql = "INSERT INTO customers (CustomerName, Gender, CustomerTelNo) VALUES ('"+textBox1.Text+"',[value-2],'"+textBox2+"'";
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
        }
    }
}
