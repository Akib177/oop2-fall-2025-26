using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            this.LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.cs;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from UserInfo where User Id = 5";

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);

                con.Close();

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateInfo updateinfo = new UpdateInfo();
            updateinfo.Show();
            this.Hide();
                
        }
    }
}
