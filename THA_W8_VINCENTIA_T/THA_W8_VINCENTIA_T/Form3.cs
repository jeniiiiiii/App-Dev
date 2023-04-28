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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace THA_W8_VINCENTIA_T
{
    public partial class Form3 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionstring = "server=localhost;uid=root;pwd=123;database=premier_league";
        string query;

        DataTable dttim = new DataTable();
        DataTable dttanggal = new DataTable();
        DataTable dthome = new DataTable();
        DataTable dtaway = new DataTable();
        DataTable dtmatch = new DataTable();
        DataTable dtdetail = new DataTable();
        string pilih = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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
            dttanggal = new DataTable();
            pilih = comboBoxteam.Text;
            query = $"SELECT m.match_date as 'tanggal', t1.team_name as 't1', t2.team_name as 't2', m.match_id as 'ID'\r\nFROM team t1 INNER JOIN premier_league.match m ON t1.team_id = m.team_home INNER JOIN team t2 ON t2.team_id = m.team_away\r\nWHERE t1.team_name = '{pilih}' OR t2.team_name = '{pilih}';";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dttanggal);

            if (dttanggal.Rows.Count > 0)
            {
                comboboxtgl.DataSource = dttanggal;
                comboboxtgl.DisplayMember = "tanggal";
                comboboxtgl.ValueMember = "ID";
                label_home.Text = dttanggal.Rows[0]["t1"].ToString();
                label_away.Text = dttanggal.Rows[0]["t2"].ToString();
            }
            else
            {
                comboboxtgl.DataSource = null;
                label_home.Text = "-";
                label_away.Text = "-";
            }
        }

        private void comboboxtgl_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtmatch = new DataTable();
            query = @"SELECT t1.team_name AS 't1', t2.team_name AS 't2', m.match_id AS 'ID' FROM premier_league.match m JOIN team t1 ON m.team_home = t1.team_id JOIN team t2 ON m.team_away = t2.team_id WHERE m.match_id = @match_id";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@match_id", comboboxtgl.SelectedValue.ToString());
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtmatch);

            if (dtmatch.Rows.Count > 0)
            {
                label_home.Text = dtmatch.Rows[0]["t1"].ToString();
                label_away.Text = dtmatch.Rows[0]["t2"].ToString();
            }
            else
            {
                label_home.Text = "";
                label_away.Text = "";
            }
        }
        private void buttonok_Click(object sender, EventArgs e)
        {
            dthome = new DataTable();
            query = $"SELECT t.team_name, p.player_name,if(p.playing_pos='G','GoalKeeper',if(p.playing_pos='M','MidFielder',if(p.playing_pos='D','Defender','Forward')))as'Position'\r\nFROM player p, team t\r\nWHERE p.team_id=t.team_id AND t.team_name='{label_home.Text}';";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dthome);
            dgv_home.DataSource = dthome;

            dtaway = new DataTable();
            query = $"SELECT t.team_name, p.player_name,if(p.playing_pos='G','GoalKeeper',if(p.playing_pos='M','MidFielder',if(p.playing_pos='D','Defender','Forward')))as'Position'\r\nFROM player p, team t\r\nWHERE p.team_id=t.team_id AND t.team_name='{label_away.Text}';";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtaway);
            dgv_away.DataSource = dtaway;

            dtdetail = new DataTable();
            query = $"SELECT d.minute as'minute',t.team_name as'team name',p.player_name as'player name',if(d.type='CY','Yellow Card',if(d.type='CR','Red Card',if(d.type='GO','Goal',if(d.type='GP','Goal Penalty',if(d.type='GW','Own GOal','Penalty Miss'))))) as 'type'\r\nFROM dmatch d,team t,player p\r\nWHERE d.team_id=t.team_id AND d.player_id=p.player_id AND d.match_id='{comboboxtgl.SelectedValue.ToString()}';";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtdetail);
            dgv_detail.DataSource = dtdetail;
        }
    }
}
