using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Job_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Program.login.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AvgSalaryRange.SelectedIndex = 0;
            MaxSalaryRange.SelectedIndex = 0;
            JobGrowthRange.SelectedIndex = 0;
            StateChoice.SelectedIndex = 0;
            RegionChoice.SelectedIndex = 0;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
