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
                string query = String.Format("SELECT ap.username, ap.password FROM Applicant AS ap WHERE ap.username = \'{0}\'", entrUsr);
                var cmd = new NpgsqlCommand(query, con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();

                if (!rdr.Read())
                {
                    Console.WriteLine("No match");
                }
                else
                {
                    Console.WriteLine("{0}, {1}", rdr.GetString(0), rdr.GetString(1));
                }

            }
            else if (comboBox1.Text == "Employer")
            {

            }
        }
    }
}
