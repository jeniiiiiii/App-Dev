using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static THA_W4_VINCENTIA_T_JADI.Form1;

namespace THA_W4_VINCENTIA_T_JADI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<team> teams = new List<team>();

        private void Form1_Load(object sender, EventArgs e)
        {
            listboxsoccer.Sorted = true;

            team team1 = new team();
            team1.teamname = "Chelsea";
            team1.teamcountry = "England";
            team1.teamcity = "London";
            team tambah = team1;
            team1.addplayer("07", " N'Golo Kante", "MF");
            team1.addplayer("06", " Thiago Silva", "DF");
            team1.addplayer("11", " Timo Werner", "FW");
            team1.addplayer("19", " Mason Mount", "MF");
            team1.addplayer("22", " Hakim Ziyech", "FW");
            team1.addplayer("10", " Christian Pulisic", "FW");
            team1.addplayer("21", " Ben Chilwell", "DF");
            team1.addplayer("15", " Kurt Zouma", "DF");
            team1.addplayer("17", " Mateo Kovacic", "MF");
            team1.addplayer("24", " Reece James", "DF");
            team1.addplayer("16", " Edouard Mendy", "GK");
            teams.Add(tambah);

            team team2 = new team();
            team2.teamname = "Liverpool";
            team2.teamcountry = "England";
            team2.teamcity = "Liverpool";
            tambah = team2;
            team2.addplayer("11", " Mohamed Salah", "FW");
            team2.addplayer("10", " Sadio Mane", "FW");
            team2.addplayer("09", " Roberto Firmino", "FW");
            team2.addplayer("04", " Virgil van Dijk", "DF");
            team2.addplayer("26", " Andrew Robertson", "DF");
            team2.addplayer("66", " Trent Alexander-Arnold", "DF");
            team2.addplayer("03", " Fabinho", "MF");
            team2.addplayer("14", " Jordan Henderson", "MF");
            team2.addplayer("06", " Thiago Alcantara", "MF");
            team2.addplayer("01", " Alisson Becker", "GK");
            team2.addplayer("20", " Diogo Jota", "FW");
            teams.Add(tambah);

            team team3 = new team();
            team3.teamname = "PSG";
            team3.teamcountry = "France";
            team3.teamcity = "Paris";
            tambah = team3;
            team3.addplayer("07", " Kylian Mbappe", "FW");
            team3.addplayer("10", " Neymar Jr", "FW");
            team3.addplayer("11", " Angel Di Maria", "FW");
            team3.addplayer("06", " Marco Verratti", "MF");
            team3.addplayer("02", " Achraf Hakimi", "DF");
            team3.addplayer("05", " Marquinhos", "DF");
            team3.addplayer("03", " Presnel Kimpembe", "DF");
            team3.addplayer("27", " Idrissa Gueye", "MF");
            team3.addplayer("18", " Georginio Wijnaldum", "MF");
            team3.addplayer("01", " Keylor Navas", "GK");
            team3.addplayer("14", " Juan Bernat", "DF");
            teams.Add(tambah);
        }

        private void comboboxcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxteam.Text = "";
            comboboxteam.Items.Clear();
            string p = comboboxcountry.SelectedItem.ToString();
            foreach (team team in teams)
            {
                if (team.teamcountry == p)
                {
                    comboboxteam.Items.Add(team.teamname);
                }
            }
        }

        private void comboboxteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxsoccer.Items.Clear();
            string nama = comboboxteam.SelectedItem.ToString();
            team team = null;
            foreach (team p in teams)
            {
                if (p.teamname == nama)
                {
                    team = p;
                }
            }
            foreach (Player player in team.Players)
            {
                listboxsoccer.Items.Add("(" + player.playernum + ") " + player.playername + ", " + player.playerpos);
            }
        }

        private void buttonaddteam_Click(object sender, EventArgs e)
        {
            if (textboxteamcountry.Text != "" || textboxteamname.Text != "" || textboxteamcity.Text != "")
            {
                string nama = textboxteamname.Text;
                string kota = textboxteamcity.Text;
                string negara = textboxteamcountry.Text;
                bool teamexists = false;
                foreach (team team in teams)
                {
                    if (team.teamname == nama)
                    {
                        teamexists = true;
                        break;
                    }
                }
                if (teamexists)
                {
                    MessageBox.Show("Team cannot be same!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                if (teamexists == false)
                {
                    team tambah = new team();
                    tambah.teamname = nama;
                    tambah.teamcity = kota;
                    tambah.teamcountry = negara;
                    teams.Add(tambah);
                }
                comboboxcountry.Items.Clear();
                foreach (team team in teams)
                {
                    if (comboboxcountry.Items.Contains(team.teamcountry) == false)
                    {
                        comboboxcountry.Items.Add(team.teamcountry);
                    }
                }
                textboxteamcity.Clear();
                textboxteamcountry.Clear();
                textboxteamname.Clear();
            }
        
            else
            {
                MessageBox.Show("All Fields Need to be Filled!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonaddplayer_Click(object sender, EventArgs e)
        {
            if (textboxplayername.Text == "" || textboxplayernumber.Text == "" || comboboxcountry.SelectedIndex == -1)
            {
                MessageBox.Show("All Fields Need to be Filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                string selectedteam = comboboxteam.SelectedItem.ToString();
                foreach (team teamm in teams)
                {
                    bool ada = false;
                    foreach (Player player in teamm.Players)
                    {
                        if (player.playernum == textboxplayernumber.Text)
                        {
                            ada = true;
                            break;
                        }
                    }
                    if (ada == false)
                    {
                        teamm.addplayer(textboxplayernumber.Text, textboxplayername.Text, comboboxplayerposition.SelectedItem.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Player with Same Number is found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }

                listboxsoccer.Items.Clear();
                string nama = comboboxteam.SelectedItem.ToString();
                team team = new team();
                foreach (team i in teams)
                {
                    if (i.teamname == nama)
                    {
                        team = i;
                    }
                }
                foreach (Player player in team.Players)
                {
                    listboxsoccer.Items.Add("(" + player.playernum + ") " + player.playername + ", " + player.playerpos);
                }
            }
            textboxplayernumber.Clear();
            textboxplayername.Clear();
        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
            string kepilih = comboboxteam.SelectedItem.ToString();
            foreach (team p in teams)
            {
                if (p.teamname == kepilih)
                {
                    if (p.Players.Count <= 11)
                    {
                        MessageBox.Show("Unable to Remove Players if Players less than 11", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        continue;
                    }
                }

                bool bener = true;
                string[] pisah = listboxsoccer.SelectedItem.ToString().Split(',');
                string[] pisah2 = pisah[0].Split(')');
                string num = pisah2[0].Substring(0);
                string name = pisah2[1].Substring(1);

                while (bener)
                {
                    foreach (Player i in p.Players)
                    {
                        if (i.playername == name)
                        {
                            p.Players.Remove(i);
                            bener = false;
                            break;
                        }
                    }
                    break;
                }

            }

            listboxsoccer.Items.Clear();
            string nama = comboboxteam.SelectedItem.ToString();
            team team = new team();
            foreach (team j in teams)
            {
                if (j.teamname == nama)
                {
                    team = j;
                }
            }
            foreach (Player y in team.Players)
            {
                listboxsoccer.Items.Add("(" + y.playernum + ") " + y.playername + ", " + y.playerpos);
            }
        }

        private void listboxsoccer_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void listboxsoccer_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
