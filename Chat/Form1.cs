using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Chat
{
    public partial class Form1 : Form
    {
        public TcpClient tcpclient;
        TcpListener tcplistener;
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
        }

        private void ClientBut_Click(object sender, EventArgs e)
        {
            tcpclient = new TcpClient(ip_port_text.Text.Split(':')[0],
                Convert.ToInt32(ip_port_text.Text.Split(':')[1]));
            stream = tcpclient.GetStream();
            Text = "Клиент";
            ClientBut.Enabled = false;
        }

        private void ServerBut_Click(object sender, EventArgs e)
        {
            IPAddress adress = IPAddress.Parse(ip_port_text.Text.Split(':')[0]);
            tcplistener = new TcpListener(adress,Convert.ToInt32(ip_port_text.Text.Split(':')[1]));
            tcplistener.Start();
            Thread thread = new Thread(UserConnect);
            thread.Start();
            Text = "Сервер";
            ServerBut.Enabled = false;
        }
        private void UserConnect()
        {
            while (true)
            {
                tcpclient = tcplistener.AcceptTcpClient();
                if (richTextBox1.InvokeRequired)
                {
                    richTextBox1.Invoke(new Action(() =>
                    {
                        richTextBox1.Text += "Клиент подключен";
                    }));
                }
                else
                {
                    richTextBox1.Text += "Клиент подключен";
                }
                Thread listen = new Thread(UserProc);
                listen.Start(tcpclient);
            }
        }
        private void UserProc(object input)
        {
            TcpClient Client = input as TcpClient;
            stream = Client.GetStream();
            while (true)
            {
                    int current;
                    byte[] mess = new byte[0];
                    current = stream.ReadByte();
                    while (current != -1)
                    {
                        Array.Resize(ref mess, mess.Length + 1);
                        mess[mess.Length - 1] = (byte)current;                       
                        if (richTextBox1.InvokeRequired)
                        {
                            richTextBox1.Invoke(new Action(() =>
                            {
                                richTextBox1.Text += Encoding.Default.GetString(new byte[] { (byte)current });
                            }));
                        }
                        else
                        {
                            richTextBox1.Text += Encoding.Default.GetString(new byte[] {(byte)current});
                        }
                        current = stream.ReadByte();
                    }
                    
            }
        }
        private void SendBut_Click(object sender, EventArgs e)
        {
            byte[] mess = Encoding.Default.GetBytes(SendText.Text);
            stream.Write(mess, 0, mess.Length);
            
        }
    }
}
