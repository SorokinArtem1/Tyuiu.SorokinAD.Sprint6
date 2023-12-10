
namespace Tyuiu.SorokinAD.Sprint6.Task4.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_SAD = new System.Windows.Forms.GroupBox();
            this.labelTask_SAD = new System.Windows.Forms.Label();
            this.groupBoxInput_SAD = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SAD = new System.Windows.Forms.TextBox();
            this.textBoxStart_SAD = new System.Windows.Forms.TextBox();
            this.labelStop_SAD = new System.Windows.Forms.Label();
            this.labelStart_SAD = new System.Windows.Forms.Label();
            this.buttonResult_SAD = new System.Windows.Forms.Button();
            this.buttonSave_SAD = new System.Windows.Forms.Button();
            this.buttonHelp_SAD = new System.Windows.Forms.Button();
            this.groupBoxOutput_SAD = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_SAD = new System.Windows.Forms.TextBox();
            this.chartFunction_SAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelOutPut = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelChart = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.groupBoxTask_SAD.SuspendLayout();
            this.groupBoxInput_SAD.SuspendLayout();
            this.groupBoxOutput_SAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAD)).BeginInit();
            this.panelOutPut.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAD
            // 
            this.groupBoxTask_SAD.Controls.Add(this.splitter4);
            this.groupBoxTask_SAD.Controls.Add(this.labelTask_SAD);
            this.groupBoxTask_SAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_SAD.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTask_SAD.Name = "groupBoxTask_SAD";
            this.groupBoxTask_SAD.Size = new System.Drawing.Size(336, 79);
            this.groupBoxTask_SAD.TabIndex = 0;
            this.groupBoxTask_SAD.TabStop = false;
            this.groupBoxTask_SAD.Text = "Условие";
            this.groupBoxTask_SAD.Enter += new System.EventHandler(this.groupBoxTask_SAD_Enter);
            // 
            // labelTask_SAD
            // 
            this.labelTask_SAD.AutoSize = true;
            this.labelTask_SAD.Location = new System.Drawing.Point(6, 16);
            this.labelTask_SAD.Name = "labelTask_SAD";
            this.labelTask_SAD.Size = new System.Drawing.Size(319, 39);
            this.labelTask_SAD.TabIndex = 0;
            this.labelTask_SAD.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5\r\nРезультат вывести в tex" +
    "tBox, построить график функции и \r\nсохранить в файл OutPutFileTask.txt по нажати" +
    "и кнопки";
            // 
            // groupBoxInput_SAD
            // 
            this.groupBoxInput_SAD.Controls.Add(this.textBoxStop_SAD);
            this.groupBoxInput_SAD.Controls.Add(this.textBoxStart_SAD);
            this.groupBoxInput_SAD.Controls.Add(this.labelStop_SAD);
            this.groupBoxInput_SAD.Controls.Add(this.labelStart_SAD);
            this.groupBoxInput_SAD.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxInput_SAD.Location = new System.Drawing.Point(337, 5);
            this.groupBoxInput_SAD.Name = "groupBoxInput_SAD";
            this.groupBoxInput_SAD.Size = new System.Drawing.Size(309, 79);
            this.groupBoxInput_SAD.TabIndex = 1;
            this.groupBoxInput_SAD.TabStop = false;
            this.groupBoxInput_SAD.Text = "Вывод данных";
            // 
            // textBoxStop_SAD
            // 
            this.textBoxStop_SAD.Location = new System.Drawing.Point(122, 44);
            this.textBoxStop_SAD.Name = "textBoxStop_SAD";
            this.textBoxStop_SAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SAD.TabIndex = 3;
            // 
            // textBoxStart_SAD
            // 
            this.textBoxStart_SAD.Location = new System.Drawing.Point(9, 44);
            this.textBoxStart_SAD.Name = "textBoxStart_SAD";
            this.textBoxStart_SAD.Size = new System.Drawing.Size(93, 20);
            this.textBoxStart_SAD.TabIndex = 2;
            this.textBoxStart_SAD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelStop_SAD
            // 
            this.labelStop_SAD.AutoSize = true;
            this.labelStop_SAD.Location = new System.Drawing.Point(119, 20);
            this.labelStop_SAD.Name = "labelStop_SAD";
            this.labelStop_SAD.Size = new System.Drawing.Size(69, 13);
            this.labelStop_SAD.TabIndex = 1;
            this.labelStop_SAD.Text = "Конец шага:";
            // 
            // labelStart_SAD
            // 
            this.labelStart_SAD.AutoSize = true;
            this.labelStart_SAD.Location = new System.Drawing.Point(6, 20);
            this.labelStart_SAD.Name = "labelStart_SAD";
            this.labelStart_SAD.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SAD.TabIndex = 0;
            this.labelStart_SAD.Text = "Старт шага:";
            // 
            // buttonResult_SAD
            // 
            this.buttonResult_SAD.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonResult_SAD.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonResult_SAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_SAD.Location = new System.Drawing.Point(724, 5);
            this.buttonResult_SAD.Name = "buttonResult_SAD";
            this.buttonResult_SAD.Size = new System.Drawing.Size(79, 79);
            this.buttonResult_SAD.TabIndex = 2;
            this.buttonResult_SAD.Text = "Выполнить";
            this.buttonResult_SAD.UseVisualStyleBackColor = false;
            this.buttonResult_SAD.Click += new System.EventHandler(this.buttonResult_SAD_Click);
            // 
            // buttonSave_SAD
            // 
            this.buttonSave_SAD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_SAD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_SAD.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSave_SAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_SAD.Location = new System.Drawing.Point(803, 5);
            this.buttonSave_SAD.Name = "buttonSave_SAD";
            this.buttonSave_SAD.Size = new System.Drawing.Size(76, 79);
            this.buttonSave_SAD.TabIndex = 3;
            this.buttonSave_SAD.Text = "Сохранить";
            this.buttonSave_SAD.UseVisualStyleBackColor = false;
            this.buttonSave_SAD.Click += new System.EventHandler(this.buttonSave_SAD_Click);
            this.buttonSave_SAD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSave_SAD_MouseClick);
            // 
            // buttonHelp_SAD
            // 
            this.buttonHelp_SAD.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonHelp_SAD.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_SAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAD.Location = new System.Drawing.Point(646, 5);
            this.buttonHelp_SAD.Name = "buttonHelp_SAD";
            this.buttonHelp_SAD.Size = new System.Drawing.Size(78, 79);
            this.buttonHelp_SAD.TabIndex = 4;
            this.buttonHelp_SAD.Text = "Справка";
            this.buttonHelp_SAD.UseVisualStyleBackColor = false;
            this.buttonHelp_SAD.Click += new System.EventHandler(this.buttonHelp_SAD_Click);
            // 
            // groupBoxOutput_SAD
            // 
            this.groupBoxOutput_SAD.Controls.Add(this.textBoxOutPut_SAD);
            this.groupBoxOutput_SAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_SAD.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutput_SAD.Name = "groupBoxOutput_SAD";
            this.groupBoxOutput_SAD.Size = new System.Drawing.Size(184, 351);
            this.groupBoxOutput_SAD.TabIndex = 5;
            this.groupBoxOutput_SAD.TabStop = false;
            this.groupBoxOutput_SAD.Text = "Вывод:";
            // 
            // textBoxOutPut_SAD
            // 
            this.textBoxOutPut_SAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_SAD.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPut_SAD.Multiline = true;
            this.textBoxOutPut_SAD.Name = "textBoxOutPut_SAD";
            this.textBoxOutPut_SAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_SAD.Size = new System.Drawing.Size(178, 332);
            this.textBoxOutPut_SAD.TabIndex = 0;
            // 
            // chartFunction_SAD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SAD.ChartAreas.Add(chartArea1);
            this.chartFunction_SAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFunction_SAD.Location = new System.Drawing.Point(194, 89);
            this.chartFunction_SAD.Name = "chartFunction_SAD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chartFunction_SAD.Series.Add(series1);
            this.chartFunction_SAD.Size = new System.Drawing.Size(690, 361);
            this.chartFunction_SAD.TabIndex = 6;
            this.chartFunction_SAD.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.MidnightBlue;
            title1.Name = "TitleFunction";
            title1.Text = "График функции ((2x-3)/(cos(x)+x))-3";
            this.chartFunction_SAD.Titles.Add(title1);
            // 
            // panelOutPut
            // 
            this.panelOutPut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelOutPut.Controls.Add(this.groupBoxOutput_SAD);
            this.panelOutPut.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut.Location = new System.Drawing.Point(0, 89);
            this.panelOutPut.Name = "panelOutPut";
            this.panelOutPut.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutPut.Size = new System.Drawing.Size(194, 361);
            this.panelOutPut.TabIndex = 1;
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelInput.Controls.Add(this.groupBoxTask_SAD);
            this.panelInput.Controls.Add(this.groupBoxInput_SAD);
            this.panelInput.Controls.Add(this.buttonHelp_SAD);
            this.panelInput.Controls.Add(this.buttonResult_SAD);
            this.panelInput.Controls.Add(this.buttonSave_SAD);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(5);
            this.panelInput.Size = new System.Drawing.Size(884, 89);
            this.panelInput.TabIndex = 0;
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelChart.Controls.Add(this.splitter3);
            this.panelChart.Controls.Add(this.splitter2);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(194, 89);
            this.panelChart.Name = "panelChart";
            this.panelChart.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelChart.Size = new System.Drawing.Size(690, 361);
            this.panelChart.TabIndex = 7;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(194, 89);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 361);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(5, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 361);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(8, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 361);
            this.splitter3.TabIndex = 1;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(3, 16);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 60);
            this.splitter4.TabIndex = 1;
            this.splitter4.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.chartFunction_SAD);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelOutPut);
            this.Controls.Add(this.panelInput);
            this.MinimumSize = new System.Drawing.Size(900, 489);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск4 | Вариант 4 | Сорокин А.Д.";
            this.groupBoxTask_SAD.ResumeLayout(false);
            this.groupBoxTask_SAD.PerformLayout();
            this.groupBoxInput_SAD.ResumeLayout(false);
            this.groupBoxInput_SAD.PerformLayout();
            this.groupBoxOutput_SAD.ResumeLayout(false);
            this.groupBoxOutput_SAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAD)).EndInit();
            this.panelOutPut.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAD;
        private System.Windows.Forms.Label labelTask_SAD;
        private System.Windows.Forms.GroupBox groupBoxInput_SAD;
        private System.Windows.Forms.TextBox textBoxStop_SAD;
        private System.Windows.Forms.TextBox textBoxStart_SAD;
        private System.Windows.Forms.Label labelStop_SAD;
        private System.Windows.Forms.Label labelStart_SAD;
        private System.Windows.Forms.Button buttonResult_SAD;
        private System.Windows.Forms.Button buttonSave_SAD;
        private System.Windows.Forms.Button buttonHelp_SAD;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAD;
        private System.Windows.Forms.TextBox textBoxOutPut_SAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAD;
        private System.Windows.Forms.Panel panelOutPut;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter3;
    }
}

