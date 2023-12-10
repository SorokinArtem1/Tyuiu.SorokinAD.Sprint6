using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SorokinAD.Sprint6.Task6.V22.Lib;
using System.IO;

namespace Tyuiu.SorokinAD.Sprint6.Task6.V22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SAD.ShowDialog();
            openFilePath = openFileDialogTask_SAD.FileName;
            textBoxInput_SAD.Text = File.ReadAllText(openFilePath);
            groupBoxOutput_SAD.Text = groupBoxOutput_SAD.Text + " " + openFileDialogTask_SAD.FileName;
            buttonResult_SAD.Enabled = true;

        }

        private void buttonResult_SAD_Click(object sender, EventArgs e)
        {
            string str = "**";
            textBoxOutput_SAD.Text = ds.CollectTextFromFile(str, openFilePath);
        }
    }
}
