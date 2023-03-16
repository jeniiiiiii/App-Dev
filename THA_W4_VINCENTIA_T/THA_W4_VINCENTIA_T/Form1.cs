using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace THA_W4_VINCENTIA_T
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private bool buttonclicked = false;
        public second secondform = new second();
        public Color Textboxname
        {
            get { return textboxname.ForeColor; }
            set { textboxname.ForeColor = value; }
        }
        public Color Textboxartist
        {
            get { return textboxartist.ForeColor; }
            set { textboxartist.ForeColor = value; }
        }
        private void buttonopen_Click(object sender, EventArgs e)
        {
            secondform.Show();
            buttonclicked = true;

            if (checkboxtrue.Checked==true && buttonclicked)
            {
                buttonsubmit.Enabled = true;
            }
        }
        private void checkboxtrue_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxtrue.Checked==true && buttonclicked)
            {
                buttonsubmit.Enabled = true;
            }
            else
            {
                buttonsubmit.Enabled = false;
            }
        }
        
        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            string nama = textboxname.Text;
            string artis = textboxartist.Text;
            if (textboxname.Text == "" || textboxartist.Text == "")
            {
                MessageBox.Show("Input correctly pleaseeeeeee!!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string kata = "Hi, my name is " + nama + " and my favorite artist is " + artis;
            secondform.Labelhello = kata;
        }
    }
}
