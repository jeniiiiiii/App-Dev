using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace THA_W8_VINCENTIA_T
{
    public partial class Form2 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionstring = "server=localhost;uid=root;pwd=123;database=premier_league";
        string query;

        DataTable dttim = new DataTable();
        DataTable dtplayer = new DataTable();
        DataTable dtkiri = new DataTable();
        DataTable dtid = new DataTable();
        DataTable dtkartu = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            query = "SELECT team_name FROM premier_league.team;";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dttim);

            comboBoxteam.DataSource = dttim;
            comboBoxteam.DisplayMember = "team_name";
        }
        private void comboBoxteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pilih = comboBoxteam.Text;
            dtplayer = new DataTable();
            query = $"SELECT p.player_name as'player'\r\nfrom player p,premier_league.team t \r\nwhere p.team_id=t.team_id and t.team_name='{pilih}' ;";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtplayer);

            comboboxplayer.DataSource = dtplayer;
            comboboxplayer.DisplayMember = "player";

            comboboxplayer.Text = "";
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            dtkiri = new DataTable();
            string teamName = comboBoxteam.Text;
            string playerName = comboboxplayer.Text;
            string positionQuery = $"SELECT CASE\r\nWHEN playing_pos = 'G' THEN 'GoalKeeper'\r\nWHEN playing_pos = 'M' THEN 'MidFielder'\r\nWHEN playing_pos = 'D' THEN 'Defender'\r\nELSE 'Forward' END as 'Position'\r\nFROM player\r\nWHERE player_name = '{playerName}'";
            query = $"SELECT p.player_name, t.team_name, ({positionQuery}), n.nation, p.team_number\r\nFROM player p, nationality n, team t\r\nWHERE p.team_id = t.team_id AND p.nationality_id = n.nationality_id AND p.player_name = '{playerName}' AND t.team_name = '{teamName}'";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtkiri);

            label_name.Text = dtkiri.Rows[0][0].ToString();
            label_team.Text = dtkiri.Rows[0][1].ToString();
            label_position.Text = dtkiri.Rows[0][2].ToString();
            label_nation.Text = dtkiri.Rows[0][3].ToString();
            label_number.Text = dtkiri.Rows[0][4].ToString();
            idpemain(playerName);

            dtkartu = new DataTable();
            string playerId = dtid.Rows[0][0].ToString();
            query = $"SELECT d.type, COUNT(d.type) as count FROM dmatch d WHERE d.player_id='{playerId}' GROUP BY d.type;";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtkartu);
            int yellowCards = 0;
            int redCards = 0;
            int goals = 0;
            int penalties = 0;

            foreach (DataRow row in dtkartu.Rows)
            {
                string type = row["type"].ToString();
                int count = Convert.ToInt32(row["count"]);
                switch (type)
                {
                    case "CY":
                        yellowCards = count++;
                        break;
                    case "CR":
                        redCards = count++;
                        break;
                    case "GO":
                        goals = count++;
                        break;
                    case "PM":
                        penalties = count++;
                        break;
                }
            }
            label_yellow.Text = yellowCards.ToString();
            label_red.Text = redCards.ToString();
            label_goal.Text = goals.ToString();
            label_penalty.Text = penalties.ToString();
        }

        private void idpemain(string namaplayer)
        {
            dtid = new DataTable();
            query = $"SELECT player_id\r\nFROM player\r\nWhere player_name='{namaplayer}';";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtid);
        }

        private void comboboxplayer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
