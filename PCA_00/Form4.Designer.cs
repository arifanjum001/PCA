namespace PCA_00
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(479, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(41)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(108, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "-- GB";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseUp);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(41)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.label3.Location = new System.Drawing.Point(108, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "-- %";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.label3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseUp);
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = true;
            this.bunifuCircleProgressbar1.LineProgressThickness = 19;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(298, 130);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.LightGray;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Aqua;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(90, 90);
            this.bunifuCircleProgressbar1.TabIndex = 4;
            this.bunifuCircleProgressbar1.Value = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(41)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(176, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "..............";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.label4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Maroon;
            this.trackBar1.Location = new System.Drawing.Point(25, -15);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(281, 56);
            this.trackBar1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.trackBar1, "Opacity");
            this.trackBar1.Value = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockToolStripMenuItem,
            this.topLockToolStripMenuItem,
            this.releaseToolStripMenuItem,
            this.mainMenueToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 92);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.lockToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // topLockToolStripMenuItem
            // 
            this.topLockToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.topLockToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLockToolStripMenuItem.Name = "topLockToolStripMenuItem";
            this.topLockToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.topLockToolStripMenuItem.Text = "On Top";
            this.topLockToolStripMenuItem.Click += new System.EventHandler(this.topLockToolStripMenuItem_Click);
            // 
            // releaseToolStripMenuItem
            // 
            this.releaseToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.releaseToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            this.releaseToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.releaseToolStripMenuItem.Text = "Release";
            this.releaseToolStripMenuItem.Click += new System.EventHandler(this.releaseToolStripMenuItem_Click);
            // 
            // mainMenueToolStripMenuItem
            // 
            this.mainMenueToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.mainMenueToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenueToolStripMenuItem.Name = "mainMenueToolStripMenuItem";
            this.mainMenueToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.mainMenueToolStripMenuItem.Text = "Main Menu";
            this.mainMenueToolStripMenuItem.Click += new System.EventHandler(this.mainMenueToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 2000;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(511, 288);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form4";
            this.toolTip1.SetToolTip(this, " Right Click to see the Options");
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topLockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenueToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}