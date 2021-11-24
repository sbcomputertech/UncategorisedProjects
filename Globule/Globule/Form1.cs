using System;
using System.Windows.Forms;

namespace Globule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files|*.txt|Hexademical data files|*.hex|Binary data files|*.bin|Test files|*globule.tst*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string globData = GlobLib.LoadGlob(textBox1.Text);
            label1.Text = "Globule data:\n" + globData;
        }

        string overwriteBackup = "no backup made";

        private void button4_Click(object sender, EventArgs e)
        {
            if (overwriteBackup != "no backup made")
            {
                GlobLib.OverwriteGlob(textBox5.Text, overwriteBackup, true);
            }
            else
            {
                Console.WriteLine("ERROR:Globfile.Overwrite.Backup¦NoBackupPresent");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string data = textBox4.Text;
            bool confirmation = checkBox1.Checked;
            overwriteBackup = GlobLib.OverwriteGlob(textBox5.Text, "|glob<>file|\n" + data, confirmation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = textBox3.Text;
            string path = textBox2.Text;
            GlobLib.AddToGlob(path, data);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (srcFile != "none")
            {
                label4.Text = GlobLib.ToGlobule(srcFile, textBox6.Text);
                label3.Text = System.IO.File.ReadAllText(srcFile);
            }
        }

        string srcFile = "none";
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            label2.Text = openFileDialog1.FileName;
            srcFile = openFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
