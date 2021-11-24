using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCD_sender
{
    public partial class LCDS : Form
    {

        string[] alphabetArray = "a-b-c-d-e-f-g-h-i-j-k-l-m-n-o-p-q-r-s-t-u-v-w-x-y-z".Split('-');
        public LCDS()
        {
            InitializeComponent();
            visualConfirmation.Text = "Disconnected";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = portInput.Text;
            serialPort1.Open();
            visualConfirmation.Text = "Connected";
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("-(" + LCDInputL1.Text + ")" + LCDInputL2.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("-(");
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            visualConfirmation.Text = "Disconnected";
        }

        private void codeGenButton_Click(object sender, EventArgs e)
        {
            if (codeGenSelectL.Checked)
            {
                Random random = new Random();
                string code = "";
                for (int i = 0; i < 16; i++)
                {
                    code = code + "" + alphabetArray[random.Next(0, alphabetArray.Length)];
                }
                codeOut1.Text = code;
                code = "";
                for (int i = 0; i < 16; i++)
                {
                    code = code + "" + alphabetArray[random.Next(0, alphabetArray.Length)];
                }
                codeOut2.Text = code;
            } else if (codeGenSelectN.Checked)
            {
                Random random = new Random();
                long code = 0;
                for (int i = 0; i < 16; i++)
                {
                    if (code == 0)
                        code = random.Next(1, 9);
                    else
                        code = (code * 10) + random.Next(1, 9);
                }
                codeOut1.Text = code.ToString();
                code = 0;
                for (int i = 0; i < 16; i++)
                {
                    if (code == 0)
                        code = random.Next(1, 9);
                    else
                        code = (code * 10) + random.Next(1, 9);
                }
                codeOut2.Text = code.ToString();
            }
        }

        private void sendCodesButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("-(" + codeOut1.Text + ")" + codeOut2.Text);
        }
    }
}
