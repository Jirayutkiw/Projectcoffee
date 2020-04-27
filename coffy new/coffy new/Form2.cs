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
        string gender;

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FORM customers";
            sql = "INSERT INTO customers (CustomerName, CustomerTelNo, Gender) VALUES ('" + textBox1.Text+"','"+textBox2+"','"+gender+"')";
            MySqlConnection con = new MySqlConnection("datasource=localhost;Initial Catalog='coffy';username=coffys;password=12345678");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;Initial Catalog='coffy';username=coffys;password=12345678");
            string sql = "SELECT * FORM customers.CustomerType";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read()) { }
                {
                    string typecos = myReader.GetString(4);
                    comboBox1.Items.Add(typecos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
