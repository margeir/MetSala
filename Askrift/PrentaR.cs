using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Drawing;
using System.Xml;
using MySql.Data.MySqlClient;

namespace Askrift
{
    public class PrentaR
    {

        private System.Xml.XmlTextReader xmlReader;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printHreyfingar;
        private System.Windows.Forms.PrintDialog printDialog1;

        MySqlConnection connection = new MySqlConnection(MetSala.MyConString);
        
        MySqlDataReader Reader;

          System.Drawing.Font headerFont = new Font("Arial", 14);
          System.Drawing.Font bodyFont = new Font("Arial", 10);
          System.Drawing.Font smairFont = new Font("Arial", 8);
          System.Drawing.Font storiFont = new Font("Arial", 18, FontStyle.Bold);
          System.Drawing.Font samtalsFont = new Font("Arial", 12, FontStyle.Bold);
          string fnafn = "";
          string fheimili = "";
          string fsveitaf = "";
          string ftexti1 = "";
          string fktvsk = "";
          string fkt = null;
          string reikningur = "REIKNINGUR";
          string tegund = null;
          double samtals_s = 0;
          double samtals_d = 0;
          double vsk1_s = 0;
          double vsk1_d = 0;
          double vsk2_s = 0;
          double vsk2_d = 0;
          double afsl_s = 0;
          double afsl_d = 0;
          ArrayList vidskm = new ArrayList();
          ArrayList vidskmnafn = new ArrayList();
          string dags1;
          string dags2;
          int sida = 0;
          int fll = 0;
          int flli = 0;
          int sidavskm = 0;
         
          public void lesaeiganda()
          {
             try
              {

                  XmlDocument doc = new XmlDocument();
                  doc.Load("fyrirt.xml");

                  XmlNodeList fyrirt = doc.GetElementsByTagName("KT");

                  foreach (XmlNode node in fyrirt)
                  {

                      XmlElement FElement = (XmlElement)node;

                      fnafn = FElement.GetElementsByTagName("Nafn")[0].InnerText;
                      fheimili = FElement.GetElementsByTagName("Heimili")[0].InnerText;
                      fsveitaf = FElement.GetElementsByTagName("Sveitarf")[0].InnerText;
                      ftexti1 = FElement.GetElementsByTagName("Texti1")[0].InnerText;
                      fktvsk = FElement.GetElementsByTagName("Ktvsk")[0].InnerText;
                    
                      if (FElement.HasAttributes)
                      {

                          fkt = FElement.Attributes["kt"].InnerText;

                      }

                    
                  }


              }
              catch (Exception ex)
              {
                  // If any error occurs, display a messagebox.
                  MessageBox.Show("Error printing report: \r\n" + ex.Message);
              }


          }
        public void prenta(int teg)
        {
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Reikningur";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;

            if (fkt == null)
            { lesaeiganda(); }
            // tekur á því hvaða tegun af reikninum er verið að prenta
            if (teg == 1)
            { tegund = "AFRIT"; }
            else if (teg == 2)
            { tegund = "KREDIT"; }
            else
                tegund = "";

            // Perform the print within a try block in case a failure
            // of any type occurs.  For this sample, all errors will
            // be handled generically by simply displaying a messagebox.
            try
            {
                // Open the XML Data file.
                xmlReader = new System.Xml.XmlTextReader("reikn.xml");

                // Position the pointer to the first element.
                xmlReader.Read();

                // Display a printer selection dialog.
                // Only print the document if the user clicks OK.

                     // This starts the actual print.  The code to output
                    // text to the selected printer resides in the PrintDocument1_PrintPage
                    // event handler.
                    printDocument1.Print();

                

                // Close the data file.
                xmlReader.Close();

            }
            catch (Exception ex)
            {
                // If any error occurs, display a messagebox.
                MessageBox.Show("Error printing report: \r\n" + ex.Message);
            }

        }



  private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
      
            // Determine the height of the header, based on the selected font.
            float headerHeight = headerFont.GetHeight(e.Graphics);

            // Determine the number of lines of body text that can be printed per page, taking
            // into account the presence of the header and the size of the selected body font.
            float linesPerPage = 55;
                // linesPerPage =(e.MarginBounds.Height - headerHeight) / bodyFont.GetHeight(e.Graphics);

            // Used to store the position at which the next body line
            // should be printed.
            float yPosition = 0;

            // Used to store the number of lines printed so far on the
            // current page.
            int count = 0;

            // User to store the text of the current line.
            string line = null;
            string rnumer = null;

            // Print the page header, as specified by the user in the form.
            // Use the header font for this line only.
            Image logo = Image.FromFile("logo.jpg");
            int x = 10;
            int y = 10;
            int width = 160;
            int height = 74;
            int l = 200;
            storiFont = new Font("Arial", 18, FontStyle.Bold);
            samtalsFont = new Font("Arial", 12, FontStyle.Bold);

