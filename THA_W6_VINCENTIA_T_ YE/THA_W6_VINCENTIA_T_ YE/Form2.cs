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

namespace THA_W6_VINCENTIA_T__YE
{

    public partial class Form2 : Form
    {
        public int b;
        string path = @"Wordle Word List.txt";
        List<Button> buttons = new List<Button>();
        List<string> wordList = new List<string>();

        Random rnd = new Random();
        public bool menang = false;
        string tebak = "";
        int baris = 0;
        int kolom = -1;
        string correctWord = "";
        int x = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string content = reader.ReadLine();
                string[] words = content.Split(',');
                wordList = words.ToList();
            }
            correctWord = wordList[rnd.Next(wordList.Count)];

            /*MessageBox.Show(correctWord);*/

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(40, 40);
                    button.Location = new Point(40 * j + 60, 40 * i + 30);
                    button.BackColor = Color.White;
                    buttons.Add(button);
                    Controls.Add(buttons[buttons.Count - 1]);
                    button.Click += new EventHandler(buttonZ_Click);
                }
            }
        }

        private void CheckWord()
        {
            int correctLetterCount = 0;
            for (int i = 0; i < 5; i++)
            {
                char guessedLetter = tebak.ToLower()[i];
                char correctLetter = correctWord[i];
                int buttonIndex = baris * 5 + i;

                if (correctLetter == guessedLetter)
                {
                    buttons[buttonIndex].BackColor = Color.DarkSeaGreen;
                    correctLetterCount++;
                }
                else if (correctWord.Contains(guessedLetter))
                {
                    buttons[buttonIndex].BackColor = Color.PapayaWhip;
                }
                else
                {
                    buttons[buttonIndex].BackColor = Color.Gainsboro;
                }
            }
            if (correctLetterCount == 5)
            {
                menang = true;
            }
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            if (!menang)
            {
                Button btn = sender as Button;
                if (btn != null && tebak.Length < 5)
                {
                    string p = btn.Text;
                    tebak += p;
                    Button emptyButton = buttons.Find(button => button.Text == "");
                    if (emptyButton != null)
                    {
                        emptyButton.Text = p;
                        kolom = buttons.IndexOf(emptyButton) % 5;
                    }
                }
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!menang)
            {
                if (tebak.Length >= 5)
                {
                    if (wordList.Contains(tebak.ToLower()))
                    {
                        CheckWord();
                        x++;
                        tebak = "";
                        if (menang)
                        {
                            MessageBox.Show("You Win!");
                            return;
                        }

                        if (x == b)
                        {
                            MessageBox.Show("You Lose! The word is: " + correctWord.ToUpper());
                        }
                        kolom++;
                        baris++;
                    }
                    else
                    {
                        MessageBox.Show(tebak + " is not in the word list.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        kolom = -1;
                    }
                }
                else
                {
                    MessageBox.Show("The word is too short.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!menang)
            {
                if (tebak.Length > 0)
                {
                    char lastChar = tebak[tebak.Length - 1];
                    tebak = tebak.Substring(0, tebak.Length - 1);
                    Button buttonToRemove = buttons.FindLast(button => button.Text == lastChar.ToString());
                    if (buttonToRemove != null)
                    {
                        buttonToRemove.Text = "";
                        kolom = buttons.IndexOf(buttonToRemove) % 5;
                    }
                }
            }
        }
    }
}
