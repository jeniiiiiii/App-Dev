using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6_VINCENTIA_T__YE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonplay_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBoxInput.Text);
            if (input <= 3)
            {
                MessageBox.Show("Input must greater than 3");
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
            else
            {
                Form2 form2 = new Form2();
                form2.b = input;
                form2.ShowDialog();
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
        }
    }
}
