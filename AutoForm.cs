﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoSalon
{
    public partial class AutoForm : Form
    {
        public AutoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm ClntFrm = new ClientForm();
            ClntFrm.Show();
        }
    }
}
