using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Askrift
{
    public partial class endurp : Form
    {
        List<string> vidsknr = new List<string>();
        List<string> vidskkt = new List<string>();
        string n_reiknd;
        string n_heimili;
        int n_pnr = 0;
        string n_stadur;
        
        Boolean fundid = false;
        DateTime dagsnuna = DateTime.Now;

        public double rsamt = 0;
        public double r1vsk = 0;
        public double r2vsk = 0;
        public double rafsl = 0;
        public int vnum = 0;
        public int nr_sm = 0;
        double[] l_vsk = new double[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        string[] lina_vskf = new string[14];


        public endurp()
        {
            InitializeComponent();
            vidskm_lesa();
            rdags1.Value = new DateTime(dagsnuna.Year, dagsnuna.Month, 1);
            rdags2.Value = DateTime.Now;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;

            if (fundid == false)
            {
                try
                {
                    
                    connection.Open();
                    command.CommandText = "select id from reikningar WHERE vidskm_nr = '" + vidsknr[comboBox1.SelectedIndex] + "' AND reiknd >= '" + rdags1.Value.ToString("yyyy:MM:dd") + "' AND reiknd <= '" + rdags2.Value.ToString("yyyy:MM:dd") + "'ORDER BY reiknd DESC";
                    comboBox2.Items.Clear();
                    //MessageBox.Show(command.CommandText);
                    comboBox2.Text = "Reikningur";
                    Reader = command.ExecuteReader();
                    while (Reader.Read())
                    {
                        comboBox2.Items.Add(Reader.GetString(0));
                    }
                    connection.Close();
                    dataGridView1.Rows.Clear();
                    rhaus1.Text = "";
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                connection.Open();
                command.CommandText = "SELECT v.nafn FROM reikningar AS r LEFT JOIN vidskm AS v ON r.vidskm_nr = v.nr WHERE r.id = '" + Convert.ToInt32(comboBox2.Text) + "'";
                Reader = command.ExecuteReader();
                Reader.Read();
                comboBox1.SelectedItem = Reader.GetString(0);
                connection.Close();
                fundid = false;
                comboBox2_SelectedIndexChanged(null, null);
            }
        }



        public void vidskm_lesa()
        {
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;

           
                //int tnafn = 0;
                try
                {
                    connection.Open();
                    command.CommandText = "select nr,nafn,kt from vidskm ORDER BY nafn";

                    Reader = command.ExecuteReader();

                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox1.Text = "Veljið viðskiptavin";

                    while (Reader.Read())
                    {
                        comboBox1.Items.Add(Reader.GetString(1));
                        vidsknr.Add(Reader.GetString(0));
                        vidskkt.Add(Reader.GetString(2));
                        //tnafn++;
                    }
                    connection.Close();

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                       
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand cmd = connection.CreateCommand();
            MySqlDataReader Reader;
            
       
            int fjrk;
            try
            {
                fjrk = Convert.ToInt32(comboBox2.Text);
                connection.Open();
                //cmd.CommandText = "nota2";
                cmd.CommandText = "G_reikn_item";
                cmd.CommandType = CommandType.StoredProcedure;
                //Þarf að sækja id eftir að búið er að velja vskm
                cmd.Parameters.Add("?spr", fjrk);
                cmd.Parameters["?spr"].Direction = ParameterDirection.Input;
                Reader = cmd.ExecuteReader();

                int r1 = 0;
                tsamtals.Clear();
                t1vsk.Clear();
                tmvsk.Clear();
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(10);
                dataGridView1.Columns["samtals"].DefaultCellStyle.Format = "N0";
                dataGridView1.Columns["verd"].DefaultCellStyle.Format = "N0";
                while (Reader.Read())
                {

                    dataGridView1.Rows[r1].Cells[0].Value = Reader.GetString(3);
                    dataGridView1.Rows[r1].Cells[1].Value = Reader.GetString(2);
                    dataGridView1.Rows[r1].Cells[3].Value = Reader.GetDouble(4);
                    dataGridView1.Rows[r1].Cells[2].Value = Reader.GetInt32(5);
                    dataGridView1.Rows[r1].Cells[5].Value = Reader.GetInt32(6);
                    dataGridView1.Rows[r1].Cells[4].Value = Reader.GetDouble(8);
                    l_vsk[r1] = Reader.GetInt32(7);
                    lina_vskf[r1] = Reader.GetString(9);
                    r1++;
                }

                Reader.Close();
                cmd.CommandText = "SELECT sm.nafn,samn.texti,samn.afsl,sm.id,samn.samtals,samn.vsk1,samn.vsk2, samn.reiknd,samn.stadur,samn.pnr,samn.heimili,samn.text2,samn.kredit FROM reikningar AS samn LEFT JOIN solumenn AS sm ON samn.solumadur = sm.id  WHERE samn.id =" + fjrk;
                cmd.CommandType = CommandType.Text;
                Reader = cmd.ExecuteReader();
                Reader.Read();
                solumadur.Text = Reader.GetString(0);
                rafsl = Reader.GetDouble(2);
                textafsl.Text = rafsl.ToString("N0");
                
                r1vsk = Reader.GetInt32(5);
                r2vsk = Reader.GetInt32(6);
                rsamt = Reader.GetInt32(4);
                tsamtals.Text = rsamt.ToString("N0");
                t1vsk.Text = r1vsk.ToString("N0");
                t2vsk.Text = r2vsk.ToString("N0");
                tmvsk.Text = (rsamt + r1vsk + r2vsk).ToString("N0");
                nr_sm = Reader.GetInt32(3);
                n_heimili = Reader.GetString(10);
                n_stadur = Reader.GetString(8);
                n_pnr = Reader.GetInt32(9);
                n_reiknd = Reader.GetString(7);
                textrdags.Text = n_reiknd;
                if (Reader.GetString(12) == "1")
                    button2.Enabled = false;
                else
                    button2.Enabled = true;

                if (Reader.IsDBNull(1))
                    rhaus1.Text = "";
                else
                    rhaus1.Text = Reader.GetString(1);
                
                if (Reader.IsDBNull(11))
                    rhaus2.Text = "";
                else
                    rhaus2.Text = Reader.GetString(11);

                Reader.Close();
            }

            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
           
        }

        private void comboBox2_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fundid = true;
                comboBox1_SelectedIndexChanged(null, null);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
          {
              XmlTextWriter XmlReiknWriter = null;
              //Bara að sækja númerið 
              XmlReiknWriter = new XmlTextWriter("reikn.xml", System.Text.Encoding.UTF8);
              XmlReiknWriter.Formatting = Formatting.Indented;

              //XmlReiknWriter.WriteStartDocument(true); 
              //XmlReiknWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='iso-8859-1'");
              XmlReiknWriter.WriteStartElement("Reikningar");

              XmlReiknWriter.WriteStartElement("Reikningur", null);
              XmlReiknWriter.WriteElementString("Dags", null, n_reiknd);
              XmlReiknWriter.WriteElementString("Nafn", null, comboBox1.SelectedItem.ToString());
              XmlReiknWriter.WriteElementString("Vidskm", null, vidsknr[comboBox1.SelectedIndex]);
              XmlReiknWriter.WriteElementString("Kt", null, vidskkt[comboBox1.SelectedIndex]);
              XmlReiknWriter.WriteElementString("Heimili", null, n_heimili);
              XmlReiknWriter.WriteElementString("Postnr", null, n_pnr.ToString());
              XmlReiknWriter.WriteElementString("Postst", null, n_stadur);
              XmlReiknWriter.WriteElementString("Texti1", null, rhaus1.Text);
              XmlReiknWriter.WriteElementString("Texti2", null, rhaus2.Text);
              XmlReiknWriter.WriteElementString("Numer", null, comboBox2.Text);

              for (int i = 0; i < (dataGridView1.Rows.Count); i++)
              {
                  if (dataGridView1.Rows[i].Cells[0].Value == null) break;
                  XmlReiknWriter.WriteElementString("Item", (string)dataGridView1[0, i].Value);
                  XmlReiknWriter.WriteElementString("Lysing", (string)dataGridView1[1, i].Value);
                  XmlReiknWriter.WriteElementString("Magn", dataGridView1[3, i].Value.ToString());
                  XmlReiknWriter.WriteElementString("Lafsl", dataGridView1[4, i].Value.ToString());
                  XmlReiknWriter.WriteElementString("Verd", string.Format("{0:0,0}", dataGridView1[2, i].Value));
                  XmlReiknWriter.WriteElementString("Lsamt", string.Format("{0:0,0}", dataGridView1[5, i].Value));
                  XmlReiknWriter.WriteElementString("VFl", lina_vskf[i]);
              }
              XmlReiknWriter.WriteElementString("solumadur", null, solumadur.Text);
              XmlReiknWriter.WriteElementString("Samtals", tmvsk.Text);
              XmlReiknWriter.WriteElementString("Vsk1", t1vsk.Text);
              XmlReiknWriter.WriteElementString("Vsk2", t2vsk.Text);
              XmlReiknWriter.WriteElementString("Sanvsk", tsamtals.Text);
              XmlReiknWriter.WriteElementString("Safsl", textafsl.Text);
              XmlReiknWriter.WriteElementString("Frumrit", "Afrit");

              XmlReiknWriter.WriteEndElement();

              //Lokið við haus 

              XmlReiknWriter.WriteEndElement();

              //Write the XML to file and close the writer

              XmlReiknWriter.Flush();
              XmlReiknWriter.Close();
              if (XmlReiknWriter != null)
                  XmlReiknWriter.Close();
              //Klára reikning færa í DB og setja inn númer á reikningi
              //Kalla á prenta reikning
              PrentaR Prentreik = new PrentaR();
                // 1 afrit 0 frumrit og 2 kredit
              Prentreik.prenta(1);
              

          }


          catch (Exception ex)
          {
              MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextWriter XmlReiknWriter = null;
                MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                connection.Open();
                command.CommandText = "SELECT id FROM reikningar ORDER BY id DESC";
                Reader = command.ExecuteReader();
                Reader.Read();
                //Bara að sækja númerið 
                Reader.Close();
                command.CommandText = "UPDATE reikningar SET kredit='1' WHERE id = '"+comboBox2.Text+"'";
                command.ExecuteNonQuery();

                int r_num = 0;
                try
                {
                    r_num = Reader.GetInt32(0) + 1;
                }
                catch
                {
                    r_num = 100000;
                }
                connection.Close();

                XmlReiknWriter = new XmlTextWriter("reikn.xml", System.Text.Encoding.UTF8);
                XmlReiknWriter.Formatting = Formatting.Indented;

                //XmlReiknWriter.WriteStartDocument(true); 
                //XmlReiknWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='iso-8859-1'");
                XmlReiknWriter.WriteStartElement("Reikningar");

                XmlReiknWriter.WriteStartElement("Reikningur", null);
                XmlReiknWriter.WriteElementString("Dags", null, n_reiknd);
                XmlReiknWriter.WriteElementString("Nafn", null, comboBox1.SelectedItem.ToString());
                XmlReiknWriter.WriteElementString("Vidskm", null, vidsknr[comboBox1.SelectedIndex]);
                XmlReiknWriter.WriteElementString("Kt", null, vidskkt[comboBox1.SelectedIndex]);
                XmlReiknWriter.WriteElementString("Heimili", null, n_heimili);
                XmlReiknWriter.WriteElementString("Postnr", null, n_pnr.ToString());
                XmlReiknWriter.WriteElementString("Postst", null, n_stadur);
                XmlReiknWriter.WriteElementString("Texti1", null, rhaus1.Text);
                XmlReiknWriter.WriteElementString("Texti2", null, rhaus2.Text);
                XmlReiknWriter.WriteElementString("Numer", null, r_num.ToString());

                for (int i = 0; i < (dataGridView1.Rows.Count); i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value == null) break;
                    XmlReiknWriter.WriteElementString("Item", (string)dataGridView1[0, i].Value);
                    XmlReiknWriter.WriteElementString("Lysing", (string)dataGridView1[1, i].Value);
                    XmlReiknWriter.WriteElementString("Magn", "-" + (double)dataGridView1[3, i].Value);
                    XmlReiknWriter.WriteElementString("Lafsl", dataGridView1[4, i].Value.ToString());
                    XmlReiknWriter.WriteElementString("Verd", "-" + string.Format("{0:0,0}", dataGridView1[2, i].Value));
                    XmlReiknWriter.WriteElementString("Lsamt", "-" + string.Format("{0:0,0}", dataGridView1[5, i].Value));
                    XmlReiknWriter.WriteElementString("VFl", lina_vskf[i]);
                }
                XmlReiknWriter.WriteElementString("solumadur", solumadur.Text);
                XmlReiknWriter.WriteElementString("Samtals", "-" + tmvsk.Text);
                XmlReiknWriter.WriteElementString("Vsk1", "-" + t1vsk.Text);
                XmlReiknWriter.WriteElementString("Vsk2", "-" + t2vsk.Text);
                XmlReiknWriter.WriteElementString("Sanvsk", "-" + tsamtals.Text);
                XmlReiknWriter.WriteElementString("Safsl", textafsl.Text);
                if(Convert.ToDouble(tmvsk.Text) < 0)
                  XmlReiknWriter.WriteElementString("Frumrit", "Frumrit KREDIT");
                else
                  XmlReiknWriter.WriteElementString("Frumrit", "Frumrit");

                XmlReiknWriter.WriteEndElement();

                //Lokið við haus 

                XmlReiknWriter.WriteEndElement();

                //Write the XML to file and close the writer

                XmlReiknWriter.Flush();
                XmlReiknWriter.Close();
                if (XmlReiknWriter != null)
                    XmlReiknWriter.Close();
                //Klára reikning færa í DB og setja inn númer á reikningi
                if (Convert.ToDouble(tsamtals.Text) < 0) 
                {
                    MessageBox.Show("Ekki er hægt að kreditfæra reikning");
                }
                else
                {
                skrifa(r_num);
                PrentaR Prentreik = new PrentaR();
                Prentreik.prenta(2);
                }

            }


          catch (Exception ex)
          {
              MessageBox.Show(ex.ToString());
          }
     
        }


        public void skrifa(int num)
        {
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            //MySqlDataReader Reader;

            double lverd = 0;
            double tlvsk = 0;
            double tlafsl = 0;
            double sl_verd = 0;
            double tlqty = 0;
            int r_num = num;
            double sqltsamtals = - Convert.ToDouble(tsamtals.Text);
            double sqlt1vsk = - Convert.ToDouble(t1vsk.Text);
            double sqlt2vsk = - Convert.ToDouble(t2vsk.Text);
            double sqltafsl = - Convert.ToDouble(textafsl.Text);

            connection.Open();
            command.CommandText = "INSERT INTO reikningar (id,stofnd,vidskm_nr,reiknd,samtals,afsl,vsk1,vsk2,texti,heimili,stadur,pnr,solumadur,tilbodnr) VALUE('" + r_num + "','" + DateTime.Now.ToString("yyyy:MM:dd") + "','" + vidsknr[comboBox1.SelectedIndex] + "','" + DateTime.Now.ToString("yyyy:MM:dd") + "','" + sqltsamtals + "','" + sqltafsl + "','" + Math.Round(sqlt1vsk) + "','" + Math.Round(sqlt2vsk) + "','" + rhaus1.Text + "','" + n_heimili + "','" + n_stadur + "','" + n_pnr + "','" + nr_sm + "','" + comboBox2.Text +"')";
            command.ExecuteNonQuery();
            

            for (int i = 0; i < (dataGridView1.Rows.Count); i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value == null) break;
                tlqty = Convert.ToDouble(dataGridView1[3, i].Value);
                lverd = Convert.ToInt32(dataGridView1[2, i].Value);
                sl_verd = Convert.ToInt32(dataGridView1[5, i].Value);
                tlvsk = Math.Round(lverd * (l_vsk[i] / 100));
                tlafsl = - Convert.ToDouble(dataGridView1[4, i].Value);
                command.Parameters.Add("?qty", tlqty);
                command.Parameters.Add("?lafsl", tlafsl);
                command.CommandText = "INSERT INTO reikn_item (id,id_reikn,lysing,item,qty,uverd,verd,vsk,lafsl,vfl) VALUES (NULL,'" + r_num + "','" + (string)dataGridView1[1, i].Value + "','" + (string)dataGridView1[0, i].Value + "',?qty,'" + -lverd + "','" + -sl_verd + "','" + -Math.Round(l_vsk[i]) + "',?lafsl,'" + lina_vskf[i] + "')";
                command.ExecuteNonQuery();
                command.Parameters.Clear();
            }

         
            connection.Close();

        }

        

    }
}
