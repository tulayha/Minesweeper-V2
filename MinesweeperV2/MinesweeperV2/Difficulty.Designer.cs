namespace MinesweeperV2
{
    partial class Difficulty
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
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnExpert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.SpringGreen;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(77, 47);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(125, 48);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMed
            // 
            this.btnMed.BackColor = System.Drawing.Color.Yellow;
            this.btnMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMed.Location = new System.Drawing.Point(77, 101);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(125, 48);
            this.btnMed.TabIndex = 0;
            this.btnMed.Text = "Medium";
            this.btnMed.UseVisualStyleBackColor = false;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnExpert
            // 
            this.btnExpert.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExpert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpert.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExpert.Location = new System.Drawing.Point(77, 155);
            this.btnExpert.Name = "btnExpert";
            this.btnExpert.Size = new System.Drawing.Size(125, 48);
            this.btnExpert.TabIndex = 0;
            this.btnExpert.Text = "Expert";
            this.btnExpert.UseVisualStyleBackColor = false;
            this.btnExpert.Click += new System.EventHandler(this.btnExpert_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnEasy);
            this.panel1.Controls.Add(this.btnExpert);
            this.panel1.Controls.Add(this.btnMed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 251);
            this.panel1.TabIndex = 1;
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Difficulty";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Difficulty";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnExpert;
        private System.Windows.Forms.Panel panel1;
    }
}