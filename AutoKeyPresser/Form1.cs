using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace AutoKeyPresser
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int SetForegroundWindow(IntPtr point);

        public Form1()
        {
            InitializeComponent();
            button2.Hide();
            rdBtnAuto.Checked= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tbxBarcode = textBox1.Text.ToString();
            string firstValue = tbxFirstValue.Text.ToString();
            string secondValue = tbxSecondValue.Text.ToString();
            string thirdValue = tbxThirdValue.Text.ToString();
            Process process = Process.GetProcessesByName("Ofisnet").FirstOrDefault();

            if (process != null && string.IsNullOrEmpty(textBox1.Text)==false)
            {

                IntPtr hand = process.MainWindowHandle;
                SetForegroundWindow(hand);
                SendKeys.Send("^(o)");
                SendKeys.SendWait(tbxBarcode);
                SendKeys.Send("{ENTER}");
                //SendKeys.Send("+(y)");
                SendKeys.Send("^+(g)");
                SendKeys.Send("%{TAB}");
                textBox1.Clear();
                textBox1.Focus();

            }
            else
            {
                MessageBox.Show("BuzzBarcode-001\nLütfen Geçerli Bir Barkod No Giriniz.");
                textBox1.Clear();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && rdBtnAuto.Checked) {
                string tbxBarcode = textBox1.Text.ToString();
                Process process = Process.GetProcessesByName("Ofisnet").FirstOrDefault();

                if (process != null && string.IsNullOrEmpty(textBox1.Text) == false)
                {
                    IntPtr hand = process.MainWindowHandle;
                    SetForegroundWindow(hand);
                    SendKeys.Send("^(o)");
                    SendKeys.SendWait(tbxBarcode);
                    SendKeys.Send("{ENTER}");
                    SendKeys.Send("^+(k)");
                    //SendKeys.Send("^(y)");
                    //SendKeys.Send("+(y)");
                    Thread.Sleep(2000);
                    SendKeys.Send("%{TAB}");
                    textBox1.Clear();
                    textBox1.Focus();

                }
                else
                {
                    MessageBox.Show("Netsim Çalışmıyor.");
                    textBox1.Clear();
                } 
            }
        }

        private void rdBtnAuto_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255,145,0);
            button2.Hide();
            textBox1.Focus();
        }

        private void rdBtnManuel_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(38, 166, 154);
            button2.Show();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
