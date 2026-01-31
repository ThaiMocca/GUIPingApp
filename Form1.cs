using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
//The following namespaces below are for using built in network-related classes
using System.Net;
using System.Net.Sockets;

namespace GUIPingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variables
        int pingMode = 0;
        string hostAddress, sourceAddress, messageText, outputText;
        byte[] buffer;
        int timeout;
        Button[] pingModeButtons;
        bool stop = false;

        //Objects
        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();

        //Methods

        private void MakeSelectedModeParametersVisable()
        {
            for (int i = 0; i < pingModeButtons.Length; i++)
            {
                //Change background color of the button to illustrated selected
                if (pingMode == i)
                {
                    pingModeButtons[i].BackColor = SystemColors.ActiveCaption;

                    //Make parameters for "Ping for a fixed amount mode" visible
                    if (pingMode == 2)
                    {
                        txtMaxPingAttempts.Enabled = true;
                    }
                    else
                    {
                        txtMaxPingAttempts.Enabled = false;
                    }
                    //Make parameters for "Broadcast mode" visible
                    if (pingMode == 3)
                    {
                        txtHostAddress.Enabled = false;
                        txtMessage.Enabled = false;
                    }
                    else
                    {
                        txtHostAddress.Enabled = true;
                        txtMessage.Enabled = true;
                    }
                }
                else
                {
                    pingModeButtons[i].BackColor = SystemColors.Control;
                }

            }
        }

        private String PingResponseOutput(PingReply reply, int pingMode = 0)
        {
            if (reply.Status == IPStatus.Success)
            {
                outputText =
                    "Ping communication status for: " + hostAddress + "\r\n"
                    + "----------------------------------------\r\n"
                    + "Address: " + reply.Address.ToString() + "\r\n"
                    + "RoundTrip time(mSec): " + reply.RoundtripTime + "\r\n"
                    + "Time to live: " + reply.Options.Ttl + "\r\n"
                    + "Don't fragment: " + reply.Options.DontFragment + "\r\n"
                    + "Buffer size: " + reply.Buffer.Length + "\r\n"
                    + "----------------------------------------\r\n";
            }
            else
            {
                outputText =
                    "Error connecting to network address/name: "
                    + hostAddress + "\r\n"
                    + "----------------------------------------\r\n";


            }
            return outputText;
        }

        private string GetLocalIPAddress()
        {

            //Get the name of this computer then
            //Retrieve all the ip addresses assigned name
            var source = Dns.GetHostEntry(Dns.GetHostName());
            //Loop through all addresses
            foreach (var ip in source.AddressList)
            {
                //Return the ip address if it is of IPV4
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    String address = ip.ToString();

                    //Return only address that start with 192.168
                    if (address.StartsWith("192.168"))
                    {
                        return address;
                    }
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }


        //Methods for objects on the form
        private void Form1_Load(object sender, EventArgs e)
        {
            pingModeButtons = new Button[]
            {
                btnSingleMode,
                btnContiMod,
                btnFixedAmountMode,
                btnBroadcastMode
            };

            txtMaxPingAttempts.Enabled = false;
            btnStop.Visible = false;
            txtSourceAddress.Enabled = false;

            sourceAddress = GetLocalIPAddress();
            MakeSelectedModeParametersVisable();
            txtSourceAddress.Text = sourceAddress;

        }

        private void btnSingleMode_Click(object sender, EventArgs e)
        {
            pingMode = 0;
            MakeSelectedModeParametersVisable();

        }

        private void btnContiMod_Click(object sender, EventArgs e)
        {
            pingMode = 1;
            MakeSelectedModeParametersVisable();
        }

        private void btnFixedAmountMode_Click(object sender, EventArgs e)
        {
            pingMode = 2;
            MakeSelectedModeParametersVisable();
        }

        private void btnBroadcastMode_Click(object sender, EventArgs e)
        {
            pingMode = 3;
            MakeSelectedModeParametersVisable();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            timeout = 120;
            PingReply reply;
            switch (pingMode)
            {
                //Single Ping
                case 0:
                    hostAddress = txtHostAddress.Text;
                    messageText = txtMessage.Text;
                    buffer = Encoding.ASCII.GetBytes(messageText);
                    reply = pingSender.Send(hostAddress, timeout, buffer, options);

                    outputText += PingResponseOutput(reply);
                    txtOutput.Text = outputText;
                    break;
                //Continuous Mode
                case 1:
                    if (txtHostAddress.Text == "")
                    {
                        outputText += "\r\nHost Address is empty";
                        txtOutput.Text = outputText;
                    }
                    else
                    {
                        tmr1000ms.Start();
                        btnStop.Visible = true;
                    }
                    break;
                //Ping for a fixed amount of times
                case 2:
                    try
                    {
                        int maxPingAttempts = Convert.ToInt16(txtMaxPingAttempts.Text);
                        long totalResponseTime = 0;
                        int pingAttemptsSucceded = 0;
                        hostAddress = txtHostAddress.Text;
                        messageText = txtMessage.Text;
                        buffer = Encoding.ASCII.GetBytes(messageText);
                        for (int currentPingAttempts = 0; currentPingAttempts < maxPingAttempts; currentPingAttempts++)
                        {
                            reply = pingSender.Send(hostAddress, timeout, buffer, options);
                            outputText += PingResponseOutput(reply);
                            if (reply.Status == IPStatus.Success)
                            {
                                totalResponseTime += reply.RoundtripTime;
                                pingAttemptsSucceded++;
                            }
                        }
                        long avgResponseTime = totalResponseTime / pingAttemptsSucceded;
                        outputText +=
                            "Total attempted ping: " + maxPingAttempts + "\r\n"
                            + "Total attempts succeded: " + pingAttemptsSucceded + "\r\n"
                            + "Total average response time for succedded attempts: " + avgResponseTime + "\r\n";
                        txtOutput.Text = outputText;
                        await Task.Delay(1);

                    }
                    catch (Exception)
                    {
                        outputText += "\r\nVerify that Max Ping Attempts is of integer";
                    }
                    break;
                //Broadcast mode
                case 3:
                    string[] IPOctedForm = sourceAddress.Split('.');
                    int subnetMaxRange = 254;
                    for (int fourthOctet = 1; fourthOctet < subnetMaxRange; fourthOctet++)
                    {
                        IPOctedForm[3] = Convert.ToString(fourthOctet);
                        hostAddress = String.Join(".", IPOctedForm);
                        if (hostAddress != sourceAddress)
                        {
                            messageText = txtMessage.Text;
                            buffer = Encoding.ASCII.GetBytes(messageText); 
                            reply = pingSender.Send(hostAddress, timeout, buffer, options);
                            outputText += PingResponseOutput(reply);
                            txtOutput.Text = outputText;
                            await Task.Delay(1);
                        }
                        btnStop.Visible = true;
                        if (stop)
                        {
                            break;
                        }
                    }
                    break;
            }

            //Clearing
            outputText = "";
            stop = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            switch (pingMode)
            {
                case 1:
                    tmr1000ms.Stop();
                    break;
            }
            btnStop.Visible = false;
            stop = true;
        }

        private void tmr1000ms_Tick(object sender, EventArgs e)
        {
            switch (pingMode)
            {
                case 1:
                    hostAddress = txtHostAddress.Text;
                    messageText = txtMessage.Text;
                    buffer = Encoding.ASCII.GetBytes(messageText);
                    PingReply reply = pingSender.Send(hostAddress, timeout, buffer, options);
                    outputText += PingResponseOutput(reply);
                    txtOutput.Text = outputText;
                    break;
            }
        }

    }

}
