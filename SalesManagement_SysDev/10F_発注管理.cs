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
    public partial class F_発注管理 : Form
    {
        public F_発注管理()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            F_物流 f_buturyuu = new F_物流();
            f_buturyuu.Show();
        }

        private void ButtonSyousai_Click(object sender, EventArgs e)
        {
            this.Close();
            F_発注詳細管理 f_syousai = new F_発注詳細管理();
            f_syousai.Show();
        }
    }
}
