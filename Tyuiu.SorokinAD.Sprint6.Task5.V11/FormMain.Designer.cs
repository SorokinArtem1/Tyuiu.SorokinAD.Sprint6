
namespace Tyuiu.SorokinAD.Sprint6.Task5.V11
{
    partial class FormMain_SAD
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelInput_SAD = new System.Windows.Forms.Panel();
            this.buttonHelp_SAD = new System.Windows.Forms.Button();
            this.buttonOpen_SAD = new System.Windows.Forms.Button();
            this.buttonResult_SAD = new System.Windows.Forms.Button();
            this.groupBoxTask_SAD = new System.Windows.Forms.GroupBox();
            this.labelTask_SAD = new System.Windows.Forms.Label();
            this.panelOutPut_SAD = new System.Windows.Forms.Panel();
            this.groupBoxOutput_SAD = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_SAD = new System.Windows.Forms.DataGridView();
            this.panelChart_SAD = new System.Windows.Forms.Panel();
            this.chartDigit_SAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter_SAD = new System.Windows.Forms.Splitter();
            this.panelInput_SAD.SuspendLayout();
            this.groupBoxTask_SAD.SuspendLayout();
            this.panelOutPut_SAD.SuspendLayout();
            this.groupBoxOutput_SAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAD)).BeginInit();
            this.panelChart_SAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDigit_SAD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput_SAD
            // 
            this.panelInput_SAD.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelInput_SAD.Controls.Add(this.buttonHelp_SAD);
            this.panelInput_SAD.Controls.Add(this.buttonOpen_SAD);
            this.panelInput_SAD.Controls.Add(this.buttonResult_SAD);
            this.panelInput_SAD.Controls.Add(this.groupBoxTask_SAD);
            this.panelInput_SAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput_SAD.Location = new System.Drawing.Point(0, 0);
            this.panelInput_SAD.Name = "panelInput_SAD";
            this.panelInput_SAD.Size = new System.Drawing.Size(825, 98);
            this.panelInput_SAD.TabIndex = 0;
            // 
            // buttonHelp_SAD
            // 
            this.buttonHelp_SAD.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonHelp_SAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAD.Location = new System.Drawing.Point(725, 12);
            this.buttonHelp_SAD.Name = "buttonHelp_SAD";
            this.buttonHelp_SAD.Size = new System.Drawing.Size(88, 79);
            this.buttonHelp_SAD.TabIndex = 1;
            this.buttonHelp_SAD.Text = "Справка";
            this.buttonHelp_SAD.UseVisualStyleBackColor = false;
            this.buttonHelp_SAD.Click += new System.EventHandler(this.buttonHelp_SAD_Click);
            // 
            // buttonOpen_SAD
            // 
            this.buttonOpen_SAD.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpen_SAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_SAD.Location = new System.Drawing.Point(620, 12);
            this.buttonOpen_SAD.Name = "buttonOpen_SAD";
            this.buttonOpen_SAD.Size = new System.Drawing.Size(88, 79);
            this.buttonOpen_SAD.TabIndex = 1;
            this.buttonOpen_SAD.Text = "Открыть файл";
            this.buttonOpen_SAD.UseVisualStyleBackColor = false;
            this.buttonOpen_SAD.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonResult_SAD
            // 
            this.buttonResult_SAD.BackColor = System.Drawing.Color.Green;
            this.buttonResult_SAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_SAD.Location = new System.Drawing.Point(512, 13);
            this.buttonResult_SAD.Name = "buttonResult_SAD";
            this.buttonResult_SAD.Size = new System.Drawing.Size(88, 79);
            this.buttonResult_SAD.TabIndex = 1;
            this.buttonResult_SAD.Text = "Выполнить";
            this.buttonResult_SAD.UseVisualStyleBackColor = false;
            this.buttonResult_SAD.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxTask_SAD
            // 
            this.groupBoxTask_SAD.Controls.Add(this.labelTask_SAD);
            this.groupBoxTask_SAD.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_SAD.Name = "groupBoxTask_SAD";
            this.groupBoxTask_SAD.Size = new System.Drawing.Size(483, 79);
            this.groupBoxTask_SAD.TabIndex = 0;
            this.groupBoxTask_SAD.TabStop = false;
            this.groupBoxTask_SAD.Text = "Условие";
            // 
            // labelTask_SAD
            // 
            this.labelTask_SAD.AutoSize = true;
            this.labelTask_SAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_SAD.Location = new System.Drawing.Point(6, 16);
            this.labelTask_SAD.Name = "labelTask_SAD";
            this.labelTask_SAD.Size = new System.Drawing.Size(449, 32);
            this.labelTask_SAD.TabIndex = 0;
            this.labelTask_SAD.Text = "Прочитать данные из файл InPutFileTask5.txt Вывести в dataGridView\r\nвсе числа, кр" +
    "атные 5. Построить диаграмму по этим значениям.";
            // 
            // panelOutPut_SAD
            // 
            this.panelOutPut_SAD.BackColor = System.Drawing.SystemColors.Info;
            this.panelOutPut_SAD.Controls.Add(this.groupBoxOutput_SAD);
            this.panelOutPut_SAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_SAD.Location = new System.Drawing.Point(0, 98);
            this.panelOutPut_SAD.Name = "panelOutPut_SAD";
            this.panelOutPut_SAD.Size = new System.Drawing.Size(202, 363);
            this.panelOutPut_SAD.TabIndex = 1;
            // 
            // groupBoxOutput_SAD
            // 
            this.groupBoxOutput_SAD.Controls.Add(this.dataGridViewOutPut_SAD);
            this.groupBoxOutput_SAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_SAD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_SAD.Name = "groupBoxOutput_SAD";
            this.groupBoxOutput_SAD.Size = new System.Drawing.Size(202, 363);
            this.groupBoxOutput_SAD.TabIndex = 0;
            this.groupBoxOutput_SAD.TabStop = false;
            this.groupBoxOutput_SAD.Text = "Вывод данных";
            // 
            // dataGridViewOutPut_SAD
            // 
            this.dataGridViewOutPut_SAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_SAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_SAD.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_SAD.Name = "dataGridViewOutPut_SAD";
            this.dataGridViewOutPut_SAD.Size = new System.Drawing.Size(196, 344);
            this.dataGridViewOutPut_SAD.TabIndex = 0;
            this.dataGridViewOutPut_SAD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutPut_SAD_CellContentClick);
            // 
            // panelChart_SAD
            // 
            this.panelChart_SAD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelChart_SAD.Controls.Add(this.chartDigit_SAD);
            this.panelChart_SAD.Controls.Add(this.splitter_SAD);
            this.panelChart_SAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_SAD.Location = new System.Drawing.Point(202, 98);
            this.panelChart_SAD.Name = "panelChart_SAD";
            this.panelChart_SAD.Size = new System.Drawing.Size(623, 363);
            this.panelChart_SAD.TabIndex = 2;
            // 
            // chartDigit_SAD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDigit_SAD.ChartAreas.Add(chartArea1);
            this.chartDigit_SAD.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDigit_SAD.Legends.Add(legend1);
            this.chartDigit_SAD.Location = new System.Drawing.Point(3, 0);
            this.chartDigit_SAD.Name = "chartDigit_SAD";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDigit_SAD.Series.Add(series1);
            this.chartDigit_SAD.Size = new System.Drawing.Size(620, 363);
            this.chartDigit_SAD.TabIndex = 1;
            this.chartDigit_SAD.Text = "chart1";
            // 
            // splitter_SAD
            // 
            this.splitter_SAD.Location = new System.Drawing.Point(0, 0);
            this.splitter_SAD.Name = "splitter_SAD";
            this.splitter_SAD.Size = new System.Drawing.Size(3, 363);
            this.splitter_SAD.TabIndex = 0;
            this.splitter_SAD.TabStop = false;
            // 
            // FormMain_SAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 461);
            this.Controls.Add(this.panelChart_SAD);
            this.Controls.Add(this.panelOutPut_SAD);
            this.Controls.Add(this.panelInput_SAD);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMain_SAD";
            this.ShowInTaskbar = false;
            this.Text = "Спринт 6 | Таск5 | Вариант 11 | Сорокин А.Д.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInput_SAD.ResumeLayout(false);
            this.groupBoxTask_SAD.ResumeLayout(false);
            this.groupBoxTask_SAD.PerformLayout();
            this.panelOutPut_SAD.ResumeLayout(false);
            this.groupBoxOutput_SAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_SAD)).EndInit();
            this.panelChart_SAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDigit_SAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput_SAD;
        private System.Windows.Forms.Panel panelOutPut_SAD;
        private System.Windows.Forms.Panel panelChart_SAD;
        private System.Windows.Forms.Splitter splitter_SAD;
        private System.Windows.Forms.Button buttonHelp_SAD;
        private System.Windows.Forms.Button buttonOpen_SAD;
        private System.Windows.Forms.Button buttonResult_SAD;
        private System.Windows.Forms.GroupBox groupBoxTask_SAD;
        private System.Windows.Forms.Label labelTask_SAD;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAD;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_SAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDigit_SAD;
    }
}

