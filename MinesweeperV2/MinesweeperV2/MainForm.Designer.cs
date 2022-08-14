namespace MinesweeperV2
{
    partial class Minesweeper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flpMainGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.mineCounter = new System.Windows.Forms.NumericUpDown();
            this.pcTimer = new System.Windows.Forms.PictureBox();
            this.pcMine = new System.Windows.Forms.PictureBox();
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tTipMine = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mineCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMine)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMainGrid
            // 
            this.flpMainGrid.Location = new System.Drawing.Point(10, 78);
            this.flpMainGrid.Margin = new System.Windows.Forms.Padding(10);
            this.flpMainGrid.Name = "flpMainGrid";
            this.flpMainGrid.Size = new System.Drawing.Size(341, 231);
            this.flpMainGrid.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.mineCounter);
            this.panel1.Controls.Add(this.pcTimer);
            this.panel1.Controls.Add(this.pcMine);
            this.panel1.Controls.Add(this.btnLevel);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 65);
            this.panel1.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTime.Location = new System.Drawing.Point(310, 24);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(48, 27);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "000";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mineCounter
            // 
            this.mineCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mineCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mineCounter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mineCounter.Location = new System.Drawing.Point(215, 24);
            this.mineCounter.Name = "mineCounter";
            this.mineCounter.Size = new System.Drawing.Size(53, 25);
            this.mineCounter.TabIndex = 2;
            this.mineCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pcTimer
            // 
            this.pcTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcTimer.BackgroundImage = global::MinesweeperV2.Properties.Resources.timer_icon;
            this.pcTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcTimer.Location = new System.Drawing.Point(274, 22);
            this.pcTimer.Name = "pcTimer";
            this.pcTimer.Size = new System.Drawing.Size(30, 30);
            this.pcTimer.TabIndex = 1;
            this.pcTimer.TabStop = false;
            // 
            // pcMine
            // 
            this.pcMine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcMine.BackgroundImage = global::MinesweeperV2.Properties.Resources.Mine;
            this.pcMine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcMine.Location = new System.Drawing.Point(182, 22);
            this.pcMine.Name = "pcMine";
            this.pcMine.Size = new System.Drawing.Size(30, 30);
            this.pcMine.TabIndex = 1;
            this.pcMine.TabStop = false;
            // 
            // btnLevel
            // 
            this.btnLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel.Location = new System.Drawing.Point(84, 23);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(70, 28);
            this.btnLevel.TabIndex = 0;
            this.btnLevel.Text = "Level";
            this.btnLevel.UseVisualStyleBackColor = true;
            this.btnLevel.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(10, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(68, 29);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tTipMine
            // 
            this.tTipMine.IsBalloon = true;
            // 
            // Minesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(370, 328);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpMainGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Minesweeper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mineCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMainGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pcMine;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.NumericUpDown mineCounter;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox pcTimer;
        private System.Windows.Forms.ToolTip tTipMine;





    }
}

