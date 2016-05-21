using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BreakReminder
{
    public partial class Form_Default : Form
    {

        private bool active = false;
        private bool onBreak = true;
        private bool shouldMinimizeAll = true;
        private bool hideInTaskTray = false;
        Timer timer = new Timer();
        DateTime timeLeft;

        public bool TimerActive
        {
            set
            {
                active = value;
                if(active == true)
                {
                    StartWork();
                }

                if(active == false)
                {
                    Lbl_State.Text = "Timer Deactivated";
                    Lbl_TimeRemaining.Text = "N/A";
                    Btn_StartStop.Text = "Start";

                }
            }

            get
            {
                return active;
            }
        }

        public void StartWork()
        {
            Lbl_State.Text = "Working";
            Btn_StartStop.Text = "Stop";
            onBreak = false;
            String delayS = TB_DelayLength.Text;
            double delay = 9;
            Double.TryParse(delayS, out delay);
            timeLeft = DateTime.Now.AddMinutes(delay);
        }

        public void StartBreak()
        {
            MinimizeAll();
            onBreak = true;
            Lbl_State.Text = "Break";
            String breakLengthS = Tb_BreakDuration.Text;
            double breakLength = 9;
            Double.TryParse(breakLengthS, out breakLength);
            timeLeft = DateTime.Now.AddMinutes(breakLength);
        }

        public Form_Default()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(TimerTick);

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (active)
            {
                TimeSpan span = (timeLeft - DateTime.Now);
                Lbl_TimeRemaining.Text = span.Minutes + ":" + span.Seconds;

                if(span.TotalSeconds < 1)
                {
                    if (onBreak == false)
                        StartBreak();
                    else
                        StartWork();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TimerActive = true;
        }

        private void TB_DelayLength_TextChanged(object sender, EventArgs e)
        {
            TimerActive = false;
        }

        private void Tb_BreakDuration_TextChanged(object sender, EventArgs e)
        {
            TimerActive = false;
        }

        private void Btn_StartStop_Click(object sender, EventArgs e)
        {
            TimerActive = !TimerActive;
        }

        private void MinimizeAll()
        {
            Type typeShell = Type.GetTypeFromProgID("Shell.Application");
            object objShell = Activator.CreateInstance(typeShell);
            typeShell.InvokeMember("MinimizeAll", System.Reflection.BindingFlags.InvokeMethod, null, objShell, null);
        }

        private void CB_Minimize_CheckedChanged(object sender, EventArgs e)
        {
            shouldMinimizeAll = CB_Minimize.Checked;
        }

        private void CB_TaskTray_CheckedChanged(object sender, EventArgs e)
        {
            //hideInTaskTray = CB_TaskTray.Checked;
            if(hideInTaskTray == true)
            {
                base.WindowState = FormWindowState.Minimized;
            }
        }

        private void HideNow()
        {

        }
    }
}
