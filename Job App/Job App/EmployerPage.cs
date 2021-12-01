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
    public partial class Form1 : Form
    {
        //Keep track of job_id's that belong to employer
        List<string> jobList = new List<string>();
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
            
        }

        public void GetJob()
        {
            StateChoice.SelectedIndex = 0;
            RegionChoice.SelectedIndex = 0;

            //Connect to db
            var cs = "Host=ec2-44-198-211-34.compute-1.amazonaws.com;Username=pbjcyutaadgyaj;Password=d759389ade78e61ecc88e682dac3cbeacfe8bebd9c262af20d864dba3f4b1fbb;Database=d2iga4s88pcpv9";
            var con = new NpgsqlConnection(cs);

            con.Open();

            //Build SQL command
            var sql = "SELECT * FROM PostJob WHERE user_id = '" + Program.EmployerID + "'";

            //Send Command to db
            var cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader rdr = cmd.ExecuteReader();

            //Record the db output and place it in the list
            while (rdr.Read())
            {
                if(!jobList.Contains(rdr.GetString(0).Trim()))
                {
                    jobList.Add(rdr.GetString(0).Trim());
                }
            }
            LoadJobs();
            con.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Event handler for when a user double clicks a job in the list
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)   //If the item isn't empty, then we set the global variable jobIDViewed to the job id that was clicked and switch windows to the popup
            {
                Program.jobIDViewed = item.Text;
                Program.popupEmployer.Show();
                this.Hide();
                Program.popupEmployer.updateJob();
            }
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            //Connect to db
            var cs = "Host=ec2-44-198-211-34.compute-1.amazonaws.com;Username=pbjcyutaadgyaj;Password=d759389ade78e61ecc88e682dac3cbeacfe8bebd9c262af20d864dba3f4b1fbb;Database=d2iga4s88pcpv9";
            var con = new NpgsqlConnection(cs);
            con.Open();

            //Build SQL command
            var sql = "INSERT INTO job (job_id, job_name, avg_salary, max_salary, job_growth,  state, region) VALUES";

            //Job Name Search
            if (!string.IsNullOrEmpty(JobNameBox.Text) && !string.IsNullOrEmpty(AvgSalaryBox.Text) && !string.IsNullOrEmpty(MaxSalaryBox.Text) && !string.IsNullOrEmpty(JobGrowthBox.Text) && StateChoice.SelectedIndex != 0 && RegionChoice.SelectedIndex != 0)
            {
                Random rnd = new Random();
                int job_id = rnd.Next(10000);

                sql += " ('" + job_id.ToString() + "', '" + JobNameBox.Text + "', " + AvgSalaryBox.Text + ", " + MaxSalaryBox.Text + ", " + JobGrowthBox.Text + ", '" + StateChoice.Text.ToUpper() + "', '" + RegionChoice.Text.ToUpper() + "')";
                Console.WriteLine(sql);
                //Send Command to db
                var cmd = new NpgsqlCommand(sql, con);
                //NpgsqlDataReader rdr = cmd.ExecuteReader();
                cmd.ExecuteNonQuery();
                label9.Text = "Job Sucessfully Added!";
                PostJob(job_id);
            }
            else
            {
                label9.Text = "Please fill out all of the fields!";
            }
            con.Close();
        }

        //Ties the job to the employer id
        private void PostJob(int job_id)
        {
            //Connect to db
            var cs = "Host=ec2-44-198-211-34.compute-1.amazonaws.com;Username=pbjcyutaadgyaj;Password=d759389ade78e61ecc88e682dac3cbeacfe8bebd9c262af20d864dba3f4b1fbb;Database=d2iga4s88pcpv9";
            var con = new NpgsqlConnection(cs);
            con.Open();

            //Build SQL command
            var sql = "INSERT INTO PostJob (job_id, user_id, date) VALUES ('" + job_id.ToString() +"', '"+ Program.EmployerID.Trim()+"', '"+ DateTime.Now.ToString("MM/dd/yyyy")+"')";
            Console.WriteLine(sql);
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void LoadJobs()
        {
            listView1.Items.Clear();
            //Connect to db
            var cs = "Host=ec2-44-198-211-34.compute-1.amazonaws.com;Username=pbjcyutaadgyaj;Password=d759389ade78e61ecc88e682dac3cbeacfe8bebd9c262af20d864dba3f4b1fbb;Database=d2iga4s88pcpv9";
            var con = new NpgsqlConnection(cs);

            foreach (String job_id in jobList)
            {
                con.Open();
                //Build SQL command
                var sql = "SELECT * FROM job WHERE job_id = '" + job_id + "'";

                //Send Command to db
                var cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();

                //Record the db output and place it in the list
                while (rdr.Read())
                {
                    ListViewItem item = new ListViewItem(rdr.GetString(0));
                    item.SubItems.Add(rdr.GetString(1));
                    item.SubItems.Add(rdr.GetInt32(2).ToString());
                    item.SubItems.Add(rdr.GetInt32(3).ToString());
                    item.SubItems.Add(rdr.GetInt32(4).ToString());
                    item.SubItems.Add(rdr.GetString(5));
                    item.SubItems.Add(rdr.GetString(6));
                    listView1.Items.Add(item);
                }
                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetJob();
        }
    }
}
