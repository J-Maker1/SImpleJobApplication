﻿using System;
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
    public partial class PopupEmployer : Form
    {
        public PopupEmployer()
        {
            InitializeComponent();
        }

        private void PopupEmployer_Load(object sender, EventArgs e)
        {

        }

        private void PopupEmployer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
