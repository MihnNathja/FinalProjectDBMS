﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SelectForm selectForm = new SelectForm();
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            selectForm.ShowDialog();
        }
    }
}