            e.Graphics.DrawImage(logo, x, y, width, height);
            e.Graphics.DrawString(fnafn, headerFont, Brushes.Black, e.MarginBounds.Left + 80, e.MarginBounds.Top - 85, new StringFormat());
            e.Graphics.DrawString(fheimili, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 65, new StringFormat());
            e.Graphics.DrawString(fsveitaf, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 50, new StringFormat());
            e.Graphics.DrawString(ftexti1, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 15, new StringFormat());
            e.Graphics.DrawString(reikningur, storiFont, Brushes.Black, e.MarginBounds.Right - 150, e.MarginBounds.Top - 85, new StringFormat());
            e.Graphics.DrawString(tegund, headerFont, Brushes.Black, e.MarginBounds.Right - 150, e.MarginBounds.Top - 55, new StringFormat());
            e.Graphics.DrawString(fktvsk, smairFont, Brushes.Black, e.MarginBounds.Right - 150, e.MarginBounds.Top - 15, new StringFormat());
            e.Graphics.DrawString("Þessi reikningur er úr rafrænu bókhaldskerfi skv. reglugerð 598/1999", smairFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());
            e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left - 85, 100, e.MarginBounds.Right, 100);
            e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, 292, e.MarginBounds.Right, 292);
            //Neðsta línan
            e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, e.MarginBounds.Bottom - 15, e.MarginBounds.Right, e.MarginBounds.Bottom - 15);
            // Print each line of the data file, but don't exceed the maximum allowable
            // number of lines per page.  Also, stop when the end of the data file is
            // reached.  This event is called once per page, so if the data exceeds a single
            // page, the XmlTextReader will pick up where it left off on the previous page.
            while (count < linesPerPage && !xmlReader.EOF)
            {
                // Move the pointer to the next "context" line in the Xml data file.
                // If the line is not an XML element, then it can be skipped.
                // Because the initial Read() call made when the xmlReader was opened
                // positioned the file to the first element (<Customers>) the following
                // call actually moves to the first <Customer> tag the first time through.
                if (xmlReader.MoveToContent() == System.Xml.XmlNodeType.Element)
                {
                    // Based on the element, determine what to print and where to print it.
                    switch (xmlReader.Name)
                    {
                        case "Reikningar":
                            {
                                // This is not really required, since the initial Read() call
                                // when the xmlReader is loaded effectively bypasses the opening element
                                // as described in the comments above.  Included here for explanation only.

                                // If a <Customers> tag is encountered, just print a blank line.
                                line = " ";

                                // Tell the XmlTextReader to move on to the next element.
                                xmlReader.Read();

                                break;
                            }
                        case "Dags":
                            {
                                e.Graphics.DrawString("Reikningur Nr.", smairFont, Brushes.Black, e.MarginBounds.Right - 190, e.MarginBounds.Top + 10, new StringFormat());
                                e.Graphics.DrawString("Dagsetning.", smairFont, Brushes.Black, e.MarginBounds.Right - 190, e.MarginBounds.Top + 25, new StringFormat());
                                e.Graphics.DrawString(xmlReader.ReadElementString(), smairFont, Brushes.Black, e.MarginBounds.Right - 90, e.MarginBounds.Top + 25, new StringFormat());
                                xmlReader.Read();
                                //Prentun nafn viðskiptavinar
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left - 10, e.MarginBounds.Top + 60, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString("Viðskiptanúmer  " + xmlReader.ReadElementString(), smairFont, Brushes.Black, e.MarginBounds.Left + 200, e.MarginBounds.Top + 10, new StringFormat());
                                xmlReader.Read();
                                //Prentun Viðskiptavinur 1. kennitala 2. Heimili 3. Póstnúmer
                                e.Graphics.DrawString("Kennitala. " + xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left, 260, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left - 10, e.MarginBounds.Top + 75, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left - 10, e.MarginBounds.Top + 90, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left + 20, e.MarginBounds.Top + 90, new StringFormat());
                                xmlReader.Read();
                                line = "";
                                break;
                            }
                        case "solumadur":
                            {
                                e.Graphics.DrawString("Sölumaður.", smairFont, Brushes.Black, e.MarginBounds.Right - 190, e.MarginBounds.Top + 40, new StringFormat());
                                e.Graphics.DrawString(xmlReader.ReadElementString(), smairFont, Brushes.Black, e.MarginBounds.Right - 90, e.MarginBounds.Top + 40, new StringFormat());
                                e.Graphics.DrawString("Verk Nr.", smairFont, Brushes.Black, e.MarginBounds.Right - 190, e.MarginBounds.Top + 55, new StringFormat());
                                e.Graphics.DrawString("Tilboð Nr.", smairFont, Brushes.Black, e.MarginBounds.Right - 190, e.MarginBounds.Top + 70, new StringFormat());
                                break;
                            }
                        case "Numer":
                            {
                                rnumer = xmlReader.ReadElementString();
                                e.Graphics.DrawString(rnumer, smairFont, Brushes.Black, e.MarginBounds.Right - 90, e.MarginBounds.Top + 10, new StringFormat());
                                e.Graphics.DrawString(rnumer, samtalsFont, Brushes.Black, e.MarginBounds.Right - 80, e.MarginBounds.Bottom, new StringFormat());
                                xmlReader.Read();
                                break;
                            }
                        case "Reikningur":
                            {
                                line = "Aukatexti / Lýsing \n";
                                xmlReader.Read();

                                break;
                            }
                        case "Item":
                            {
                                e.Graphics.DrawString("Nr.", bodyFont, Brushes.Black, e.MarginBounds.Left, 275, new StringFormat());
                                e.Graphics.DrawString("Vörulýsing", bodyFont, Brushes.Black, e.MarginBounds.Left + 50, 275, new StringFormat());
                                e.Graphics.DrawString("Magn", bodyFont, Brushes.Black, e.MarginBounds.Left + 370, 275, new StringFormat());
                                e.Graphics.DrawString("Afs %", bodyFont, Brushes.Black, e.MarginBounds.Left + 420, 275, new StringFormat());
                                e.Graphics.DrawString("Ein.Verð", bodyFont, Brushes.Black, e.MarginBounds.Left + 470, 275, new StringFormat());
                                e.Graphics.DrawString("Verð", bodyFont, Brushes.Black, e.MarginBounds.Left + 560, 275, new StringFormat());
                                
                                //xmlReader.Read();
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + l, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left + 50, e.MarginBounds.Top + l, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left + 380, e.MarginBounds.Top + l, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left + 430, e.MarginBounds.Top + l, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left + 530, e.MarginBounds.Top + l, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                                xmlReader.Read();
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left + 600, e.MarginBounds.Top + l, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                                xmlReader.Read();
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.LightGray, e.MarginBounds.Left + 620, e.MarginBounds.Top + l, new StringFormat());
                                xmlReader.Read();
                                l = l + 20;
                                line = "";   //verð að hreinsa úr línu þannig að það prentist ekki endalasut.
                                break;
                            }
                        case "Texti2":
                            {
                                e.Graphics.DrawString(xmlReader.ReadElementString(), bodyFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + l+80, new StringFormat());
                                xmlReader.Read();
                                break;
                            }

                        case "Samtals":
                            {
                                e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, e.MarginBounds.Bottom - 250, e.MarginBounds.Right, e.MarginBounds.Bottom - 250);
                                e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, e.MarginBounds.Bottom - 250, e.MarginBounds.Left, 292);
                                e.Graphics.DrawString("Samtals með vsk. " + xmlReader.ReadElementString(), samtalsFont, Brushes.Black, e.MarginBounds.Left + 400, e.MarginBounds.Bottom - 170, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString("VSK 25,5%   " + xmlReader.ReadElementString(), smairFont, Brushes.Black, e.MarginBounds.Right - 150, e.MarginBounds.Bottom - 200, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString("VSK 7%   " + xmlReader.ReadElementString(), smairFont, Brushes.Black, e.MarginBounds.Right - 250, e.MarginBounds.Bottom - 200, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString("Samtals án VSK   " + xmlReader.ReadElementString(), smairFont, Brushes.Black, e.MarginBounds.Left + 470, e.MarginBounds.Bottom - 220, new StringFormat());
                                xmlReader.Read();
                                e.Graphics.DrawString("Samtals afsláttur   " + xmlReader.ReadElementString(), smairFont, Brushes.Black, e.MarginBounds.Left + 320, e.MarginBounds.Bottom - 220, new StringFormat());
                                break;
                            }
                        default:
                            {
                                // All other elements in the sample XML file are actual data
                                // fields pertaining to a customer record.  Print the field name
                                // and value.  The ReadElementString retrieves the value and 
                                // automatically forces the XmlTextReader to move on to the 
                                // next element.  Because this is handled generically, any additional
                                // customer fields added inside the <Customer> tag in the xml file will 
                                // automatically be shown in the printed report.
                                line = xmlReader.ReadElementString();
                                break;
                            }
                    }

                    
                    yPosition = e.MarginBounds.Bottom - 250 + (count * bodyFont.GetHeight(e.Graphics));
                    e.Graphics.DrawString(line, bodyFont, Brushes.Black, e.MarginBounds.Left, yPosition, new StringFormat());
                    line = "";
                    // Increment the counter to show that another line has been printed.
                    // This is used in the positioning of future lines of text on the current page.
                    count++;
                }
                else
                {
                    // If the XmlTextReader is positioned on a line that is NOT an
                    // Element, then just go on to the next line.
                    xmlReader.Read();
                }
            }

            // If more data exists, print another page.  If not stop this event from firing
            // again by setting the HasMorePages property to false.
            if (xmlReader.EOF)
                e.HasMorePages = false;
            else
                e.HasMorePages = true;
        }


  public void prentaHdags(string d1,string d2)
  {
      this.printHreyfingar = new System.Drawing.Printing.PrintDocument();
      this.printDialog1 = new System.Windows.Forms.PrintDialog();

      string d_fra = d1;
      string d_til = d2;

      if (fkt == null)
      { lesaeiganda(); }

      MySqlCommand command = connection.CreateCommand();
      // 
      // printDocument1
      // 
      this.printHreyfingar.DocumentName = "Hreyfingar";
      this.printHreyfingar.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printHreyfingarF);
      // 
      // printDialog1
      // 
      this.printDialog1.Document = this.printHreyfingar;
      // Perform the print within a try block in case a failure
      // of any type occurs.  For this sample, all errors will
      // be handled generically by simply displaying a messagebox.
      DialogResult ilagi = printDialog1.ShowDialog();
      if (ilagi == DialogResult.OK)
      {
          try
          {

              connection.Open();
              command.CommandText = "hreyfingar_dags";
              command.CommandType = CommandType.StoredProcedure;
              command.Parameters.Add("?dags1", d_fra);
              command.Parameters["?dags1"].Direction = ParameterDirection.Input;
              command.Parameters.Add("?dags2", d_til);
              command.Parameters["?dags2"].Direction = ParameterDirection.Input;
              Reader = command.ExecuteReader();
              printHreyfingar.Print();
              Reader.Close();
              connection.Close();

          }
          catch (Exception ex)
          {
              // If any error occurs, display a messagebox.
              MessageBox.Show("Villa við útprentun á hreyfingum: \r\n" + ex.Message);
          }
      }
  }

  public void prentasamninga()
  {
      this.printHreyfingar = new System.Drawing.Printing.PrintDocument();
      this.printDialog1 = new System.Windows.Forms.PrintDialog();

      if (fkt == null)
      { lesaeiganda(); }

      MySqlCommand command = connection.CreateCommand();
      // 
      // printDocument1
      // 
      this.printHreyfingar.DocumentName = "Samningar";
      this.printHreyfingar.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printSamningaF);
      // 
      // printDialog1
      // 
      this.printDialog1.Document = this.printHreyfingar;
      // Perform the print within a try block in case a failure
      // of any type occurs.  For this sample, all errors will
      // be handled generically by simply displaying a messagebox.
      DialogResult ilagi = printDialog1.ShowDialog();
      if (ilagi == DialogResult.OK)
      {
          try
          {

              connection.Open();
              command.CommandText = "samningar_a";
              command.CommandType = CommandType.StoredProcedure;
              Reader = command.ExecuteReader();
              printHreyfingar.Print();
              Reader.Close();
              connection.Close();

          }
          catch (Exception ex)
          {
              // If any error occurs, display a messagebox.
              MessageBox.Show("Villa við útprentun á hreyfingum: \r\n" + ex.Message);
          }
      }
  }


  public void prentaHreyfingar(string d1, string d2, string kt)
  {
      //Prenta hreyfingar viðskiptavina
      this.printHreyfingar = new System.Drawing.Printing.PrintDocument();
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      dags1 = d1;
      dags2 = d2;
     

      if (fkt == null)
      { lesaeiganda(); }

      MySqlCommand command = connection.CreateCommand();
      // 
      // printDocument1
      // 
      this.printHreyfingar.DocumentName = "Viðskiptamenn";
      this.printHreyfingar.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printHreyfingarV);
      // 
      // printDialog1
      // 
      this.printDialog1.Document = this.printHreyfingar;
      // Perform the print within a try block in case a failure
      // of any type occurs.  For this sample, all errors will
      // be handled generically by simply displaying a messagebox.
      DialogResult ilagi = printDialog1.ShowDialog();
      if (ilagi == DialogResult.OK)
      {
          // Finnum alla viðskiðtavini með hreyfingu í töflu reikningar 
          connection.Open();
         if (kt == "")
         {
              command.CommandText = "vidskm_mh";
              command.CommandType = CommandType.StoredProcedure;
              command.Parameters.Add("?dags1", dags1);
              command.Parameters["?dags1"].Direction = ParameterDirection.Input;
              command.Parameters.Add("?dags2", dags2);
              command.Parameters["?dags2"].Direction = ParameterDirection.Input;
              command.Parameters.Add("?kennitala", kt);
              command.Parameters["?kennitala"].Direction = ParameterDirection.Input;
         }
          else
          {
              command.CommandText = "SELECT nr,nafn FROM vidskm WHERE nr = '" + kt + "'";
          }
          Reader = command.ExecuteReader();
         
              while(Reader.Read())
              {
                  vidskm.Add(Reader.GetString(0));
                  vidskmnafn.Add(Reader.GetString(1));
              }
              Reader.Close();
          
          try
          {
                            
              printHreyfingar.Print();
              connection.Close();

          }
          catch (Exception ex)
          {
              // If any error occurs, display a messagebox.
              MessageBox.Show("Villa við útprentun á hreyfingum: \r\n" + ex.Message);
          }
      }
  }




  private void printHreyfingarF(object sender, System.Drawing.Printing.PrintPageEventArgs e)
  {

      // Determine the height of the header, based on the selected font.
      float headerHeight = headerFont.GetHeight(e.Graphics);

      // Determine the number of lines of body text that can be printed per page, taking
      // into account the presence of the header and the size of the selected body font.
      float linesPerPage = 54;

      // Used to store the position at which the next body line
      // should be printed.
      float yPosition = 0;

      // Used to store the number of lines printed so far on the
      // current page.
      int count = 0;

      // User to store the text of the current line.
      string id = "";
      string dags = "";
      string samtals = "";
      string vsk1 = "";
      string vsk2 = "";
      string afsl = "";
      string nafn = "";
         

      // Print the page header, as specified by the user in the form.
      // Use the header font for this line only.
      Image logo = Image.FromFile("logo.jpg");
      
    
      storiFont = new Font("Arial", 18, FontStyle.Bold);
      samtalsFont = new Font("Arial", 12, FontStyle.Bold);

      e.Graphics.DrawString(fnafn, headerFont, Brushes.Black, e.MarginBounds.Left + 80, e.MarginBounds.Top - 85, new StringFormat());
      e.Graphics.DrawString(fheimili, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 65, new StringFormat());
      e.Graphics.DrawString(fsveitaf, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 50, new StringFormat());
      e.Graphics.DrawString(ftexti1, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 15, new StringFormat());
      e.Graphics.DrawString("HREYFINGARLISTI", storiFont, Brushes.Black, e.MarginBounds.Right - 170, e.MarginBounds.Top - 85, new StringFormat());
      e.Graphics.DrawString("****", smairFont, Brushes.Black, e.MarginBounds.Right - 150, e.MarginBounds.Top - 15, new StringFormat());
      e.Graphics.DrawString("Alls samtals", smairFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());
      e.Graphics.DrawString("Dagsetning", bodyFont, Brushes.Black, e.MarginBounds.Left, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("Númer", bodyFont, Brushes.Black, e.MarginBounds.Left + 50, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      //e.Graphics.DrawString("", bodyFont, Brushes.Black, e.MarginBounds.Left + 70, 110, new StringFormat());
      e.Graphics.DrawString("KREDIT", bodyFont, Brushes.Black, e.MarginBounds.Left + 160, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("VSK S1", bodyFont, Brushes.Black, e.MarginBounds.Left + 260, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("VSK S2", bodyFont, Brushes.Black, e.MarginBounds.Left + 360, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("Afsl.", bodyFont, Brushes.Black, e.MarginBounds.Left + 410, 110, new StringFormat());
      e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left - 85, 100, e.MarginBounds.Right + 85, 100);
      //e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, 292, e.MarginBounds.Right, 292);
      //Neðsta línan
      e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, e.MarginBounds.Bottom - 15, e.MarginBounds.Right, e.MarginBounds.Bottom - 15);
      // Print each line of the data file, but don't exceed the maximum allowable
      // number of lines per page.  Also, stop when the end of the data file is
      // reached.  This event is called once per page, so if the data exceeds a single
      // page, the XmlTextReader will pick up where it left off on the previous page.
      while (Reader.Read())
      {
          id = Reader.GetInt32(0).ToString();
          dags = Reader.GetString(1).PadRight(10);
          samtals = Reader.GetInt32(2).ToString("N0");
          vsk1 = Reader.GetInt32(4).ToString("N0");
          vsk2 = Reader.GetInt32(5).ToString("N0");
          afsl = Reader.GetInt32(3).ToString("N0");
          nafn = Reader.GetInt32(6).ToString();
          

          samtals_s = samtals_s + Reader.GetInt32(2);
          vsk1_s = vsk1_s + Reader.GetInt32(4);
          vsk2_s = vsk2_s + Reader.GetInt32(5);
          afsl_s = afsl_s + Reader.GetInt32(3);

          //line = Reader.GetString(0)+"     "+Reader.GetString(3)+"       "+Reader.GetString(1)+" "+Reader.GetString(2);

          yPosition = e.MarginBounds.Top + 28 + (count * bodyFont.GetHeight(e.Graphics));
          //e.Graphics.DrawString(line, bodyFont, Brushes.Black, e.MarginBounds.Left, yPosition, new StringFormat());
          e.Graphics.DrawString(dags, bodyFont, Brushes.Black, e.MarginBounds.Left, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(id, bodyFont, Brushes.Black, e.MarginBounds.Left + 50, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(nafn, bodyFont, Brushes.Black, e.MarginBounds.Left + 80, yPosition, new StringFormat());
          e.Graphics.DrawString(samtals, bodyFont, Brushes.Black, e.MarginBounds.Left + 160, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk1, bodyFont, Brushes.Black, e.MarginBounds.Left + 260, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk2, bodyFont, Brushes.Black, e.MarginBounds.Left + 360, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(afsl, bodyFont, Brushes.Black, e.MarginBounds.Left + 450, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
         
          if (count == linesPerPage)
              break;
          // Increment the counter to show that another line has been printed.
          // This is used in the positioning of future lines of text on the current page.
          count++;
      }
              if (count == linesPerPage)
              {
                  e.HasMorePages = true;
                  e.Graphics.DrawString(samtals_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 160, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(vsk1_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 260, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(vsk2_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 360, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(afsl_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 450, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));

                  //e.Graphics.DrawString(vsk1_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 640, e.MarginBounds.Bottom - 50 , new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  //e.Graphics.DrawString(samtals_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 500, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  samtals_d = samtals_d + samtals_s;
                  samtals_s = 0;
                  vsk1_d = vsk1_d + vsk1_s;
                  vsk1_s = 0;
                  vsk2_d = vsk2_d + vsk2_s;
                  vsk2_s = 0;
                  afsl_d = afsl_d + afsl_s;
                  afsl_s = 0;
                                
              }
              else
              {
                  e.HasMorePages = false;
                  samtals_d = samtals_d + samtals_s;
                  vsk1_d = vsk1_d + vsk1_s;
                  vsk2_d = vsk2_d + vsk2_s;
                  afsl_d = afsl_d + afsl_s;

                  e.Graphics.DrawString(samtals_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 160, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(vsk1_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 260, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(vsk2_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 360, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(afsl_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 450, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));

                  //e.Graphics.DrawString(vsk1_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 640, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  //e.Graphics.DrawString(vsk1_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 640, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(samtals_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 160, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(vsk1_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 260, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(vsk2_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 360, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(afsl_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 450, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));

                  //e.Graphics.DrawString(samtals_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 500, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  //e.Graphics.DrawString(samtals_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 500, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
              
                }   
      }

  private void printHreyfingarV(object sender, System.Drawing.Printing.PrintPageEventArgs e)
  {
      //Hreyfingarlisti fyrir viðskipamenn útprentun
      // Determine the height of the header, based on the selected font.
      float headerHeight = headerFont.GetHeight(e.Graphics);

      // Determine the number of lines of body text that can be printed per page, taking
      // into account the presence of the header and the size of the selected body font.
      float linesPerPage = 54;

      // Used to store the position at which the next body line
      // should be printed.
      float yPosition = 0;

      // Used to store the number of lines printed so far on the
      // current page.
      int count = 0;
      
      // User to store the text of the current line.
      string id = "";
      DateTime dags = DateTime.Now;
      string samtals = "";
      string vsk1 = "";
      string vsk2 = "";
      string afsl = "";
            
      

      // Print the page header, as specified by the user in the form.
      storiFont = new Font("Arial", 18, FontStyle.Bold);
      samtalsFont = new Font("Arial", 12, FontStyle.Bold);
      MySqlCommand command = connection.CreateCommand();


      

      e.Graphics.DrawString(fnafn, headerFont, Brushes.Black, e.MarginBounds.Left + 80, e.MarginBounds.Top - 85, new StringFormat());
     // e.Graphics.DrawString(fheimili, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 65, new StringFormat());
     // e.Graphics.DrawString(fsveitaf, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 50, new StringFormat());
     // e.Graphics.DrawString(ftexti1, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 15, new StringFormat());
      e.Graphics.DrawString("HREYFINGAR VIÐSKIPTAMENN", storiFont, Brushes.Black, e.MarginBounds.Right - 370, e.MarginBounds.Top - 85, new StringFormat());
      e.Graphics.DrawString("****", smairFont, Brushes.Black, e.MarginBounds.Right - 150, e.MarginBounds.Top - 15, new StringFormat());
      e.Graphics.DrawString("Alls samtals", smairFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());
      e.Graphics.DrawString("Dagsetning", bodyFont, Brushes.Black, e.MarginBounds.Left, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("Númer", bodyFont, Brushes.Black, e.MarginBounds.Left + 50, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      //e.Graphics.DrawString("", bodyFont, Brushes.Black, e.MarginBounds.Left + 70, 110, new StringFormat());
      e.Graphics.DrawString("DEBIT", bodyFont, Brushes.Black, e.MarginBounds.Left + 160, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("VSK S1", bodyFont, Brushes.Black, e.MarginBounds.Left + 260, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("VSK S2", bodyFont, Brushes.Black, e.MarginBounds.Left + 360, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("Afsl.", bodyFont, Brushes.Black, e.MarginBounds.Left + 410, 110, new StringFormat());
      e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left - 85, 100, e.MarginBounds.Right + 85, 100);
      //e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, 292, e.MarginBounds.Right, 292);
      //Neðsta línan
      e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, e.MarginBounds.Bottom - 15, e.MarginBounds.Right, e.MarginBounds.Bottom - 15);
      // Print each line of the data file, but don't exceed the maximum allowable
      // number of lines per page.  Also, stop when the end of the data file is
      // reached.  This event is called once per page, so if the data exceeds a single
      // page, the XmlTextReader will pick up where it left off on the previous page.
      
      //if(sida < vidskm.Count)
      if(count < linesPerPage)
      {
         if (fll == 1)
          {
              sida = sida - 1;
          }
          command.CommandText = "SELECT  id,reiknd,samtals,afsl,vsk1,vsk2 FROM reikningar WHERE vidskm_nr = '" + vidskm[sida] + "' AND reiknd >= '"+dags1+"' AND reiknd <= '"+dags2+"' ORDER BY reiknd ";
              Reader = command.ExecuteReader();
              e.Graphics.DrawString(vidskmnafn[sida].ToString(), storiFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - 45, new StringFormat());
              e.Graphics.DrawString(vidskm[sida].ToString(), smairFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - 65, new StringFormat());
              if (fll == 1)
              {
                  while (flli != 0)
                  {
                      Reader.Read();
                      flli--;
                  }
                  fll = 0;
              }

          while (Reader.Read())
                  {
                      
                      id = Reader.GetInt32(0).ToString();
                      dags = Convert.ToDateTime(Reader.GetString(1));
                      samtals = Reader.GetInt32(2).ToString("N0");
                      vsk1 = Reader.GetInt32(4).ToString("N0");
                      vsk2 = Reader.GetInt32(5).ToString("N0");
                      afsl = Reader.GetInt32(3).ToString("N0");


                      yPosition = e.MarginBounds.Top + 28 + (count * bodyFont.GetHeight(e.Graphics));

                      e.Graphics.DrawString(dags.ToString("dd.MM.yyyy"), bodyFont, Brushes.Black, e.MarginBounds.Left, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                      e.Graphics.DrawString(id, bodyFont, Brushes.Black, e.MarginBounds.Left + 50, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                      e.Graphics.DrawString(samtals, bodyFont, Brushes.Black, e.MarginBounds.Left + 160, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                      e.Graphics.DrawString(vsk1, bodyFont, Brushes.Black, e.MarginBounds.Left + 260, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                      e.Graphics.DrawString(vsk2, bodyFont, Brushes.Black, e.MarginBounds.Left + 360, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                      e.Graphics.DrawString(afsl, bodyFont, Brushes.Black, e.MarginBounds.Left + 450, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                      samtals_s = samtals_s + Reader.GetInt32(2);
                      vsk1_s = vsk1_s + Reader.GetInt32(4);
                      vsk2_s = vsk2_s + Reader.GetInt32(5);
                      afsl_s = afsl_s + Reader.GetInt32(3);
                      
                      // Increment the counter to show that another line has been printed.
                      // This is used in the positioning of future lines of text on the current page.
                      count++;
                       
                      if (count >= linesPerPage)
                      {
                        e.HasMorePages = true;
                          fll = 1;
                          flli = count;
                          break;
                         // þarf að bæta við ef sami viðskiptavinur fer yfir á nýja síðu 
                         //ekki loka reader og halda lestri áfram.
                         
                       }
              
                }
                  //e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, yPosition + 17, e.MarginBounds.Right, yPosition + 17);
                  sidavskm++; //TElja síður þarf að vera til þess að hægt að telja ef um fl. en eina síðu pr. viðskiptamann
                  e.Graphics.DrawString(samtals_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 160, e.MarginBounds.Bottom - 29, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(vsk1_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 260, e.MarginBounds.Bottom - 29, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(vsk2_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 360, e.MarginBounds.Bottom - 29, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  e.Graphics.DrawString(afsl_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 450, e.MarginBounds.Bottom - 29, new StringFormat(StringFormatFlags.DirectionRightToLeft));
                  samtals_d = samtals_d + samtals_s;
                  samtals_s = 0;
                  vsk1_d = vsk1_d + vsk1_s;
                  vsk1_s = 0;
                  vsk2_d = vsk2_d + vsk2_s;
                  vsk2_s = 0;
                  afsl_d = afsl_d + afsl_s;
                  afsl_s = 0;
                   sida++;
                   e.Graphics.DrawString("Síða", bodyFont, Brushes.Black, e.MarginBounds.Left + 500, e.MarginBounds.Bottom + 10, new StringFormat());
                   e.Graphics.DrawString(sidavskm.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 530, e.MarginBounds.Bottom + 10, new StringFormat());
                   //e.Graphics.DrawString("af", bodyFont, Brushes.Black, e.MarginBounds.Left + 550, e.MarginBounds.Bottom + 10, new StringFormat());
                   //e.Graphics.DrawString(Convert.ToString(vidskm.Count + sidavskm), bodyFont, Brushes.Black, e.MarginBounds.Left + 570, e.MarginBounds.Bottom + 10, new StringFormat());
                  e.HasMorePages = true;
                  Reader.Close();
                             
            }
      if (sida == vidskm.Count && fll == 0)
      {
          e.HasMorePages = false;
          e.Graphics.DrawString(samtals_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 160, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk1_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 260, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk2_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 360, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(afsl_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 450, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      }          
  }






  private void printSamningaF(object sender, System.Drawing.Printing.PrintPageEventArgs e)
  {

      // Determine the height of the header, based on the selected font.
      float headerHeight = headerFont.GetHeight(e.Graphics);

      // Determine the number of lines of body text that can be printed per page, taking
      // into account the presence of the header and the size of the selected body font.
      float linesPerPage = 54;

      // Used to store the position at which the next body line
      // should be printed.
      float yPosition = 0;

      // Used to store the number of lines printed so far on the
      // current page.
      int count = 0;

      // User to store the text of the current line.
      string id = "";
      string dags = "";
      string samtals = "";
      string vsk1 = "";
      string vsk2 = "";
      string afsl = "";
      string nafn = "";
      string vnafn = "";


      // Print the page header, as specified by the user in the form.
      // Use the header font for this line only.
      Image logo = Image.FromFile("logo.jpg");
      int x = 10;
      int y = 10;
      int width = 160;
      int height = 74;

      storiFont = new Font("Arial", 18, FontStyle.Bold);
      samtalsFont = new Font("Arial", 12, FontStyle.Bold);

      e.Graphics.DrawImage(logo, x, y, width, height);
      e.Graphics.DrawString(fnafn, headerFont, Brushes.Black, e.MarginBounds.Left + 80, e.MarginBounds.Top - 85, new StringFormat());
      e.Graphics.DrawString(fheimili, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 65, new StringFormat());
      e.Graphics.DrawString(fsveitaf, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 50, new StringFormat());
      e.Graphics.DrawString(ftexti1, smairFont, Brushes.Black, e.MarginBounds.Left + 82, e.MarginBounds.Top - 15, new StringFormat());
      e.Graphics.DrawString("SAMNINGAR", storiFont, Brushes.Black, e.MarginBounds.Right - 170, e.MarginBounds.Top - 85, new StringFormat());
      e.Graphics.DrawString("****", smairFont, Brushes.Black, e.MarginBounds.Right - 150, e.MarginBounds.Top - 15, new StringFormat());
      e.Graphics.DrawString("Samtals öll blöð", smairFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom, new StringFormat());
      e.Graphics.DrawString("Dagsetning", bodyFont, Brushes.Black, e.MarginBounds.Left, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("Númer", bodyFont, Brushes.Black, e.MarginBounds.Left + 50, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("", bodyFont, Brushes.Black, e.MarginBounds.Left + 70, 110, new StringFormat());
      e.Graphics.DrawString("Samtals án VSK", bodyFont, Brushes.Black, e.MarginBounds.Left + 160, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("VSK S1", bodyFont, Brushes.Black, e.MarginBounds.Left + 260, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("VSK S2", bodyFont, Brushes.Black, e.MarginBounds.Left + 360, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawString("Afsláttur", bodyFont, Brushes.Black, e.MarginBounds.Left + 460, 110, new StringFormat(StringFormatFlags.DirectionRightToLeft));
      e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left - 85, 100, e.MarginBounds.Right + 85, 100);
      //e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, 292, e.MarginBounds.Right, 292);
      //Neðsta línan
      e.Graphics.DrawLine(Pens.Gray, e.MarginBounds.Left, e.MarginBounds.Bottom - 15, e.MarginBounds.Right, e.MarginBounds.Bottom - 15);
      // Print each line of the data file, but don't exceed the maximum allowable
      // number of lines per page.  Also, stop when the end of the data file is
      // reached.  This event is called once per page, so if the data exceeds a single
      // page, the XmlTextReader will pick up where it left off on the previous page.
      while (Reader.Read())
      {
          id = Reader.GetInt32(0).ToString();
          dags = Reader.GetString(1).PadRight(10);
          samtals = Reader.GetInt32(2).ToString("N0");
          vsk1 = Reader.GetInt32(4).ToString("N0");
          vsk2 = Reader.GetInt32(5).ToString("N0");
          afsl = Reader.GetInt32(3).ToString("N0");
          nafn = Reader.GetInt32(6).ToString();
          vnafn = Reader.GetString(7);

          samtals_s = samtals_s + Reader.GetInt32(2);
          vsk1_s = vsk1_s + Reader.GetInt32(4);
          vsk2_s = vsk2_s + Reader.GetInt32(5);
          afsl_s = afsl_s + Reader.GetInt32(3);

          //line = Reader.GetString(0)+"     "+Reader.GetString(3)+"       "+Reader.GetString(1)+" "+Reader.GetString(2);

          yPosition = e.MarginBounds.Top + 28 + (count * bodyFont.GetHeight(e.Graphics));
          //e.Graphics.DrawString(line, bodyFont, Brushes.Black, e.MarginBounds.Left, yPosition, new StringFormat());
          e.Graphics.DrawString(dags, bodyFont, Brushes.Black, e.MarginBounds.Left, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(id, bodyFont, Brushes.Black, e.MarginBounds.Left + 50, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(nafn, bodyFont, Brushes.Black, e.MarginBounds.Left + 80, yPosition, new StringFormat());
          e.Graphics.DrawString(samtals, bodyFont, Brushes.Black, e.MarginBounds.Left + 160, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk1, bodyFont, Brushes.Black, e.MarginBounds.Left + 260, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk2, bodyFont, Brushes.Black, e.MarginBounds.Left + 360, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(afsl, bodyFont, Brushes.Black, e.MarginBounds.Left + 450, yPosition, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vnafn, bodyFont, Brushes.Black, e.MarginBounds.Left + 470, yPosition, new StringFormat());
          if (count == linesPerPage)
              break;
          // Increment the counter to show that another line has been printed.
          // This is used in the positioning of future lines of text on the current page.
          count++;
      }
      if (count == linesPerPage)
      {
          e.HasMorePages = true;
          e.Graphics.DrawString(samtals_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 160, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk1_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 260, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk2_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 360, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(afsl_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 450, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));

          //e.Graphics.DrawString(vsk1_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 640, e.MarginBounds.Bottom - 50 , new StringFormat(StringFormatFlags.DirectionRightToLeft));
          //e.Graphics.DrawString(samtals_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 500, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          samtals_d = samtals_d + samtals_s;
          samtals_s = 0;
          vsk1_d = vsk1_d + vsk1_s;
          vsk1_s = 0;
          vsk2_d = vsk2_d + vsk2_s;
          vsk2_s = 0;
          afsl_d = afsl_d + afsl_s;
          afsl_s = 0;

      }
      else
      {
          e.HasMorePages = false;
          samtals_d = samtals_d + samtals_s;
          vsk1_d = vsk1_d + vsk1_s;
          vsk2_d = vsk2_d + vsk2_s;
          afsl_d = afsl_d + afsl_s;

          e.Graphics.DrawString(samtals_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 160, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk1_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 260, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk2_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 360, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(afsl_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 450, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));

          //e.Graphics.DrawString(vsk1_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 640, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          //e.Graphics.DrawString(vsk1_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 640, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(samtals_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 160, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk1_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 260, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(vsk2_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 360, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          e.Graphics.DrawString(afsl_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 450, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));

          //e.Graphics.DrawString(samtals_s.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 500, e.MarginBounds.Bottom - 50, new StringFormat(StringFormatFlags.DirectionRightToLeft));
          //e.Graphics.DrawString(samtals_d.ToString("N0"), bodyFont, Brushes.Black, e.MarginBounds.Left + 500, e.MarginBounds.Bottom, new StringFormat(StringFormatFlags.DirectionRightToLeft));

      }
  }




    }
}
