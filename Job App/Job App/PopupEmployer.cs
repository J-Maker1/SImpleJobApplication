﻿using System;
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
    public partial class PopupEmployer : Form
    {
        int[] change = { 0, 0, 0, 0, 0, 0 };
        string newTitle;
        string newAvg;
        string newMax;
        string newGrowth;
        string newState;
        string newRegion;
        public PopupEmployer()
        {
            InitializeComponent();
        }

        private void PopupEmployer_Load(object sender, EventArgs e)
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

        private void PopupEmployer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
           
            //Connect to db
            var cs = "Host=ec2-44-198-211-34.compute-1.amazonaws.com;Username=pbjcyutaadgyaj;Password=d759389ade78e61ecc88e682dac3cbeacfe8bebd9c262af20d864dba3f4b1fbb;Database=d2iga4s88pcpv9";
            var con = new NpgsqlConnection(cs);
            con.Open();

            if (change[0] == 1)
            {
                var sql = "UPDATE job SET job_name = '" + newTitle + "' WHERE job_id = '" + Program.jobIDViewed + "'";
                //Send Command to db
                var cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();
            }
            if (change[1] == 1)
            {
                var sql = "UPDATE job SET avg_salary = '" + avgBox.Text + "' WHERE job_id = '" + Program.jobIDViewed + "'";
                //Send Command to db
                var cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();
            }
            if (change[2] == 1)
            {
                var sql = "UPDATE job SET max_salary = '" + newMax + "' WHERE job_id = '" + Program.jobIDViewed + "'";
                //Send Command to db
                var cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();
            }
            if (change[3] == 1)
            {
                var sql = "UPDATE job SET job_growth = '" + growthBox.Text + "' WHERE job_id = '" + Program.jobIDViewed + "'";
                //Send Command to db
                var cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();
            }
            if (change[4] == 1)
            {
                var sql = "UPDATE job SET state = '" + stateBox.Text + "' WHERE job_id = '" + Program.jobIDViewed + "'";
                //Send Command to db
                var cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();
            }
            if (change[5] == 1)
            {
                var sql = "UPDATE job SET region = '" + regionBox.Text + "' WHERE job_id = '" + Program.jobIDViewed + "'";
                //Send Command to db
                var cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            //Connect to db
            var cs = "Host=ec2-44-198-211-34.compute-1.amazonaws.com;Username=pbjcyutaadgyaj;Password=d759389ade78e61ecc88e682dac3cbeacfe8bebd9c262af20d864dba3f4b1fbb;Database=d2iga4s88pcpv9";
            var con = new NpgsqlConnection(cs);
            con.Open();

            //Build SQL command
            var sql = "DELETE FROM job WHERE job_id = '" + Program.jobIDViewed + "'";

            //Send Command to db
            var cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            //return to employer search page
            titleBox.Clear();
            avgBox.Clear();
            maxBox.Clear();
            stateBox.Clear();
            regionBox.Clear();
            growthBox.Clear();
            Program.jobIDViewed = "";
            Program.employerPage.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //return to employer search page
            titleBox.Clear();
            avgBox.Clear();
            maxBox.Clear();
            stateBox.Clear();
            regionBox.Clear();
            growthBox.Clear();
            Program.jobIDViewed = "";
            Program.employerPage.Show();
            this.Hide();
        }
        private void titelBox_TextChanged(object sender, EventArgs e)
        {
            change[0] = 1;
            newTitle = titleBox.Text;
            update_Click(sender, e);
        }
        private void avgBox_TextChanged(object sender, EventArgs e)
        {
            change[1] = 1;
            newAvg = avgBox.Text;
            update_Click(sender, e);
        }
        private void maxBox_TextChanged(object sender, EventArgs e)
        {
            change[2] = 1;
            newMax = maxBox.Text;
            update_Click(sender, e);
        }
        private void growthBox_TextChanged(object sender, EventArgs e)
        {
            change[3] = 1;
            newGrowth = growthBox.Text;
            update_Click(sender, e);
        }
        private void stateBox_TextChanged(object sender, EventArgs e)
        {
            change[4] = 1;
            newState = stateBox.Text;
            update_Click(sender, e);
        }
        private void regionBox_TextChanged(object sender, EventArgs e)
        {
            change[5] = 1;
            newRegion = regionBox.Text;
            update_Click(sender, e);
        }

    }
}
