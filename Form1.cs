using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace SerialPortTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Initalization Display Data
            InitializeComponent();
           
        }

        //Function of Control Status
        private void Cbox_Status(bool status)
        {
            this.Cb_Port.Enabled = status;
            this.Cb_Rate.Enabled = status;
            this.Cb_Proof.Enabled = status;
            this.Cb_StopBits.Enabled = status;
            this.Cb_DataLenght.Enabled = status;
        }

        //Create a new SerailPort global object named matarn
        SerialPort matarn = new SerialPort();

        //Function for connect button
        private void Bt_Connect_Click(object sender, EventArgs e)
        {
            try {
                if (this.Bt_Connect.Text == "Connect")
                {
                    matarn.PortName = this.Cb_Port.Text;
                    matarn.BaudRate = int.Parse(this.Cb_Rate.Text);
                    matarn.DataBits = int.Parse(this.Cb_DataLenght.Text);
                    switch (this.Cb_Proof.Text)
                    {
                        case "None":
                            matarn.Parity = Parity.None;
                            break;
                        case "Odd":
                            matarn.Parity = Parity.Odd;
                            break;
                        case "Even":
                            matarn.Parity = Parity.Even;
                            break;
                    }
                    switch (this.Cb_StopBits.Text)
                    {
                        case "1":
                            matarn.StopBits = StopBits.One;
                            break; 
                        case "2":
                            matarn.StopBits = StopBits.Two;
                            break;
                    }
                    //this.Lb_Cmd.Text = int.Parse(this.Cb_Port.Text).ToString()
                    matarn.Open();
                    if (!matarn.IsOpen)
                    {
                        this.Lb_Status.Text = "Communication  Failed!";
                    }
                    Cbox_Status(false);
                    this.Lb_Status.Text = "Communication Successfully!";
                    this.Bt_Connect.Text = "Disconnect";
                }
                else
                {
                    matarn.Close();
                    this.Lb_Status.Text = "Disconnected Successfully!";
                    this.Bt_Connect.Text = "Connect";
                    Cbox_Status(true);

                }
            }
            catch(Exception error) {
                
                this.Lb_Status.Text = error.Message;

            }
        }

        // the data display on application opening
        private void Form1_Load(object sender, EventArgs e)
        {
            try 
            {

                //Get the ports of computer
                string[] sys_Ports = SerialPort.GetPortNames();

                if (sys_Ports != null)
                {
                    //this.Lb_Send_Status.Text = sys_Ports[0].ToString();
                    //foreach (string port in sys_Ports)
                    //{
                    //    this.Cb_Test.Items.Add(port);
                    //}
                    this.Cb_Port.DataSource = sys_Ports;
                }


                ////Port
                //string[] arrPorts;
                //ArrayList arr_Ports = new ArrayList();
                //for (int i = 1; i <= 10; i++)
                //{
                //    arr_Ports.Add("COM" + i);
                //}
                //arrPorts = (string[])arr_Ports.ToArray(typeof(string));


                //Rate
                int[] arrRate;
                ArrayList list_Rate = new ArrayList();
                for (int i = 300; i < 115200 * 2; i *= 2)
                {
                    list_Rate.Add(i);
                    if (i == 38400)
                    {
                        i = 57600;
                        list_Rate.Add(57600);
                    }
                }
                arrRate = (int[])list_Rate.ToArray(typeof(int));
                //Proof
                string[] arrProof = { "None", "Even", "Odd" };
                //DataBits
                string[] arrDataLenght = { "8", "7" };
                //StopBits
                string[] arrStopBits = { "1", "2" };

                //Put the Data to display
                this.Cb_Rate.DataSource = arrRate;
                this.Cb_Proof.DataSource = arrProof;
                this.Cb_DataLenght.DataSource = arrDataLenght;
                this.Cb_StopBits.DataSource = arrStopBits;
                this.Cb_Rate.SelectedIndex = 5;
            }
            catch(Exception error)
            {
                this.Lb_Status.Text = error.Message;
            }
        }

        //Function of send button
        private void Bt_Send_Click(object sender, EventArgs e)
        {

            try 
            {
                if (!matarn.IsOpen) {
                    this.Lb_Send_Status.Text = "Please Connection Frist!";
                }
                else
                {
                    if (this.Tb_Cmd.Text.Length < 1)
                    {
                        this.Lb_Send_Status.Text = "Please input command!";
                    }
                    else { 
                        string[] Cmd_String = this.Tb_Cmd.Text.Split(' ');
                        List<byte> byte_list = new List<byte>();
                        foreach (string s in Cmd_String)
                        {
                            byte_list.Add(Convert.ToByte(s,16));
                    
                        }

                        byte[] Cmd_byte = byte_list.ToArray();

                        matarn.Write(Cmd_byte, 0, Cmd_byte.Length);
                        Thread.Sleep(50);
                        byte[] Readres = new byte[matarn.BytesToRead];

                        //matarn.Read(Readres, 0, matarn.BytesToRead);
                        byte[] Read_Bytes = new byte[matarn.BytesToRead];
                        matarn.Read(Read_Bytes, 0, matarn.BytesToRead);
                        string res_Data = "";
                        foreach (byte s in Read_Bytes)
                        {
                            if (Read_Bytes.Length == 1)
                            {
                                res_Data = s.ToString();
                                break;
                            }
                            res_Data = s.ToString() + " ";
                        }
                        this.Tb_Res_Data.Text = res_Data;
                        if(res_Data == "6")
                        {
                            this.Lb_Send_Status.Text = "发送成功";
                        }
                        else
                        {
                            this.Lb_Send_Status.Text = "发送失败";
                        }
                    }
                }
            }
            catch (Exception error)
            {
                this.Lb_Send_Status.Text = error.Message;
            }
        }

        private void Lk_Help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://blog.csdn.net/weixin_39993322/article/details/110902143");
        }
    }
}
