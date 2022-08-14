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
    public partial class Minesweeper : Form
    {
        private int sCol = 9;
        private int sRow = 9;
        private int numMines = 10;
        private bool firstClk;
        private int clkCounter;
        private int _flagCounter;
        private int flagCounter
        {
            set
            {

                mineCounter.Value = value;
                _flagCounter = value;
            }
            get
            {
                return _flagCounter;
            }
        }
        private int time
        {
            get
            {
                return int.Parse(lblTime.Text);
            }
            set
            {
                if (value == 0) { timer.Enabled = false; }
                lblTime.Text = value.ToString();
            }
        }

        private Dictionary<Point, BtnMine> lsBtns = new Dictionary<Point, BtnMine>();

        private List<Point> lsMines = new List<Point>();
       

        #region Initialize Game
        public Minesweeper()
        {
            InitializeComponent();
            initializeBtnMatrix();
            setupGrid();
            resetGame();
            mineCounter.Leave += mineCounter_Leave;
            tTipMine.SetToolTip(mineCounter, "Press Reset or any mine to set Custom Mines.");
        }

        private void initializeBtnMatrix()
        {
            BtnMine tempBtn;
            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 22; j++)
                {
                    tempBtn = new BtnMine();
                    tempBtn.MouseUp += tempBtn_MouseUp;
                    lsBtns.Add(new Point(i, j), tempBtn);

                }
            }
        }

        #endregion

        #region Set and Reset Functions
        private void setupGrid()
        {
            BtnMine btnRef = new BtnMine();
            flpMainGrid.Size = new System.Drawing.Size((btnRef.Width + (btnRef.Margin.All * 2)) * sRow, (btnRef.Height + (btnRef.Margin.All * 2)) * sCol);
            flpMainGrid.Controls.Clear();
            for (int i = 0; i < sRow; i++)
            {
                for (int j = 0; j < sCol; j++)
                {
                    flpMainGrid.Controls.Add(lsBtns[new Point(i, j)]);
                }
            }
        }

        private void resetGame()
        {
            clkCounter = flpMainGrid.Controls.Count - numMines;
            mineCounter.Maximum = (sRow * sCol) / 2;
            flagCounter = numMines;
            firstClk = true;
            time = 0;
            foreach (BtnMine btn in flpMainGrid.Controls)
            {
                btn.reset();
            }
        }

        private void setupMines(Point clkPoint)
        {
            List<Point> nextToBtn = adjacentBtnSet(clkPoint);

            Random rand = new Random();
            lsMines.Clear();
            int x = 0;
            Point tempMine;
            while (x < numMines)
            {
                tempMine = new Point(rand.Next(sRow), rand.Next(sCol));
                if (!nextToBtn.Contains(tempMine) && !lsMines.Contains(tempMine))
                {
                    lsMines.Add(tempMine);
                    lsBtns[tempMine].isMine = true;
                    x++;
                }
            }

            foreach (Point p in lsMines)
            {
                adjacentBtnSet(p, false);
            }

        }

        #endregion

        #region Check and Miscellaneous Fucntions
        private void gameOver(bool check = false)
        {
            timer.Enabled = false;
            if (!check)
            {
                foreach (Point p in lsMines)
                {
                    lsBtns[p].btnClickLeft();
                }
            }
            Result form = new Result(check, time);
            form.ShowDialog();
            resetGame();
        }

        private List<Point> adjacentBtnSet(Point point, bool check = true)
        {
            List<Point> nextToBtn = new List<Point>();
            Point tempPoint;
            BtnMine mine;
            for (int i = point.X - 1; i <= point.X + 1; i++)
            {
                if (i >= 0 && i < sRow)
                {
                    for (int j = point.Y - 1; j <= point.Y + 1; j++)
                    {
                        if (j >= 0 && j < sCol)
                        {
                            tempPoint = new Point(i, j);
                            mine = lsBtns[tempPoint];
                            if (check)
                            { 
                                nextToBtn.Add(tempPoint); 
                            }
                            else
                            {
                                mine.AdjacentCount += mine.isMine ? 0 : 1;
                            }
                            
                        }
                    }
                }
            }
            return nextToBtn;
        }

        private void adjacentBtnCheck(Point point, bool check = true)
        {
            Point tempPoint;
            BtnMine mine;
            for (int i = point.X - 1; i <= point.X + 1; i++)
            {
                if (i >= 0 && i < sRow)
                {
                    for (int j = point.Y - 1; j <= point.Y + 1; j++)
                    {
                        if (j >= 0 && j < sCol)
                        {
                            tempPoint = new Point(i, j);
                            mine = lsBtns[tempPoint];
                            if (check && !mine.clickState && clkCounter != 0)
                            {
                                mine.btnClickLeft();
                                clkCounter--;
                                if (mine.isEmpty)
                                {
                                    adjacentBtnCheck(tempPoint);
                                }
                                if (clkCounter == 0)
                                {
                                    gameOver(true);
                                }
                            }
                            else if (!check && !mine.flagSet && !mine.clickState && clkCounter != 0)
                            {
                                if (ClkButton(mine)) { return; }
                            }

                        }
                    }
                }
            }
        }

        private bool ClkButton(BtnMine btn)
        {
            bool temp = false;
            btn.btnClickLeft();
            clkCounter--;

            if (btn.isMine)
            {
                temp = true;
                gameOver();
            }
            else if (clkCounter == 0)
            {
                temp = true;
                gameOver(true);
            }
            else if (btn.isEmpty)
            {
                adjacentBtnCheck(lsBtns.First(a => a.Value == btn).Key);
            }
            return temp;
        }
        #endregion

        #region Control Event handlers
        private void timer_Tick(object sender, EventArgs e)
        {
            time++;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            Difficulty form = new Difficulty();
            form.ShowDialog();
            sRow = form.row;
            sCol = form.col;
            numMines = form.mines;
            if (sRow * sCol != flpMainGrid.Controls.Count)
            {
                setupGrid();
            }
            resetGame();
        }

        private void mineCounter_Leave(object sender, EventArgs e)
        {
            if (numMines != (int)mineCounter.Value)
            {
                numMines = (int)mineCounter.Value == 0 ? 1 : (int)mineCounter.Value;
                resetGame();
            }
        }

        private void tempBtn_MouseUp(object sender, MouseEventArgs e)
        {
            BtnMine btnClk = sender as BtnMine;
            if (firstClk)
            {
                timer.Enabled = true;
            }

            if (firstClk && e.Button == MouseButtons.Left)
            {
                Point tempPoint = lsBtns.First(a => a.Value == btnClk).Key;
                setupMines(tempPoint);
                firstClk = false;
            }
            switch (e.Button)
            {
                case MouseButtons.Left:
                    #region Unlicked button pressed
                    if (!btnClk.clickState)
                    {
                        if (btnClk.flagSet)
                        {
                            flagCounter++;
                            btnClk.flagSet = false;
                        }

                        ClkButton(btnClk);
                    }
                    #endregion
                    #region When already clicked Number button pressed
                    else if (!btnClk.isEmpty)
                    {
                        adjacentBtnCheck(lsBtns.First(a => a.Value == btnClk).Key, false);
                    }
                    #endregion
                    break;
                case MouseButtons.Right:
                    if (!btnClk.clickState)
                    {
                        if (!btnClk.flagSet && flagCounter == 0) { return; }
                        btnClk.btnClickRight();
                        flagCounter += btnClk.flagSet ? -1 : +1;
                    }
                    break;
                default:
                    break;
            }

        }

        #endregion
    }
}
