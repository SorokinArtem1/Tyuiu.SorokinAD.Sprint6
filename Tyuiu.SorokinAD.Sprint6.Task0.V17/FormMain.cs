using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinAD.Sprint6.Task0.V17.Lib;

namespace Tyuiu.SorokinAD.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && e.KeyChar!=8)
            {
                e.Handled = true;
            }

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            DataSerivce ds = new DataSerivce();
            try
            {
                textBoxOutput.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput.Text)));

            }
            catch
            {
               
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполлнил студент группы ИИПБ-23-2 Сорокин Артём Дмитриевич");
        }
    }
}
/*             DataSerivce ds = new DataSerivce();
try
{
    textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput)));
}
catch
{
    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
        }    */