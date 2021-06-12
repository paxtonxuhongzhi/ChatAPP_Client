using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;



namespace TCPClient
{
    public partial class TCPClient : Form
    {

        private TcpClient tcpClient;
        public BinaryReader br;
        public BinaryWriter bw;
        private string time;
        private Boolean isTcpConnected = false;

        public TCPClient()
        {
            InitializeComponent();
        }

        private void StartConnect_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(()=>TryConnect());
            myThread.IsBackground = true;
            myThread.Start();
        }

        private void SendBotton_Click(object sender, EventArgs e)
        {
            if (isTcpConnected == true)
            {
                NetworkStream clientStream = tcpClient.GetStream();
                bw = new BinaryWriter(clientStream);
                bw.Write(SendTextBox.Text);
                time = DateTime.Now.ToString();
                this.Invoke(new Action(() => ReceiveTextBox.Text += time + "       " + "我说：" + "\r\n" + SendTextBox.Text + "\r\n"));
                SendTextBox.Clear();
            }
            else
            {
                MessageBox.Show("请先进行连接");
            }
        }

        private void TryConnect()
        {
            try
            {
                tcpClient = new TcpClient(this.IPTextBox.Text, 5000);
                this.Invoke(new Action(() => ConnectState.Text = "连接成功"));
                isTcpConnected = true;
                while (true)
                {
                    NetworkStream clientStream = tcpClient.GetStream();
                    if (clientStream.DataAvailable)
                    {
                        br = new BinaryReader(clientStream);
                        string receive = null;
                        receive = br.ReadString();
                        if (receive.Length > 0)
                        {
                            try
                            {
                                time = DateTime.Now.ToString();
                                this.Invoke(new Action(() => ReceiveTextBox.Text += time + "       " + "服务器说：" + "\r\n" + receive + "\r\n"));
                            }
                            catch
                            {
                                MessageBox.Show("当前处于连接断开状态！");
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                //for (int i = 0; i < 10; i++)
                //{
                //    Thread.Sleep(500);
                //    TryConnect();
                //}
                //MessageBox.Show("132132");
            }
           
        }

        private void SendTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.SendBotton_Click(sender, e);
            }
            //if (e.Control && e.KeyCode == Keys.R)
            //{
            //    this.SendBotton_Click(sender, e);
            //    this.SendBotton_Click(sender, e);
            //    //换行输入
            //}
        }

        private void IPTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == (Keys.Control | Keys.Enter))
            //{
            //    MessageBox.Show("组合快捷键测试...");
            //}
          
            if (e.KeyCode == Keys.Enter)
            {
                this.StartConnect_Click(sender,e);
            }
           
        }

        private void ReceiveTextBox_TextChanged(object sender, EventArgs e)
        {
            ReceiveTextBox.SelectionStart = ReceiveTextBox.Text.Length;
            ReceiveTextBox.ScrollToCaret();
        }

        private void SendTextBox_TextChanged(object sender, EventArgs e)
        {
            ReceiveTextBox.SelectionStart = ReceiveTextBox.Text.Length;
            ReceiveTextBox.ScrollToCaret();
        }
    }
}
