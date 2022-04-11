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

namespace WindowsFormsApp11April
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;

        public string sqlQuery;

        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable dtplayerHome = new DataTable();
            DataTable dtplayerAway = new DataTable();
            sqlQuery = "SELECT t.team_name, t.team_id, t.home_stadium, t.capacity , m.manager_name, p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtplayerHome);
            sqlQuery = "SELECT t.team_name, t.team_id, t.home_stadium, t.capacity , m.manager_name, p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlAdapter.Fill(dtplayerAway);
            comboBoxHome.DataSource = dtplayerHome;
            comboBoxHome.DisplayMember = "team_name";
            comboBoxHome.ValueMember = "team_id";
            comboBoxAway.DataSource = dtplayerAway;
            comboBoxAway.DisplayMember = "team_name";
            comboBoxAway.ValueMember = "team_id";
        }

        private void labelCaptainHome_Click(object sender, EventArgs e)
        {

        }

        private void labelManajerHome_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable namaManager = new DataTable();
            DataTable namaKapten = new DataTable();
            sqlQuery = "SELECT t.team_name, t.team_id, t.home_stadium, t.capacity , m.manager_name, p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(namaManager);
            sqlAdapter.Fill(namaKapten);
            labelManajerAway.Text = namaManager.Rows[comboBoxAway.SelectedIndex][4].ToString();
            labelKaptenAway.Text = namaKapten.Rows[comboBoxAway.SelectedIndex][5].ToString();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Manajer = new DataTable();
            DataTable Kapten = new DataTable();
            DataTable Stadion = new DataTable();
            DataTable Kapasitas= new DataTable();
            sqlQuery = "SELECT t.team_name, t.team_id, t.home_stadium, t.capacity , m.manager_name, p.player_name FROM team t, manager m, player p where t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Manajer);
            sqlAdapter.Fill(Kapten);
            sqlAdapter.Fill(Stadion);
            sqlAdapter.Fill(Kapasitas);
            labelManajerHome.Text = Manajer.Rows[comboBoxHome.SelectedIndex][4].ToString();
            labelKaptenHome.Text = Kapten.Rows[comboBoxHome.SelectedIndex][5].ToString();
            labelStadion.Text = Stadion.Rows[comboBoxHome.SelectedIndex][2].ToString();
            labelKapasitas.Text = Kapasitas.Rows[comboBoxHome.SelectedIndex][3].ToString();
        }

        private void labelStadion_Click(object sender, EventArgs e)
        {

        }

        private void labelKapasitas_Click(object sender, EventArgs e)
        {

        }

        private void labelKaptenHome_Click(object sender, EventArgs e)
        {

        }

        private void labelManajerAway_Click(object sender, EventArgs e)
        {

        }
    }
}
