using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace NewCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static bool Osn = false;
        public static int comaNum;
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
            if (richTextBoxVir.Text.Length <= 5)
                richTextBoxVir.Text += "1";
            if (richTextBoxVir.Text.Length == 6 && richTextBoxOsn.Text.Length <= 5 && richTextBoxOsn.Text != "e")
                richTextBoxOsn.Text += "1";
            if (Osn == true && richTextBoxOsn.Text!="e")
            {
                richTextBoxOsn.Text += "1";
                richTextBoxVir.Text = richTextBoxVir.Text.Remove(richTextBoxVir.Text.Length - 1);
            }
        }
        /// <summary>
        /// ввод 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 5)
                richTextBoxVir.Text += "2";
            if (richTextBoxVir.Text.Length == 6 && richTextBoxOsn.Text.Length <= 5 && richTextBoxOsn.Text != "e")
                richTextBoxOsn.Text += "2";
            if (Osn == true && richTextBoxOsn.Text != "e")
            {
                richTextBoxOsn.Text += "2";
                richTextBoxVir.Text = richTextBoxVir.Text.Remove(richTextBoxVir.Text.Length - 1);
            }
        }
        /// <summary>
        /// ввод 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 5)
                richTextBoxVir.Text += "3";
            if (richTextBoxVir.Text.Length == 6 && richTextBoxOsn.Text.Length <= 5 && richTextBoxOsn.Text != "e")
                richTextBoxOsn.Text += "3";
            if (Osn == true && richTextBoxOsn.Text != "e")
            {
                richTextBoxOsn.Text += "3";
                richTextBoxVir.Text = richTextBoxVir.Text.Remove(richTextBoxVir.Text.Length - 1);
            }
        }
        /// <summary>
        /// ввод 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 5)
                richTextBoxVir.Text += "4";
            if (richTextBoxVir.Text.Length == 6 && richTextBoxOsn.Text.Length <= 5 && richTextBoxOsn.Text != "e")
                richTextBoxOsn.Text += "4";
            if (Osn == true && richTextBoxOsn.Text != "e")
            {
                richTextBoxOsn.Text += "4";
                richTextBoxVir.Text = richTextBoxVir.Text.Remove(richTextBoxVir.Text.Length - 1);
            }
        }
        /// <summary>
        /// ввод 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 5)
                richTextBoxVir.Text += "5";
            if (richTextBoxVir.Text.Length == 6 && richTextBoxOsn.Text.Length <= 5 && richTextBoxOsn.Text != "e")
                richTextBoxOsn.Text += "5";
            if (Osn == true && richTextBoxOsn.Text != "e")
            {
                richTextBoxOsn.Text += "5";
                richTextBoxVir.Text = richTextBoxVir.Text.Remove(richTextBoxVir.Text.Length - 1);
            }
        }
        /// <summary>
        /// ввод 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 5)
                richTextBoxVir.Text += "6";
            if (richTextBoxVir.Text.Length == 6 && richTextBoxOsn.Text.Length <= 5 && richTextBoxOsn.Text != "e")
                richTextBoxOsn.Text += "6";
            if (Osn == true && richTextBoxOsn.Text != "e")
            {
                richTextBoxOsn.Text += "6";
                richTextBoxVir.Text = richTextBoxVir.Text.Remove(richTextBoxVir.Text.Length - 1);
            }
        }
        /// <summary>
        /// ввод 7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 5)
                richTextBoxVir.Text += "7";
            if (richTextBoxVir.Text.Length == 6 && richTextBoxOsn.Text.Length <= 5 && richTextBoxOsn.Text != "e")
                richTextBoxOsn.Text += "7";
            if (Osn == true && richTextBoxOsn.Text != "e")
            {
                richTextBoxOsn.Text += "7";
                richTextBoxVir.Text = richTextBoxVir.Text.Remove(richTextBoxVir.Text.Length - 1);
            }
        }
        /// <summary>
        /// ввод 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 5)
                richTextBoxVir.Text += "8";
            if (richTextBoxVir.Text.Length == 6 && richTextBoxOsn.Text.Length <= 5 && richTextBoxOsn.Text != "e")
                richTextBoxOsn.Text += "8";
            if (Osn == true && richTextBoxOsn.Text != "e" )
            {
                richTextBoxOsn.Text += "8";
                richTextBoxVir.Text = richTextBoxVir.Text.Remove(richTextBoxVir.Text.Length - 1);
            }
        }
        /// <summary>
        /// ввод 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 5)
                richTextBoxVir.Text += "9";
            if (richTextBoxVir.Text.Length==6 && richTextBoxOsn.Text.Length<=5 && richTextBoxOsn.Text != "e")
                richTextBoxOsn.Text += "9";
            if (Osn == true && richTextBoxOsn.Text != "e")
            {
                richTextBoxOsn.Text += "9";
                richTextBoxVir.Text = richTextBoxVir.Text.Remove(richTextBoxVir.Text.Length - 1);
            }
        }
        /// <summary>
        /// ввод 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button0_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length <= 5 && richTextBoxVir.Text.Length!=0 && richTextBoxOsn.Text.Length == 0)
                richTextBoxVir.Text += "0";
            if (richTextBoxVir.Text.Length == 6 && richTextBoxOsn.Text.Length <= 5 && richTextBoxOsn.Text.Length != 0 && richTextBoxOsn.Text != "e")
                richTextBoxOsn.Text += "0";
            if (Osn == true && richTextBoxOsn.Text != "e")
            {
                if(richTextBoxVir.Text.Length == 6 && richTextBoxOsn.Text.Length <= 5 && richTextBoxOsn.Text.Length != 0)
                    richTextBoxOsn.Text += "0";                
            }
        }
        /// <summary>
        /// запрет на ввод в текстбокс1 !!! НЕ ХОЧЕТ БЛОКИРОВАТЬ РУЧНОЙ ВВОД >5 СИМВОЛОВ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBoxVir_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if (!Regex.Match(c, @"[0-9]").Success && richTextBoxVir.Text.Length!=0 && richTextBoxVir.Text.Length<=5)
                e.Handled = true;
            if (!Regex.Match(c, @"[1-9]").Success && richTextBoxVir.Text.Length == 0 && richTextBoxVir.Text.Length <= 5)
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (richTextBoxVir.Text != "")
                {
                    List<string> nLines = richTextBoxVir.Lines.ToList();
                    nLines.RemoveAt(nLines.Count - 1);
                    richTextBoxVir.Lines = nLines.ToArray();
                }
                richTextBoxOsn.Focus();              
            }
        }
        /// <summary>
        /// запрет на ввод в текстбокс2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBoxOsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            string c = e.KeyChar.ToString();
            if (!Regex.Match(c, @"[0-9]").Success && richTextBoxOsn.Text.Length != 0)
                e.Handled = true;
            if (!Regex.Match(c, @"[1-9]").Success && richTextBoxOsn.Text.Length == 0)
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (richTextBoxOsn.Text != "")
                {
                    List<string> nLines = richTextBoxOsn.Lines.ToList();
                    nLines.RemoveAt(nLines.Count - 1);
                    richTextBoxOsn.Lines = nLines.ToArray();
                }
                richTextBoxVir.Focus();
            }            
        }
        /// <summary>
        /// клик на кнопку log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLog_Click(object sender, EventArgs e)
        {
            richTextBoxOsn.Enabled = true;
            richTextBoxOsn.Text = "";
        }
        /// <summary>
        /// клик на кнопку ln
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLn_Click(object sender, EventArgs e)
        {
            richTextBoxOsn.Enabled = false;
            richTextBoxOsn.Text = "e";            
        }
        /// <summary>
        /// клик на кнопку lg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLg_Click(object sender, EventArgs e)
        {
            richTextBoxOsn.Enabled = false;
            richTextBoxOsn.Text = "10";
        }
        /// <summary>
        /// стирка символов - вроде работает
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (Osn==false)
                if (richTextBoxVir.Text.Length != 0)
                    richTextBoxVir.Text = richTextBoxVir.Text.Remove(richTextBoxVir.Text.Length - 1);
            if (Osn==true)
                if (richTextBoxOsn.Text.Length != 0)
                    richTextBoxOsn.Text = richTextBoxOsn.Text.Remove(richTextBoxOsn.Text.Length - 1);            
        }
        /// <summary>
        /// очистка одного поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            richTextBoxOsn.Enabled = true;
            richTextBoxOsn.Text = "";
            richTextBoxVir.Text = "";
        }
        /// <summary>
        /// очистка всего
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCE_Click(object sender, EventArgs e)
        {
            richTextBoxOsn.Enabled = true;
            richTextBoxOsn.Text = "";
            richTextBoxVir.Text = "";
            labelResult.Text = "";
            label2.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (richTextBoxOsn.Text != "1" && richTextBoxOsn.Text != "0" && richTextBoxVir.Text!="0")
            {
                //тут надо передать данные из richTextBoxVir в переменную-выражение
                //richTextBoxOsn в переменную-основание
                if (richTextBoxVir.Text.Length >6  || richTextBoxOsn.Text.Length >6)
                {
                    MessageBox.Show("Введено слишком длинное число.");
                    richTextBoxVir.Text = "";
                    richTextBoxOsn.Text = "";
                }
                if (richTextBoxOsn.Text.Length != 0 && richTextBoxVir.Text.Length != 0)
                {
                    labelResult.Text = "+log(" + richTextBoxOsn.Text + "," + richTextBoxVir.Text + ")" + "+";
                    richTextBoxOsn.Text = "";
                    richTextBoxOsn.Enabled = true;
                    richTextBoxVir.Text = "";
                }
            }            
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length > 6 || richTextBoxOsn.Text.Length > 6)
            {
                MessageBox.Show("Введено слишком длинное число.");
                richTextBoxVir.Text = "";
                richTextBoxOsn.Text = "";
            }
            if (richTextBoxOsn.Text != "1" && richTextBoxOsn.Text != "0" && richTextBoxVir.Text != "0")
            {
                //тут надо передать данные из richTextBoxVir в переменную-выражение
                //richTextBoxOsn в переменную-основание
                if (richTextBoxOsn.Text.Length != 0 && richTextBoxVir.Text.Length != 0)
                {
                    labelResult.Text = "-log(" + richTextBoxOsn.Text + "," + richTextBoxVir.Text + ")" + "-";
                    richTextBoxOsn.Text = "";
                    richTextBoxOsn.Enabled = true;
                    richTextBoxVir.Text = "";
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length > 6 || richTextBoxOsn.Text.Length > 6)
            {
                MessageBox.Show("Введено слишком длинное число.");
                richTextBoxVir.Text = "";
                richTextBoxOsn.Text = "";
            }
            if (richTextBoxOsn.Text != "1" && richTextBoxOsn.Text != "0" && richTextBoxVir.Text != "0")
            {
                //тут надо передать данные из richTextBoxVir в переменную-выражение
                //richTextBoxOsn в переменную-основание
                if (richTextBoxOsn.Text.Length != 0 && richTextBoxVir.Text.Length != 0)
                {
                    if (labelResult.Text.Length == 0)
                        labelResult.Text = "log(" + richTextBoxOsn.Text + "," + richTextBoxVir.Text + ")" + "/";
                    else
                        labelResult.Text = "/log(" + richTextBoxOsn.Text + "," + richTextBoxVir.Text + ")" + "/";
                    richTextBoxOsn.Text = "";
                    richTextBoxOsn.Enabled = true;
                    richTextBoxVir.Text = "";
                }
            }
        }

        private void buttonUmn_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length > 6 || richTextBoxOsn.Text.Length > 6)
            {
                MessageBox.Show("Введено слишком длинное число.");
                richTextBoxVir.Text = "";
                richTextBoxOsn.Text = "";
            }
            if (richTextBoxOsn.Text != "1" && richTextBoxOsn.Text != "0" && richTextBoxVir.Text != "0")
            {
                //тут надо передать данные из richTextBoxVir в переменную-выражение
                //richTextBoxOsn в переменную-основание
                if (richTextBoxOsn.Text.Length != 0 && richTextBoxVir.Text.Length != 0)
                {
                    if (labelResult.Text.Length == 0)
                        labelResult.Text = "log(" + richTextBoxOsn.Text + "," + richTextBoxVir.Text + ")" + "*";
                    else
                        labelResult.Text = "log(" + richTextBoxOsn.Text + "," + richTextBoxVir.Text + ")" + "*";
                    richTextBoxOsn.Text = "";
                    richTextBoxOsn.Enabled = true;
                    richTextBoxVir.Text = "";
                }
            }
        }
        /// <summary>
        /// ДОДЕЛАТЬ НАДО
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStep_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length > 6 || richTextBoxOsn.Text.Length > 6)
            {
                MessageBox.Show("Введено слишком длинное число.");
                richTextBoxVir.Text = "";
                richTextBoxOsn.Text = "";
            }
            if (richTextBoxOsn.Text != "1" && richTextBoxOsn.Text != "0" && richTextBoxVir.Text != "0")
            {
                //тут надо передать данные из richTextBoxVir в переменную-выражение
                //richTextBoxOsn в переменную-основание
                //цифру из степени - в степень - это Step
                if (richTextBoxOsn.Text.Length != 0 && richTextBoxVir.Text.Length != 0)
                {
                    Stepen nMain = new Stepen();
                    if (nMain.ShowDialog(this) == DialogResult.Cancel)
                    {
                        MessageBox.Show("Степень не была выбрана", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    int Step = Stepen.str;
                    labelResult.Text = "log(" + richTextBoxOsn.Text + "," + richTextBoxVir.Text + ")" + "^"+Step;
                    richTextBoxOsn.Text = "";
                    richTextBoxOsn.Enabled = true;
                    richTextBoxVir.Text = "";
                }
            }
        }
        /// <summary>
        /// ///корень
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCor_Click(object sender, EventArgs e)
        {
            if (richTextBoxVir.Text.Length > 6 || richTextBoxOsn.Text.Length > 6)
            {
                MessageBox.Show("Введено слишком длинное число.");
                richTextBoxVir.Text = "";
                richTextBoxOsn.Text = "";
            }
            if (richTextBoxOsn.Text != "1" && richTextBoxOsn.Text != "0" && richTextBoxVir.Text != "0")
            {
                //тут надо передать данные из richTextBoxVir в переменную-выражение
                //richTextBoxOsn в переменную-основание
                if (richTextBoxOsn.Text.Length != 0 && richTextBoxVir.Text.Length != 0)
                {
                    labelResult.Text = "sqrt(log(" + richTextBoxOsn.Text + "," + richTextBoxVir.Text + "))";
                    richTextBoxOsn.Text = "";
                    richTextBoxOsn.Enabled = true;
                    richTextBoxVir.Text = "";
                }
            }
        }
        /// <summary>
        /// изменение режима ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonComa_Click(object sender, EventArgs e)
        {
            if (Osn == true)
                Osn = false;
            else
                Osn = true;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            //сюда перенести результат            
            double result=0; //вот сюда, да
            comaNum = Kol_vo.coma;//количество знаков после запятой
            label2.Text = Convert.ToString(Math.Round(result, comaNum));            
        }

        private void ввестиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kol_vo nMaint = new Kol_vo();
            if (nMaint.ShowDialog(this) == DialogResult.Cancel)
            {
                MessageBox.Show("Количество знаков в ответе не было выбрано", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            comaNum = Kol_vo.coma;
        }
    }
}
