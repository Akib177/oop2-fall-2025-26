using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GreyGym
{
    public partial class ProfileUpdateInfo : Form
    {
        private int userId;
        private int trainerId;
        private Form trainerForm;

        public ProfileUpdateInfo(int loggedUserId, int loggedTrainerId, Form trainer)
        {
            InitializeComponent();
            userId = loggedUserId;
            trainerId = loggedTrainerId;
            trainerForm = trainer;
        }

        private void ProfileUpdateInfo_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            string cs = @"Data Source=AKIB\SQLEXPRESS;Initial Catalog=GreyGym;Integrated Security=True;TrustServerCertificate=True";

            string query = @"
                SELECT Name, Phone, Gmail, Password
                FROM UserInfo
                WHERE UserId = @UserId
            ";

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;

                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            textBox1.Text = dr["Name"].ToString();
                            textBox2.Text = dr["Phone"].ToString();
                            textBox3.Text = dr["Gmail"].ToString();
                            textBox4.Text = dr["Password"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=AKIB\SQLEXPRESS;Initial Catalog=GreyGym;Integrated Security=True;TrustServerCertificate=True";

            string query = @"
               UPDATE UserInfo
                SET  Name = @Name,  Phone = @Phone, Gmail = @Gmail, Password = @Password
                WHERE ID = @UserId; ";

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = textBox1.Text;
                    cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = textBox2.Text;
                    cmd.Parameters.Add("@Gmail", SqlDbType.VarChar).Value = textBox3.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = textBox4.Text;
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile updated successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete your profile?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes) return;

            string cs = @"Data Source=AKIB\SQLEXPRESS;Initial Catalog=GreyGym;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                using (SqlCommand cmd =
                    new SqlCommand("DELETE FROM UserInfo WHERE UserId=@UserId", con))
                {
                    cmd.Parameters.Add("@UserId", SqlDbType.Int).Value = userId;

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Profile deleted");

                    trainerForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Back button
        private void button1_Click(object sender, EventArgs e)
        {
            trainerForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
