
namespace Tyuiu.SorokinAD.Sprint6.Task0.V17
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.groupBoxDataService = new System.Windows.Forms.GroupBox();
            this.textBoxVariable = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxDataService.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask.Location = new System.Drawing.Point(23, 26);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(747, 259);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            this.groupBoxTask.UseWaitCursor = true;
            this.groupBoxTask.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(495, 200);
            this.textBoxTask.TabIndex = 3;
            this.textBoxTask.Text = "Вычислить выражение по формуле";
            this.textBoxTask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = global::Tyuiu.SorokinAD.Sprint6.Task0.V17.Properties.Resources.Screenshot_2;
            this.pictureBoxFormula.Location = new System.Drawing.Point(603, 19);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(95, 62);
            this.pictureBoxFormula.TabIndex = 2;
            this.pictureBoxFormula.TabStop = false;
            // 
            // groupBoxDataService
            // 
            this.groupBoxDataService.Controls.Add(this.textBoxVariable);
            this.groupBoxDataService.Controls.Add(this.textBoxInput);
            this.groupBoxDataService.Location = new System.Drawing.Point(23, 291);
            this.groupBoxDataService.Name = "groupBoxDataService";
            this.groupBoxDataService.Size = new System.Drawing.Size(450, 104);
            this.groupBoxDataService.TabIndex = 1;
            this.groupBoxDataService.TabStop = false;
            this.groupBoxDataService.Text = "Ввод данных";
            // 
            // textBoxVariable
            // 
            this.textBoxVariable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxVariable.Location = new System.Drawing.Point(178, 19);
            this.textBoxVariable.Name = "textBoxVariable";
            this.textBoxVariable.ReadOnly = true;
            this.textBoxVariable.Size = new System.Drawing.Size(100, 20);
            this.textBoxVariable.TabIndex = 1;
            this.textBoxVariable.Text = "Переменная X:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(178, 62);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxOutput);
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(498, 291);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(272, 104);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxOutput.Location = new System.Drawing.Point(47, 62);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(176, 20);
            this.textBoxOutput.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxResult.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.Text = "Результат";
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult.Location = new System.Drawing.Point(637, 401);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(133, 37);
            this.buttonResult.TabIndex = 3;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(591, 401);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(37, 37);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxDataService);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт6 | Таск0 | Вариант 17 | Сорокин А.Д.";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxDataService.ResumeLayout(false);
            this.groupBoxDataService.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxDataService;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxVariable;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonHelp;
    }
}

