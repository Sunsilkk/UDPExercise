using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace UDP_Client
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            udpClient.Connect(txtInput.Text, 8081);
            Byte[] sendBytes = Encoding.UTF8.GetBytes(txtInput1.Text);
            udpClient.Send(sendBytes, sendBytes.Length);

        }
    }
}
