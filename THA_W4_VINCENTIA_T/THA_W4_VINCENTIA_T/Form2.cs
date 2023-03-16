using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W4_VINCENTIA_T
{
    public partial class second : Form
    {
        public second()
        {
            InitializeComponent();
        }
        public string Labelhello
        {
            get { return labelhello.Text; }
            set { labelhello.Text = value; }
        }
        private void buttonmagic_Click(object sender, EventArgs e)
        {
            Main firstform = Application.OpenForms["Main"] as Main;
            if (radiobuttonblack.Checked == false && radiobuttonblue.Checked == false && radiobuttonbrown.Checked == false && radiobuttongold.Checked == false 
                && radiobuttongreen.Checked == false && radiobuttonkhaki.Checked == false && radiobuttonpink.Checked == false && radiobuttonpurple.Checked == false)
            {
                MessageBox.Show("Choose one pleaseee!!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (checkboxagree.Checked && checkboxtrue2.Checked)
            {
                buttonmagic.Enabled = true;
            }
            else
            {
                buttonmagic.Enabled = false;
            }

            if (checkboxagree.Checked==true && checkboxtrue2.Checked==true)
            {
                if (radiobuttonpink.Checked)
                {
                    firstform.BackColor = Color.Salmon;
                }
                if (radiobuttonpurple.Checked)
                {
                    firstform.BackColor = Color.SlateBlue;
                }
                if (radiobuttonblue.Checked)
                {
                    firstform.BackColor = Color.SkyBlue;
                }
                if (radiobuttongreen.Checked)
                {
                    firstform.BackColor = Color.PaleGreen;
                }
                if (radiobuttonkhaki.Checked)
                {
                    firstform.BackColor = Color.Khaki;
                }

                if (radiobuttonblack.Checked)
                {
                    firstform.ForeColor = Color.Black;
                }
                if (radiobuttongold.Checked)
                {
                    firstform.ForeColor = Color.Gold;
                }
                if (radiobuttonbrown.Checked)
                {
                    firstform.ForeColor = Color.SaddleBrown;
                }
                if (firstform != null)
                {
                    firstform.Refresh();
                }
            }
        }

       
        private void checkboxagree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxagree.Checked && checkboxtrue2.Checked)
            {
                buttonmagic.Enabled = true;
            }
            else
            {
                buttonmagic.Enabled = false;
            }
        }

        private void checkboxtrue2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxagree.Checked && checkboxtrue2.Checked)
            {
                buttonmagic.Enabled = true;
            }
            else
            {
                buttonmagic.Enabled = false;
            }
        }
        private void labelhello_Click(object sender, EventArgs e)
        {

        }

    }
}
