using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinAD.Sprint6.Task5.V11.Lib;

namespace Tyuiu.SorokinAD.Sprint6.Task5.V11
{
    public partial class FormMain_SAD : Form
    {
        public FormMain_SAD()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\blitz\source\repos\Tyuiu.SorokinAD.Sprint6\Tyuiu.SorokinAD.Sprint6.Task5.V11\bin\Debug\InPutFileTask5V11.txt";
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_SAD.ColumnCount = 2;
            dataGridViewOutPut_SAD.Columns[0].Width = 20;
            dataGridViewOutPut_SAD.Columns[1].Width = 50;

            this.chartDigit_SAD.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDigit_SAD.ChartAreas[0].AxisY.Title = "Ось Y";
            chartDigit_SAD.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewOutPut_SAD.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDigit_SAD.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-2 Сороокин Артём Дмитриевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewOutPut_SAD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
