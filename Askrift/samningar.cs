using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using MySql.Data.MySqlClient;


namespace Askrift
{

  public partial class samningar : Form
    {
       /*public static string MyConString = "SERVER=localhost;" +
               "DATABASE=metreikn;" +
               "UID=metnet;" +
               "PASSWORD=met7816";
         */   
      public double rsamt =0;
      public double r1vsk = 0;
      public double r2vsk = 0;
      public double rafsl = 0;
      
      public int vnum = 0;
      public int nr_sm = 0;

      double[] lina_vskp = new double[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
      string[] lina_vskf = new string[14];
      double[] sl_vsk1 = new double[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
      double[] sl_vsk2 = new double[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
      double[] lina_afsl = new double[14] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

      public samningar()
        {
            
            InitializeComponent();
            rdags.Value = DateTime.Now;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vidskm_lesa();
        }
      
      public void vidskm_lesa()
        {
            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            try
            {
                connection.Open();
                //Ef verið er með StoredProcedure
                //command.CommandText = "medsaming";
                //command.CommandType = CommandType.StoredProcedure;
                //Ef verið er að velja beint
                command.CommandText = "select nr,nafn from vidskm WHERE msamn = 'Y' ORDER BY nafn";
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
                connection.Close();
               //.Rows.Add(10);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array.Clear(lina_vskp, 0, 14);
            Array.Clear(lina_vskf, 0, 14);
            Array.Clear(sl_vsk1, 0, 14);
            Array.Clear(sl_vsk2, 0, 14);
            Array.Clear(lina_afsl, 0, 14);

            MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            connection.Open();
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
            //debug2.Text = comboBox2.Text;
             command.CommandText = "SELECT id,heimili,pnr,kt,simi,stadur FROM vidskm WHERE nr = '"+comboBox2.Text+"'";
             command.CommandType = CommandType.Text;

             debug2.Text = command.CommandText;
             Reader = command.ExecuteReader();
             Reader.Read();
             vnum = Reader.GetInt32(0);
             nr_samn.Text = vnum.ToString();
             heimili.Text = Reader.GetString(1);
             pnr.Text = Reader.GetString(2);
             kennitala.Text = Reader.GetString(3).ToString();
             simi.Text = Reader.GetString(4);
             stadur.Text = Reader.GetString(5);
             Reader.Close();
            connection.Close();
            get_samning(vnum);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
        }
       

      private void get_samning(int vnum)
      {
          MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
          MySqlCommand cmd = connection.CreateCommand();
          MySqlDataReader Reader;
          string[,] linur = new string[20, 2];
          //string l_vara;
          int fjrk;
          try
          {
              fjrk = vnum;
              connection.Open();
              //cmd.CommandText = "nota2";
              cmd.CommandText = "G_samn_item";
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
                  dataGridView1.Rows[r1].Cells[3].Value = Reader.GetString(4);
                  dataGridView1.Rows[r1].Cells[2].Value = Reader.GetInt32(5);
                  dataGridView1.Rows[r1].Cells[5].Value = Reader.GetInt32(6);
                  dataGridView1.Rows[r1].Cells[4].Value = Reader.GetInt32(8);
                  lina_vskp[r1] = Reader.GetInt32(7);
                  lina_vskf[r1] = Reader.GetString(9);
                  r1++;
              }
                            
              Reader.Close();
              cmd.CommandText = "SELECT sm.nafn,samn.texti,samn.afsl,sm.id,samn.samtals,samn.vsk1,samn.vsk2 FROM samningar AS samn LEFT JOIN solumenn AS sm ON samn.solumadur = sm.id  WHERE samn.id =" + fjrk;
              cmd.CommandType = CommandType.Text;
              Reader = cmd.ExecuteReader();
                Reader.Read();
                  solumadur.Text = Reader.GetString(0);
                   rafsl = Reader.GetInt32(2);
                   textafsl.Text = rafsl.ToString("N0");
                   r1vsk = Reader.GetInt32(5);
                   r2vsk = Reader.GetInt32(6);
                   rsamt = Reader.GetInt32(4);
                   tsamtals.Text = rsamt.ToString("N0");
                   t1vsk.Text = r1vsk.ToString("N0");
                   t2vsk.Text = r2vsk.ToString("N0");
                   tmvsk.Text = (rsamt + r1vsk + r2vsk).ToString("N0");
                   nr_sm = Reader.GetInt32(3);

                  if (Reader.IsDBNull(1))
                      rhaus1.Text = "";
                  else
                  rhaus1.Text = Reader.GetString(1);
                 
              Reader.Close();
          }

          catch (MySql.Data.MySqlClient.MySqlException ex)
          {
              MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
          connection.Close();
      }

      //Útbúa reiknining úr öllum samningum
      private void button8_Click(object sender, EventArgs e)
      {
          // Perform the print within a try block in case a failure
          // of any type occurs.  For this sample, all errors will
          // be handled generically by simply displaying a messagebox.
          try
          {
              int i = 0;
              while (i < comboBox1.Items.Count)
              {
                  comboBox1.SelectedIndex = i;
                  get_samning(vnum);
                  xmlreik();
                  i++;
              }
              
              
          }
          catch (Exception ex)
          {
              // If any error occurs, display a messagebox.
              MessageBox.Show("Error printing report: \r\n" + ex.Message);
          }
          
      }

      
      void xmlreik()
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
              if (t1vsk.Text.Equals(""))
              {
                  MessageBox.Show("Ekki hægt að gera 0 reikning");
              }
              else
              {
                  skrifa(r_num);
                  PrentaR Prentreik = new PrentaR();
                  Prentreik.prenta(0);
              }

          }


          catch (Exception ex)
          {
              MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

      }

      public void skrifa(int num)
      {
          MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
          MySqlCommand command = connection.CreateCommand();
          //MySqlDataReader Reader;
           
          int r_num = num;
          
          connection.Open();
          command.CommandText = "INSERT INTO reikningar (id,stofnd,vidskm_nr,reiknd,samtals,afsl,vsk1,vsk2,solumadur,texti,heimili,stadur,pnr) VALUE('" + r_num + "','" + DateTime.Now.ToString("yyyy:MM:dd") + "','" + comboBox2.Text + "','" + rdags.Value.ToString("yyyy:MM:dd") + "','" + rsamt + "','"+ rafsl +"','" + r1vsk + "','" + r2vsk + "','" + nr_sm + "','" + rhaus1.Text + "','" + heimili.Text + "','" + stadur.Text + "','" + pnr.Text + "')";
          command.ExecuteNonQuery();

          double lverd = 0;
          double tlafsl = 0;
          double sl_verd = 0;
          int tlqty = 0;

          for (int i = 0; i < (dataGridView1.Rows.Count); i++)
          {
              if (dataGridView1.Rows[i].Cells[0].Value == null) break;
              tlqty = Convert.ToInt32(dataGridView1[3, i].Value);
              lverd = Convert.ToInt32(dataGridView1[2, i].Value);
              sl_verd = Convert.ToDouble(dataGridView1[5, i].Value);
              tlafsl = Convert.ToDouble(dataGridView1[4, i].Value);
              command.CommandText = "INSERT INTO reikn_item (id,id_reikn,lysing,item,qty,uverd,verd,vsk,lafsl,vfl) VALUES (NULL,'" + r_num + "','" + (string)dataGridView1[1, i].Value + "','" + (string)dataGridView1[0, i].Value + "','" + tlqty + "','" + lverd + "','" + sl_verd + "','" + lina_vskp[i] + "','" + tlafsl + "','" + lina_vskf[i] + "')";
              command.ExecuteNonQuery();
          }

          dataGridView1.Rows.Clear();
          dataGridView1.Rows.Add(14);
          tsamtals.Clear();
          tmvsk.Clear();
          t1vsk.Clear();
          t2vsk.Clear();

          connection.Close();


      }
           
      //Eyða út samningi er hér á eftir 
      private void button1_Click(object sender, EventArgs e)
      {
          MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
          MySqlCommand command = connection.CreateCommand();
          int samn_nr = Convert.ToInt32(nr_samn.Text);

          connection.Open();
          command.CommandText = "DELETE FROM sam_item WHERE id_reikn = '" + samn_nr + "'";
          command.ExecuteNonQuery();

          command.CommandText = "DELETE FROM samningar WHERE id = '" + samn_nr + "'";
          command.ExecuteNonQuery();

          command.CommandText = "UPDATE vidskm SET msamn = 'N' WHERE nr = '"+comboBox2.Text+"'";
          command.ExecuteNonQuery();
          vidskm_lesa();
        }


      private void dataGridView1_CellContentClick(object sender, KeyEventArgs e)
      {
          dataGridView1.Columns[2].DefaultCellStyle.Format = "N0";
          dataGridView1.Columns[5].DefaultCellStyle.Format = "N0";
          //dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
                  lina_vskp[dataGridView1.CurrentRow.Index] = gl4.vsk;
                  lina_vskf[dataGridView1.CurrentRow.Index] = gl4.vskf;

              }
              gl4.Close();

          }

          if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
          {
                  // Ef vörunúmer ekki tómt og Vörunafn er tómt
              if (Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value) != "")
                  //if (Convert.ToString(dataGridView1.Rows[n].Cells[0].Value) != "" && Convert.ToString(dataGridView1.Rows[n].Cells[1].Value) == "")
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
                          if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) == "")
                          {
                              dataGridView1.CurrentRow.Cells[2].Value = Reader.GetDouble(1);
                          }
                          
