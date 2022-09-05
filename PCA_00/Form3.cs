using System;
using System.Windows.Forms;

namespace PCA_00
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TopMost=true;
            bunifuProgressBar1.Value += 2;
            if (bunifuProgressBar1.Value == 100)
                Close();
        }

        private void Form3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
