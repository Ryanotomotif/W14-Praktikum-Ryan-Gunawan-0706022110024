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


namespace W14_Praktikum_Ryan_Gunawan_0706022110024
{
	public partial class FormDataTeam : Form
	{
		public FormDataTeam()
		{
			InitializeComponent();
		}

		static string connectionString = "server=localhost;uid=root;pwd=;database=premier_league;";
		public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
		public MySqlCommand sqlCommand;
		public MySqlDataAdapter sqlAdapter;
		public string sqlQuery;
		DataTable dtTeam = new DataTable();
		DataTable dtSkor = new DataTable();
		int posisiTeam = 0;

		private void Form1_Load(object sender, EventArgs e)
		{
			sqlQuery = "SELECT t.team_name as `Nama Tim`, CONCAT(m.manager_name,' ','(',n.nation,')'),CONCAT(home_stadium,',',' ',city,' ','(',capacity,')') FROM team t, manager m, nationality n WHERE t.manager_id = m.manager_id AND m.nationality_id = n.nationality_id;";
			sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
			sqlAdapter = new MySqlDataAdapter(sqlCommand);
			sqlAdapter.Fill(dtTeam);

			sqlQuery = "SELECT CONCAT(p.player_name, ' ', sum(if (dm.`type` = 'GO' or dm.`type` = 'GP',1, 0)),'(',sum(if (dm.`type` = 'GP',1, 0)),')')  as 'Top Score' FROM player p, dmatch dm WHERE p.player_id = dm.player_id group by p.player_id order by 1;";
			sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
			sqlAdapter = new MySqlDataAdapter(sqlCommand);
			sqlAdapter.Fill(dtSkor);
			DataTeam(0);
		}
		public void DataTeam (int Posisi)
		{
			posisiTeam = Posisi;
			lbl_NamaTim.Text = dtTeam.Rows[Posisi][0].ToString();
			lbl_NamaManager.Text = dtTeam.Rows[Posisi][1].ToString();
			lbl_NamaStadium.Text = dtTeam.Rows[Posisi][2].ToString();
			lbl_TopSkor.Text = dtSkor.Rows[Posisi][0].ToString();
		}

		private void btn_First_Click(object sender, EventArgs e)
		{
			DataTeam(0);
		}

		private void btn_Prev_Click(object sender, EventArgs e)
		{
			if (posisiTeam > 0)
			{
				posisiTeam--;
				DataTeam(posisiTeam);
			}
			else
			{
				MessageBox.Show("Sudah Data Paling Pertama");
			}
		}

		private void btn_Next_Click(object sender, EventArgs e)
		{
			if (posisiTeam < dtTeam.Rows.Count - 1)
			{
				posisiTeam++;
				DataTeam(posisiTeam);
			}
			else
			{
				MessageBox.Show("Sudah Data Paling Terakhir");
			}
		}

		private void btn_Last_Click(object sender, EventArgs e)
		{
			DataTeam(dtTeam.Rows.Count - 1);
		}
	}
}
