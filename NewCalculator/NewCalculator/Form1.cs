using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// ввод цифры 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 16)
                richTextBoxVir.Text += "1";
            else
                richTextBoxOsn.Text += "1";
        }
        /// <summary>
        /// ввод 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 16)
                richTextBoxVir.Text += "2";
            else
                richTextBoxOsn.Text += "2";
        }
        /// <summary>
        /// ввод 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 16)
                richTextBoxVir.Text += "3";
            else
                richTextBoxOsn.Text += "3";
        }
        /// <summary>
        /// ввод 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 16)
                richTextBoxVir.Text += "4";
            else
                richTextBoxOsn.Text += "4";
        }
        /// <summary>
        /// ввод 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 16)
                richTextBoxVir.Text += "5";
            else
                richTextBoxOsn.Text += "5";
        }
        /// <summary>
        /// ввод 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 16)
                richTextBoxVir.Text += "6";
            else
                richTextBoxOsn.Text += "6";
        }
        /// <summary>
        /// ввод 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 16)
                richTextBoxVir.Text += "7";
            else
                richTextBoxOsn.Text += "7";
        }
        /// <summary>
        /// ввод 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 16)
                richTextBoxVir.Text += "8";
            else
                richTextBoxOsn.Text += "8";
        }
        /// <summary>
        /// ввод 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 16)
                richTextBoxVir.Text += "9";
            else
                richTextBoxOsn.Text += "9";
        }
        /// <summary>
        /// ввод 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button0_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 16 && richTextBoxVir.Text.Length!=0 && richTextBoxOsn.Text.Length == 0)
                richTextBoxVir.Text += "0";
            else
                richTextBoxOsn.Text += "0";
        }
    }
}
