using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCA_00
{
    public partial class Form4 : Form
    {
      

        Form1 OriginalForm;
        public Form4(Form1 IncomingForm)
        {
            OriginalForm = IncomingForm;
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            OriginalForm.swtch = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label3.Text = " " + OriginalForm.CPUU + " %";
            label2.Text =  + OriginalForm.ARAM + " GB";

            bunifuCircleProgressbar1.Value = (int)((OriginalForm.CPUU + OriginalForm.RAMU) / 2);

            if (bunifuCircleProgressbar1.Value >= 20 && bunifuCircleProgressbar1.Value < 50)
            {
                label4.Text = "      Normal";
                bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SpringGreen;
            }

            else if (bunifuCircleProgressbar1.Value >= 50 && bunifuCircleProgressbar1.Value < 80)
            {
                label4.Text = "      Midium";
                bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.OrangeRed;
            }
            else if (bunifuCircleProgressbar1.Value >= 80)
            {
                label4.Text = "      At Risk";
                bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Crimson;
            }
            else
            {
                label4.Text = "    Excillent";
                bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Aqua;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Crimson;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Tomato;
        }


        int mX = 0, mY = 0;
        bool mDown = false;
        bool lck = false;

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            if (lck == false) mDown = true;
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mDown)
            {
                mX = MousePosition.X - 200;
                mY = MousePosition.Y - 40;
                SetDesktopLocation(mX, mY);
            }
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Opacity = (double)(0.1+ trackBar1.Value*0.1);
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lck = true;
        }

        private void topLockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void releaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = false;
            lck = false;
        }

        private void mainMenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OriginalForm.Show();
            Close();
        }

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            mDown = false;
        }
    }
}
