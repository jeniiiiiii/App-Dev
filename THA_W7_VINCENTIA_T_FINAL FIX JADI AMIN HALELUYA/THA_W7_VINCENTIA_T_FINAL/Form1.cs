using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_VINCENTIA_T_FINAL
{
    public partial class Form1 : Form
    {

        public Dictionary<string, List<string>> filmjamisrandom = new Dictionary<string, List<string>>();
        public Form1()
        {
            InitializeComponent();
        }
        string path = @".\movieposter\movielist.txt";
        List<string> judul = new List<string>();
        List<string> poster = new List<string>();
        public void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader p = new StreamReader(path))
            {
                string b;
                while ((b = p.ReadLine()) != null)
                {
                    string[] parts = b.Split(',');
                    if (parts.Length == 2)
                    {
                        judul.Add(parts[0]);
                        poster.Add(parts[1]);
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < judul.Count; i++)
            {
                PictureBox picturebox = new PictureBox();
                picturebox.Image = Image.FromFile(poster[i]);
                picturebox.Size = new Size(200, 200);
                picturebox.SizeMode = PictureBoxSizeMode.Zoom;
                picturebox.Location = new Point((count % 3) * 200 + 12, (count / 3) * 250 + 12);
                panel1.Controls.Add(picturebox);
                count++;
                picturebox.Tag = poster[i];
                picturebox.Click += PictureBox_Click;

                Label label = new Label();
                label.Text = judul[i];
                label.Font = new Font("Mongolian Baiti", 12, FontStyle.Bold);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Location = new Point(picturebox.Left + 50, picturebox.Bottom + 5);
                label.AutoSize = true;
                label.TextAlign = ContentAlignment.MiddleCenter;

                panel1.Controls.Add(label);

            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                string posterPath = pictureBox.Tag as string;
                if (!string.IsNullOrEmpty(posterPath))
                {
                    int index = poster.IndexOf(posterPath); 
                    if (index >= 0 && index < judul.Count)
                    {
                        string judulFilm = judul[index]; 
                        Form2 form2 = new Form2(filmjamisrandom);
                        form2.PosterPath = posterPath;
                        form2.JudulFilm = judulFilm; 

                        form2.TopLevel = false;
                        panel1.Controls.Add(form2);
                        form2.FormBorderStyle = FormBorderStyle.None;
                        form2.Dock = DockStyle.Fill;
                        form2.Show();
                        form2.filmjamisrandom = filmjamisrandom;
                    }
                }
            }
        }
    }
}
