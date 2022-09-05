using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Diagnostics;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Windows.Media;
using System.Threading.Tasks;
using Microsoft.Win32; //for regestry
using System.IO; //text write 

namespace PCA_00
{
    public partial class Form1 : Form
    {



        SpeechSynthesizer synth = new SpeechSynthesizer { Volume = 100, Rate = 0 };
        PerformanceCounter perfCPUcounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfMEMcounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfCMEMCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

        public void VoiceSF(string Txt) //female voiced synth . . . .
        {
            synth.SelectVoiceByHints(VoiceGender.Female);
            synth.Speak(Txt);
        }
        public void VoiceSM(string Txt) //male voiced synth  . . . . 
        {

            synth.SelectVoiceByHints(VoiceGender.Male);
            synth.Speak(Txt);

        }

        public Form1()
        {

            InitializeComponent();
            Application.Run(new Form3());
        }

        #region chartControls


        public class MeasureModel
        {
            public System.DateTime DateTime { get; set; }
            public double Value { get; set; }
        }
        public void chartLoad()
        {



            cartesianChart1.Hoverable = false;
            cartesianChart1.DataTooltip = null;
            cartesianChart1.DisableAnimations = true;

            var mapper = Mappers.Xy<MeasureModel>()
                        .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                        .Y(model => model.Value);           //use the value property as Y

            //lets save the mapper globally.
            Charting.For<MeasureModel>(mapper);

            CPU_Value = new ChartValues<MeasureModel>();
            RAM_Values = new ChartValues<MeasureModel>();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                  
                    
                    // PointForeground = Brushes.Black,
                    Stroke = Brushes.MediumSpringGreen,
                   // PointForeground =Brushes.Transparent,
                    Values = CPU_Value,
                    PointGeometrySize = 18,
                    StrokeThickness = 5
                },

                new LineSeries
                {
                     Stroke = Brushes.Crimson,
                   // PointForeground =Brushes.Transparent,
                    Values = RAM_Values,
                    PointGeometrySize = 18,
                    Fill = Brushes.Transparent,
                    StrokeThickness = 5
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new DateTime((long)value).ToLongTimeString(),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            SetAxisLimits(System.DateTime.Now);

        }

        public ChartValues<MeasureModel> CPU_Value { get; set; }
        public ChartValues<MeasureModel> RAM_Values { get; set; }
        private void SetAxisLimits(System.DateTime now)
        {
            cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(0).Ticks;
            cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks;
        }


        #endregion


        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you really want to close P.C.A ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            { Close(); }
        }

        bool x = false;
        private void panel5_Click(object sender, EventArgs e)
        {


            Hide();

            if (x == false)
            {
                notifyIcon1.ShowBalloonTip(1000, "P.C.A is running in background ! ", "You can re open P.C.A by right clicking the hidden icon", ToolTipIcon.None);

                //  synth.SelectVoiceByHints(VoiceGender.Male);

                {
                    var t1 = Task.Factory.StartNew(() => VoiceSM(" P C A is running in background. You can re open P C A by right clicking on the hidden icon"));
                }
                x = true;
            }

        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            
            if (bunifuSlider1.Value < 5) label1.Text = "Off";
            else
            label1.Text = "" + bunifuSlider1.Value;
                if (bunifuSlider1.Value > 60)
                bunifuSlider1.IndicatorColor = System.Drawing.Color.Crimson;
            else
                bunifuSlider1.IndicatorColor = System.Drawing.Color.SeaGreen;
            //  bunifuCircleProgressbar1.Value = bunifuSlider1.Value;
        }

        private void bunifuSlider2_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "" + (double)((bunifuSlider2.Value + 1) * .5);

            timer2.Interval = ((bunifuSlider2.Value + 1) * 500);