                          lina_vskp[dataGridView1.CurrentRow.Index] = Reader.GetFloat(2);
                          lina_vskf[dataGridView1.CurrentRow.Index] = Reader.GetString(3);

                      }
                      Reader.Close();
                      connection.Close();
                  }
                  if (Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value) != "")//Ef magn er ekki tómt
                  {
                      // Hér er verðið sett inn ein verð * magn - afsl sem er i prósentu
                      lina_afsl[dataGridView1.CurrentRow.Index] = ((Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value) * ((Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value))) * (Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value) / 100)));
                      dataGridView1.CurrentRow.Cells[5].Value = (Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value) * (Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value)) - lina_afsl[dataGridView1.CurrentRow.Index]);
                      //Cells 0 ITEM - 1 Texti - 2 verð - 3 magn - 4 afsl - 5 samtals - 6 samtals + vsk - 7 vask flokkur vsk_f
                      //usamtals er upphæð á nótu samtals án vsk
                      // Margeir usamtals = usamtals + Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
                      //Hér er síðan reiknað út verð á línu með vsk l_vsk[númerlínu] hefur að geyma vask %
                      //Ekki verið að sýna það hér en þarf að reikan og hafa
                      //dataGridView1.Rows[n].Cells[6].Value = (Convert.ToInt32(dataGridView1.Rows[n].Cells[5].Value) * (1 + (l_vsk[n] / 100))).ToString("N0");
                      //Hér þarf að fá samtals upphæð vsk pr. línu 
                      if (lina_vskf[dataGridView1.CurrentRow.Index] == "S1")
                      {
                          sl_vsk1[dataGridView1.CurrentRow.Index] = (Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value) * (lina_vskp[dataGridView1.CurrentRow.Index])/100);
                          reportData.Text = lina_vskp[dataGridView1.CurrentRow.Index].ToString() + "|" + sl_vsk1[dataGridView1.CurrentRow.Index] + " | " + dataGridView1.CurrentRow.Index;
                      }

                      else
                      {
                          sl_vsk2[dataGridView1.CurrentRow.Index] = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value) * (lina_vskp[dataGridView1.CurrentRow.Index]/100);
                          reportData.Text = lina_vskp[dataGridView1.CurrentRow.Index].ToString();

                      }
                        
                  }
                                
          }

          if (e.KeyCode == Keys.F4)
          {
              int t = 0;
              double samtals = 0;
              double vsk1 = 0;
              double vsk2 = 0;
              double afsl = 0;

              
            while (t < dataGridView1.RowCount)
            {
                samtals = samtals + Math.Round(Convert.ToDouble(dataGridView1.Rows[t].Cells[5].Value),0);
                vsk1 = vsk1 + Math.Round(sl_vsk1[t],0);
                vsk2 = vsk2 + Math.Round(sl_vsk2[t],0);
                afsl = afsl + Math.Round(lina_afsl[t],0);
                
                tsamtals.Text = samtals.ToString("N0");
                t1vsk.Text = vsk1.ToString("N0");
                t2vsk.Text = vsk2.ToString("N0");
                textafsl.Text = afsl.ToString("N0");
                tmvsk.Text = (samtals + vsk1 + vsk2).ToString("N0");

                t++;
            }
          }

          if (e.KeyCode == Keys.F5)
          {
              double vsk1 = 0;
              double vsk2 = 0;

              MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
              MySqlCommand command = connection.CreateCommand();
              //MySqlDataReader Reader;

              connection.Open();

              command.CommandText = "DELETE FROM sam_item WHERE id_reikn = '" + vnum + "'";
              command.ExecuteNonQuery();

              
              for (int i = 0; i < (dataGridView1.Rows.Count); i++)
              {
                  if (dataGridView1.Rows[i].Cells[0].Value == null) break;
                  double lverd = Convert.ToDouble(dataGridView1[2, i].Value);
                  double sl_verd = Convert.ToDouble(dataGridView1[5, i].Value);
                  double tlvsk = sl_vsk1[i] + sl_vsk2[i];
                  vsk1 = vsk1 + sl_vsk1[i];
                  vsk2 = vsk2 + sl_vsk2[i];
                  command.Parameters.Add("?qty", Convert.ToDouble(dataGridView1[3, i].Value));
                  command.Parameters.Add("?lafsl", Convert.ToDouble(dataGridView1[4, i].Value));
                  command.CommandText = "INSERT INTO sam_item (id,id_reikn,lysing,item,qty,uverd,verd,vsk,lafsl,vfl) VALUES (NULL,'" + vnum + "','" + (string)dataGridView1[1, i].Value + "','" + (string)dataGridView1[0, i].Value + "',?qty,'" + lverd + "','" + Math.Round(sl_verd) + "','" + Math.Round(tlvsk) + "',?lafsl,'" + lina_vskf[i] + "')";

                  command.ExecuteNonQuery();
                  command.Parameters.Clear();
              }
              command.CommandText = "UPDATE samningar SET stofnd='"+DateTime.Now.ToString("yyyy:MM:dd")+"', samtals='"+Convert.ToDouble(tsamtals.Text)+"', afsl='"+Convert.ToDouble(textafsl.Text)+"', vsk1='"+Math.Round(vsk1)+"', vsk2='"+Math.Round(vsk2)+"',texti='"+rhaus1.Text+"' WHERE id = "+vnum+"";   
              command.ExecuteNonQuery();
          }
      }
       




      
// hér endar formið 

    }
}
