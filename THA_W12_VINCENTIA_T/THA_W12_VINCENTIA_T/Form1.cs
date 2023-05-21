using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace THA_W12_VINCENTIA_T
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dtnation = new DataTable();
        DataTable dtcurman = new DataTable();
        DataTable dtallman = new DataTable();
        string connection = "server=localhost;uid=root;pwd=123;database=premier_league";
        string query = "";
        public Form1()
        {
            try
            {
                sqlConnection = new MySqlConnection(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboboxdelete.SelectedIndexChanged -= comboboxdelete_SelectedIndexChanged;
            comboboxedit.SelectedIndexChanged -= comboboxedit_SelectedIndexChanged;

            query = "SELECT team_name, team_id FROM team;";
            sqlConnection = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt);
            sqlDataAdapter.Fill(dt2);
            sqlDataAdapter.Fill(dt4);

            comboBoxteamname.DataSource = dt;
            comboBoxteamname.DisplayMember = "team_name";
            comboBoxteamname.ValueMember = "team_id";

            comboboxedit.DataSource = dt2;
            comboboxedit.DisplayMember = "team_name";
            comboboxedit.ValueMember = "team_id";

            comboboxdelete.DataSource = dt4;
            comboboxdelete.DisplayMember = "team_name";
            comboboxdelete.ValueMember = "team_id";

            comboboxdelete.SelectedIndexChanged += comboboxdelete_SelectedIndexChanged;
            comboboxedit.SelectedIndexChanged += comboboxedit_SelectedIndexChanged;

            query = "SELECT nation, nationality_id FROM nationality;";
            sqlConnection = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtnation);
            comboBoxnationality.DataSource = dtnation;
            comboBoxnationality.DisplayMember = "nation";
            comboBoxnationality.ValueMember = "nationality_id";

            query = "SELECT p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate\r\nFROM player p, nationality n\r\nWHERE p.nationality_id=n.nationality_id && p.status=1;";
            sqlConnection = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt3);
            dataGridView1.DataSource = dt3;
            dataGridView1.ClearSelection();

            query = $"SELECT m.manager_id, m.manager_name, n.nation, m.birthdate FROM manager m LEFT JOIN nationality n ON n.nationality_id = m.nationality_id WHERE m.working = 0;";
            sqlConnection = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtallman);
            dgv_allmanager.DataSource = dtallman;
            dgv_allmanager.ClearSelection();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBoxname.Text == "" || textBoxteamnum.Text == "" || comboBoxnationality.Text == "" || textBoxpos.Text == "" || textBoxheight.Text == "" || textBoxweight.Text == "" || string.IsNullOrEmpty(dateTimePicker1.Value.ToString()) || comboBoxteamname.Text == "")
            {
                MessageBox.Show("Please input correctly", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string nama = textBoxname.Text;
                string id = textBox1.Text;
                string num = textBoxteamnum.Text;
                string nation = comboBoxnationality.SelectedValue.ToString();
                string pos = textBoxpos.Text;
                string h = textBoxheight.Text;
                string w = textBoxweight.Text;
                string bd = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string team = comboBoxteamname.SelectedValue.ToString();

                query = $"INSERT INTO player values ('{id}', '{num}', '{nama}', '{nation}', '{pos}', '{h}', '{w}', '{bd}', '{team}', '1', '0');";
                executeSQL(query);
                textBoxname.Text = "";
                textBox1.Text = "";
                textBoxheight.Text = "";
                textBoxpos.Text = "";
                textBoxweight.Text = "";
                textBoxpos.Text = "";
                textBoxteamnum.Text = "";
                dataGridView1.ClearSelection();
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            if (dgv_allmanager.CurrentRow != null && comboboxedit.SelectedItem != null && dgv_manager.CurrentRow != null)
            {
                string id = dgv_allmanager.CurrentRow.Cells[0].Value.ToString();
                query = $"UPDATE team SET manager_id = '{id}' WHERE team_id = '{comboboxedit.SelectedValue}';";
                executeSQL3(query);
                string id2 = dgv_manager.CurrentRow.Cells[0].Value.ToString();
                query = $"UPDATE manager SET working = 0 WHERE manager_id = '{id2}';";
                executeSQL3(query);
                query = $"UPDATE manager SET working = 1 WHERE manager_id = '{id}';";
                executeSQL3(query);
                updatedgv3();
                dgv_allmanager.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select a manager and a team.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int row = dt3.Rows.Count;
            if (comboboxdelete.SelectedItem != null)
            {
                if (row >= 11)
                {
                    if (dataGridView1.SelectedRows.Count != 0)
                    {
                        string name = dataGridView1.SelectedRows[0].Cells["player_name"].Value.ToString();
                        query = $"UPDATE player SET status = 0 WHERE player_name = '{name}';";
                        executeSQL2(query);
                        dataGridView1.ClearSelection();
                        comboboxdelete.SelectedIndexChanged -= comboboxdelete_SelectedIndexChanged;
                        comboboxdelete.SelectedItem = null;
                        comboboxdelete.SelectedIndexChanged += comboboxdelete_SelectedIndexChanged;
                        MessageBox.Show("Player deleted successfully.", "SECCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please select a player.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Total players are less than 11!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a team.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void comboboxedit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string team = comboboxedit.SelectedValue.ToString();
            dtcurman.Clear();
            query = $"SELECT m.manager_id, m.manager_name, t.team_name, m.birthdate, n.nation\r\nFROM manager m, team t, nationality n\r\nWHERE t.manager_id=m.manager_id && n.nationality_id=m.nationality_id && t.team_id = '{team}' && t.team_name is not null;";
            sqlConnection = new MySqlConnection(connection);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtcurman);
            dgv_manager.DataSource = dtcurman;
            dgv_manager.ClearSelection();
        }

        private void comboboxdelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt3.Clear();
            if (comboboxdelete.SelectedItem != null)
            {
                string team = comboboxdelete.SelectedValue.ToString();
                query = $"SELECT p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate, t.team_name\r\nFROM player p join nationality n on p.nationality_id=n.nationality_id\r\nJOIN team t on t.team_id=p.team_id\r\nWHERE p.status=1 && t.team_id = '{team}';";
                sqlConnection = new MySqlConnection(connection);
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt3);
                dataGridView1.DataSource = dt3;
                dataGridView1.ClearSelection();
            }
        }
        private void updatedgv1()
        {
            dt3.Clear();
            try
            {
                query = $"SELECT p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate, t.team_name\r\nFROM player p join nationality n on p.nationality_id=n.nationality_id\r\nJOIN team t on t.team_id=p.team_id\r\nWHERE p.status=1;";
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updatedgv2()
        {
            dt3.Clear();
            try
            {
                query = "SELECT p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate\r\nFROM player p, nationality n\r\nWHERE p.nationality_id=n.nationality_id && p.status=1;";
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updatedgv3()
        {
            try
            {
                dtcurman.Clear();
                string team = comboboxedit.SelectedValue.ToString();
                query = $"SELECT m.manager_id, m.manager_name, t.team_name, m.birthdate, n.nation\r\nFROM manager m, team t, nationality n\r\nWHERE t.manager_id=m.manager_id && n.nationality_id=m.nationality_id && t.team_id = '{team}' && t.team_name is not null;";
                sqlConnection = new MySqlConnection(connection);
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtcurman);
                dgv_manager.DataSource = dtcurman;
                dgv_manager.ClearSelection();

                dtallman.Clear();
                query = $"SELECT m.manager_id, m.manager_name, n.nation, m.birthdate FROM manager m LEFT JOIN nationality n ON n.nationality_id = m.nationality_id WHERE m.working = 0;";
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtallman);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void executeSQL(string query)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                updatedgv2();
            }
        }
        private void executeSQL2(string query)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                updatedgv1();
            }
        }

        private void executeSQL3(string query)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
