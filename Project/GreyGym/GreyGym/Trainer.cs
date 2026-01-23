using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GreyGym
{
    public partial class Trainer : Form
    {
        private int loggedTrainerId;

        public Trainer(int trainerId)
        {
            InitializeComponent();
            loggedTrainerId = trainerId;
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
            string cs = @"Data Source=AKIB\SQLEXPRESS;Initial Catalog=GreyGym;Integrated Security=True;TrustServerCertificate=True";

            string query = @"
               SELECT ui.Name, ui.Gender, ui.UserType, up.StartDate, up.EndDate
            FROM TrainerUser tu
            INNER JOIN UserInfo ui
            ON tu.CustomerID = ui.ID
            INNER JOIN UserPackage up
            ON tu.CustomerID = up.UserId
            WHERE tu.TrainerID = @TrainerID
            ";

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.Add("@TrainerID", SqlDbType.Int).Value = loggedTrainerId;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnDiet_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=AKIB\SQLEXPRESS;Initial Catalog=GreyGym;Integrated Security=True;TrustServerCertificate=True";

            string query = @"
              SELECT ui.Name, ui.Gender, ui.UserType, dp.CurrentWeight,
              dp.TargetWeight, dp.Goal, dp.FoodPlan, dp.StartDateFROM DietPlan dp 
              INNER JOIN UserInfo ui ON dp.UserID = ui.ID
              WHERE dp.TrainerID = @TrainerID;";

            using (SqlConnection con = new SqlConnection(cs))
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.Add("@TrainerID", SqlDbType.Int).Value = loggedTrainerId;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileUpdateInfo p = new ProfileUpdateInfo(loggedTrainerId, loggedTrainerId, this);
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