using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace MACtest
{
    public partial class Form_mactest : Form
    {
        private Thread scanner;
        private string serialrecv = String.Empty;
        public Form_mactest()
        {
            InitializeComponent();
        }

        private void Form_mactest_Load(object sender, EventArgs e)
        {
            //create vars for testing
            String[] Portname = SerialPort.GetPortNames();

            //create a loop for each string in SerialPort.GetPortNames
            foreach (string str in Portname)
            {
                try
                {
                    comm = new SerialPort(str);
                    comm.Open();

                    //if the port exist and we can open it
                    if (comm.IsOpen)
                    {
                        cb_port.Items.Add(str);
                        comm.Close();
                    }
                }

                //else we have no ports or can't open them display the 
                //precise error of why we either don't have ports or can't open them
                catch (Exception err)
                {
                    err.ToString();
                    //MessageBox.Show(err.ToString(), "Error - No Ports available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            comm.NewLine = "\r\n";
            comm.RtsEnable = true;
            comm.DataReceived += new SerialDataReceivedEventHandler(comm_DataReceived);

            scanner = new Thread(scanner_datarec);
            scanner.Start();
        }
        private void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = comm.BytesToRead;
            byte[] buf = new byte[n];
            comm.Read(buf, 0, n);
            string str=System.Text.Encoding.ASCII.GetString(buf);

            serialrecv += str;


            if ((serialrecv.IndexOf("New") > -1) && (serialrecv.IndexOf("RSSI") > -1) && (this.lbx_scanner.Items.Count > 0))
            {
                this.lb_serialport.Invoke((MethodInvoker)delegate()
                {
                    show_bdadata(serialrecv.Substring(serialrecv.IndexOf("New")));
                });
                serialrecv = String.Empty;
            }
        }
        private void show_bdadata(string str)
        {
            this.lb_bda.Text = str;
            if (this.lbx_bda.Items.Count == 1)
            {
                this.lbx_bda.Items.Clear();
            }
            this.lbx_bda.Items.Add(str);

            maccmp();
        }
        private void scanner_datarec()
        {
            while(true)
            {
                if(this.txt_scanner.Text.Trim()!=String.Empty)
                {
                    this.lbx_scanner.Invoke((MethodInvoker)delegate()
                    {
                        AddItem();
                    });
                }
                Thread.Sleep(3000);
            }
        }
        private void AddItem()
        {
            if (this.lbx_scanner.Items.Count == 1)
            {
                this.lbx_scanner.Items.Clear();
                this.lb_result.Text = "检测结果";
                this.lb_result.ForeColor = Color.Black;
            }
            string str = this.txt_scanner.Text.ToString();
            if ((str.IndexOf("LNA") > -1) && str.Length > 30)
            {
                this.lbx_scanner.Items.Add(str);
                this.txt_scanner.Text = String.Empty;
            }
            else 
            {
                this.txt_scanner.Text = String.Empty;
                MessageBox.Show("二维码扫描数据错误，请重新扫描"); 
            }
        }
        private void maccmp()
        {
            //LNA880F10E00E24/157152799998749
            string scanner = this.lbx_scanner.Items[0].ToString();
            //this.lbx_scanner.Items.Clear();
            string scanner_mac = scanner.Substring(3,12);
            //New Device:[880F10E0393F], RSSI:44
            string bda = this.lbx_bda.Items[0].ToString();
            //this.lbx_bda.Items.Clear();
            string bda_mac = bda.Substring(bda.IndexOf('[')+1,12);

            if (scanner_mac == bda_mac)
            {
                this.lb_result.Text = "合格";
                this.lb_result.ForeColor = Color.Green;
            }
            else 
            {
                this.lb_result.Text = "不合格";
                this.lb_result.ForeColor = Color.Red; 
            }
            this.txt_scanner.Focus();
 
        }

        private void btn_openserial_Click(object sender, EventArgs e)
        {
            //设置好端口名和波特率
            if (cb_port.Text.ToString() == String.Empty)
            {
                MessageBox.Show("端口不能为空");
                return;
            }
            comm.PortName = cb_port.Text.ToString();
            comm.BaudRate = int.Parse(cb_bandrate.Text.ToString());

            try
            {
                comm.Open();
                this.label_serialstatus.Text = "串口已打开";
                this.txt_scanner.Focus();
            }
            //打开失败，抛出异常
            catch (Exception ex)
            {
                this.label_serialstatus.Text = "串口打开失败";
                comm = new SerialPort();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_closeserial_Click(object sender, EventArgs e)
        {
            if (comm.IsOpen)
            {
                comm.Close();
                if (comm.IsOpen)
                {
                    this.label_serialstatus.Text = "串口关闭失败";
                }
                else
                {
                    this.label_serialstatus.Text = "串口已关闭";
                }
            }
        }

        private void Form_mactest_FormClosing(object sender, FormClosingEventArgs e)
        {
            scanner.Abort();
        }
    }
}
