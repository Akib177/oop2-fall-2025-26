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

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            this.Hide();
            eq.Show();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpProfile emp = new EmpProfile();  
            this.Hide();
            emp.Show();
        }
    }
}
