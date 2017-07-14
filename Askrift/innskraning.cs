using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Askrift
{
    public partial class innskraning : Form
    {
        public string solumadur;
      
        public innskraning()
        {
            
            InitializeComponent();
            textlykilord.KeyDown += new KeyEventHandler(Form5_KeyPress);
            
            
        }
       
        void Form5_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adgerd();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adgerd();
           
        }

        public void adgerd()
        {
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            string lpw = "";

            connection.Open();
            command.CommandText = "SELECT nafn,lykilord FROM solumenn WHERE notendan = '" + textnotendan.Text + "'";
            Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                lpw = Reader.GetString(1);
                solumadur = Reader.GetString(0);
            }
            Reader.Close();
            connection.Close();



            if (textlykilord.Text == lpw && lpw != "")
            {
                this.DialogResult = DialogResult.OK;
                //MessageBox.Show(solumadur);
                this.Close();
            }
            else
            {
                MessageBox.Show("Notandi ekki á skrá eða \n rangt lykilorð!","Innskráning",MessageBoxButtons.OK);
                this.DialogResult = DialogResult.Cancel;
                this.Close();

            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textnotendan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnotendan_valid(object sender, EventArgs e)
        {
            textnotendan.SelectAll();
        }
       

        
    }
}
