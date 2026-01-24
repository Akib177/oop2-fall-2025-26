using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreyGym
{
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }

        private void EmployeeHome_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpProfile empProfile = new EmpProfile();
            empProfile.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.Show();
            this.Close();
        }
    }
}
