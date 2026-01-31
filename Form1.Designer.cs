namespace GUIPingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnFixedAmountMode = new Button();
            btnSingleMode = new Button();
            btnContiMod = new Button();
            txtHostAddress = new TextBox();
            txtSourceAddress = new TextBox();
            txtOutput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaxPingAttempts = new TextBox();
            label6 = new Label();
            btnStart = new Button();
            btnStop = new Button();
            label7 = new Label();
            txtMessage = new TextBox();
            btnBroadcastMode = new Button();
            tmr1000ms = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnFixedAmountMode
            // 
            btnFixedAmountMode.Location = new Point(22, 102);
            btnFixedAmountMode.Name = "btnFixedAmountMode";
            btnFixedAmountMode.Size = new Size(80, 48);
            btnFixedAmountMode.TabIndex = 0;
            btnFixedAmountMode.Text = "Fixed Attempts";
            btnFixedAmountMode.UseVisualStyleBackColor = true;
            btnFixedAmountMode.Click += btnFixedAmountMode_Click;
            // 
            // btnSingleMode
            // 
            btnSingleMode.Location = new Point(22, 47);
            btnSingleMode.Name = "btnSingleMode";
            btnSingleMode.Size = new Size(80, 48);
            btnSingleMode.TabIndex = 1;
            btnSingleMode.Text = "Single";
            btnSingleMode.UseVisualStyleBackColor = true;
            btnSingleMode.Click += btnSingleMode_Click;
            // 
            // btnContiMod
            // 
            btnContiMod.BackColor = SystemColors.Control;
            btnContiMod.Location = new Point(108, 47);
            btnContiMod.Name = "btnContiMod";
            btnContiMod.Size = new Size(80, 48);
            btnContiMod.TabIndex = 2;
            btnContiMod.Text = "Continuous";
            btnContiMod.UseVisualStyleBackColor = false;
            btnContiMod.Click += btnContiMod_Click;
            // 
            // txtHostAddress
            // 
            txtHostAddress.Location = new Point(377, 133);
            txtHostAddress.Name = "txtHostAddress";
            txtHostAddress.Size = new Size(197, 23);
            txtHostAddress.TabIndex = 4;
            // 
            // txtSourceAddress
            // 
            txtSourceAddress.Location = new Point(377, 97);
            txtSourceAddress.Name = "txtSourceAddress";
            txtSourceAddress.Size = new Size(197, 23);
            txtSourceAddress.TabIndex = 5;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(228, 288);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(478, 150);
            txtOutput.TabIndex = 6;
            txtOutput.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 7;
            label1.Text = "Ping Mode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 136);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 8;
            label2.Text = "Host Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 100);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 9;
            label3.Text = "Source Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(335, 23);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 10;
            label4.Text = "Parameters";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(398, 235);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 11;
            label5.Text = "Output";
            // 
            // txtMaxPingAttempts
            // 
            txtMaxPingAttempts.Location = new Point(377, 61);
            txtMaxPingAttempts.Name = "txtMaxPingAttempts";
            txtMaxPingAttempts.Size = new Size(197, 23);
            txtMaxPingAttempts.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(257, 64);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 13;
            label6.Text = "Max Ping Attempts";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(66, 313);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(80, 48);
            btnStart.TabIndex = 14;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(66, 367);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(80, 48);
            btnStop.TabIndex = 15;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(257, 172);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 17;
            label7.Text = "Message";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(377, 169);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(197, 23);
            txtMessage.TabIndex = 16;
            // 
            // btnBroadcastMode
            // 
            btnBroadcastMode.BackColor = SystemColors.Control;
            btnBroadcastMode.Location = new Point(108, 102);
            btnBroadcastMode.Name = "btnBroadcastMode";
            btnBroadcastMode.Size = new Size(80, 48);
            btnBroadcastMode.TabIndex = 18;
            btnBroadcastMode.Text = "Broadcast";
            btnBroadcastMode.UseVisualStyleBackColor = false;
            btnBroadcastMode.Click += btnBroadcastMode_Click;
            // 
            // tmr1000ms
            // 
            tmr1000ms.Interval = 1000;
            tmr1000ms.Tick += tmr1000ms_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBroadcastMode);
            Controls.Add(label7);
            Controls.Add(txtMessage);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(label6);
            Controls.Add(txtMaxPingAttempts);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Controls.Add(txtSourceAddress);
            Controls.Add(txtHostAddress);
            Controls.Add(btnContiMod);
            Controls.Add(btnSingleMode);
            Controls.Add(btnFixedAmountMode);
            Name = "Form1";
            Text = "Ping Application";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFixedAmountMode;
        private Button btnSingleMode;
        private Button btnContiMod;
        private TextBox txtHostAddress;
        private TextBox txtSourceAddress;
        private TextBox txtOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaxPingAttempts;
        private Label label6;
        private Button btnStart;
        private Button btnStop;
        private Label label7;
        private TextBox txtMessage;
        private Button btnBroadcastMode;
        private System.Windows.Forms.Timer tmr1000ms;
    }
}
