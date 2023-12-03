
namespace Tyuiu.SorokinAD.Sprint6.Task1.V7
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
            this.groupBoxTask_SAD = new System.Windows.Forms.GroupBox();
            this.labelTask_SAD = new System.Windows.Forms.Label();
            this.groupBoxInput_SAD = new System.Windows.Forms.GroupBox();
            this.textBoxStop_SAD = new System.Windows.Forms.TextBox();
            this.textBoxStart_SAD = new System.Windows.Forms.TextBox();
            this.labelStop_SAD = new System.Windows.Forms.Label();
            this.labelStart_SAD = new System.Windows.Forms.Label();
            this.groupBoxOutput_SAD = new System.Windows.Forms.GroupBox();
            this.labelResult_SAD = new System.Windows.Forms.Label();
            this.textBoxOutput_SAD = new System.Windows.Forms.TextBox();
            this.buttonHelp_SAD = new System.Windows.Forms.Button();
            this.buttonOutput_SAD = new System.Windows.Forms.Button();
            this.groupBoxTask_SAD.SuspendLayout();
            this.groupBoxInput_SAD.SuspendLayout();
            this.groupBoxOutput_SAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAD
            // 
            this.groupBoxTask_SAD.Controls.Add(this.labelTask_SAD);
            this.groupBoxTask_SAD.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SAD.Name = "groupBoxTask_SAD";
            this.groupBoxTask_SAD.Size = new System.Drawing.Size(504, 323);
            this.groupBoxTask_SAD.TabIndex = 0;
            this.groupBoxTask_SAD.TabStop = false;
            this.groupBoxTask_SAD.Text = "Условие";
            // 
            // labelTask_SAD
            // 
            this.labelTask_SAD.AutoSize = true;
            this.labelTask_SAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_SAD.Location = new System.Drawing.Point(6, 29);
            this.labelTask_SAD.Name = "labelTask_SAD";
            this.labelTask_SAD.Size = new System.Drawing.Size(365, 60);
            this.labelTask_SAD.TabIndex = 0;
            this.labelTask_SAD.Text = "Протабулировать функцию ((2x-3)/(cos(x)+5))+5\r\nна заданном диапазоне.\r\nРезультат " +
    "вывести в виде таблицы";
            // 
            // groupBoxInput_SAD
            // 
            this.groupBoxInput_SAD.Controls.Add(this.textBoxStop_SAD);
            this.groupBoxInput_SAD.Controls.Add(this.textBoxStart_SAD);
            this.groupBoxInput_SAD.Controls.Add(this.labelStop_SAD);
            this.groupBoxInput_SAD.Controls.Add(this.labelStart_SAD);
            this.groupBoxInput_SAD.Location = new System.Drawing.Point(12, 341);
            this.groupBoxInput_SAD.Name = "groupBoxInput_SAD";
            this.groupBoxInput_SAD.Size = new System.Drawing.Size(276, 97);
            this.groupBoxInput_SAD.TabIndex = 1;
            this.groupBoxInput_SAD.TabStop = false;
            this.groupBoxInput_SAD.Text = "Ввод данных";
            // 
            // textBoxStop_SAD
            // 
            this.textBoxStop_SAD.Location = new System.Drawing.Point(144, 62);
            this.textBoxStop_SAD.Name = "textBoxStop_SAD";
            this.textBoxStop_SAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SAD.TabIndex = 3;
            // 
            // textBoxStart_SAD
            // 
            this.textBoxStart_SAD.Location = new System.Drawing.Point(6, 62);
            this.textBoxStart_SAD.Name = "textBoxStart_SAD";
            this.textBoxStart_SAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SAD.TabIndex = 2;
            // 
            // labelStop_SAD
            // 
            this.labelStop_SAD.AutoSize = true;
            this.labelStop_SAD.Location = new System.Drawing.Point(141, 31);
            this.labelStop_SAD.Name = "labelStop_SAD";
            this.labelStop_SAD.Size = new System.Drawing.Size(69, 13);
            this.labelStop_SAD.TabIndex = 1;
            this.labelStop_SAD.Text = "Конец шага:";
            // 
            // labelStart_SAD
            // 
            this.labelStart_SAD.AutoSize = true;
            this.labelStart_SAD.Location = new System.Drawing.Point(6, 31);
            this.labelStart_SAD.Name = "labelStart_SAD";
            this.labelStart_SAD.Size = new System.Drawing.Size(67, 13);
            this.labelStart_SAD.TabIndex = 0;
            this.labelStart_SAD.Text = "Старт шага:";
            // 
            // groupBoxOutput_SAD
            // 
            this.groupBoxOutput_SAD.Controls.Add(this.labelResult_SAD);
            this.groupBoxOutput_SAD.Controls.Add(this.textBoxOutput_SAD);
            this.groupBoxOutput_SAD.Location = new System.Drawing.Point(522, 12);
            this.groupBoxOutput_SAD.Name = "groupBoxOutput_SAD";
            this.groupBoxOutput_SAD.Size = new System.Drawing.Size(266, 426);
            this.groupBoxOutput_SAD.TabIndex = 2;
            this.groupBoxOutput_SAD.TabStop = false;
            this.groupBoxOutput_SAD.Text = "Вывод данных";
            // 
            // labelResult_SAD
            // 
            this.labelResult_SAD.AutoSize = true;
            this.labelResult_SAD.Location = new System.Drawing.Point(7, 29);
            this.labelResult_SAD.Name = "labelResult_SAD";
            this.labelResult_SAD.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SAD.TabIndex = 1;
            this.labelResult_SAD.Text = "Результат:";
            // 
            // textBoxOutput_SAD
            // 
            this.textBoxOutput_SAD.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutput_SAD.Location = new System.Drawing.Point(10, 57);
            this.textBoxOutput_SAD.Multiline = true;
            this.textBoxOutput_SAD.Name = "textBoxOutput_SAD";
            this.textBoxOutput_SAD.ReadOnly = true;
            this.textBoxOutput_SAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_SAD.Size = new System.Drawing.Size(250, 363);
            this.textBoxOutput_SAD.TabIndex = 0;
            this.textBoxOutput_SAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonHelp_SAD
            // 
            this.buttonHelp_SAD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_SAD.Location = new System.Drawing.Point(294, 351);
            this.buttonHelp_SAD.Name = "buttonHelp_SAD";
            this.buttonHelp_SAD.Size = new System.Drawing.Size(85, 87);
            this.buttonHelp_SAD.TabIndex = 4;
            this.buttonHelp_SAD.Text = "Справка";
            this.buttonHelp_SAD.UseVisualStyleBackColor = false;
            this.buttonHelp_SAD.Click += new System.EventHandler(this.buttonHelp_SAD_Click);
            // 
            // buttonOutput_SAD
            // 
            this.buttonOutput_SAD.BackColor = System.Drawing.Color.Green;
            this.buttonOutput_SAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutput_SAD.Location = new System.Drawing.Point(385, 351);
            this.buttonOutput_SAD.Name = "buttonOutput_SAD";
            this.buttonOutput_SAD.Size = new System.Drawing.Size(131, 87);
            this.buttonOutput_SAD.TabIndex = 5;
            this.buttonOutput_SAD.Text = "Выполнить";
            this.buttonOutput_SAD.UseVisualStyleBackColor = false;
            this.buttonOutput_SAD.Click += new System.EventHandler(this.buttonOutput_SAD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOutput_SAD);
            this.Controls.Add(this.buttonHelp_SAD);
            this.Controls.Add(this.groupBoxOutput_SAD);
            this.Controls.Add(this.groupBoxInput_SAD);
            this.Controls.Add(this.groupBoxTask_SAD);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт6 | Таск1 | Вариант 7 | Сорокин А.Д.";
            this.groupBoxTask_SAD.ResumeLayout(false);
            this.groupBoxTask_SAD.PerformLayout();
            this.groupBoxInput_SAD.ResumeLayout(false);
            this.groupBoxInput_SAD.PerformLayout();
            this.groupBoxOutput_SAD.ResumeLayout(false);
            this.groupBoxOutput_SAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAD;
        private System.Windows.Forms.GroupBox groupBoxInput_SAD;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAD;
        private System.Windows.Forms.TextBox textBoxOutput_SAD;
        private System.Windows.Forms.Label labelTask_SAD;
        private System.Windows.Forms.TextBox textBoxStop_SAD;
        private System.Windows.Forms.TextBox textBoxStart_SAD;
        private System.Windows.Forms.Label labelStop_SAD;
        private System.Windows.Forms.Label labelStart_SAD;
        private System.Windows.Forms.Label labelResult_SAD;
        private System.Windows.Forms.Button buttonHelp_SAD;
        private System.Windows.Forms.Button buttonOutput_SAD;
    }
}

