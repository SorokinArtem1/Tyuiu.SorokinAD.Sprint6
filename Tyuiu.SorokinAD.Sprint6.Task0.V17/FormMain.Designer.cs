
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
            this.groupBoxTask_SAD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SAD = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_SAD = new System.Windows.Forms.PictureBox();
            this.groupBoxDataService_SAD = new System.Windows.Forms.GroupBox();
            this.textBoxVariable_SAD = new System.Windows.Forms.TextBox();
            this.textBoxInput_SAD = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SAD = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_SAD = new System.Windows.Forms.TextBox();
            this.textBoxResult_SAD = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask_SAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAD)).BeginInit();
            this.groupBoxDataService_SAD.SuspendLayout();
            this.groupBoxResult_SAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAD
            // 
            this.groupBoxTask_SAD.Controls.Add(this.textBoxTask_SAD);
            this.groupBoxTask_SAD.Controls.Add(this.pictureBoxFormula_SAD);
            this.groupBoxTask_SAD.Location = new System.Drawing.Point(23, 26);
            this.groupBoxTask_SAD.Name = "groupBoxTask_SAD";
            this.groupBoxTask_SAD.Size = new System.Drawing.Size(747, 259);
            this.groupBoxTask_SAD.TabIndex = 0;
            this.groupBoxTask_SAD.TabStop = false;
            this.groupBoxTask_SAD.Text = "Условие";
            this.groupBoxTask_SAD.UseWaitCursor = true;
            this.groupBoxTask_SAD.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxTask_SAD
            // 
            this.textBoxTask_SAD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxTask_SAD.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SAD.Multiline = true;
            this.textBoxTask_SAD.Name = "textBoxTask_SAD";
            this.textBoxTask_SAD.ReadOnly = true;
            this.textBoxTask_SAD.Size = new System.Drawing.Size(495, 200);
            this.textBoxTask_SAD.TabIndex = 3;
            this.textBoxTask_SAD.Text = "Вычислить выражение по формуле\r\nОкруглить до трёх знаков после запятой.";
            this.textBoxTask_SAD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBoxFormula_SAD
            // 
            this.pictureBoxFormula_SAD.Image = global::Tyuiu.SorokinAD.Sprint6.Task0.V17.Properties.Resources.Screenshot_2;
            this.pictureBoxFormula_SAD.Location = new System.Drawing.Point(603, 19);
            this.pictureBoxFormula_SAD.Name = "pictureBoxFormula_SAD";
            this.pictureBoxFormula_SAD.Size = new System.Drawing.Size(95, 62);
            this.pictureBoxFormula_SAD.TabIndex = 2;
            this.pictureBoxFormula_SAD.TabStop = false;
            this.pictureBoxFormula_SAD.UseWaitCursor = true;
            // 
            // groupBoxDataService_SAD
            // 
            this.groupBoxDataService_SAD.Controls.Add(this.textBoxVariable_SAD);
            this.groupBoxDataService_SAD.Controls.Add(this.textBoxInput_SAD);
            this.groupBoxDataService_SAD.Location = new System.Drawing.Point(23, 291);
            this.groupBoxDataService_SAD.Name = "groupBoxDataService_SAD";
            this.groupBoxDataService_SAD.Size = new System.Drawing.Size(450, 104);
            this.groupBoxDataService_SAD.TabIndex = 1;
            this.groupBoxDataService_SAD.TabStop = false;
            this.groupBoxDataService_SAD.Text = "Ввод данных";
            // 
            // textBoxVariable_SAD
            // 
            this.textBoxVariable_SAD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxVariable_SAD.Location = new System.Drawing.Point(178, 19);
            this.textBoxVariable_SAD.Name = "textBoxVariable_SAD";
            this.textBoxVariable_SAD.ReadOnly = true;
            this.textBoxVariable_SAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxVariable_SAD.TabIndex = 1;
            this.textBoxVariable_SAD.Text = "Переменная X:";
            // 
            // textBoxInput_SAD
            // 
            this.textBoxInput_SAD.Location = new System.Drawing.Point(178, 62);
            this.textBoxInput_SAD.Name = "textBoxInput_SAD";
            this.textBoxInput_SAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput_SAD.TabIndex = 0;
            this.textBoxInput_SAD.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            this.textBoxInput_SAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupBoxResult_SAD
            // 
            this.groupBoxResult_SAD.Controls.Add(this.textBoxOutput_SAD);
            this.groupBoxResult_SAD.Controls.Add(this.textBoxResult_SAD);
            this.groupBoxResult_SAD.Location = new System.Drawing.Point(498, 291);
            this.groupBoxResult_SAD.Name = "groupBoxResult_SAD";
            this.groupBoxResult_SAD.Size = new System.Drawing.Size(272, 104);
            this.groupBoxResult_SAD.TabIndex = 2;
            this.groupBoxResult_SAD.TabStop = false;
            this.groupBoxResult_SAD.Text = "Вывод данных";
            // 
            // textBoxOutput_SAD
            // 
            this.textBoxOutput_SAD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxOutput_SAD.Location = new System.Drawing.Point(47, 62);
            this.textBoxOutput_SAD.Name = "textBoxOutput_SAD";
            this.textBoxOutput_SAD.ReadOnly = true;
            this.textBoxOutput_SAD.Size = new System.Drawing.Size(176, 20);
            this.textBoxOutput_SAD.TabIndex = 1;
            // 
            // textBoxResult_SAD
            // 
            this.textBoxResult_SAD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxResult_SAD.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_SAD.Name = "textBoxResult_SAD";
            this.textBoxResult_SAD.ReadOnly = true;
            this.textBoxResult_SAD.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_SAD.TabIndex = 0;
            this.textBoxResult_SAD.Text = "Результат";
            this.textBoxResult_SAD.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
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
            this.Controls.Add(this.groupBoxResult_SAD);
            this.Controls.Add(this.groupBoxDataService_SAD);
            this.Controls.Add(this.groupBoxTask_SAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт6 | Таск0 | Вариант 17 | Сорокин А.Д.";
            this.groupBoxTask_SAD.ResumeLayout(false);
            this.groupBoxTask_SAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SAD)).EndInit();
            this.groupBoxDataService_SAD.ResumeLayout(false);
            this.groupBoxDataService_SAD.PerformLayout();
            this.groupBoxResult_SAD.ResumeLayout(false);
            this.groupBoxResult_SAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SAD;
        private System.Windows.Forms.GroupBox groupBoxDataService_SAD;
        private System.Windows.Forms.GroupBox groupBoxResult_SAD;
        private System.Windows.Forms.TextBox textBoxTask_SAD;
        private System.Windows.Forms.TextBox textBoxInput_SAD;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SAD;
        private System.Windows.Forms.TextBox textBoxOutput_SAD;
        private System.Windows.Forms.TextBox textBoxResult_SAD;
        private System.Windows.Forms.TextBox textBoxVariable_SAD;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonHelp;
    }
}

