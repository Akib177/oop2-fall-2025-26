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
    public partial class CustomerPayment : Form
    {
        
        public CustomerPayment()
        {
            InitializeComponent();
        }
       

        
       
        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
          
        }

        private void CustomerPayment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportsDB;Integrated Security=True;TrustServerCertificate=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Amount ", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            PaymentDGV.DataSource = table;


            //string query = ("SELECT Package.PackageName, UserPackage.IsActive FROM UserPackage INNER JOIN Package ON UserPackage.PackageId = Package.PackageId "); ;

            // SqlDataAdapter da = new SqlDataAdapter(query, con);
            // DataTable table = new DataTable();
            // da.Fill(table);
            // dataGridView1.DataSource = table;
        }
        private void Reset_AllBoxes()
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=RAHUL_SARKER\TEW_SQLEXPRESS;Initial Catalog=gymmananagment;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("insert into Amount Values(@Amount, @Method, @PaymentStatus, @Goal)", con);

            cnn.Parameters.AddWithValue("@Amount", double.Parse(AmountTb.Text));
            cnn.Parameters.AddWithValue("@Method", PayoptionTb.Text);
            cnn.Parameters.AddWithValue("@PaymentStatus",txtGmail.Text );
            

            cnn.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Saved");


        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "500";
            PackageTb.Text = "Student";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "1000";
            PackageTb.Text = "Standard";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "1500";
            PackageTb.Text = "Primium";
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerWorkout cw = new CustomerWorkout(); 
            cw.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CustomerHome ch = new CustomerHome();
            ch.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CustomerWorkout ch = new CustomerWorkout();
            ch.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SportsDB;Integrated Security=True;TrustServerCertificate=True");

            con.Open();

            SqlCommand cnn = new SqlCommand("select * from Amount ", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            PaymentDGV.DataSource = table;
        }
    }
}
