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
    public partial class PopupUser : Form
    {
        public PopupUser()
        {
            InitializeComponent();
        }


        private void PopupUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //return to user search page
            titleBox.Clear();
            avgBox.Clear();
            maxBox.Clear();
            stateBox.Clear();
            regionBox.Clear();
            growthBox.Clear();
            Program.jobIDViewed = "";
            Program.userPage.Show();
            this.Hide();
        }

        public void updateJob()
        {
            //Connect to db
            var cs = "Host=ec2-44-198-211-34.compute-1.amazonaws.com;Username=pbjcyutaadgyaj;Password=d759389ade78e61ecc88e682dac3cbeacfe8bebd9c262af20d864dba3f4b1fbb;Database=d2iga4s88pcpv9";
            var con = new NpgsqlConnection(cs);
            con.Open();

            //job_name, avg_salary, max_salary, job_growth,  state, region
            var sql1 = "SELECT job_name FROM job WHERE job_id = '" + Program.jobIDViewed + "'";
            var sql2 = "SELECT avg_salary FROM job WHERE job_id = '" + Program.jobIDViewed + "'";
            var sql3 = "SELECT max_salary FROM job WHERE job_id = '" + Program.jobIDViewed + "'";
            var sql4 = "SELECT job_growth FROM job WHERE job_id = '" + Program.jobIDViewed + "'";
            var sql5 = "SELECT state FROM job WHERE job_id = '" + Program.jobIDViewed + "'";
            var sql6 = "SELECT region FROM job WHERE job_id = '" + Program.jobIDViewed + "'";

            //Send Command to db
            var cmd1 = new NpgsqlCommand(sql1, con);
            var rdr1 = cmd1.ExecuteScalar();
            var cmd2 = new NpgsqlCommand(sql2, con);
            var rdr2 = cmd2.ExecuteScalar();
            var cmd3 = new NpgsqlCommand(sql3, con);
            var rdr3 = cmd3.ExecuteScalar();
            var cmd4 = new NpgsqlCommand(sql4, con);
            var rdr4 = cmd4.ExecuteScalar();
            var cmd5 = new NpgsqlCommand(sql5, con);
            var rdr5 = cmd5.ExecuteScalar();
            var cmd6 = new NpgsqlCommand(sql6, con);
            var rdr6 = cmd6.ExecuteScalar();

            titleBox.Text = rdr1.ToString();
            avgBox.Text = rdr2.ToString();
            maxBox.Text = rdr3.ToString();
            growthBox.Text = rdr4.ToString();
            stateBox.Text = rdr5.ToString();
            regionBox.Text = rdr6.ToString();

        }
    }
}
