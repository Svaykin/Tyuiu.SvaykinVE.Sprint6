namespace Tyuiu.SvaykinVE.Sprint6.Task0.V18
{
    partial class FormMain
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
            buttonres_SV = new Button();
            textBoxTask_SV = new TextBox();
            pictureBoxTask_SV = new PictureBox();
            textBoxWrite_SV = new TextBox();
            textBoxResult_SV = new TextBox();
            groupBoxInput_SV = new GroupBox();
            textBox_SV = new TextBox();
            groupBoxOutput_SV = new GroupBox();
            buttonInfo_SV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_SV).BeginInit();
            groupBoxInput_SV.SuspendLayout();
            groupBoxOutput_SV.SuspendLayout();
            SuspendLayout();
            // 
            // buttonres_SV
            // 
            buttonres_SV.Location = new Point(26, 60);
            buttonres_SV.Name = "buttonres_SV";
            buttonres_SV.Size = new Size(168, 62);
            buttonres_SV.TabIndex = 0;
            buttonres_SV.Text = "результат";
            buttonres_SV.UseVisualStyleBackColor = true;
            buttonres_SV.Click += buttonres_SV_Click;
            // 
            // textBoxTask_SV
            // 
            textBoxTask_SV.Location = new Point(12, 12);
            textBoxTask_SV.Multiline = true;
            textBoxTask_SV.Name = "textBoxTask_SV";
            textBoxTask_SV.ReadOnly = true;
            textBoxTask_SV.Size = new Size(538, 266);
            textBoxTask_SV.TabIndex = 1;
            textBoxTask_SV.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            textBoxTask_SV.TextChanged += textBox1_TextChanged;
            // 
            // pictureBoxTask_SV
            // 
            pictureBoxTask_SV.Image = Properties.Resources.Снимок_экрана_2025_12_08_142806;
            pictureBoxTask_SV.Location = new Point(556, 12);
            pictureBoxTask_SV.Name = "pictureBoxTask_SV";
            pictureBoxTask_SV.Size = new Size(226, 120);
            pictureBoxTask_SV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_SV.TabIndex = 2;
            pictureBoxTask_SV.TabStop = false;
            pictureBoxTask_SV.Click += pictureBoxTask_SV_Click;
            // 
            // textBoxWrite_SV
            // 
            textBoxWrite_SV.Location = new Point(79, 61);
            textBoxWrite_SV.Name = "textBoxWrite_SV";
            textBoxWrite_SV.Size = new Size(100, 23);
            textBoxWrite_SV.TabIndex = 3;
            // 
            // textBoxResult_SV
            // 
            textBoxResult_SV.BackColor = Color.White;
            textBoxResult_SV.Location = new Point(26, 31);
            textBoxResult_SV.Name = "textBoxResult_SV";
            textBoxResult_SV.ReadOnly = true;
            textBoxResult_SV.Size = new Size(168, 23);
            textBoxResult_SV.TabIndex = 4;
            // 
            // groupBoxInput_SV
            // 
            groupBoxInput_SV.Controls.Add(textBox_SV);
            groupBoxInput_SV.Controls.Add(textBoxWrite_SV);
            groupBoxInput_SV.Location = new Point(12, 284);
            groupBoxInput_SV.Name = "groupBoxInput_SV";
            groupBoxInput_SV.Size = new Size(570, 154);
            groupBoxInput_SV.TabIndex = 5;
            groupBoxInput_SV.TabStop = false;
            groupBoxInput_SV.Text = "Введите значение переменной";
            groupBoxInput_SV.Enter += groupBox1_Enter;
            // 
            // textBox_SV
            // 
            textBox_SV.BorderStyle = BorderStyle.None;
            textBox_SV.Location = new Point(79, 38);
            textBox_SV.Name = "textBox_SV";
            textBox_SV.ReadOnly = true;
            textBox_SV.Size = new Size(168, 16);
            textBox_SV.TabIndex = 5;
            textBox_SV.Text = "введите значение x";
            // 
            // groupBoxOutput_SV
            // 
            groupBoxOutput_SV.Controls.Add(textBoxResult_SV);
            groupBoxOutput_SV.Controls.Add(buttonres_SV);
            groupBoxOutput_SV.Location = new Point(588, 284);
            groupBoxOutput_SV.Name = "groupBoxOutput_SV";
            groupBoxOutput_SV.Size = new Size(200, 154);
            groupBoxOutput_SV.TabIndex = 6;
            groupBoxOutput_SV.TabStop = false;
            groupBoxOutput_SV.Text = "итог";
            // 
            // buttonInfo_SV
            // 
            buttonInfo_SV.Location = new Point(707, 211);
            buttonInfo_SV.Name = "buttonInfo_SV";
            buttonInfo_SV.Size = new Size(75, 67);
            buttonInfo_SV.TabIndex = 7;
            buttonInfo_SV.Text = "?";
            buttonInfo_SV.UseVisualStyleBackColor = true;
            buttonInfo_SV.Click += this.buttonInfo_SV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo_SV);
            Controls.Add(groupBoxOutput_SV);
            Controls.Add(groupBoxInput_SV);
            Controls.Add(pictureBoxTask_SV);
            Controls.Add(textBoxTask_SV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 18 | Свайкин В.Е.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_SV).EndInit();
            groupBoxInput_SV.ResumeLayout(false);
            groupBoxInput_SV.PerformLayout();
            groupBoxOutput_SV.ResumeLayout(false);
            groupBoxOutput_SV.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonres_SV;
        private TextBox textBoxTask_SV;
        private TextBox textBoxWrite_SV;
        private TextBox textBoxResult_SV;
        private GroupBox groupBoxInput_SV;
        private GroupBox groupBoxOutput_SV;
        private TextBox textBox_SV;
        public PictureBox pictureBoxTask_SV;
        private Button buttonInfo_SV;
    }
}
