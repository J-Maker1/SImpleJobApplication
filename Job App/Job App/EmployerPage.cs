using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Program.login.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AvgSalaryRange.SelectedIndex = 0;
            //MaxSalaryRange.SelectedIndex = 0;
            //JobGrowthRange.SelectedIndex = 0;
            StateChoice.SelectedIndex = 0;
            RegionChoice.SelectedIndex = 0;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
