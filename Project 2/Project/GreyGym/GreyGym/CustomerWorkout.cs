using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GreyGym
{
    public partial class CustomerWorkout : Form
    {
        public CustomerWorkout()
        {
            InitializeComponent();
        }

        private void PaymentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=RAHUL_SARKER\TEW_SQLEXPRESS;Initial Catalog=gymmananagment;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("insert into DietPlan Values(@UserID, @CurrentWeight, @TargetWeight, @Goal)", con);

            cnn.Parameters.AddWithValue("@CurrentWeight", double.Parse(txtcurrw.Text));
            cnn.Parameters.AddWithValue("@TargetWeight", double.Parse(txtterw.Text));
            cnn.Parameters.AddWithValue("@Goal", goal.Text);
            cnn.Parameters.AddWithValue("@UserID", int.Parse(Autobox.Text));

            cnn.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Saved");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportsDB;Integrated Security=True;TrustServerCertificate=True";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a User ID first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT CurrentWeight FROM DietPlan WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserID", textBox1.Text);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("User ID not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PayoptionTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NameCB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AmountTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportsDB;Integrated Security=True;TrustServerCertificate=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("update DietPlan set CurrentWeight=@CurrentWeight,TargetWeight=@TargetWeight,Goal=@Goal where UserID=@UserID", con);

            cnn.Parameters.AddWithValue("@CurrentWeight", double.Parse(txtcurrw.Text));
            cnn.Parameters.AddWithValue("@TargetWeight", double.Parse(txtterw.Text));
            cnn.Parameters.AddWithValue("@Goal", goal.Text);
            cnn.Parameters.AddWithValue("@UserID", int.Parse(Autobox.Text));
           

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportsDB;Integrated Security=True;TrustServerCertificate=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("select * from DietPlan ", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataview.DataSource = table;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportsDB;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("delete from DietPlan where  Userid=@Userid", con);

            cnn.Parameters.AddWithValue("@playerid", int.Parse(Autobox.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted");

        }

        private void CustomerWorkout_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportsDB;Integrated Security=True;TrustServerCertificate=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("select * from DietPlan ", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataview.DataSource = table;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            CustomerPayment cp = new CustomerPayment();
            cp.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CustomerProfile cp = new CustomerProfile();
            cp.Show(); 
            this.Hide();
        }
    }
}
