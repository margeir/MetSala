using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Globalization;
using MySql.Data.MySqlClient;


namespace Askrift
{
    

    public partial class reikningar : Form
    {
        
        public string solum;
        public double upph;
        public int nr_sm = 0;
        double usamtals = 0;
        double u1vsk = 0;
        double u2vsk = 0;
        //double lvsk = 0.255D;
        double uafsl = 0;
        double[] l_vsk = new double[14] {0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        double[] sl1_vsk = new double[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] sl2_vsk = new double[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] sl_vsk = new double[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        string[] lina_vskf = new string[14];

        int DEBUGA = 1;

        private void reikningar_lyklar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                dataGridView1.Focus();
                SendKeys.Send("{F2}");
            }
        }


        public reikningar(string vidskm)
        {
            InitializeComponent();
            if (DEBUGA == 1)
            { debug1.Show(); }
            else
            { debug1.Hide(); }
          
            if (vidskm != "") 
            {
                MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                connection.Open();
                command.CommandText = "select nr,nafn from vidskm WHERE nr ='" + vidskm + "'";
                //command.CommandText = "SELECT * FROM w_vidskm";
                Reader = command.ExecuteReader();
                
                Reader.Read();
                comboBox2.Text = Reader.GetString(0);
                comboBox1.Text = Reader.GetString(1);
                Reader.Close();
                connection.Close();
            }
            dataGridView1.Rows.Add(14);
            vidskm_lesa();
            rdags.Value = DateTime.Now;

        }


        private void dataGridView1_CellContentClick(object sender, KeyEventArgs e)
        {
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            if (e.KeyCode == Keys.F2)
            {
                vorur gl4 = new vorur();
                //gl4.Foreldri1 = this;
                if (gl4.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.CurrentRow.Cells[0].Value = gl4.valid;
                    dataGridView1.CurrentRow.Cells[1].Value = gl4.lysing;
                    dataGridView1.CurrentRow.Cells[2].Value = Convert.ToInt32(gl4.einverd);
                    l_vsk[dataGridView1.CurrentRow.Index] = gl4.vsk;
                    lina_vskf[dataGridView1.CurrentRow.Index] = gl4.vskf;
                    
                }
                gl4.Close();
                
            }
            
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    int n = 0;
                    double lafsl = 0;
                    usamtals = 0;
                    u1vsk = 0;
                    u2vsk = 0;
                    uafsl = 0;

                    while (n < dataGridView1.RowCount)
                    {
                        if (Convert.ToString(dataGridView1.Rows[n].Cells[0].Value) != "" && Convert.ToString(dataGridView1.Rows[n].Cells[1].Value) == "")
                        {
                            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
                            MySqlCommand command = connection.CreateCommand();
                            MySqlDataReader Reader;

                            connection.Open();
                           
                            //command.CommandText = "select vnafn,verd from vorur WHERE vitem = '"+dataGridView1.CurrentRow.Cells[0].Value+"'";
                            command.CommandText = "vorurvsk";
                            command.CommandType = CommandType.StoredProcedure;
                            //Þarf að sækja id eftir að búið er að velja vskm
                            command.Parameters.Add("?spr", dataGridView1.CurrentRow.Cells[0].Value);
                            command.Parameters["?spr"].Direction = ParameterDirection.Input;
                            Reader = command.ExecuteReader();

                            while (Reader.Read())
                            {
                                dataGridView1.CurrentRow.Cells[1].Value = Reader.GetString(0);
                                dataGridView1.CurrentRow.Cells[2].Value = Reader.GetString(1);
                                l_vsk[dataGridView1.CurrentRow.Index] = Reader.GetFloat(2);
                                lina_vskf[dataGridView1.CurrentRow.Index] = Reader.GetString(3);
                                
                            }
                            Reader.Close();
                            connection.Close();
                        }
                        if (Convert.ToString(dataGridView1.Rows[n].Cells[3].Value) != "")
                        {
                            // Hér er verðið sett inn ein verð * magn - afsl sem er i prósentu
                            lafsl = ((Convert.ToDouble(dataGridView1.Rows[n].Cells[2].Value) * (Convert.ToDouble(dataGridView1.Rows[n].Cells[3].Value)) * (Convert.ToDouble(dataGridView1.Rows[n].Cells[4].Value) / 100)));
                            dataGridView1.Rows[n].Cells[5].Value = (Convert.ToDouble(dataGridView1.Rows[n].Cells[2].Value) * (Convert.ToDouble(dataGridView1.Rows[n].Cells[3].Value)) - lafsl);
                            //Cells 0 ITEM - 1 Texti - 2 verð - 3 magn - 4 afsl - 5 samtals - 6 samtals + vsk - 7 vask flokkur vsk_f
                            //usamtals er upphæð á nótu samtals án vsk
                            usamtals = Math.Round(usamtals + Convert.ToInt32(dataGridView1.Rows[n].Cells[5].Value),0);
                            //Hér er síðan reiknað út verð á línu með vsk l_vsk[númerlínu] hefur að geyma vask %
                            dataGridView1.Rows[n].Cells[6].Value = (Convert.ToInt32(dataGridView1.Rows[n].Cells[5].Value) * (1 + (l_vsk[n] / 100))).ToString("N0");
                            //Hér þarf að fá samtals upphæð vsk pr. línu 
                            if (l_vsk[n] == 25.5D)
                            {
                                sl1_vsk[n] = Convert.ToDouble(dataGridView1.Rows[n].Cells[5].Value) * (l_vsk[n] / 100);
                               
                            }
                            else
                            {
                                sl2_vsk[n] = Convert.ToDouble(dataGridView1.Rows[n].Cells[5].Value) * (l_vsk[n] / 100);
                               
                            }
                                //Vask upphæð á nótu verður á línuupphæð summeruð
                            u1vsk = Math.Round(u1vsk + sl1_vsk[n]);
                            u2vsk = Math.Round(u2vsk + sl2_vsk[n]);
                            
                            s1vsk.Text = u1vsk.ToString("N0");
                            s2vsk.Text = u2vsk.ToString("N0");
                            sanvsk.Text = usamtals.ToString("N0");
                            sl_vsk[n] = sl1_vsk[n] + sl2_vsk[n];
                            smvsk.Text = (usamtals + u1vsk + u2vsk).ToString("N0");

                            uafsl = uafsl + Convert.ToDouble(dataGridView1.Rows[n].Cells[5].Value) - ((Convert.ToDouble(dataGridView1.Rows[n].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[n].Cells[3].Value)));
                            textAfsl.Text = uafsl.ToString("N0");
                        }
                        n++;
                    }
                }
            
        }

