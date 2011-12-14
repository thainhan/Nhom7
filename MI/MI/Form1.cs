using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace MI
{
    public partial class Form1 : Form
    {
       // ServiceHost serviceHost = new ServiceHost(typeof(MiService));
        ServiceHost myservice = null;
        ServiceMetadataBehavior behavior;
        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Enabled = false;
            btStop.Enabled = true;
            String result = null;
            Uri baseAddress;
            try
            {
                NetTcpBinding ntc = new NetTcpBinding();
                ntc.MaxReceivedMessageSize = 2147483647;
                ntc.Security.Mode = SecurityMode.None;
                if (cb_EndPoints1.Checked == true)
                {
                    baseAddress = new Uri("net.tcp://" + baseaddress.Text + "/" + tb_NetTCPBinding.Text);
                    myservice = new ServiceHost(typeof(MiService), baseAddress);
                    myservice.AddServiceEndpoint(typeof(IMiService), ntc, baseAddress);
                    if (mex.Checked == false)
                    {
                        behavior = new ServiceMetadataBehavior();
                        behavior.HttpGetEnabled = true;
                        
                        myservice.Description.Behaviors.Add(behavior);
                        behavior.HttpGetUrl = baseAddress;
                       
                        myservice.AddServiceEndpoint(typeof(IMetadataExchange), ntc, "MI1");
                        

                    }
                    result += "NetTcpBinding";

                }
                if (cb_EndPoints2.Checked == true)
                {
                    WSHttpBinding wsh = new WSHttpBinding();
                    wsh.MaxBufferPoolSize = 2147483647;
                    wsh.MaxReceivedMessageSize = 2147483647;
                    wsh.Security.Mode = SecurityMode.None;
                    baseAddress = new Uri("http://" + baseaddress.Text + "/" + tb_WSHttpBinding.Text);
                    myservice = new ServiceHost(typeof(MiService), baseAddress);
                    myservice.AddServiceEndpoint(typeof(IMiService), wsh, baseAddress);

                    if (mex.Checked == false)
                    {
                        behavior = new ServiceMetadataBehavior();
                        behavior.HttpGetEnabled = true;
                        myservice.Description.Behaviors.Add(behavior);
                        behavior.HttpGetUrl = baseAddress;
                        myservice.AddServiceEndpoint(typeof(IMetadataExchange), wsh, "MI2");

                    }
                    result += "     WSHttpBinding";
                }
                myservice.Open();
                mess.Text =myservice.State + " - Đã kết nối kiểu " + result;
                btStart.Enabled =false;
                btStop.Enabled =  true;
            }
            catch (Exception ex)
            {
                mess.Text = ex.Message;
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
          
        }

        private void btStop_Click_1(object sender, EventArgs e)
        {  try
            {   btStart.Enabled = true;
                myservice.Close();
                mess.Text = myservice.State.ToString();
                
            }
            catch (Exception ex)
            {
                mess.Text = ex.Message;
            }

        }

       


    }
}