            if (bunifuSlider2.Value > 1)
                bunifuSlider2.IndicatorColor = System.Drawing.Color.Crimson;
            else
                bunifuSlider2.IndicatorColor = System.Drawing.Color.SeaGreen;
            //  bunifuCircleProgressbar2.Value = bunifuSlider2.Value;

        }

        private void bunifuSlider3_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = "" + (bunifuSlider3.Value + 20);
            if (bunifuSlider3.Value > 49)
                bunifuSlider3.IndicatorColor = System.Drawing.Color.Crimson;
            else
                bunifuSlider3.IndicatorColor = System.Drawing.Color.SeaGreen;
            // bunifuCircleProgressbar5.Value = bunifuSlider3.Value;
        }



        private void bunifuSlider4_ValueChanged_1(object sender, EventArgs e)
        {
            label4.Text = "" + (bunifuSlider4.Value + 20);
            if (bunifuSlider4.Value > 49)
                bunifuSlider4.IndicatorColor = System.Drawing.Color.Crimson;
            else
                bunifuSlider4.IndicatorColor = System.Drawing.Color.SeaGreen;
        }



        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();

        }

        #region form designs

        int mX = 0, mY = 0;
        bool mDown;
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
            panel1.Hide();
            panel2.Show();
            synth.Dispose();

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Hide();
            panel1.Show();
            synth = new SpeechSynthesizer { Volume = 100, Rate = 0 };
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            mDown = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mDown)
            {
                mX = MousePosition.X - 200;
                mY = MousePosition.Y - 40;
                SetDesktopLocation(mX, mY);
            }

        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.Height = 50;
            panel4.Width = 50;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.Height = 45;
            panel4.Width = 45;
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.Height = 50;
            panel5.Width = 50;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.Height = 45;
            panel5.Width = 45;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mDown = false;
        }
        #endregion


        public int CPUU = 0;
        public int RAMU;
        public double ARAM;
        int CWC = 0, RWC = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            CPUU = (int)perfCPUcounter.NextValue();
            RAMU = (int)perfCMEMCounter.NextValue();
            ARAM = Math.Round((double)perfMEMcounter.NextValue() / 1024, 2);

            if (CPUU > (20 + bunifuSlider3.Value)) ++CWC;
            else CWC = 0;

            if ((RAMU) >= (20 + bunifuSlider4.Value)) ++RWC; // RAM warning condition
            else RWC = 0;
            // frame work 4 er niche chart kaj kore na!!



            if (CWC == 3)
            {
                notifyIcon1.ShowBalloonTip(1000, "CPU warning !", "CPU current usage is :  " + CPUU, ToolTipIcon.Warning);
                {
                    var t1 = Task.Factory.StartNew(() => VoiceSF(CPUU + "% of CPU usage")).ContinueWith((df) => RWC = 0);
                }
                listBox1.Items.Add("CPU Usage: " + CPUU + " %" + " in [ " + DateTime.Now.ToString() + " ]");  
            }

            if (RWC == 3)
            {
                notifyIcon1.ShowBalloonTip(1000, "Available RAM warning !", "Current available RAM is :  " + ARAM, ToolTipIcon.Warning);
                {
                    var t1 = Task.Factory.StartNew(() => VoiceSF("only" + ARAM + "GB ram available")).ContinueWith((df) => RWC = 0);
                }
                listBox1.Items.Add("Avail RAM: " + ARAM + " GB" + " in [ " + DateTime.Now.ToString() + " ]");
            }


            if (Visible)

            {

                bunifuCircleProgressbar1.Value = CPUU;
                bunifuCircleProgressbar2.Value = RAMU;
                bunifuCircleProgressbar5.Value = ((CPUU + RAMU) / 2);


                var now = DateTime.Now;

                if (RAM_Values.Count > 16) RAM_Values.RemoveAt(0);
                if (CPU_Value.Count > 16) CPU_Value.RemoveAt(0);

                CPU_Value.Add(new MeasureModel { DateTime = now, Value = CPUU });
                RAM_Values.Add(new MeasureModel { DateTime = now, Value = RAMU });

                SetAxisLimits(now);

                cartesianChart1.AxisY[0].MinValue = 0;
                cartesianChart1.AxisY[0].MaxValue = 100;
            }
            else
            { }

        }


        int Sec = 0, Min = 0, Hou = 0;
        int tc = 0;
        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.Hide();
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel7.Show();

        }
        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.Height += 6;
            panel6.Width += 6;

        }
        private void panel6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox1.Show();
            panel8.Show();
            label8.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
            panel8.Hide();
            label8.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();


            int i;


            StreamWriter objWriter = new StreamWriter("Log_History.txt", true); //  text writer er function
           
            objWriter.WriteLine();
            objWriter.WriteLine("App Start");
            for (i = 0; i < listBox1.Items.Count; i++)
            {
                objWriter.WriteLine(listBox1.Items[i]);
            }
            objWriter.WriteLine();
            objWriter.WriteLine("Total time ellipsed :" + Hou_Min.Text);
            objWriter.WriteLine("App Closed.");
            objWriter.Close();


        }

        public bool swtch;

      

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                // "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"

                  RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                  reg.SetValue("P.C.A StrtUp", Application.ExecutablePath.ToString());
                MessageBox.Show("P.C.A is successfully saved in Windows Startup Application.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                  RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                  reg.SetValue("P.C.A StrtUp", Application.ExecutablePath.ToString() + "_"); // path er sathe akta '_' add korte hoi . . .
                MessageBox.Show("P.C.A is removed from Windows Startup Application.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\system32\Taskmgr.exe");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox2.Checked==true)  cartesianChart1.DisableAnimations = false;

           else cartesianChart1.DisableAnimations = true;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // Process.Start("Log_History.txt");
            Form5 a = new Form5();
            a.Show();

        }

        private void panel3_Click(object sender, EventArgs e) //gadget show er jonne . . .
        {
            if (swtch == false)
            {
                swtch = true;
                Form4 gad = new Form4(this);
                gad.Show();
                Hide();
            }
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.Height -= 6;
            panel6.Width -= 6;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartLoad();

            timer2.Interval = ((bunifuSlider2.Value + 1) * 500);
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            Sec++;
            if (Sec == 60) { Min++; ++tc; Sec = 0; }
            if (Min == 60) { Hou++; Min = 0; }
            Hou_Min.Text = ("" + Hou + ":" + Min + ":" + Sec);

        if (bunifuSlider1.Value == tc && bunifuSlider1.Value>=5) 
  
            {
                notifyIcon1.ShowBalloonTip(1000, "Time Warning! ", "time spent : " + Hou + " : " + Min + " Min.", ToolTipIcon.Info);
                tc = 0;
            }

        }
    }
}