        void WriteError(string str)
        {
            debug1.Text = str;
        }

        public void vidskm_lesa()
        {
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            connection.Open();
            command.CommandText = "select nr,nafn from vidskm ORDER BY nafn";
            //command.CommandText = "SELECT * FROM w_vidskm";
            Reader = command.ExecuteReader();

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Text = "Veljið viðskiptavin";

            while (Reader.Read())
            {
                comboBox1.Items.Add(Reader.GetString(1));
                comboBox2.Items.Add(Reader.GetString(0));

            }
            Reader.Close();
            command.CommandText = "select id,nafn from solumenn ORDER BY nafn";
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                nr_sm = Reader.GetInt32(0);
                comboBox3.Items.Add(Reader.GetString(1));
            }
            
            connection.Close();
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                heimili.Text = "";
                pnr.Text = "";
                stadur.Text = "";
                kennitala.Text = "";
                simi.Text = "";
                return;
            }

            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            connection.Open();
            //command.CommandText = "select id,dags,vidskm_nr,l_haus from nota";

            debug1.Text = comboBox1.SelectedIndex.ToString();
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
            //debug2.Text = comboBox2.Text;
            command.CommandText = "SELECT heimili,pnr,stadur,kt,simi FROM vidskm WHERE nr = '" + comboBox2.Text + "'";
            Reader = command.ExecuteReader();
            //Reader.Read();
            while (Reader.Read())
            {
                heimili.Text = Reader.GetString(0);
                pnr.Text = Reader.GetString(1);
                stadur.Text = Reader.GetString(2);
                kennitala.Text = Reader.GetString(3).ToString();
                simi.Text = Reader.GetString(4);
            }
            Reader.Close();
            connection.Close();
            comboBox3.Text  = solum;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            samningar gl1 = new samningar();
            gl1.ShowDialog();
        }

        private void r_prenta_Click(object sender, EventArgs e)
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
                XmlReiknWriter.WriteElementString("Dags", null, rdags.Text);
                XmlReiknWriter.WriteElementString("Nafn", null, comboBox1.SelectedItem.ToString());
                XmlReiknWriter.WriteElementString("Vidskm", null, comboBox2.SelectedItem.ToString());
                XmlReiknWriter.WriteElementString("Kt", null, kennitala.Text);
                XmlReiknWriter.WriteElementString("Heimili", null, heimili.Text);
                XmlReiknWriter.WriteElementString("Postnr", null, pnr.Text);
                XmlReiknWriter.WriteElementString("Postst", null, stadur.Text);
                XmlReiknWriter.WriteElementString("Texti1", null, rhaus1.Text);
                XmlReiknWriter.WriteElementString("Texti2", null, rhaus2.Text);
                XmlReiknWriter.WriteElementString("Numer", null, r_num.ToString());

                for (int i = 0; i < (dataGridView1.Rows.Count); i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value == null) break;
                    XmlReiknWriter.WriteElementString("Item", (string)dataGridView1[0, i].Value);
                    XmlReiknWriter.WriteElementString("Lysing", (string)dataGridView1[1, i].Value);
                    XmlReiknWriter.WriteElementString("Magn", (string)dataGridView1[3, i].Value);
                    XmlReiknWriter.WriteElementString("Lafsl", (string)dataGridView1[4, i].Value);
                    XmlReiknWriter.WriteElementString("Verd", string.Format("{0:0,0}", dataGridView1[2, i].Value));
                    XmlReiknWriter.WriteElementString("Lsamt", string.Format("{0:0,0}", dataGridView1[5, i].Value));
                    XmlReiknWriter.WriteElementString("VFl", lina_vskf[i]);
                }
                XmlReiknWriter.WriteElementString("solumadur", comboBox3.Text);
                XmlReiknWriter.WriteElementString("Samtals", smvsk.Text);
                XmlReiknWriter.WriteElementString("Vsk1", s1vsk.Text);
                XmlReiknWriter.WriteElementString("Vsk2", s2vsk.Text);
                XmlReiknWriter.WriteElementString("Sanvsk", sanvsk.Text);
                XmlReiknWriter.WriteElementString("Safsl", textAfsl.Text);
                if(Convert.ToDouble(smvsk.Text) < 0)
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
                if (sanvsk.Text.Equals("")) 
                {
                    MessageBox.Show("Ekki hægt að gera 0 reikning");
                }
                else
                {
                skrifa(1, r_num);
                PrentaR Prentreik = new PrentaR();
                Prentreik.prenta(0);
                }

            }


          catch (Exception ex)
          {
              WriteError(ex.ToString());
          }
     }

        public void skrifa(int hv,int num)
        {
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            //MySqlDataReader Reader;


            int result;
            int r_num = num;
            string hvert;
            string hvert_item;

            if (hv == 1)
            {    
                hvert = "reikningar";
                hvert_item = "reikn_item";
             }
            else
            {
                hvert = "samningar";
                hvert_item = "sam_item";
            }
            
            connection.Open();
            command.CommandText = "INSERT INTO " + hvert + " (id,stofnd,vidskm_nr,reiknd,samtals,afsl,vsk1,vsk2,texti,heimili,stadur,pnr,solumadur,text2) VALUE('" + r_num + "','" + DateTime.Now.ToString("yyyy:MM:dd") + "','" + comboBox2.Text + "','" + rdags.Value.ToString("yyyy:MM:dd") + "','" + usamtals + "','" + Math.Round(uafsl) + "','" + u1vsk + "','" + u2vsk + "','" + rhaus1.Text + "','" + heimili.Text + "','" + stadur.Text + "','" + pnr.Text + "','" + nr_sm + "','"+rhaus2.Text+"')";
            try
            {
                result = Convert.ToInt32(command.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Villa í innsetningu gagna í grunn \n " + ex);
            }
                double lverd = 0;
                double tlvsk = 0;
                double tlafsl = 0;
                double sl_verd = 0;
                double tlqty = 0;
                

                for (int i = 0; i < (dataGridView1.Rows.Count); i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value == null) break;
                    tlqty = Convert.ToDouble(dataGridView1[3, i].Value);
                    
                    lverd = Convert.ToDouble(dataGridView1[2, i].Value);
                    sl_verd = Convert.ToDouble(dataGridView1[5, i].Value);
                    tlvsk = Math.Round(lverd * (l_vsk[i]/100),0);
                    tlafsl = Math.Round(Convert.ToDouble(dataGridView1[4, i].Value),0);

                    command.Parameters.Add("?qty", tlqty);
                    command.Parameters.Add("?lafsl", tlafsl);
                    command.CommandText = "INSERT INTO " + hvert_item + "(id,id_reikn,lysing,item,qty,uverd,verd,vsk,lafsl,vfl) VALUES (NULL,'" + r_num + "','" + (string)dataGridView1[1, i].Value + "','" + (string)dataGridView1[0, i].Value + "',?qty,'" + lverd + "','" + Math.Round(sl_verd) + "','" + Math.Round(sl_vsk[i]) + "',?lafsl,'" + lina_vskf[i] + "')";
                    
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(14);
            sanvsk.Clear();
            smvsk.Clear();
            s1vsk.Clear();
            rhaus2.Clear();
            comboBox1.SelectedIndex = -1;
           
           connection.Close();

        }

        private void set_askrift_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            connection.Open();
            command.CommandText = "SELECT id FROM vidskm WHERE nr = "+comboBox2.SelectedItem.ToString()+"";
            Reader = command.ExecuteReader();
            Reader.Read();
            //Bara að sækja númerið 
            Reader.Close();
            int r_num = 0;
            try
            {
                r_num = Reader.GetInt32(0);
            }
            catch
            {
                r_num = 1;
            }
            command.CommandText = "UPDATE vidskm SET msamn='Y' WHERE nr = " + comboBox2.SelectedItem.ToString() + "";
            command.ExecuteNonQuery();
            connection.Close();

            skrifa(0, r_num);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            vidskm_lesa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void b_peningar_Click(object sender, EventArgs e)
        {
           string hsverd = smvsk.Text;
            g_peningar gpen = new g_peningar(hsverd);
                    gpen.ShowDialog();


        }
        
        
 



    }

 

}