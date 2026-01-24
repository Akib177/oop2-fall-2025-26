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
    public partial class CustomerProfile : Form
    {
        public CustomerProfile()
        {
            InitializeComponent();
        }
        public void Getgrid()
        {
            SqlConnection con = new SqlConnection(@"Data Source=AKIB\SQLEXPRESS;Initial Catalog=GreyGym;Integrated Security=True;TrustServerCertificate=True";);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from UserInfo", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ProfileDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AKIB\SQLEXPRESS;Initial Catalog=GreyGym;Integrated Security=True;TrustServerCertificate=True";);
            SqlCommand cmd = new SqlCommand("delete from UserInfo where Id='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            cmd.Dispose();
            con.Close();
            Getgrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AKIB\SQLEXPRESS;Initial Catalog=GreyGym;Integrated Security=True;TrustServerCertificate=True";);
            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into UserInfo values('" + txtName.Text + "','" + textGmail.Text + "','" + txtPhone.Text  +"','" + txtPass.Text + "')", con);
            int check = cmd.ExecuteNonQuery();
            if (check > 0)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Not- Inserted");
            }
            cmd.Dispose();
            con.Close();
            Getgrid();

        }

        private void CustomerProfile_Load(object sender, EventArgs e)
        {
            Getgrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AKIB\SQLEXPRESS;Initial Catalog=GreyGym;Integrated Security=True;TrustServerCertificate=True";);  
            con.Open();

            SqlCommand cmd = new SqlCommand("update UserInfo set  Name='" + txtName.Text + "',Gmail='" + textGmail.Text + "',Phone='" + txtPhone.Text + "', Password='" + txtPass.Text + "', where ID='" + textBox1.Text + "'", con);
            // con.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated");
            cmd.ExecuteNonQuery();  
                MessageBox.Show("updated");  
                cmd.Dispose();  
                con.Close();  
                Getgrid();  
        }
        public void clearmethod()
        {
            txtName.Text = "";
            textGmail.Text = "";
            txtPhone.Text = "";
            txtPass.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CustomerHome ch = new CustomerHome();
            ch.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerWorkout cw = new CustomerWorkout();
            cw.Show();
            this.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
