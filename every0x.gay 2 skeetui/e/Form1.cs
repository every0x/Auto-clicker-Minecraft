using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e
{
    public partial class Form1 : Form
    {
        private int toggle;

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "mouse_event", ExactSpelling = true, SetLastError = true)]
        private static extern bool apimouse_event(int dwFlags, int dX, int dY, int cButtons, int dwExtraInfo);

        [DebuggerNonUserCode]

        [DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr GetActiveWindow();

        private void gunaMetroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void siticoneTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void siticoneTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        private static extern bool mouse_event(int dwFlags, int dX, int dY, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        private void timer1_Tick(object sender, EventArgs e)
        {
            VBMath.Randomize();
            Random random = new Random();
            checked
            {
                int maxValue = (int)Math.Round(1000.0 / (double)this.skeetSlider1.Value);
                int minValue = (int)Math.Round(1000.0 / (double)this.skeetSlider2.Value);
                this.timer1.Interval = random.Next(minValue, maxValue);
                bool flag = Control.MouseButtons == MouseButtons.Left;
                if (flag)
                {
                    bool flag2 = !(Form1.GetActiveWindow() == base.Handle);
                    if (flag2)
                    {
                        Form1.apimouse_event(4, 0, 0, 0, 0);
                        Form1.apimouse_event(2, 0, 0, 0, 0);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/ZBMYzt7dVj");
        }

        private void skeetSlider1_Load(object sender, EventArgs e)
        {
            bool flag = this.skeetSlider1.Value > this.skeetSlider2.Value;
            if (flag)
            {
                this.skeetSlider2.Value = this.skeetSlider1.Value;
                this.label2.Text = Conversions.ToString(this.skeetSlider2.Value);
            }
            this.label1.Text = this.skeetSlider1.Value.ToString();
        }

        private void skeetSlider2_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del " + Application.ExecutablePath);
            Application.Exit();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Form1.GetAsyncKeyState(Keys.F4) < 0)
            {

                this.timer1.Start();
                this.timer2.Start();
                this.timer1.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Form1.GetAsyncKeyState(Keys.F4) < 0)
            {
                this.timer1.Stop();
                this.timer1.Start();
                this.timer2.Stop();
            }
        }
    

private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            checked
            {
                this.toggle++;
                bool flag = this.toggle == 1;
                if (flag)
                {
                    this.timer1.Start();
                    this.gunaButton1.Text = "Toggle Off";
                }
                else
                {
                    this.timer1.Stop();
                    this.toggle = 0;
                    this.gunaButton1.Text = "Toggle On";
                }
            }
        }
    }
}

