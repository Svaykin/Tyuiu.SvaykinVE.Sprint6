namespace Tyuiu.SvaykinVE.Sprint6.Task1.V3
{
    partial class FormMain_SV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTask_SV = new TextBox();
            groupBoxInput_SV = new GroupBox();
            textBoxInputStop_SV = new TextBox();
            textBoxStopTxt_SV = new TextBox();
            textBoxStartTxt_SV = new TextBox();
            textBoxInputStart_SV = new TextBox();
            groupBoxOutput_SV = new GroupBox();
            buttonRes_SV = new Button();
            textBoxRes_SV = new TextBox();
            buttonInfo_SV = new Button();
            groupBoxInput_SV.SuspendLayout();
            groupBoxOutput_SV.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTask_SV
            // 
            textBoxTask_SV.Location = new Point(12, 12);
            textBoxTask_SV.Multiline = true;
            textBoxTask_SV.Name = "textBoxTask_SV";
            textBoxTask_SV.ReadOnly = true;
            textBoxTask_SV.Size = new Size(505, 254);
            textBoxTask_SV.TabIndex = 0;
            textBoxTask_SV.Text = "Написать программу, которая выводит таблицу значений функции \r\n1+sin(x) (x) = 5 - 3x + 2x-0.5 произвести табулирование) f(x) на заданном диапазоне\r\n[-5; 5]";
            textBoxTask_SV.TextChanged += this.textBoxTask_SV_TextChanged;
            // 
            // groupBoxInput_SV
            // 
            groupBoxInput_SV.Controls.Add(textBoxInputStop_SV);
            groupBoxInput_SV.Controls.Add(textBoxStopTxt_SV);
            groupBoxInput_SV.Controls.Add(textBoxStartTxt_SV);
            groupBoxInput_SV.Controls.Add(textBoxInputStart_SV);
            groupBoxInput_SV.Location = new Point(13, 285);
            groupBoxInput_SV.Name = "groupBoxInput_SV";
            groupBoxInput_SV.Size = new Size(504, 153);
            groupBoxInput_SV.TabIndex = 1;
            groupBoxInput_SV.TabStop = false;
            groupBoxInput_SV.Text = "Ввод данных";
            // 
            // textBoxInputStop_SV
            // 
            textBoxInputStop_SV.Location = new Point(259, 72);
            textBoxInputStop_SV.Name = "textBoxInputStop_SV";
            textBoxInputStop_SV.Size = new Size(194, 23);
            textBoxInputStop_SV.TabIndex = 3;
            // 
            // textBoxStopTxt_SV
            // 
            textBoxStopTxt_SV.BackColor = SystemColors.Menu;
            textBoxStopTxt_SV.BorderStyle = BorderStyle.None;
            textBoxStopTxt_SV.Location = new Point(259, 50);
            textBoxStopTxt_SV.Name = "textBoxStopTxt_SV";
            textBoxStopTxt_SV.ReadOnly = true;
            textBoxStopTxt_SV.Size = new Size(148, 16);
            textBoxStopTxt_SV.TabIndex = 2;
            textBoxStopTxt_SV.Text = "Конец шага:";
            // 
            // textBoxStartTxt_SV
            // 
            textBoxStartTxt_SV.BackColor = SystemColors.Menu;
            textBoxStartTxt_SV.BorderStyle = BorderStyle.None;
            textBoxStartTxt_SV.Location = new Point(15, 50);
            textBoxStartTxt_SV.Name = "textBoxStartTxt_SV";
            textBoxStartTxt_SV.ReadOnly = true;
            textBoxStartTxt_SV.Size = new Size(148, 16);
            textBoxStartTxt_SV.TabIndex = 1;
            textBoxStartTxt_SV.Text = "Старт шага:";
            textBoxStartTxt_SV.TextChanged += textBox_SV_TextChanged;
            // 
            // textBoxInputStart_SV
            // 
            textBoxInputStart_SV.Location = new Point(15, 72);
            textBoxInputStart_SV.Name = "textBoxInputStart_SV";
            textBoxInputStart_SV.Size = new Size(194, 23);
            textBoxInputStart_SV.TabIndex = 0;
            // 
            // groupBoxOutput_SV
            // 
            groupBoxOutput_SV.Controls.Add(buttonRes_SV);
            groupBoxOutput_SV.Controls.Add(textBoxRes_SV);
            groupBoxOutput_SV.Location = new Point(523, 12);
            groupBoxOutput_SV.Name = "groupBoxOutput_SV";
            groupBoxOutput_SV.Size = new Size(265, 426);
            groupBoxOutput_SV.TabIndex = 2;
            groupBoxOutput_SV.TabStop = false;
            groupBoxOutput_SV.Text = "Вывод данных";
            // 
            // buttonRes_SV
            // 
            buttonRes_SV.BackColor = Color.Lime;
            buttonRes_SV.Location = new Point(17, 345);
            buttonRes_SV.Name = "buttonRes_SV";
            buttonRes_SV.Size = new Size(232, 68);
            buttonRes_SV.TabIndex = 4;
            buttonRes_SV.Text = "Выполнить";
            buttonRes_SV.UseVisualStyleBackColor = false;
            buttonRes_SV.Click += buttonRes_SV_Click;
            // 
            // textBoxRes_SV
            // 
            textBoxRes_SV.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_SV.Location = new Point(17, 22);
            textBoxRes_SV.Multiline = true;
            textBoxRes_SV.Name = "textBoxRes_SV";
            textBoxRes_SV.ReadOnly = true;
            textBoxRes_SV.Size = new Size(232, 317);
            textBoxRes_SV.TabIndex = 3;
            // 
            // buttonInfo_SV
            // 
            buttonInfo_SV.BackColor = SystemColors.Highlight;
            buttonInfo_SV.Location = new Point(459, 215);
            buttonInfo_SV.Name = "buttonInfo_SV";
            buttonInfo_SV.Size = new Size(49, 41);
            buttonInfo_SV.TabIndex = 3;
            buttonInfo_SV.Text = "?";
            buttonInfo_SV.UseVisualStyleBackColor = false;
            buttonInfo_SV.Click += buttonInfo_SV_Click;
            // 
            // FormMain_SV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo_SV);
            Controls.Add(groupBoxOutput_SV);
            Controls.Add(groupBoxInput_SV);
            Controls.Add(textBoxTask_SV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_SV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 3 | Свайкин В.Е.";
            Load += Form1_Load;
            groupBoxInput_SV.ResumeLayout(false);
            groupBoxInput_SV.PerformLayout();
            groupBoxOutput_SV.ResumeLayout(false);
            groupBoxOutput_SV.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask_SV;
        private GroupBox groupBoxInput_SV;
        private GroupBox groupBoxOutput_SV;
        private TextBox textBoxRes_SV;
        private TextBox textBoxStartTxt_SV;
        private TextBox textBoxInputStart_SV;
        private Button buttonRes_SV;
        private TextBox textBoxInputStop_SV;
        private TextBox textBoxStopTxt_SV;
        private Button buttonInfo_SV;
    }
}
