﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_注文管理 : Form
    {
        public F_注文管理()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_営業 f_eigyou = new F_営業();
            f_eigyou.Show();
        }

        private void ButtonSyousai_Click(object sender, EventArgs e)
        {
            this.Close();
            F_注文詳細登録 f_syousai = new F_注文詳細登録();
            f_syousai.Show();
        }

        private void ButtonExe_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }
    }
}
