using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_VINCENTIA_T_FINAL
{
    public partial class Form3 : Form
    {
        public string JudulFilm { get; set; }
        public string buttonjam { get; set; }
        private List<string> merah = new List<string>();
        private int buttonmerah = 0;
        private List<Button> redbuttons = new List<Button>();
        private Random random = new Random();
        private List<Button> buttonsList = new List<Button>();
        private Dictionary<Button, bool> buttonInfo = new Dictionary<Button, bool>();
        public Dictionary<string,List<string>> randomjam = new Dictionary<string,List<string>>();

        public Form3(Dictionary<string, List<string>> randomjam)
        {
            InitializeComponent();
            this.randomjam = randomjam ;

        }
        public void Form3_Load(object sender, EventArgs e)
        {
            string filmdanjam = JudulFilm + "," + buttonjam;
            int spacing = 1;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button button1 = new Button();
                    button1.Size = new Size(32, 32);
                    button1.Location = new Point(j * (32 + spacing) + 20, i * (32 + spacing) + 20);
                    button1.BackColor = Color.White;
                    button1.Tag = i + " " + j;
                    button1.Click += button_Clicked;
                    buttonsList.Add(button1);
                    buttonInfo.Add(button1, false);
                    this.panel1.Controls.Add(button1);

                }
            }

            if (randomjam.ContainsKey(filmdanjam))
            {
                List<string> listredbuttontag = randomjam[filmdanjam];
                foreach (string s in listredbuttontag)
                {
                    int index = buttonsList.FindIndex(button => Convert.ToString(button.Tag) == s);
                    buttonsList[index].BackColor = Color.Red;
                }
                foreach (Button button in buttonsList)
                {
                    if (button.BackColor != Color.Red)
                    {
                        button.BackColor = Color.White;
                    }
                }
            }
            else
            {
                buttonmerah = random.Next(1, 71);
                ChangeButtonsColorRandomly(buttonmerah, Color.Red);
                foreach (Button button in buttonsList)
                {
                    if (button.BackColor != Color.Red)
                    {
                        button.BackColor = Color.White;
                    }
                }
            }


            Button reserve = new Button();
            reserve.Size = new Size(70, 35);
            reserve.Location = new Point(this.ClientSize.Width - reserve.Size.Width - 150, 80);
            this.panel1.Controls.Add(reserve);
            reserve.Text = "RESERVE";
            reserve.BackColor = Color.White;
            reserve.Click += button_reserve_Click;

            Button back = new Button();
            back.Text = "BACK";
            back.BackColor = Color.White;
            back.Size = new Size(70, 40);
            back.Location = new Point(20, this.Height - back.Height - 20);
            back.Click += back_Click;
            this.panel1.Controls.Add(back);

            Button reset = new Button();
            reset.Size = new Size(70, 35);
            reset.Location = new Point(reserve.Location.X + 80, 80);
            this.panel1.Controls.Add(reset);
            reset.Text = "RESET";
            reset.BackColor = Color.White;
            reset.Click += button_reset_Click;
 
        }

        private void ChangeButtonsColorRandomly(int numButtons, Color color)
        {
            string filmdanjam = JudulFilm + "," + buttonjam;
            for (int i = 0; i < numButtons; i++)
            {
                int randIndex = random.Next(0, 100);
                Button button = this.panel1.Controls[randIndex] as Button;
                if (button != null && button.BackColor != color)
                {
                    button.BackColor = color;
                    redbuttons.Add(button);
                    buttonsList[randIndex].BackColor = Color.Red;
                }
            }
            foreach (Button button in buttonsList)
            {
                if (button.BackColor == color)
                {
                    merah.Add(Convert.ToString(button.Tag));
                }
                
            }
            randomjam[filmdanjam] = merah;
        }

        private void button_Clicked(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.BackColor != Color.Red)
            {
                clickedButton.BackColor = Color.Gray;
                buttonInfo[clickedButton] = true; 
            }
            else if (clickedButton.BackColor == Color.Red)
            {
                MessageBox.Show("The seat already taken", "SEAT TAKEN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.filmjamisrandom = randomjam;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form);
            form.Show();
        }


        private void button_reserve_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.panel1.Controls)
            {
                if (control is Button && control.BackColor == Color.Gray && buttonInfo[(Button)control] == true)
                {
                    Button button = (Button)control;
                    button.BackColor = Color.Red;
                    foreach (Button x in buttonsList)
                    {
                        button.BackColor = Color.Red;
                    }
                    foreach (Button a in buttonsList)
                    {
                        if (a.BackColor == Color.Red)
                        {
                            merah.Add(Convert.ToString(a.Tag));
                            redbuttons.Add(a);
                        }
                    }
                    string filmdanjam = JudulFilm + "," + buttonjam;
                    randomjam[filmdanjam] = merah;

                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset?", "Reset Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (Control control in this.panel1.Controls)
                {
                    if (control is Button)
                    {
                        Button button = (Button)control;
                        button.BackColor = Color.White;
                        foreach (Button c in buttonsList)
                        {
                            c.BackColor = Color.White;
                        }
                        buttonInfo[button] = false;
                        foreach (Button a in buttonsList)
                        {
                            if (a.BackColor == Color.Red)
                            {
                                redbuttons.Add(a);
                                merah.Add(Convert.ToString(a.Tag));
                            }
                        }
                        string filmdanjam = JudulFilm + "," + buttonjam;
                        randomjam[filmdanjam] = merah;
                    }
                }
            }
        }

    }
}