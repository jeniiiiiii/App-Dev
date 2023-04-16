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
        public string PosterPath { get; set; }
        public string JudulFilm { get; set; }
        string buttontag;
        public Dictionary<string, List<string>> filmjamisrandom = new Dictionary<string, List<string>>();
        public Form2(Dictionary<string, List<string>> filmjamisrandom)
        {
            InitializeComponent();
            this.filmjamisrandom = filmjamisrandom;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PictureBox picturebox = new PictureBox();
            picturebox.Image = Image.FromFile(PosterPath);
            picturebox.Size = new Size(200, 200);
            picturebox.SizeMode = PictureBoxSizeMode.Zoom;
            picturebox.Location = new Point(20, 20);
            this.panel1.Controls.Add(picturebox);

            Label label = new Label();
            label.Text = JudulFilm; 
            label.Font = new Font("Mongolian Baiti", 12, FontStyle.Bold);
            label.Location = new Point(240, 40);
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleCenter;
            this.panel1.Controls.Add(label);

            Button button1 = new Button();
            button1.Text = "13:10";
            button1.BackColor = Color.White;
            button1.Size = new Size(70, 30);
            button1.Location = new Point(240, label.Bottom + 20);
            button1.Click += Button1_Click;
            this.panel1.Controls.Add(button1);

            Button button2 = new Button();
            button2.Text = "14:50";
            button2.BackColor = Color.White;
            button2.Size = new Size(70, 30);
            button2.Location = new Point(320, label.Bottom + 20);
            button2.Click += Button2_Click;
            this.panel1.Controls.Add(button2);

            Button button3 = new Button();
            button3.Text = "17:35";
            button3.BackColor = Color.White;
            button3.Size = new Size(70, 30);
            button3.Location = new Point(400, label.Bottom + 20);
            button3.Click += Button3_Click; 
            this.panel1.Controls.Add(button3);

            Button back = new Button();
            back.Text = "BACK";
            back.BackColor = Color.White;
            back.Size = new Size(70, 40);
            back.Location = new Point(20, this.Height - back.Height - 20);
            back.Click += back_Click;
            this.panel1.Controls.Add(back);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            buttontag = "1";
            ShowForm3InPanel();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            buttontag = "2";
            ShowForm3InPanel();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            buttontag = "3";
            ShowForm3InPanel();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form);
            form.Show();
        }
        
        public void ShowForm3InPanel()
        {
            panel1.Controls.Clear();
            Form3 form3 = new Form3(filmjamisrandom);
            form3.TopLevel = false;
            form3.buttonjam = buttontag;
            form3.JudulFilm = JudulFilm;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;
            panel1.Controls.Add(form3);
            form3.Show();
        }
    }
}

