
namespace Tyuiu.SorokinAD.Sprint6.Task2.V21
{
    partial class Form1
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
            this.groupBoxTask_SAD = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_SAD = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_SAD = new System.Windows.Forms.GroupBox();
            this.labelTask_SAD = new System.Windows.Forms.Label();
            this.labelResult_SAD = new System.Windows.Forms.Label();
            this.labelStart_SAD = new System.Windows.Forms.Label();
            this.labelStop_SAD = new System.Windows.Forms.Label();
            this.textBoxStart_SAD = new System.Windows.Forms.TextBox();
            this.textBoxStop_SAD = new System.Windows.Forms.TextBox();
            this.buttonHelp_SAD = new System.Windows.Forms.Button();
            this.buttonResult_SAD = new System.Windows.Forms.Button();
            this.dataGridViewResult_SAD = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_SAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_SAD.SuspendLayout();
            this.groupBoxInput_SAD.SuspendLayout();
            this.groupBoxOutput_SAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAD
            // 
            this.groupBoxTask_SAD.Controls.Add(this.labelTask_SAD);
            this.groupBoxTask_SAD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAD.Name = "groupBoxTask_SAD";
            this.groupBoxTask_SAD.Size = new System.Drawing.Size(410, 322);
            this.groupBoxTask_SAD.TabIndex = 0;
            this.groupBoxTask_SAD.TabStop = false;
            this.groupBoxTask_SAD.Text = "Условие";
            // 
            // groupBoxInput_SAD
            // 
            this.groupBoxInput_SAD.Controls.Add(this.textBoxStop_SAD);
            this.groupBoxInput_SAD.Controls.Add(this.textBoxStart_SAD);
            this.groupBoxInput_SAD.Controls.Add(this.labelStop_SAD);
            this.groupBoxInput_SAD.Controls.Add(this.labelStart_SAD);
            this.groupBoxInput_SAD.Location = new System.Drawing.Point(12, 340);
            this.groupBoxInput_SAD.Name = "groupBoxInput_SAD";
            this.groupBoxInput_SAD.Size = new System.Drawing.Size(242, 98);
            this.groupBoxInput_SAD.TabIndex = 1;
            this.groupBoxInput_SAD.TabStop = false;
            this.groupBoxInput_SAD.Text = "Ввод данных";
            // 
            // groupBoxOutput_SAD
            // 
            this.groupBoxOutput_SAD.Controls.Add(this.chartFunction_SAD);
            this.groupBoxOutput_SAD.Controls.Add(this.dataGridViewResult_SAD);
            this.groupBoxOutput_SAD.Controls.Add(this.labelResult_SAD);
            this.groupBoxOutput_SAD.Location = new System.Drawing.Point(439, 12);
            this.groupBoxOutput_SAD.Name = "groupBoxOutput_SAD";
            this.groupBoxOutput_SAD.Size = new System.Drawing.Size(549, 426);
            this.groupBoxOutput_SAD.TabIndex = 2;
            this.groupBoxOutput_SAD.TabStop = false;
            this.groupBoxOutput_SAD.Text = "Вывод данных";
            // 
            // labelTask_SAD
            // 
            this.labelTask_SAD.AutoSize = true;
            this.labelTask_SAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_SAD.Location = new System.Drawing.Point(6, 26);
            this.labelTask_SAD.Name = "labelTask_SAD";
            this.labelTask_SAD.Size = new System.Drawing.Size(366, 48);
            this.labelTask_SAD.TabIndex = 0;
            this.labelTask_SAD.Text = "Протабулировать функцию cos(x)+(cos(x)/(x+2))-3x\r\nна заданном диапазоне.\r\nРезульт" +
    "ат вывести в DataGridView и построить график";
            // 
            // labelResult_SAD
            // 
            this.labelResult_SAD.AutoSize = true;
            this.labelResult_SAD.Location = new System.Drawing.Point(6, 26);
            this.labelResult_SAD.Name = "labelResult_SAD";
            this.labelResult_SAD.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SAD.TabIndex = 0;
            this.labelResult_SAD.Text = "Результат:";
            // 
            // labelStart_SAD
            // 
            this.labelStart_SAD.AutoSize = true;
            this.labelStart_SAD.Location = new System.Drawing.Point(6, 29);
            this.labelStart_SAD.Name = "labelStart_SAD";
            this.labelStart_SAD.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SAD.TabIndex = 0;
            this.labelStart_SAD.Text = "Старт шага:";
            // 
            // labelStop_SAD
            // 
            this.labelStop_SAD.AutoSize = true;
            this.labelStop_SAD.Location = new System.Drawing.Point(126, 29);
            this.labelStop_SAD.Name = "labelStop_SAD";
            this.labelStop_SAD.Size = new System.Drawing.Size(69, 13);
            this.labelStop_SAD.TabIndex = 1;
            this.labelStop_SAD.Text = "Конец шага:";
            // 
            // textBoxStart_SAD
            // 
            this.textBoxStart_SAD.Location = new System.Drawing.Point(7, 58);
            this.textBoxStart_SAD.Name = "textBoxStart_SAD";
            this.textBoxStart_SAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SAD.TabIndex = 2;
            // 
            // textBoxStop_SAD
            // 
            this.textBoxStop_SAD.Location = new System.Drawing.Point(129, 58);
            this.textBoxStop_SAD.Name = "textBoxStop_SAD";
            this.textBoxStop_SAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SAD.TabIndex = 3;
            // 
            // buttonHelp_SAD
            // 
            this.buttonHelp_SAD.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_SAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAD.Location = new System.Drawing.Point(260, 350);
            this.buttonHelp_SAD.Name = "buttonHelp_SAD";
            this.buttonHelp_SAD.Size = new System.Drawing.Size(74, 88);
            this.buttonHelp_SAD.TabIndex = 3;
            this.buttonHelp_SAD.Text = "Справка";
            this.buttonHelp_SAD.UseVisualStyleBackColor = false;
            this.buttonHelp_SAD.Click += new System.EventHandler(this.buttonHelp_SAD_Click);
            // 
            // buttonResult_SAD
            // 
            this.buttonResult_SAD.BackColor = System.Drawing.Color.Green;
            this.buttonResult_SAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_SAD.Location = new System.Drawing.Point(340, 350);
            this.buttonResult_SAD.Name = "buttonResult_SAD";
            this.buttonResult_SAD.Size = new System.Drawing.Size(93, 88);
            this.buttonResult_SAD.TabIndex = 4;
            this.buttonResult_SAD.Text = "Выполнить";
            this.buttonResult_SAD.UseVisualStyleBackColor = false;
            this.buttonResult_SAD.Click += new System.EventHandler(this.buttonResult_SAD_Click);
            this.buttonResult_SAD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_SAD_MouseDown);
            this.buttonResult_SAD.MouseEnter += new System.EventHandler(this.buttonResult_SAD_MouseEnter);
            this.buttonResult_SAD.MouseLeave += new System.EventHandler(this.buttonResult_SAD_MouseLeave);
            // 
            // dataGridViewResult_SAD
            // 
            this.dataGridViewResult_SAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SAD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewResult_SAD.Location = new System.Drawing.Point(9, 42);
            this.dataGridViewResult_SAD.Name = "dataGridViewResult_SAD";
            this.dataGridViewResult_SAD.RowHeadersVisible = false;
            this.dataGridViewResult_SAD.Size = new System.Drawing.Size(136, 378);
            this.dataGridViewResult_SAD.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // chartFunction_SAD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SAD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SAD.Legends.Add(legend1);
            this.chartFunction_SAD.Location = new System.Drawing.Point(161, 42);
            this.chartFunction_SAD.Name = "chartFunction_SAD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SAD.Series.Add(series1);
            this.chartFunction_SAD.Size = new System.Drawing.Size(529, 378);
            this.chartFunction_SAD.TabIndex = 3;
            this.chartFunction_SAD.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.buttonResult_SAD);
            this.Controls.Add(this.buttonHelp_SAD);
            this.Controls.Add(this.groupBoxOutput_SAD);
            this.Controls.Add(this.groupBoxInput_SAD);
            this.Controls.Add(this.groupBoxTask_SAD);
            this.Name = "Form1";
            this.Text = "Спринт 6 | Таск2 | Вариант 21 | Сорокин А.Д.";
            this.groupBoxTask_SAD.ResumeLayout(false);
            this.groupBoxTask_SAD.PerformLayout();
            this.groupBoxInput_SAD.ResumeLayout(false);
            this.groupBoxInput_SAD.PerformLayout();
            this.groupBoxOutput_SAD.ResumeLayout(false);
            this.groupBoxOutput_SAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SAD)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxOutput_SAD;
        private System.Windows.Forms.Label labelResult_SAD;
        private System.Windows.Forms.Button buttonHelp_SAD;
        private System.Windows.Forms.Button buttonResult_SAD;
        private System.Windows.Forms.DataGridView dataGridViewResult_SAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SAD;
    }
}

