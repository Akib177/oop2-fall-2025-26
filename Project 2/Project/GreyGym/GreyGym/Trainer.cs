using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GreyGym
{
    public partial class Trainer : Form
    {
        private int loggedTrainerId;

        public Trainer(int id)
        {
            InitializeComponent();
            loggedTrainerId = Session.ID;
        }

        private void Trainer_Load(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ApplicationHelper.cs;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = @"
                SELECT ui.Name, ui.Gender, ui.UserType, up.StartDate, up.EndDate
                FROM TrainerUser tu
                INNER JOIN UserInfo ui ON tu.UID = ui.UserId
                INNER JOIN UserPackage up ON tu.UID = up.UserId
                WHERE tu.TID = @TrainerID
            ";

            DataSet ds = new DataSet();

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();

            con.Close();
        }

        private void btnDiet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ApplicationHelper.cs;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = @"
                SELECT ui.Name, ui.Gender, ui.UserType,
                       dp.CurrentWeight, dp.TargetWeight,
                       dp.Goal, dp.FoodPlan, dp.StartDate
                FROM DietPlan dp
                INNER JOIN UserInfo ui ON dp.UserID = ui.UserId
                WHERE dp.TrainerID = @TrainerID
            ";


            DataSet ds = new DataSet();

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();

            con.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileUpdateInfo p =
                new ProfileUpdateInfo(loggedTrainerId, loggedTrainerId, this);

            this.Hide();
            p.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }
    }
}
