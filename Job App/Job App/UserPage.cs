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

        //Setting handler for when the user logs out
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Program.login.Show();
            this.Hide();
        }

        //Setting default values of the combo boxes
        private void Form2_Load(object sender, EventArgs e)
        {
            AvgSalaryRange.SelectedIndex = 0;
            MaxSalaryRange.SelectedIndex = 0;
            JobGrowthRange.SelectedIndex = 0;
            StateChoice.SelectedIndex = 0;
            RegionChoice.SelectedIndex = 0;
        }

        //Make sure program ends when exiting the window
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Event handler for searching jobs
        private void SearchButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //Connect to db
            var cs = "Host=ec2-44-198-211-34.compute-1.amazonaws.com;Username=pbjcyutaadgyaj;Password=d759389ade78e61ecc88e682dac3cbeacfe8bebd9c262af20d864dba3f4b1fbb;Database=d2iga4s88pcpv9";
            var con = new NpgsqlConnection(cs);
            con.Open();

            //Build SQL command
            var sql = "SELECT * FROM job";
            Boolean whereAdded = false;

            //Job Name Search
            if (!string.IsNullOrEmpty(JobNameBox.Text))
            {
                if (whereAdded == false)
                {
                    whereAdded = true;
                    sql += " WHERE job_name = '" + JobNameBox.Text + "'";
                }
                else
                {
                    sql += " AND job_name = '" + JobNameBox.Text + "'";
                }
            }
            //Avg Salary Search
            if (!string.IsNullOrEmpty(AvgSalaryBox.Text))
            {
                if (whereAdded == false)
                {
                    whereAdded = true;
                    if(AvgSalaryRange.SelectedIndex == 0)
                    {
                        sql += " WHERE avg_salary = '" + AvgSalaryBox.Text + "'";
                    }
                    else
                    {
                        sql += " WHERE avg_salary > '" + AvgSalaryBox.Text + "'";
                    }
                }
                else
                {
                    if (AvgSalaryRange.SelectedIndex == 0)
                    {
                        sql += " AND avg_salary = '" + AvgSalaryBox.Text + "'";
                    }
                    else
                    {
                        sql += " AND avg_salary > '" + AvgSalaryBox.Text + "'";
                    }
                }
                
            }
            //Max Salary Search
            if (!string.IsNullOrEmpty(MaxSalaryBox.Text))
            {
                if (whereAdded == false)
                {
                    whereAdded = true;
                    if (MaxSalaryRange.SelectedIndex == 0)
                    {
                        sql += " WHERE max_salary = '" + MaxSalaryBox.Text + "'";
                    }
                    else
                    {
                        sql += " WHERE max_salary > '" + MaxSalaryBox.Text + "'";
                    }
                }
                else
                {
                    if (MaxSalaryRange.SelectedIndex == 0)
                    {
                        sql += " AND max_salary = '" + MaxSalaryBox.Text + "'";
                    }
                    else
                    {
                        sql += " AND max_salary > '" + MaxSalaryBox.Text + "'";
                    }
                }
            }
            //Job Growth Search
            if (!string.IsNullOrEmpty(JobGrowthBox.Text))
            {
                if (whereAdded == false)
                {
                    whereAdded = true;
                    if (JobGrowthRange.SelectedIndex == 0)
                    {
                        sql += " WHERE job_growth = '" + JobGrowthBox.Text + "'";
                    }
                    else
                    {
                        sql += " WHERE job_growth > '" + JobGrowthBox.Text + "'";
                    }
                }
                else
                {
                    if (JobGrowthRange.SelectedIndex == 0)
                    {
                        sql += " AND job_growth = '" + JobGrowthBox.Text + "'";
                    }
                    else
                    {
                        sql += " AND job_growth > '" + JobGrowthBox.Text + "'";
                    }
                }
            }
            //State Search
            if(StateChoice.SelectedIndex != 0)
            {
                if (whereAdded == false)
                {
                    whereAdded = true;
                    sql += " WHERE state = '" + StateChoice.Text + "'";
                }
                else
                {
                    sql += " AND state = '" + StateChoice.Text + "'";
                }
            }
            //Region Search
            if (RegionChoice.SelectedIndex != 0)
            {
                if (whereAdded == false)
                {
                    whereAdded = true;
                    sql += " WHERE region = '" + RegionChoice.Text + "'";
                }
                else
                {
                    sql += " AND region = '" + RegionChoice.Text + "'";
                }
            }
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

        //Event handler for when a user double clicks a job in the list
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)   //If the item isn't empty, then we set the global variable jobIDViewed to the job id that was clicked and switch windows to the popup
            {
                Program.jobIDViewed = item.Text;
                Program.popupUserPage.Show();
                this.Hide();
                Program.popupUserPage.updateJob();
            }
        }
    }
}
