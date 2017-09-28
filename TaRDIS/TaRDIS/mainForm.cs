using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;
using TaRDIS.Properties;


namespace TaRDIS
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            #region tray icon
            trayIcon = new NotifyIcon();
            trayIcon.Icon = TaRDIS.Properties.Resources.favicon;
            MenuItem quitSelection = new MenuItem("Close");
            MenuItem focusTaRDIS = new MenuItem("Bring to front");
            ContextMenu cntxMenu = new ContextMenu();
            cntxMenu.MenuItems.Add(focusTaRDIS);
            cntxMenu.MenuItems.Add(quitSelection);
            trayIcon.ContextMenu = cntxMenu;
            trayIcon.Text = "TaRDIS";
            trayIcon.DoubleClick += TrayIcon_DoubleClick;
            trayIcon.Visible = true;

            quitSelection.Click += QuitSelection_Click;
            focusTaRDIS.Click += TrayIcon_DoubleClick;
            #endregion
            GetNIC();
            totalRAM = Math.Round((double)GetRAM() / (1024 * 1024), 0);
            #region Init progress bar
            progBar.Location = new Point(175, 75);
            progBar.Size = new Size(147, 23);
            progBar.Maximum = (int)totalRAM;
            progBar.DisplayStyle = ProgressBarDisplayText.CustomText;
            progBar.Visible = true;
            this.Controls.Add(progBar);
            progBar.BringToFront();
            #endregion
            ShowInTaskbar = false;
            osLabel.Text = getOSInfo();
            //menuItem_1s.Checked = true;
            refreshLabel.Text = "Refresh rate: " + (Settings.Default.refreshRate/1000).ToString() +"s";
            timer1.Interval = Settings.Default.refreshRate;
            timer1.Enabled = true;
        }

        graphForm f1 = new graphForm();
        bool freqDivider = false;
        bool stress = true;
        customProgressBar progBar = new customProgressBar();
        List<Thread> threadList = new List<Thread>();
        NotifyIcon trayIcon;
        #region PC specs and sensors
        double totalRAM;
        ohmRead sensor = new ohmRead(true, false, true);
        #endregion
        #region PerfCounters
        PerformanceCounter hddIdleCnt = new PerformanceCounter("PhysicalDisk", "% Idle Time", "_Total");
        PerformanceCounter hddReadCnt = new PerformanceCounter("PhysicalDisk","Disk Read Bytes/sec","_Total");
        PerformanceCounter hddWriteCnt = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");
        PerformanceCounter cpuCnt = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter dsCnt = new PerformanceCounter("Network Interface", "Bytes Received/sec");
        PerformanceCounter usCnt = new PerformanceCounter("Network Interface", "Bytes Sent/sec");
        PerformanceCounter bandwidthCnt = new PerformanceCounter("Network Interface", "Current Bandwidth");
        PerformanceCounter ramCnt = new PerformanceCounter("Memory", "Available MBytes");
        #endregion


        private void initStressThreads()
        {
            for (int i=0;i< new PerformanceCounterCategory("Processor").GetInstanceNames().Count() - 1;i++)
                threadList.Add(new Thread(KeepBusy));
        }
        static void KeepBusy()
        {
            while(true)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            float currentAvailRam = ramCnt.NextValue();
            var cpu = (int)Math.Round(cpuCnt.NextValue(), 0);
            var ram = (int)Math.Round(((totalRAM - currentAvailRam) * 100) / totalRAM, 0);
            cpuPercent.Text = Convert.ToString(cpu) + "%";
            dsBox.Text = Math.Round(dsCnt.NextValue()*8/(1024*1024),2).ToString()+" Mbps";
            usBox.Text = Math.Round(usCnt.NextValue() * 8 / (1024 * 1024), 2).ToString() + " Mbps";
            bandwidthBox.Text = Math.Round(bandwidthCnt.NextValue()/(1024*1024),2).ToString()+" Mbps";
            ramBox.Text = currentAvailRam.ToString() + " MB";
            hddWriteBox.Text=Math.Round(hddWriteCnt.NextValue() / (1024 * 1024), 2).ToString() + " MB/sec";
            hddReadBox.Text = Math.Round(hddReadCnt.NextValue() / (1024 * 1024), 2).ToString() + " MB/sec";
            var activeTime = (int)Math.Round(100-hddIdleCnt.NextValue(),0);
            hddActiveBox.Text = activeTime.ToString() + "%";
            if (activeTime <= 5) hddPbx.Image = Resources.hdd_idle;
            else if (activeTime > 5 && activeTime < 80) hddPbx.Image = Resources.hdd_normal;
            else hddPbx.Image = Resources.hdd_high;
            progBar.Value = (int)(totalRAM - currentAvailRam);
            progBar.CustomText = ram.ToString();

            if (!freqDivider)
            {
                var processes = Process.GetProcesses();
                var procs = processes.Where(x => x.SessionId == Process.GetCurrentProcess().SessionId)
                   .OrderByDescending(x => x.PrivateMemorySize64)
                   .ToList();

                ramList.Items.Clear();
                for (int i = 0; i < 3; i++)
                    ramList.Items.Add(new ListViewItem(new string[] { procs[i].ProcessName, (Math.Round((double)procs[i].PrivateMemorySize64 / (1024 * 1024), 0)).ToString() + " MB" }));
            }
            freqDivider = !freqDivider;
            cpuTempBox.Text = sensor.getCPUtemp();
            
            if(Application.OpenForms["graphForm"]!=null)
            {
                f1.addPoint(cpu,ram,activeTime);
            }
            sw.Stop();
            grabTime.Text = "Execute time: " +sw.ElapsedMilliseconds.ToString()+" ms";
        }

        void GetNIC()
        {
            PerformanceCounterCategory category = new PerformanceCounterCategory("Network Interface");
            String[] instancename = category.GetInstanceNames();
            foreach (String name in instancename)
                comboBox1.Items.Add(name);
            comboBox1.SelectedIndex = Settings.Default.selectedNIC;
            dsCnt.InstanceName=comboBox1.SelectedItem.ToString();
            usCnt.InstanceName = comboBox1.SelectedItem.ToString();
            bandwidthCnt.InstanceName = comboBox1.SelectedItem.ToString();
        }

        #region Get PC info
        static ulong GetRAM()
        {
            return new ComputerInfo().TotalPhysicalMemory;
        }

        static string getOSInfo()
        {
            return new ComputerInfo().OSFullName + " " + new ComputerInfo().OSVersion;
        }
        #endregion
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dsCnt.InstanceName = comboBox1.SelectedItem.ToString();
            usCnt.InstanceName = comboBox1.SelectedItem.ToString();
            bandwidthCnt.InstanceName = comboBox1.SelectedItem.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                this.TopMost = true;
            else
                this.TopMost = false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default.WindowLocation != null)
                this.Location = Settings.Default.WindowLocation;
            checkBox1.Checked = Settings.Default.AlwaysOnTop;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Dispose objects
            trayIcon.Dispose();
            cpuCnt.Dispose();
            ramCnt.Dispose();
            dsCnt.Dispose();
            usCnt.Dispose();
            bandwidthCnt.Dispose();
            #endregion
            if (threadList.Any())
            {
                foreach (Thread t in threadList)
                    t.Abort();
                threadList.Clear();
            }

            Settings.Default.selectedNIC = comboBox1.SelectedIndex;
            Settings.Default.WindowLocation = this.Location;
            Settings.Default.AlwaysOnTop = checkBox1.Checked;
            Settings.Default.Save();
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = groupBox3.CreateGraphics();
            //g.Clear(SystemColors.Control);
            float max=142f;
            Pen pen = new Pen(Color.Black, 0.25f);
            using (Font f = new Font(FontFamily.GenericSansSerif, 7))
            {
                SizeF len;
                for (float i = 0; i <= max; i += max / 5)
                {
                    int x=11 +(int)Math.Round(i, 0);
                    string txt = ((int)(Math.Ceiling(i * 100 / max))).ToString()+"%";
                    g.DrawLine(pen, new Point(x, 69), new Point(x, 72));
                    len = g.MeasureString(txt, f);
                    g.DrawString(txt, f, Brushes.Black, new Point(Convert.ToInt32(x-len.Width/2),73));
                }
            }
        }
        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            Activate();   
        }
        private void QuitSelection_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in ((sender as ToolStripMenuItem).OwnerItem as ToolStripMenuItem).DropDownItems)
            {
                item.Checked = (item == (sender as ToolStripMenuItem));
                if(item.Checked)
                {
                    var intervalTick = 1;
                    switch(item.Text)
                    {
                        case "2s":
                            intervalTick = 2000;
                            break;
                        case "5s":
                            intervalTick = 5000;
                            break;
                        case "10s":
                            intervalTick = 10000;
                            break;
                        case "30s":
                            intervalTick = 30000;
                            break;
                        case "1m":
                            intervalTick = 60000;
                            break;
                        default:
                            intervalTick = 1000;
                            break;
                    }
                    timer1.Interval = intervalTick;
                    Settings.Default.refreshRate = intervalTick;
                    refreshLabel.Text = "Refresh rate: " + (intervalTick / 1000).ToString() + "s";
                }
            }
        }

        private void stressBtn_Click(object sender, EventArgs e)
        {
            if(stress)
            {
                if (MessageBox.Show("This will put the CPU load to 100%.\nTo stop the stress test, press the CPU stress test button again.\nAre you sure you want to continue", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    initStressThreads();
                    stressBtn.BackColor = SystemColors.ActiveCaption;
                    foreach (Thread t in threadList)
                        t.Start();
                    stress = !stress;
                }
            }
            else
            {
                foreach (Thread t in threadList)
                    t.Abort();
                threadList.Clear();
                stressBtn.BackColor = SystemColors.Control;
                stress = !stress;
            }
        }

        private void graphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.Show();
        }
    }
}
