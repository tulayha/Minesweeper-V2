using System;
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
    public partial class Difficulty : Form
    {
        public int row { get; private set; }
        public int col { get; private set; }
        public int mines { get; private set; }
        public Difficulty()
        {
            InitializeComponent();
            row = 9;
            col = 9;
            mines = 10;
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            row = 9;
            col = 9;
            mines = 10;
            this.Close();
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            row = 15;
            col = 15;
            mines = 40;
            this.Close();
        }

        private void btnExpert_Click(object sender, EventArgs e)
        {
            row = 22;
            col = 22;
            mines = 99;
            this.Close();
        }
    }
}
