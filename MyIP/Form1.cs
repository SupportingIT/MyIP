using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;

namespace MyIP
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer; 
        string localip_address = "Unknown";
        string localip_name = "Unknown";
        string publicip_address = "";
        string publicip_name = System.Net.Dns.GetHostName();
        public Form1()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MyIP is a tiny application by Patrick Lambert <dendory@gmail.com>\nIt is provided for free with no warranty. Use at your own risks!\n\nPublic IP information is fetched from dyndns.org", "About");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                NetworkInterface ni = NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault();
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            localip_name = ni.Name;
                            localip_address = ip.Address.ToString();
                            localip.Text = localip_address;
                        }
                    }
                }
            }
            catch
            {
                localip_address = "Unknown";
                localip.Text = "Unknown";
            }
            timer = new Timer();
            timer.Interval = 1000;
            this.timer.Tick += new EventHandler(button2_Click);
            timer.Start();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string details = "";
            try
            {
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                    {
                        details += ni.Name + "\n";
                        foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                details += "- IP: " + ip.Address.ToString() + "\n";
                            }
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                            {
                                details += "- IPv6: " + ip.Address.ToString() + "\n";
                            }
                        }
                        foreach (GatewayIPAddressInformation gw in ni.GetIPProperties().GatewayAddresses)
                        {
                            if (gw.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                details += "- Gateway: " + gw.Address.ToString() + "\n";
                            }
                        }
                        details += "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                details += "An error occured: " + ex.Message;
            }
            MessageBox.Show(details, "All interfaces");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            localip.Text = localip_name;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            localip.Text = localip_address;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            publicip.Text = publicip_name;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            publicip.Text = publicip_address;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                timer.Stop();
                publicip.Text = "Refreshing...";
                Application.DoEvents();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start(); 
                TcpClient client = new TcpClient("checkip.dyndns.org", 80);
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());
                sr.BaseStream.ReadTimeout = 2000;
                sw.WriteLine("GET / HTTP/1.0\n\n");
                sw.Flush();
                string data = sr.ReadLine();
                while (data != null)
                {
                    publicip_address += data;
                    data = sr.ReadLine();
                    if (stopwatch.ElapsedMilliseconds > 5000) break;
                }
                stopwatch.Stop();
                int first = publicip_address.IndexOf("Address: ") + 9;
                int last = publicip_address.LastIndexOf("");
                publicip_address = publicip_address.Substring(first, last - first);
                publicip_address = publicip_address.Substring(0, publicip_address.IndexOf("<"));
                publicip.Text = publicip_address;
            }
            catch(Exception ex)
            {
                if (ex.Message == "No such host is known")
                {
                    publicip_address = "No Internet connection.";
                    publicip.Text = "No Internet connection.";
                }
                else
                {
                    publicip_address = "An error occurred. Try refresh.";
                    publicip.Text = "An error occurred. Try refresh.";
                }
            }
        }
    }
}
