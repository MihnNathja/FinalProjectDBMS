﻿using DBMSProject.DAO;
using DBMSProject.Object;
using System;
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
    public partial class FQuanLyDichVu : Form
    {
        public FQuanLyDichVu()
        {
            InitializeComponent();
        }

        private void ServiceTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucQuanLyDoAn.LoadDuLieu(tabDichVu.SelectedTab.Text);
            ucQuanLyThucUong.LoadDuLieu(tabDichVu.SelectedTab.Text);
            ucQuanLyTheCao.LoadDuLieu(tabDichVu.SelectedTab.Text);
        }

        private void FQuanLyDichVu_Load(object sender, EventArgs e)
        {
            ServiceTab_SelectedIndexChanged(sender, e);
        }
    }
}
