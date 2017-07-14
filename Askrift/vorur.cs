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
    public partial class vorur : Form
    {
        public reikningar MyParentForm;
        public samningar Foreldri1;
        public string valid;
        public string lysing;
        public string einverd;
        public string vskf;
        public float vsk;
        

        MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
        
        public vorur()
        {
            InitializeComponent();
            
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
                        
            connection.Open();
          
            int n = 0;
                command.CommandText = "select vitem,vnafn,verd, vsk from vorur ORDER BY vitem";
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[n].Cells[0].Value = Reader.GetString(0);
                    dataGridView1.Rows[n].Cells[1].Value = Reader.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = Reader.GetString(2);
                    dataGridView1.Rows[n].Cells[3].Value = Reader.GetString(3);
                                    
                    n++;
                }
                Reader.Close();
            connection.Close();
           
        }

        private void dataGridView1_CellContentClick(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                connection.Open();
                command.CommandText = "select prosenta, heiti from vsk WHERE heiti = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'";
                Reader = command.ExecuteReader();
                Reader.Read();
                vsk = Reader.GetFloat(0);
                vskf = Reader.GetString(1);
                Reader.Close();
         
                valid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                lysing = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                einverd = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }

            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}