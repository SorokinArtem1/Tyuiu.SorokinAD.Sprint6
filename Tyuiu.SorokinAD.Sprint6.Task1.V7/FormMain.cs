﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinAD.Sprint6.Task1.V7.Lib;

namespace Tyuiu.SorokinAD.Sprint6.Task1.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonOutput_SAD_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_SAD.Text);
                int stopStep = Convert.ToInt32(textBoxStop_SAD.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxOutput_SAD.Text = "";
                textBoxOutput_SAD.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxOutput_SAD.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxOutput_SAD.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}    |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxOutput_SAD.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxOutput_SAD.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-23-2 Сорокин Артём Дмитриевич");
        }
    }
}
