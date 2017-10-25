// READ THIS:
// Looking for the EV3 code in this file? 
// Do a text search for the string "EV3:"!

using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

// EV3: Added the line "using EV3MessengerLib;" 
//      to make the code from the EV3MessengerLib.dll
//      available in this program file.
using EV3MessengerLib;

namespace EV3RemoteControl
{

    public partial class Mainform : Form
    {
        HttpClient client = new HttpClient();
        // EV3: EV3Messenger is used to communicate with the Lego EV3.
        private EV3Messenger ev3Messenger;

        // You need a timer to receive messages from the EV3
        // at specified time intervals.
        private Timer messageReceiveTimer;

        public Mainform()
        {
            InitializeComponent();
            // Create the Timer object and set it to generate a timer tick event 
            // every 10 milliseconds. The timer tick can be used to execute code at fixed intervals.
            messageReceiveTimer = new Timer();
            messageReceiveTimer.Interval = 10;

            // Set the "messageReadTimer_Tick" method as method that is executed when
            // a timer tick event occurs.
            // The "messageReadTimer_Tick" method is defined later in this code (search!).
            messageReceiveTimer.Tick += new System.EventHandler(messageReadTimer_Tick);

            // EV3: Create an EV3Messenger object which you can use to talk to the EV3.
            ev3Messenger = new EV3Messenger();

            FillSerialPortSelectionBoxWithAvailablePorts();
            UpdateButtonsAndConnectionInfo();
        }

        private void scanForSerialPortsButton_Click(object sender, EventArgs e)
        {
            FillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            String port = serialPortSelectionBox.Text;
            if (ev3Messenger.Connect(port))
            {
                UpdateButtonsAndConnectionInfo();
                receivedMessagesListBox.Items.Clear();
                messageReceiveTimer.Start();
            }
            else
            {
                MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                    + "Is your EV3 connected to that serial port? Or is it using another one?");
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            messageReceiveTimer.Stop();
            ev3Messenger.Disconnect();
            UpdateButtonsAndConnectionInfo();
        }

        private void serialPortSelectionBox_Leave(object sender, EventArgs e)
        {
            serialPortSelectionBox.Text = serialPortSelectionBox.Text.ToUpper();
        }

        private void FillSerialPortSelectionBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            serialPortSelectionBox.Items.Clear();
            foreach (String port in ports)
            {
                serialPortSelectionBox.Items.Add(port);
            }
        }

        private void UpdateButtonsAndConnectionInfo()
        {
            bool isConnected = ev3Messenger.IsConnected;

            connectButton.Enabled = !isConnected;
            scanForSerialPortsButton.Enabled = !isConnected;
            disconnectButton.Enabled = isConnected;

            if (isConnected)
            {
                connectedDeviceLabel.Text = "Connected to:\n" + ev3Messenger.Port;
                connectedDeviceLabel.BackColor = Color.LightGreen;
            }
            else
            {
                connectedDeviceLabel.Text = "No connection";
                connectedDeviceLabel.BackColor = Color.Red;
            }
        }

        private void clearReceivedMessagesButton_Click(object sender, EventArgs e)
        {
            receivedMessagesListBox.Items.Clear();
        }

        // EV3: This method is the event handler for the messageReadTimer.
        //      The method is called when the timer has reached its 'interval' value.
        //      
        private void messageReadTimer_Tick(object sender, EventArgs e)
        {
            if (ev3Messenger.IsConnected)
            {
                EV3Message message = ev3Messenger.ReadMessage();
                if (message != null)
                {
                    if (message.MailboxTitle == "Message")
                    {
                        receivedMessagesListBox.Items.Add(message);
                    }

                    else if (message.MailboxTitle == "Kleur1")
                    {
                        int kleur1 = Convert.ToInt32(message.ValueAsNumber);
                    }
                    else if (message.MailboxTitle == "Kleur2")
                    {
                        int kleur2 = Convert.ToInt32(message.ValueAsNumber);
                    }

                    else if (message.MailboxTitle == "Alarm" && message.ValueAsNumber == 1 && message.ValueAsNumber == 0)
                    {
                        AlarmTextBox.Text = message.ValueAsNumber.ToString();
                    }

                }
            }
        }


        private void sendRightButton_Click(object sender, EventArgs e)
        {
            // Send message "Right" to EV3 mailbox with title "Move"
            if (ev3Messenger.IsConnected)
            {
                ev3Messenger.SendMessage("Move", "Right");
            }
        }

        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Stop the timer
            messageReceiveTimer.Stop();

            // EV3: Disconnect
            if (ev3Messenger.IsConnected)
            {
                ev3Messenger.Disconnect();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (ev3Messenger.IsConnected)
            {
                string[] words = commandBox.Text.Split(':');
                if (words.Length == 2)
                {
                    ev3Messenger.SendMessage(words[0], words[1]);
                }
                else
                {
                    receivedMessagesListBox.Items.Add("Wrong format, use <mailbox:message>");
                }
            }
        }

        private void test_Click(object sender, EventArgs e)
        {

        }
    }
}
