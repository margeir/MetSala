using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Askrift
{
    public partial class hr_dags : Form
    {
        public MetSala Foreldri1;
        public string dagur1 = DateTime.Now.ToString("yyyy:MM:dd");
        public string dagur2 = DateTime.Now.ToString("yyyy:MM:dd");
        public string kennitala = "0000000000";
        public hr_dags()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            kennitala = text_kt.Text;
        }

        private void dags1_ValueChanged(object sender, EventArgs e)
        {
            dagur1 = dags1.Value.ToString("yyyy:MM:dd");
        }

        private void dags2_ValueChanged(object sender, EventArgs e)
        {
            dagur2 = dags2.Value.ToString("yyyy:MM:dd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }
    }
}
