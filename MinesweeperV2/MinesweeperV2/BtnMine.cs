using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperV2
{
    class BtnMine : Button
    {
        private string _text;
        private int _count;
        public bool clickState;
        public bool flagSet { get; set; }
        public bool isMine { get; set; }

        public BtnMine()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseVisualStyleBackColor = false;
            this.Size = new System.Drawing.Size(25, 25);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public void btnClickLeft(){
            if (!clickState)
            {
                if (flagSet)
                {
                    flagSet = false;
                }
                if (isMine)
                {
                    this.BackColor = System.Drawing.Color.Red;
                    this.BackgroundImage = MinesweeperV2.Properties.Resources.Mine;
                }
                else
                {
                    this.BackColor = System.Drawing.SystemColors.Control;
                    this.Enabled = !isEmpty;
                    setColor();
                    this.Text = _text;
                }
                clickState = !clickState;
            }
        }
        public void btnClickRight()
        {
            flagSet = !flagSet;
            this.BackColor = flagSet ? System.Drawing.Color.Green : System.Drawing.Color.LightSteelBlue;

        }
       

        private void setColor()
        {
            switch (_text)
            {
                case "1":
                    this.ForeColor = System.Drawing.Color.MidnightBlue;
                    break;
                case "2":
                    this.ForeColor = System.Drawing.Color.Blue;
                    break;
                case "3":
                    this.ForeColor = System.Drawing.Color.Green;
                    break;
                case "4":
                    this.ForeColor = System.Drawing.Color.Orange;
                    break;
                case "5":
                    this.ForeColor = System.Drawing.Color.Red;
                    break;
                case "6":
                    this.ForeColor = System.Drawing.Color.DarkRed;
                    break;
                case "7":
                    this.ForeColor = System.Drawing.Color.DarkMagenta;
                    break;
                case "8":
                    this.ForeColor = System.Drawing.Color.Black;
                    break;
                default:
                    break;
            }
        }
        public int AdjacentCount
        {
            set
            {
                _count = value;
                _text = value > 0 ? value.ToString() : "";
            }
            get { return _count; }
        }

        public bool isEmpty
        {
            get
            {
                return !isMine && AdjacentCount == 0;
            }
        }

        public void reset()
        {
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = null;
            AdjacentCount = 0;
            this.Text = _text;
            clickState = false;
            this.Enabled = true;
            flagSet = false;
            isMine = false;
        }
        
    }
}
