using System;
using Npgsql;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string entrUsr = textBox1.Text; string entrPass = textBox2.Text;
            var cs = "Host=ec2-44-198-211-34.compute-1.amazonaws.com;Username=pbjcyutaadgyaj;Password=d759389ade78e61ecc88e682dac3cbeacfe8bebd9c262af20d864dba3f4b1fbb;Database=d2iga4s88pcpv9";
            var con = new NpgsqlConnection(cs);
            con.Open();
            if (comboBox1.Text == "Applicant")
            {
                string query = String.Format("SELECT ap.password FROM Applicant AS ap WHERE ap.username = \'{0}\';", entrUsr);
                var cmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();


                if (!rdr.Read())
                {
                    Console.WriteLine("No match");
                }
                else
                {

                    string actpass = rdr.GetString(0);
                    actpass = actpass.Trim(' ');
                    //Console.WriteLine("{0}, {1}", rdr.GetString(0), rdr.GetString(1));
                    //Comparing passwords (we should probably be storing the
                    //hashes of the passwords but this is just for practice)
                    Boolean passmatch = entrPass.Equals(actpass);

                    if (passmatch)
                    {
                        Program.userPage.Show();
                        this.Hide();
                    }

                }

            }
            else if (comboBox1.Text == "Employer")
            {
                string query = String.Format("SELECT ap.password FROM Employer AS ap WHERE ap.username = \'{0}\';", entrUsr);
                var cmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();


                if (!rdr.Read())
                {
                    Console.WriteLine("No match");
                }
                else
                {
                    string actpass = rdr.GetString(0);
                    actpass = actpass.Trim(' ');
                    //Console.WriteLine("{0}, {1}", rdr.GetString(0), rdr.GetString(1));
                    //Comparing passwords (we should probably be storing the
                    //hashes of the passwords but this is just for practice)
                    Boolean passmatch = entrPass.Equals(actpass);

                    if (passmatch)
                    {
                        Program.employerPage.Show();
                        this.Hide();
                    }

                }
            }
        }

        //This is the method for the register button being clicked
        private void button2_Click(object sender, EventArgs e)
        {
            string entrUsr = textBox4.Text; string entrPass = textBox5.Text;
            string entrName = textBox3.Text;  string usrType = comboBox2.Text;
            var cs = "Host=ec2-44-198-211-34.compute-1.amazonaws.com;Username=pbjcyutaadgyaj;Password=d759389ade78e61ecc88e682dac3cbeacfe8bebd9c262af20d864dba3f4b1fbb;Database=d2iga4s88pcpv9";
            var con = new NpgsqlConnection(cs);
            con.Open();

            var cmd = new NpgsqlCommand();
            cmd.Connection = con;

            if(usrType.Equals("Applicant"))
            {
                cmd.CommandText = String.Format(
                    "INSERT INTO Applicant(user_id, username, password, applicant_name) VALUES(\'{0}\', \'{1}\', \'{2}\', \'{3}\')",
                    Guid.NewGuid().ToString("N"), entrUsr, entrPass, entrName);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Applicant created");

            }
            else if(usrType.Equals("Employer"))
            {
                cmd.CommandText = String.Format(
                    "INSERT INTO Employer(user_id, username, password, company_name) VALUES(\'{0}\', \'{1}\', \'{2}\', \'{3}\')",
                    Guid.NewGuid().ToString("N"), entrUsr, entrPass, entrName);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employer created");
                textBox4.Text

            }


            con.Close();

        }

        //Ignore
        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
