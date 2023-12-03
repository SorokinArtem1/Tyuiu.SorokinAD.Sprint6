using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinAD.Sprint6.Task2.V21.Lib;

namespace Tyuiu.SorokinAD.Sprint6.Task2.V21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResult_SAD_Click(object sender, EventArgs e)
        {
            try
            {

                int startStep = Convert.ToInt32(textBoxStart_SAD.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SAD.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_SAD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SAD.ChartAreas[0].AxisY.Title = "Ось Y";



                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_SAD.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_SAD.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void buttonResult_SAD_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_SAD.BackColor = Color.Red;
        }

        private void buttonResult_SAD_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_SAD.BackColor = Color.Green;
        }

        private void buttonResult_SAD_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_SAD.BackColor = Color.Blue;
        }

        private void buttonHelp_SAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-23-2 Сорокин Артём Дмитриевич", "Сообщение");
        }
    }
}
