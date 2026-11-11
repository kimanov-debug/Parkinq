using System;
using System.Drawing;
using System.Windows.Forms;

namespace Parkinq
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TableLayoutPanel tlpParking;
        private System.Windows.Forms.Panel pnlSpot1;
        private System.Windows.Forms.Panel pnlSpot2;
        private System.Windows.Forms.Panel pnlSpot3;
        private System.Windows.Forms.Panel pnlSpot4;
        private System.Windows.Forms.Panel pnlSpot5;
        private System.Windows.Forms.Label lblSpotNum1;
        private System.Windows.Forms.Label lblSpotNum2;
        private System.Windows.Forms.Label lblSpotNum3;
        private System.Windows.Forms.Label lblSpotNum4;
        private System.Windows.Forms.Label lblSpotNum5;
        private System.Windows.Forms.Panel pnlCar;
        private System.Windows.Forms.Panel pnlLightL;
        private System.Windows.Forms.Panel pnlLightR;
        private System.Windows.Forms.Panel pnlWindowFront;
        private System.Windows.Forms.Panel pnlWindowBack;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tlpParking = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSpot1 = new System.Windows.Forms.Panel();
            this.lblSpotNum1 = new System.Windows.Forms.Label();
            this.pnlSpot2 = new System.Windows.Forms.Panel();
            this.lblSpotNum2 = new System.Windows.Forms.Label();
            this.pnlSpot3 = new System.Windows.Forms.Panel();
            this.lblSpotNum3 = new System.Windows.Forms.Label();
            this.pnlSpot4 = new System.Windows.Forms.Panel();
            this.lblSpotNum4 = new System.Windows.Forms.Label();
            this.pnlSpot5 = new System.Windows.Forms.Panel();
            this.lblSpotNum5 = new System.Windows.Forms.Label();
            this.pnlCar = new System.Windows.Forms.Panel();
            this.pnlLightL = new System.Windows.Forms.Panel();
            this.pnlLightR = new System.Windows.Forms.Panel();
            this.pnlWindowFront = new System.Windows.Forms.Panel();
            this.pnlWindowBack = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            this.pnlTop.SuspendLayout();
            this.tlpParking.SuspendLayout();
            this.pnlSpot1.SuspendLayout();
            this.pnlSpot2.SuspendLayout();
            this.pnlSpot3.SuspendLayout();
            this.pnlSpot4.SuspendLayout();
            this.pnlSpot5.SuspendLayout();
            this.pnlCar.SuspendLayout();
            this.SuspendLayout();

            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(30, 30, 34);
            this.pnlTop.Controls.Add(this.lblScore);
            this.pnlTop.Controls.Add(this.lblTime);
            this.pnlTop.Controls.Add(this.btnNewGame);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 70);
            this.pnlTop.TabIndex = 0;

            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(30, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(82, 30);
            this.lblScore.Text = "Xal: 0";

            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(200, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(155, 30);
            this.lblTime.Text = "Vaxt: 30 san";

            this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.Location = new System.Drawing.Point(800, 14);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(180, 42);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.TabStop = false;
            this.btnNewGame.Text = "Yeni oyun";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);

            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(144, 238, 144);
            this.lblMessage.Location = new System.Drawing.Point(0, 75);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1000, 40);
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Text = "";

            this.tlpParking.BackColor = System.Drawing.Color.White;
            this.tlpParking.ColumnCount = 5;
            this.tlpParking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpParking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpParking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpParking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpParking.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpParking.Controls.Add(this.pnlSpot1, 0, 0);
            this.tlpParking.Controls.Add(this.pnlSpot2, 1, 0);
            this.tlpParking.Controls.Add(this.pnlSpot3, 2, 0);
            this.tlpParking.Controls.Add(this.pnlSpot4, 3, 0);
            this.tlpParking.Controls.Add(this.pnlSpot5, 4, 0);
            this.tlpParking.Location = new System.Drawing.Point(45, 130);
            this.tlpParking.Name = "tlpParking";
            this.tlpParking.Padding = new System.Windows.Forms.Padding(5);
            this.tlpParking.RowCount = 1;
            this.tlpParking.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpParking.Size = new System.Drawing.Size(910, 300);
            this.tlpParking.TabIndex = 2;

            this.pnlSpot1.BackColor = System.Drawing.Color.FromArgb(60, 60, 66);
            this.pnlSpot1.Controls.Add(this.lblSpotNum1);
            this.pnlSpot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpot1.Margin = new System.Windows.Forms.Padding(3);
            this.pnlSpot1.Name = "pnlSpot1";

            this.pnlSpot2.BackColor = System.Drawing.Color.FromArgb(60, 60, 66);
            this.pnlSpot2.Controls.Add(this.lblSpotNum2);
            this.pnlSpot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpot2.Margin = new System.Windows.Forms.Padding(3);
            this.pnlSpot2.Name = "pnlSpot2";

            this.pnlSpot3.BackColor = System.Drawing.Color.FromArgb(60, 60, 66);
            this.pnlSpot3.Controls.Add(this.lblSpotNum3);
            this.pnlSpot3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpot3.Margin = new System.Windows.Forms.Padding(3);
            this.pnlSpot3.Name = "pnlSpot3";

            this.pnlSpot4.BackColor = System.Drawing.Color.FromArgb(60, 60, 66);
            this.pnlSpot4.Controls.Add(this.lblSpotNum4);
            this.pnlSpot4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpot4.Margin = new System.Windows.Forms.Padding(3);
            this.pnlSpot4.Name = "pnlSpot4";

            this.pnlSpot5.BackColor = System.Drawing.Color.FromArgb(60, 60, 66);
            this.pnlSpot5.Controls.Add(this.lblSpotNum5);
            this.pnlSpot5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpot5.Margin = new System.Windows.Forms.Padding(3);
            this.pnlSpot5.Name = "pnlSpot5";

            this.lblSpotNum1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSpotNum1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSpotNum1.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.lblSpotNum1.Height = 50;
            this.lblSpotNum1.Name = "lblSpotNum1";
            this.lblSpotNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSpotNum1.Text = "1";

            this.lblSpotNum2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSpotNum2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSpotNum2.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.lblSpotNum2.Height = 50;
            this.lblSpotNum2.Name = "lblSpotNum2";
            this.lblSpotNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSpotNum2.Text = "2";

            this.lblSpotNum3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSpotNum3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSpotNum3.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.lblSpotNum3.Height = 50;
            this.lblSpotNum3.Name = "lblSpotNum3";
            this.lblSpotNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSpotNum3.Text = "3";

            this.lblSpotNum4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSpotNum4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSpotNum4.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.lblSpotNum4.Height = 50;
            this.lblSpotNum4.Name = "lblSpotNum4";
            this.lblSpotNum4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSpotNum4.Text = "4";

            this.lblSpotNum5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSpotNum5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblSpotNum5.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            this.lblSpotNum5.Height = 50;
            this.lblSpotNum5.Name = "lblSpotNum5";
            this.lblSpotNum5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSpotNum5.Text = "5";

            this.pnlCar.BackColor = System.Drawing.Color.FromArgb(42, 111, 219);
            this.pnlCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCar.Controls.Add(this.pnlLightL);
            this.pnlCar.Controls.Add(this.pnlLightR);
            this.pnlCar.Controls.Add(this.pnlWindowFront);
            this.pnlCar.Controls.Add(this.pnlWindowBack);
            this.pnlCar.Location = new System.Drawing.Point(420, 460);
            this.pnlCar.Name = "pnlCar";
            this.pnlCar.Size = new System.Drawing.Size(60, 110);
            this.pnlCar.Visible = false;

            this.pnlLightL.BackColor = System.Drawing.Color.Gold;
            this.pnlLightL.Location = new System.Drawing.Point(4, 4);
            this.pnlLightL.Name = "pnlLightL";
            this.pnlLightL.Size = new System.Drawing.Size(12, 8);

            this.pnlLightR.BackColor = System.Drawing.Color.Gold;
            this.pnlLightR.Location = new System.Drawing.Point(44, 4);
            this.pnlLightR.Name = "pnlLightR";
            this.pnlLightR.Size = new System.Drawing.Size(12, 8);

            this.pnlWindowFront.BackColor = System.Drawing.Color.FromArgb(176, 216, 240);
            this.pnlWindowFront.Location = new System.Drawing.Point(7, 22);
            this.pnlWindowFront.Name = "pnlWindowFront";
            this.pnlWindowFront.Size = new System.Drawing.Size(46, 30);

            this.pnlWindowBack.BackColor = System.Drawing.Color.FromArgb(176, 216, 240);
            this.pnlWindowBack.Location = new System.Drawing.Point(7, 75);
            this.pnlWindowBack.Name = "pnlWindowBack";
            this.pnlWindowBack.Size = new System.Drawing.Size(46, 22);

            this.timer1.Interval = 1000;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(60, 60, 66);
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tlpParking);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parkinq oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tlpParking.ResumeLayout(false);
            this.pnlSpot1.ResumeLayout(false);
            this.pnlSpot2.ResumeLayout(false);
            this.pnlSpot3.ResumeLayout(false);
            this.pnlSpot4.ResumeLayout(false);
            this.pnlSpot5.ResumeLayout(false);
            this.pnlCar.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}