
namespace LCD_sender
{
    partial class LCDS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCDS));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.portInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.LCDInputL1 = new System.Windows.Forms.TextBox();
            this.LCDInputL2 = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.visualConfirmation = new System.Windows.Forms.Label();
            this.codeGenButton = new System.Windows.Forms.Button();
            this.codeGenSelectL = new System.Windows.Forms.RadioButton();
            this.codeGenSelectN = new System.Windows.Forms.RadioButton();
            this.codeOut1 = new System.Windows.Forms.Label();
            this.codeOut2 = new System.Windows.Forms.Label();
            this.sendCodesButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(182, 36);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(42, 20);
            this.portInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter COM port to connect to";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(86, 75);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(56, 30);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(229, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton1.Text = "Close";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // LCDInputL1
            // 
            this.LCDInputL1.Location = new System.Drawing.Point(12, 119);
            this.LCDInputL1.MaxLength = 16;
            this.LCDInputL1.Name = "LCDInputL1";
            this.LCDInputL1.Size = new System.Drawing.Size(201, 20);
            this.LCDInputL1.TabIndex = 4;
            // 
            // LCDInputL2
            // 
            this.LCDInputL2.Location = new System.Drawing.Point(12, 145);
            this.LCDInputL2.MaxLength = 16;
            this.LCDInputL2.Name = "LCDInputL2";
            this.LCDInputL2.Size = new System.Drawing.Size(201, 20);
            this.LCDInputL2.TabIndex = 5;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(11, 171);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(86, 23);
            this.sendButton.TabIndex = 6;
            this.sendButton.Text = "Send to LCD";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(138, 171);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear LCD";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(148, 75);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(76, 30);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Connection status :";
            // 
            // visualConfirmation
            // 
            this.visualConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.visualConfirmation.Location = new System.Drawing.Point(8, 84);
            this.visualConfirmation.Name = "visualConfirmation";
            this.visualConfirmation.Size = new System.Drawing.Size(75, 15);
            this.visualConfirmation.TabIndex = 10;
            this.visualConfirmation.Text = "Disconnected";
            this.visualConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codeGenButton
            // 
            this.codeGenButton.Location = new System.Drawing.Point(12, 213);
            this.codeGenButton.Name = "codeGenButton";
            this.codeGenButton.Size = new System.Drawing.Size(105, 23);
            this.codeGenButton.TabIndex = 12;
            this.codeGenButton.Text = "Generate codes";
            this.codeGenButton.UseVisualStyleBackColor = true;
            this.codeGenButton.Click += new System.EventHandler(this.codeGenButton_Click);
            // 
            // codeGenSelectL
            // 
            this.codeGenSelectL.AutoSize = true;
            this.codeGenSelectL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeGenSelectL.Location = new System.Drawing.Point(134, 246);
            this.codeGenSelectL.Name = "codeGenSelectL";
            this.codeGenSelectL.Size = new System.Drawing.Size(70, 21);
            this.codeGenSelectL.TabIndex = 13;
            this.codeGenSelectL.TabStop = true;
            this.codeGenSelectL.Text = "Letters";
            this.codeGenSelectL.UseVisualStyleBackColor = true;
            // 
            // codeGenSelectN
            // 
            this.codeGenSelectN.AutoSize = true;
            this.codeGenSelectN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeGenSelectN.Location = new System.Drawing.Point(134, 269);
            this.codeGenSelectN.Name = "codeGenSelectN";
            this.codeGenSelectN.Size = new System.Drawing.Size(83, 21);
            this.codeGenSelectN.TabIndex = 14;
            this.codeGenSelectN.TabStop = true;
            this.codeGenSelectN.Text = "Numbers";
            this.codeGenSelectN.UseVisualStyleBackColor = true;
            // 
            // codeOut1
            // 
            this.codeOut1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeOut1.Location = new System.Drawing.Point(8, 254);
            this.codeOut1.Name = "codeOut1";
            this.codeOut1.Size = new System.Drawing.Size(105, 18);
            this.codeOut1.TabIndex = 15;
            // 
            // codeOut2
            // 
            this.codeOut2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeOut2.Location = new System.Drawing.Point(8, 272);
            this.codeOut2.Name = "codeOut2";
            this.codeOut2.Size = new System.Drawing.Size(105, 18);
            this.codeOut2.TabIndex = 16;
            // 
            // sendCodesButton
            // 
            this.sendCodesButton.Location = new System.Drawing.Point(138, 213);
            this.sendCodesButton.Name = "sendCodesButton";
            this.sendCodesButton.Size = new System.Drawing.Size(75, 23);
            this.sendCodesButton.TabIndex = 17;
            this.sendCodesButton.Text = "Send codes";
            this.sendCodesButton.UseVisualStyleBackColor = true;
            this.sendCodesButton.Click += new System.EventHandler(this.sendCodesButton_Click);
            // 
            // LCDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 303);
            this.Controls.Add(this.sendCodesButton);
            this.Controls.Add(this.codeOut2);
            this.Controls.Add(this.codeOut1);
            this.Controls.Add(this.codeGenSelectN);
            this.Controls.Add(this.codeGenSelectL);
            this.Controls.Add(this.codeGenButton);
            this.Controls.Add(this.visualConfirmation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.LCDInputL2);
            this.Controls.Add(this.LCDInputL1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LCDS";
            this.Text = "LCDS";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox LCDInputL1;
        private System.Windows.Forms.TextBox LCDInputL2;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label visualConfirmation;
        private System.Windows.Forms.Button codeGenButton;
        private System.Windows.Forms.RadioButton codeGenSelectL;
        private System.Windows.Forms.RadioButton codeGenSelectN;
        private System.Windows.Forms.Label codeOut1;
        private System.Windows.Forms.Label codeOut2;
        private System.Windows.Forms.Button sendCodesButton;
    }
}

