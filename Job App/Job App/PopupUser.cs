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
    public partial class PopupUser : Form
    {
        public PopupUser()
        {
            InitializeComponent();
        }

        private void PopupUser_Load(object sender, EventArgs e)
        {

        }

        private void PopupUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
