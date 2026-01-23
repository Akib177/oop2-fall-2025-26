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
        SqlConnection con = new SqlConnection("Data Source=RAHUL_SARKER\\TEW_SQLEXPRESS;Initial Catalog=gymmananagment;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        private void FillName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select MName from MemberTbl", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MName", typeof(string));
            dt.Load(rdr);
         //   NameCB = "MName";
          //  NameCB= dt;
            con.Close();
        }
        private void Populate()
        {
            con.Open();
            string query = "select * from Amount";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            con.Close();
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
            AmountTb.Text = "";
            NameCB.Text = "";
        }

        private void CustomerPayment_Load(object sender, EventArgs e)
        {
            FillName();
            Populate();


            //string query = ("SELECT Package.PackageName, UserPackage.IsActive FROM UserPackage INNER JOIN Package ON UserPackage.PackageId = Package.PackageId "); ;

            // SqlDataAdapter da = new SqlDataAdapter(query, con);
            // DataTable table = new DataTable();
            // da.Fill(table);
            // dataGridView1.DataSource = table;
        }
        private void Reset_AllBoxes()
        {
            NameCB.Text = "";
            AmountTb.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            if (NameCB.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("select amount and package  ");
            }
            else
            {
                try
                {
                    con.Open();
                    string status = "Confirm";
                    
                    string query = "insert into Amount ( Amount, Method, PaymentStatus) values('" + AmountTb.Text + "','" + PayoptionTb + "'," + AmountTb.Text + status + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Confirmed Successfully");
                    con.Close();
                    Populate();
                    Reset_AllBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "500";
            NameCB.Text = "Student";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "1000";
            NameCB.Text = "Standard";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "1500";
            NameCB.Text = "Primium";
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
    }
}
