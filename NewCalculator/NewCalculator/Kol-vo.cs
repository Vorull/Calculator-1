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
    public partial class Kol_vo : Form
    {
        public static int coma;
        public Kol_vo()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case char k when !Char.IsDigit(k) && k != (char)Keys.Back:
                    e.Handled = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coma = Convert.ToInt32(textBox1.Text);
            if (coma > 7)
                MessageBox.Show("Ошибка! Слишком большое число, введите поменьше.");
            else
                DialogResult = DialogResult.OK;
        }
    }
}
