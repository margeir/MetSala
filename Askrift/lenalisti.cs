using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Askrift
{
    public partial class lenalisti : Form
    {
        ArrayList vnr = new ArrayList();

        public lenalisti()
        {
            InitializeComponent();
        }

        private void lenalisti_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            connection.Open();
            command.CommandText = "select nafn,nr from vidskm ORDER BY id";
            //command.CommandText = "SELECT * FROM w_vidskm";
            Reader = command.ExecuteReader();

            comboBox1.Items.Clear();
           
            comboBox1.Text = "Veljið viðskiptavin";

            while (Reader.Read())
            {
                comboBox1.Items.Add(Reader.GetString(0));
               vnr.Add(Reader.GetString(1));

            }
            Reader.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            connection.Open();
            command.CommandText = "INSERT INTO lenalisti (id,vnr,len,verd,lysing) VALUE(NULL,'"+ vnr[comboBox1.SelectedIndex] +"','" + textBox1.Text + "','" + Convert.ToDouble(textBox2.Text) + "','"+textBox3.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                comboBox1.SelectedIndex = 0;
                textBox1.Clear();
                textBox2.Text = "0";
                textBox3.Clear();
        }
    }
}
