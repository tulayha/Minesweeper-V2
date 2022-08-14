﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperV2
{
    public partial class Result : Form
    {
        public Result(bool result, int time)
        {
            InitializeComponent();
            lblResult.Text = result ? "You Won!" : "You Lose!";
            lblTime.Text += time.ToString() + " s";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
