using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Config
{
    public partial class Form1 : Form
    {
        bool activated = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripDropDownButton1_Click(object sender, EventArgs e)
        {
        }

        private void Save_and_exit_Click(object sender, EventArgs e)
        {
            IP_Config.Properties.Settings.Default.IP = tbIP.Text;
            IP_Config.Properties.Settings.Default.Subnet = tbSubnet.Text;
            IP_Config.Properties.Settings.Default.Gateway = tbGateway.Text;
            IP_Config.Properties.Settings.Default.DNS = tbDNS.Text;
            IP_Config.Properties.Settings.Default.Interfacename = tbInterfaceName.Text;

            IP_Config.Properties.Settings.Default.Save();
            panel1.Hide();
            btnActivateFTP.Enabled = true;
            btnActivateNormal.Enabled = true;
           
        }

        private void ProfileSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Show();
            btnActivateFTP.Enabled = false;
            btnActivateNormal.Enabled = false;
        }

        private void BtnActivateFTP_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface ip set address name=\"" + tbInterfaceName.Text  + "\" static " + tbIP.Text + " " + tbSubnet.Text + " " +  tbGateway.Text);
            p.StartInfo = psi;
            p.StartInfo.Verb = "runas";
            p.StartInfo.CreateNoWindow = false;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            p.WaitForExit();

            if(p.ExitCode == 0)
            {
                Process dns = new Process();
                ProcessStartInfo dns1 = new ProcessStartInfo("netsh", "interface ipv4 set dnsservers name=\"" + tbInterfaceName.Text + "\"  source=static address=" + tbDNS.Text + " validate=no");
                dns.StartInfo = dns1;
                dns.StartInfo.Verb = "runas";
                dns.StartInfo.CreateNoWindow = false;
                dns.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                dns.Start();
                dns.WaitForExit();
                
                if(dns.ExitCode == 0)
                {
                    MessageBox.Show("Success!", "Network Config");

                    btnActivateFTP.Enabled = false;
                    btnActivateFTP.Text = "Activated PS3 FTP Profile";
                    btnActivateNormal.Text = "Activate Normal Profile";

                    btnActivateNormal.Enabled = true;
                    //IP_Config.Properties.Settings.Default.ActivateFTP = true;
                }
                else
                {
                    MessageBox.Show("An error occured while setting up DNS Server", "Network Config");
                    return;
                }

            }
            else
            {
                MessageBox.Show("An error occured while setting up network", "Network Config");
                return;
            }


        }

        private void BtnActivateNormal_Click(object sender, EventArgs e)
        {

            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", "interface ip set address \"" + tbInterfaceName.Text + "\" dhcp");
            p.StartInfo = psi;
            p.StartInfo.Verb = "runas";
            p.StartInfo.CreateNoWindow = false;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            p.WaitForExit();

            if (p.ExitCode == 0)
            {

                Process clearDNS = new Process();
                ProcessStartInfo dns = new ProcessStartInfo("netsh", "interface ip set dns \"" + tbInterfaceName.Text + "\" dhcp");
                clearDNS.StartInfo = dns;
                clearDNS.StartInfo.Verb = "runas";
                clearDNS.StartInfo.CreateNoWindow = false;
                clearDNS.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                clearDNS.Start();
                clearDNS.WaitForExit();

                if (p.ExitCode == 0)
                {
                    MessageBox.Show("Success!", "Network Config");
                    btnActivateFTP.Text = "Activate PS3 FTP Profile";
                    btnActivateNormal.Text = "Activated Normal Profile";
                    btnActivateFTP.Enabled = true;
                    btnActivateNormal.Enabled = false;

                    //IP_Config.Properties.Settings.Default.ActivateFTP = false;
                }
                else
                {
                    MessageBox.Show("An error occured while clearing DNS Server", "Network Config");

                }
            }
            else
            {
                MessageBox.Show("An error occured while changing network to DHCP", "Network Config");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(IP_Config.Properties.Settings.Default.ActivateFTP.ToString());
            //if (IP_Config.Properties.Settings.Default.ActivateFTP = true)
            //{
            //   
            //    btnActivateFTP.Enabled = false;
            //    btnActivateNormal.Enabled = true;
            //}
            //else if ((IP_Config.Properties.Settings.Default.ActivateFTP = false))
            //{
            //    btnActivateFTP.Enabled = true;
            //    btnActivateNormal.Enabled = false;
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //IP_Config.Properties.Settings.Default.Save();

        }

        private void ResetSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //IP_Config.Properties.Settings.Default.Reset();
            //btnActivateFTP.Enabled = true;
            //btnActivateNormal.Enabled = true;
        }
    }
}
