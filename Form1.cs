using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace DataChewer
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void targetExeName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void confirmExe_Click(object sender, EventArgs e)
        {
            targetProcessName.Text = targetExeName.Text + ".exe";
            string targetAddressName = "";
            targetExeName.Text = targetAddressName.ToString();
            //will be used later to display address val.

        }

        private void runSniper_Click(object sender, EventArgs e)
        {
            Process[] finalTarget = Process.GetProcessesByName(targetExeName.Text);
                if(includeMemoryDump.Checked)
            {
                var myDump = new functions();
                myDump.createMemDump(targetExeName.Text);
            }
            else
            {

            }
                if(includeDataDump.Checked)
            {

            }
            else
            {

            }
                if(includeDlls.Checked)
            {

            }
            else
            {

            }
                if(includeCrashlog.Checked)
            {

            }
            else
            {

            }
                if(includeCpuUsage.Checked)
            {

            }
            else
            {
                cpuUsageVal.Text = "null";
            }
                if (includeMemoryUsage.Checked)
            {

            }
            else
            {
                memUsageVal.Text = "null";
            }
        }
    }
}
