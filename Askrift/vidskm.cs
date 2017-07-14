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
    public partial class vidskm : Form
    {
        public vidskm()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd. MM yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            //MySqlDataReader Reader;
            connection.Open();
            
            s_vskmnr.Text = s_kt.Text.Replace("-", "");
            if (s_nafn.Text == "")
            {
                MessageBox.Show("Það verður að vera nafn til þess að hægt sé að skrá viðskiptavin");
                return;
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.dd";
          
            command.CommandText = "INSERT INTO vidskm (id,nr,nafn,heimili,pnr,kt,simi,netfang,stofn,deild,stadur)VALUE(NULL,'"+s_vskmnr.Text+"','"+s_nafn.Text+"','"+sheimili.Text+"','"+spostnr.Text+"','"+s_kt.Text+"','"+s_simi.Text+"','"+s_netfang.Text+"','"+dateTimePicker1.Value.ToString("yyyy:MM:dd")+"','"+textdeild.Text+"','"+textStadur.Text+"')";
            command.ExecuteReader();
            dateTimePicker1.CustomFormat = "dd. MM yyyy";
            connection.Close();
            ClearTextBoxes(this);         
        }


        public void ClearTextBoxes(Control control)
        {

            foreach (Control c in control.Controls)
            {

                if (c is TextBox)
                {

                    ((TextBox)c).Clear();

                }

                if (c.HasChildren)
                {

                    ClearTextBoxes(c);

                }

            }
            spostnr.Text = "000";
        }

        
        
    }
}