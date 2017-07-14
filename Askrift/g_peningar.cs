using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Askrift
{
    

    public partial class g_peningar : Form
    { 
        
        public reikningar yfirgl;
        public g_peningar(string sverd)
        {
            InitializeComponent();
           
           label1.Text = sverd;
        }

        private void haetta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
