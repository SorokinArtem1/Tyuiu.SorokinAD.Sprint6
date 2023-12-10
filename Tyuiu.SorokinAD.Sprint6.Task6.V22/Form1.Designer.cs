
namespace Tyuiu.SorokinAD.Sprint6.Task6.V22
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxTask_SAD = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_SAD = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_SAD = new System.Windows.Forms.GroupBox();
            this.textBoxInput_SAD = new System.Windows.Forms.TextBox();
            this.textBoxOutput_SAD = new System.Windows.Forms.TextBox();
            this.labelTask_SAD = new System.Windows.Forms.Label();
            this.buttonOpenFile_SAD = new System.Windows.Forms.Button();
            this.buttonResult_SAD = new System.Windows.Forms.Button();
            this.buttonHelp_SAD = new System.Windows.Forms.Button();
            this.openFileDialogTask_SAD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_SAD = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxTask_SAD.SuspendLayout();
            this.groupBoxInput_SAD.SuspendLayout();
            this.groupBoxOutput_SAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SAD
            // 
            this.groupBoxTask_SAD.Controls.Add(this.labelTask_SAD);
            this.groupBoxTask_SAD.Location = new System.Drawing.Point(12, 91);
            this.groupBoxTask_SAD.Name = "groupBoxTask_SAD";
            this.groupBoxTask_SAD.Size = new System.Drawing.Size(786, 69);
            this.groupBoxTask_SAD.TabIndex = 0;
            this.groupBoxTask_SAD.TabStop = false;
            this.groupBoxTask_SAD.Text = "Условие";
            // 
            // groupBoxInput_SAD
            // 
            this.groupBoxInput_SAD.Controls.Add(this.textBoxInput_SAD);
            this.groupBoxInput_SAD.Location = new System.Drawing.Point(12, 166);
            this.groupBoxInput_SAD.Name = "groupBoxInput_SAD";
            this.groupBoxInput_SAD.Size = new System.Drawing.Size(373, 272);
            this.groupBoxInput_SAD.TabIndex = 1;
            this.groupBoxInput_SAD.TabStop = false;
            this.groupBoxInput_SAD.Text = "Ввод:";
            // 
            // groupBoxOutput_SAD
            // 
            this.groupBoxOutput_SAD.Controls.Add(this.textBoxOutput_SAD);
            this.groupBoxOutput_SAD.Location = new System.Drawing.Point(391, 166);
            this.groupBoxOutput_SAD.Name = "groupBoxOutput_SAD";
            this.groupBoxOutput_SAD.Size = new System.Drawing.Size(397, 272);
            this.groupBoxOutput_SAD.TabIndex = 2;
            this.groupBoxOutput_SAD.TabStop = false;
            this.groupBoxOutput_SAD.Text = "Вывод:";
            // 
            // textBoxInput_SAD
            // 
            this.textBoxInput_SAD.Location = new System.Drawing.Point(7, 19);
            this.textBoxInput_SAD.Multiline = true;
            this.textBoxInput_SAD.Name = "textBoxInput_SAD";
            this.textBoxInput_SAD.ReadOnly = true;
            this.textBoxInput_SAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_SAD.Size = new System.Drawing.Size(360, 247);
            this.textBoxInput_SAD.TabIndex = 0;
            // 
            // textBoxOutput_SAD
            // 
            this.textBoxOutput_SAD.Location = new System.Drawing.Point(7, 20);
            this.textBoxOutput_SAD.Multiline = true;
            this.textBoxOutput_SAD.Name = "textBoxOutput_SAD";
            this.textBoxOutput_SAD.ReadOnly = true;
            this.textBoxOutput_SAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_SAD.Size = new System.Drawing.Size(384, 246);
            this.textBoxOutput_SAD.TabIndex = 0;
            // 
            // labelTask_SAD
            // 
            this.labelTask_SAD.AutoSize = true;
            this.labelTask_SAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask_SAD.Location = new System.Drawing.Point(7, 20);
            this.labelTask_SAD.Name = "labelTask_SAD";
            this.labelTask_SAD.Size = new System.Drawing.Size(777, 30);
            this.labelTask_SAD.TabIndex = 0;
            this.labelTask_SAD.Text = resources.GetString("labelTask_SAD.Text");
            // 
            // buttonOpenFile_SAD
            // 
            this.buttonOpenFile_SAD.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile_SAD.Name = "buttonOpenFile_SAD";
            this.buttonOpenFile_SAD.Size = new System.Drawing.Size(90, 72);
            this.buttonOpenFile_SAD.TabIndex = 3;
            this.buttonOpenFile_SAD.Text = "button1";
            this.toolTip_SAD.SetToolTip(this.buttonOpenFile_SAD, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_SAD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SAD.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonResult_SAD
            // 
            this.buttonResult_SAD.Location = new System.Drawing.Point(109, 13);
            this.buttonResult_SAD.Name = "buttonResult_SAD";
            this.buttonResult_SAD.Size = new System.Drawing.Size(88, 72);
            this.buttonResult_SAD.TabIndex = 4;
            this.buttonResult_SAD.Text = "button2";
            this.toolTip_SAD.SetToolTip(this.buttonResult_SAD, "Производит поиск в файле первых слов \r\nи конкатенирует первые слова строк");
            this.buttonResult_SAD.UseVisualStyleBackColor = true;
            this.buttonResult_SAD.Click += new System.EventHandler(this.buttonResult_SAD_Click);
            // 
            // buttonHelp_SAD
            // 
            this.buttonHelp_SAD.Location = new System.Drawing.Point(695, 13);
            this.buttonHelp_SAD.Name = "buttonHelp_SAD";
            this.buttonHelp_SAD.Size = new System.Drawing.Size(93, 72);
            this.buttonHelp_SAD.TabIndex = 5;
            this.buttonHelp_SAD.Text = "button1";
            this.toolTip_SAD.SetToolTip(this.buttonHelp_SAD, "Сведение о программе");
            this.buttonHelp_SAD.UseVisualStyleBackColor = true;
            // 
            // openFileDialogTask_SAD
            // 
            this.openFileDialogTask_SAD.FileName = "openFileDialog1";
            // 
            // toolTip_SAD
            // 
            this.toolTip_SAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SAD.ToolTipTitle = "Подсказка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_SAD);
            this.Controls.Add(this.buttonResult_SAD);
            this.Controls.Add(this.buttonOpenFile_SAD);
            this.Controls.Add(this.groupBoxOutput_SAD);
            this.Controls.Add(this.groupBoxInput_SAD);
            this.Controls.Add(this.groupBoxTask_SAD);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label labelTask_SAD;
        private System.Windows.Forms.GroupBox groupBoxInput_SAD;
        private System.Windows.Forms.TextBox textBoxInput_SAD;
        private System.Windows.Forms.GroupBox groupBoxOutput_SAD;
        private System.Windows.Forms.TextBox textBoxOutput_SAD;
        private System.Windows.Forms.Button buttonOpenFile_SAD;
        private System.Windows.Forms.Button buttonResult_SAD;
        private System.Windows.Forms.Button buttonHelp_SAD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_SAD;
        private System.Windows.Forms.ToolTip toolTip_SAD;
    }
}

