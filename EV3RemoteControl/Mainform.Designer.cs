namespace EV3RemoteControl
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.connectedDeviceLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.scanForSerialPortsButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.serialPortSelectionBox = new System.Windows.Forms.ComboBox();
            this.receivedDataGroupBox = new System.Windows.Forms.GroupBox();
            this.Alarm = new System.Windows.Forms.Label();
            this.AlarmTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KleurTextBox = new System.Windows.Forms.TextBox();
            this.receivedMessagesGroupBox = new System.Windows.Forms.GroupBox();
            this.clearReceivedMessagesButton = new System.Windows.Forms.Button();
            this.receivedMessagesListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.test = new System.Windows.Forms.Button();
            this.connectionGroupBox.SuspendLayout();
            this.receivedDataGroupBox.SuspendLayout();
            this.receivedMessagesGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.connectedDeviceLabel);
            this.connectionGroupBox.Controls.Add(this.disconnectButton);
            this.connectionGroupBox.Controls.Add(this.scanForSerialPortsButton);
            this.connectionGroupBox.Controls.Add(this.connectButton);
            this.connectionGroupBox.Controls.Add(this.serialPortSelectionBox);
            this.connectionGroupBox.Location = new System.Drawing.Point(13, 12);
            this.connectionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.connectionGroupBox.Size = new System.Drawing.Size(907, 106);
            this.connectionGroupBox.TabIndex = 3;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Connection";
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedDeviceLabel.Location = new System.Drawing.Point(573, 25);
            this.connectedDeviceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(193, 57);
            this.connectedDeviceLabel.TabIndex = 10;
            this.connectedDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(407, 62);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(100, 28);
            this.disconnectButton.TabIndex = 9;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // scanForSerialPortsButton
            // 
            this.scanForSerialPortsButton.Location = new System.Drawing.Point(240, 43);
            this.scanForSerialPortsButton.Margin = new System.Windows.Forms.Padding(4);
            this.scanForSerialPortsButton.Name = "scanForSerialPortsButton";
            this.scanForSerialPortsButton.Size = new System.Drawing.Size(107, 28);
            this.scanForSerialPortsButton.TabIndex = 8;
            this.scanForSerialPortsButton.Text = "Rescan Ports";
            this.scanForSerialPortsButton.UseVisualStyleBackColor = true;
            this.scanForSerialPortsButton.Click += new System.EventHandler(this.scanForSerialPortsButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(407, 18);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 28);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // serialPortSelectionBox
            // 
            this.serialPortSelectionBox.FormattingEnabled = true;
            this.serialPortSelectionBox.Location = new System.Drawing.Point(40, 43);
            this.serialPortSelectionBox.Margin = new System.Windows.Forms.Padding(4);
            this.serialPortSelectionBox.Name = "serialPortSelectionBox";
            this.serialPortSelectionBox.Size = new System.Drawing.Size(160, 24);
            this.serialPortSelectionBox.TabIndex = 0;
            this.serialPortSelectionBox.Leave += new System.EventHandler(this.serialPortSelectionBox_Leave);
            // 
            // receivedDataGroupBox
            // 
            this.receivedDataGroupBox.Controls.Add(this.Alarm);
            this.receivedDataGroupBox.Controls.Add(this.AlarmTextBox);
            this.receivedDataGroupBox.Controls.Add(this.label1);
            this.receivedDataGroupBox.Controls.Add(this.KleurTextBox);
            this.receivedDataGroupBox.Location = new System.Drawing.Point(420, 135);
            this.receivedDataGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.receivedDataGroupBox.Name = "receivedDataGroupBox";
            this.receivedDataGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.receivedDataGroupBox.Size = new System.Drawing.Size(449, 84);
            this.receivedDataGroupBox.TabIndex = 4;
            this.receivedDataGroupBox.TabStop = false;
            this.receivedDataGroupBox.Text = "EV3 Status";
            // 
            // Alarm
            // 
            this.Alarm.AutoSize = true;
            this.Alarm.Location = new System.Drawing.Point(347, 25);
            this.Alarm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(44, 17);
            this.Alarm.TabIndex = 3;
            this.Alarm.Text = "Alarm";
            // 
            // AlarmTextBox
            // 
            this.AlarmTextBox.Location = new System.Drawing.Point(307, 49);
            this.AlarmTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlarmTextBox.Name = "AlarmTextBox";
            this.AlarmTextBox.Size = new System.Drawing.Size(119, 22);
            this.AlarmTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kleur";
            // 
            // KleurTextBox
            // 
            this.KleurTextBox.Location = new System.Drawing.Point(60, 49);
            this.KleurTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.KleurTextBox.Name = "KleurTextBox";
            this.KleurTextBox.Size = new System.Drawing.Size(119, 22);
            this.KleurTextBox.TabIndex = 0;
            // 
            // receivedMessagesGroupBox
            // 
            this.receivedMessagesGroupBox.Controls.Add(this.clearReceivedMessagesButton);
            this.receivedMessagesGroupBox.Controls.Add(this.receivedMessagesListBox);
            this.receivedMessagesGroupBox.Location = new System.Drawing.Point(13, 126);
            this.receivedMessagesGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.receivedMessagesGroupBox.Name = "receivedMessagesGroupBox";
            this.receivedMessagesGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.receivedMessagesGroupBox.Size = new System.Drawing.Size(385, 191);
            this.receivedMessagesGroupBox.TabIndex = 5;
            this.receivedMessagesGroupBox.TabStop = false;
            this.receivedMessagesGroupBox.Text = "EV3 Message";
            // 
            // clearReceivedMessagesButton
            // 
            this.clearReceivedMessagesButton.Location = new System.Drawing.Point(20, 148);
            this.clearReceivedMessagesButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearReceivedMessagesButton.Name = "clearReceivedMessagesButton";
            this.clearReceivedMessagesButton.Size = new System.Drawing.Size(357, 28);
            this.clearReceivedMessagesButton.TabIndex = 2;
            this.clearReceivedMessagesButton.Text = "Clear";
            this.clearReceivedMessagesButton.UseVisualStyleBackColor = true;
            this.clearReceivedMessagesButton.Click += new System.EventHandler(this.clearReceivedMessagesButton_Click);
            // 
            // receivedMessagesListBox
            // 
            this.receivedMessagesListBox.FormattingEnabled = true;
            this.receivedMessagesListBox.ItemHeight = 16;
            this.receivedMessagesListBox.Location = new System.Drawing.Point(20, 25);
            this.receivedMessagesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.receivedMessagesListBox.Name = "receivedMessagesListBox";
            this.receivedMessagesListBox.Size = new System.Drawing.Size(357, 116);
            this.receivedMessagesListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSend);
            this.groupBox2.Controls.Add(this.commandBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 363);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(400, 141);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EV3 <mailbox:message>";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(153, 92);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 28);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // commandBox
            // 
            this.commandBox.Location = new System.Drawing.Point(13, 49);
            this.commandBox.Margin = new System.Windows.Forms.Padding(4);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(372, 22);
            this.commandBox.TabIndex = 0;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(624, 274);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 8;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 516);
            this.Controls.Add(this.test);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.receivedMessagesGroupBox);
            this.Controls.Add(this.receivedDataGroupBox);
            this.Controls.Add(this.connectionGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainform";
            this.Text = "EV3 Remote Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.connectionGroupBox.ResumeLayout(false);
            this.receivedDataGroupBox.ResumeLayout(false);
            this.receivedDataGroupBox.PerformLayout();
            this.receivedMessagesGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.GroupBox receivedDataGroupBox;
        private System.Windows.Forms.GroupBox receivedMessagesGroupBox;
        private System.Windows.Forms.ListBox receivedMessagesListBox;
        private System.Windows.Forms.TextBox KleurTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AlarmTextBox;
        private System.Windows.Forms.Label Alarm;
        private System.Windows.Forms.ComboBox serialPortSelectionBox;
        private System.Windows.Forms.Label connectedDeviceLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button scanForSerialPortsButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button clearReceivedMessagesButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button test;
    }
}

