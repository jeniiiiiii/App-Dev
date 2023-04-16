using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace THA_W7_VINCENTIA_T_FINAL
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }

        public string PosterPath { get; set; }
        public string JudulFilm { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {
            PictureBox picturebox = new PictureBox();
            picturebox.Image = Image.FromFile(PosterPath);
            picturebox.Size = new Size(200, 200);
            picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            picturebox.Location = new Point(20, 20);
            this.Controls.Add(picturebox);

            Label label = new Label();
            label.Text = JudulFilm; // Set judul film ke label
            label.Font = new Font("Mongolian Baiti", 12, FontStyle.Bold);
            label.Location = new Point(240, 40);
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(label);

            Button button1 = new Button();
            button1.Text = "13:10";
            button1.Size = new Size(70, 30);
            button1.Location = new Point(240, label.Bottom + 20);
            button1.Click += Button1_Click; // Tambahkan event handler untuk button1
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Text = "14:50";
            button2.Size = new Size(70, 30);
            button2.Location = new Point(320, label.Bottom + 20);
            button2.Click += Button2_Click; // Tambahkan event handler untuk button2
            this.Controls.Add(button2);

            Button button3 = new Button();
            button3.Text = "17:35";
            button3.Size = new Size(70, 30);
            button3.Location = new Point(400, label.Bottom + 20);
            button3.Click += Button3_Click; // Tambahkan event handler untuk button3
            this.Controls.Add(button3);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.ShowForm3InPanel();
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.ShowForm3InPanel();
            }
        }
        
        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.ShowForm3InPanel();
            }
        }
    }
}

