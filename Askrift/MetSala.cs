using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Management;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Askrift
{
   
    public partial class MetSala : Form
    {
         
        public void MetGet()
        {
            StreamReader skra = new StreamReader("kerfisb.dat");
            string gagnag = skra.ReadLine();
            MetSala.key = skra.ReadLine();
            MyConString = "SERVER=localhost;DATABASE=" + gagnag + ";UID=root;PASSWORD=$lp0022aq";
         }
        
        public static string MyConString = "";
        public static string key = "";
        public string solumadur;   
        public Boolean msoluf = false;
        public Boolean msamnf = false;
        public Boolean form_vidskm = false;
        reikningar soluForm;
        samningar samnForm;
        Form vidskmForm;
        Form eprent;
        public MetSala()
        {
              
            MetGet();

            if (KeyGet() != 0)
            {
                 Environment.Exit(0);
            }
            
            InitializeComponent();
            
            //login.MdiParent = this;
            innskraning login = new innskraning();

            if (login.ShowDialog() != DialogResult.OK)
            {
                Close();
                
            }

            
            samnForm = new samningar();
            vidskmForm = new vidskm();
            eprent = new endurp();
            soluForm = new reikningar("");
            
    
                samnForm.MdiParent = this;
                samnForm.TopLevel = false;
                samnForm.Dock = DockStyle.Fill;
                samnForm.Text = "MetSala Samningar";
                samnForm.Parent = panel1;

                vidskmForm.MdiParent = this;
                vidskmForm.TopLevel = false;
                vidskmForm.Dock = DockStyle.Fill;
                vidskmForm.Text = "MetSala Viðskiptamenn";
                vidskmForm.Parent = panel1;

                eprent.MdiParent = this;
                eprent.Parent = panel1;
                eprent.TopLevel = false;
                //eprent.Show();
                eprent.PerformAutoScale();

                
                solumadur = login.solumadur;
                soluForm.MdiParent = this;
                soluForm.TopLevel = false;
                soluForm.Dock = DockStyle.Fill;
                soluForm.Text = "MetSala Sölukerfi";
                soluForm.Parent = panel1;
                soluForm.solum = solumadur;
                soluForm.Show();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            form_fela();
                soluForm.Show();
                       
           
        }
        

        private void OpenFile(object sender, EventArgs e)
        {
            form_fela();
                samnForm.Show();
                samnForm.vidskm_lesa();
            
            
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_fela();
            vidskmForm.Show();
                       
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrentaR prentaH = new PrentaR();
            hr_dags g_dags = new hr_dags();
            g_dags.Foreldri1 = this;
            string dags1 = "";
            string dags2 = "";
            string kennitala = "";


            if (g_dags.ShowDialog() == DialogResult.OK)
            {
                dags1 = g_dags.dagur1;
                dags2 = g_dags.dagur2;
                kennitala = g_dags.kennitala;
            }
            else
            {
                g_dags.Close();
                return;
            }
            g_dags.Close();
            prentaH.prentaHreyfingar(dags1,dags2,kennitala);
        }

        private void hreyfingarDagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrentaR prentaH = new PrentaR();
            hr_dags g_dags = new hr_dags();
            g_dags.Foreldri1 = this;
            string dags1 = "";
            string dags2 = "";


            if (g_dags.ShowDialog() == DialogResult.OK)
            {
                dags1 = g_dags.dagur1;
                dags2 = g_dags.dagur2;
            }
            else
            {
                g_dags.Close();
                return;
            }
            g_dags.Close();
            prentaH.prentaHdags(dags1, dags2);
        }

        private void endurprentareikningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_fela();
            eprent.Show();
        }

        private void prentaAllaSamningaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrentaR prentaH = new PrentaR();
            prentaH.prentasamninga();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
                        

        private void form_fela()
        {
            eprent.Hide();
            soluForm.Hide();
            samnForm.Hide();
            vidskmForm.Hide();
                    
        }

        public int KeyGet()
        {
            string HDD_ID = GetHDDSerialNumber();
            string MAC_ID = GetMACAddress();

            int hdddec = int.Parse(HDD_ID.Remove(5), System.Globalization.NumberStyles.HexNumber);
            int macdec = int.Parse(MAC_ID.Remove(5), System.Globalization.NumberStyles.HexNumber);
            int summa = hdddec - macdec - 670101;
            int st_lengd = summa.ToString().Length;
            int vartala = int.Parse(summa.ToString().Substring(st_lengd - 4, 4), System.Globalization.NumberStyles.Integer);
            string key_c = vartala.ToString().Replace("-", "");
            string S_summa = (summa + 670101).ToString().Replace("-","");
            if (key_c == key)
            {
                return 0;
            }
            else
            {
                MessageBox.Show("Aðgangur ekki leyfður hafið samband við MetNet ehf.\n info@metnet.is og tilgreinið þennan lykil " + S_summa + ".");
                return 1;
            }
        }

        public string GetHDDSerialNumber()
        {

            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"C:\"");

            disk.Get();

            return disk["VolumeSerialNumber"].ToString();
        }

        


        public string GetMACAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            string MACAddress = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                if (MACAddress == String.Empty)  // only return MAC Address from first card
                {
                    if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
                }
                mo.Dispose();
            }
            MACAddress = MACAddress.Replace(":", "");
            return MACAddress;
        }

        private void lenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lenalisti lenForm = new lenalisti();

            lenForm.MdiParent = this;
            lenForm.TopLevel = false;
            lenForm.Dock = DockStyle.Fill;
            lenForm.Text = "Lén á viðskiptamenn";
            lenForm.Parent = panel1;
            form_fela();
                lenForm.Show();
        }


    }
}
