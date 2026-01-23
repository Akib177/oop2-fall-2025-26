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

namespace GreyGym
{
    public partial class EmpProfile : Form
    {
        public EmpProfile()
        {
            InitializeComponent();
        }

        private void EmpProfile_Load(object sender, EventArgs e)
        {
            LoadData();   
        }

        
        private void LoadData()
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.cs;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                cmd.CommandText = "Select * from UserInfo where Id = 5";
                    

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.ClearSelection();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateInfo upi = new UpdateInfo();
            upi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeHome emph = new EmployeeHome();
            emph.Show();
            this.Hide();
        }
    }
}
