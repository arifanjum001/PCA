using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;



namespace PCA_00
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();


           List<string> lines= File.ReadAllLines("Log_History.txt").ToList();
            foreach(string line in lines)
                { listBox1.Items.Add(line); }
            
        }

    }
}
