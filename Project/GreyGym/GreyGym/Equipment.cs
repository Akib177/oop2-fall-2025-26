using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GreyGym
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            this.LoadEquipmentData();
        }

        private void LoadEquipmentData()
        {
            try
            {
                var con = new SqlConnection();
                con.ConnectionString = ApplicationHelper.cs;
                con.Open();

                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "select ID, Ename, Category, Quantity, PurchaseDate, Status from GymEquipment";

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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EmployeeHome emph = new EmployeeHome();
            emph.Show();
            this.Close();
        }
    }
}
