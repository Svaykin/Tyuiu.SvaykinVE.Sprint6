namespace Tyuiu.SvaykinVE.Sprint6.Task4.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_SV = new GroupBox();
            buttonSave_SV = new Button();
            buttonRes_SV = new Button();
            textBoxTask_SV = new TextBox();
            buttonInfo_SV = new Button();
            groupBoxOutput_SV = new GroupBox();
            chart_SV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxRes_SV = new TextBox();
            groupBoxTask_SV.SuspendLayout();
            groupBoxOutput_SV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_SV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_SV
            // 
            groupBoxTask_SV.Controls.Add(buttonSave_SV);
            groupBoxTask_SV.Controls.Add(buttonRes_SV);
            groupBoxTask_SV.Controls.Add(textBoxTask_SV);
            groupBoxTask_SV.Controls.Add(buttonInfo_SV);
            groupBoxTask_SV.Dock = DockStyle.Top;
            groupBoxTask_SV.Location = new Point(0, 0);
            groupBoxTask_SV.Name = "groupBoxTask_SV";
            groupBoxTask_SV.Size = new Size(800, 89);
            groupBoxTask_SV.TabIndex = 1;
            groupBoxTask_SV.TabStop = false;
            groupBoxTask_SV.Text = "Условие";
            // 
            // buttonSave_SV
            // 
            buttonSave_SV.Location = new Point(549, 22);
            buttonSave_SV.Name = "buttonSave_SV";
            buttonSave_SV.Size = new Size(74, 61);
            buttonSave_SV.TabIndex = 2;
            buttonSave_SV.Text = "Сохранить";
            buttonSave_SV.UseVisualStyleBackColor = true;
            buttonSave_SV.Click += buttonSave_SV_Click;
            // 
            // buttonRes_SV
            // 
            buttonRes_SV.Location = new Point(466, 22);
            buttonRes_SV.Name = "buttonRes_SV";
            buttonRes_SV.Size = new Size(77, 61);
            buttonRes_SV.TabIndex = 6;
            buttonRes_SV.Text = "Выполнить";
            buttonRes_SV.UseVisualStyleBackColor = true;
            buttonRes_SV.Click += buttonRes_SV_Click;
            // 
            // textBoxTask_SV
            // 
            textBoxTask_SV.BorderStyle = BorderStyle.None;
            textBoxTask_SV.Location = new Point(6, 22);
            textBoxTask_SV.Multiline = true;
            textBoxTask_SV.Name = "textBoxTask_SV";
            textBoxTask_SV.ReadOnly = true;
            textBoxTask_SV.Size = new Size(378, 61);
            textBoxTask_SV.TabIndex = 5;
            textBoxTask_SV.Text = "Написать программу, которая выводит таблицу значений функции f(x) = ((2cos(x)+2)/(2x-1))+cos(x)-5x+3\r\nпроизвести табулирование f(x) на заданном диапазоне [-5; 5]";
            textBoxTask_SV.TextChanged += textBoxTask_SV_TextChanged;
            // 
            // buttonInfo_SV
            // 
            buttonInfo_SV.BackColor = SystemColors.Highlight;
            buttonInfo_SV.Location = new Point(390, 22);
            buttonInfo_SV.Name = "buttonInfo_SV";
            buttonInfo_SV.Size = new Size(70, 61);
            buttonInfo_SV.TabIndex = 4;
            buttonInfo_SV.Text = "?";
            buttonInfo_SV.UseVisualStyleBackColor = false;
            buttonInfo_SV.Click += buttonInfo_SV_Click;
            // 
            // groupBoxOutput_SV
            // 
            groupBoxOutput_SV.Controls.Add(chart_SV);
            groupBoxOutput_SV.Controls.Add(textBoxRes_SV);
            groupBoxOutput_SV.Dock = DockStyle.Fill;
            groupBoxOutput_SV.Location = new Point(0, 89);
            groupBoxOutput_SV.Name = "groupBoxOutput_SV";
            groupBoxOutput_SV.Size = new Size(800, 361);
            groupBoxOutput_SV.TabIndex = 2;
            groupBoxOutput_SV.TabStop = false;
            groupBoxOutput_SV.Text = "Вывод данных";
            // 
            // chart_SV
            // 
            chartArea2.Name = "ChartArea1";
            chart_SV.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart_SV.Legends.Add(legend2);
            chart_SV.Location = new Point(209, 22);
            chart_SV.Name = "chart_SV";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart_SV.Series.Add(series2);
            chart_SV.Size = new Size(579, 317);
            chart_SV.TabIndex = 5;
            // 
            // textBoxRes_SV
            // 
            textBoxRes_SV.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_SV.Location = new Point(12, 22);
            textBoxRes_SV.Multiline = true;
            textBoxRes_SV.Name = "textBoxRes_SV";
            textBoxRes_SV.ReadOnly = true;
            textBoxRes_SV.Size = new Size(191, 317);
            textBoxRes_SV.TabIndex = 4;
            textBoxRes_SV.TextChanged += textBoxRes_SV_TextChanged;
            // 
            // FormMain_SV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutput_SV);
            Controls.Add(groupBoxTask_SV);
            Name = "FormMain_SV";
            Text = "Спринт 6 | Таск 4 | Вариант 21 | Свайкин В.Е.";
            Load += Form1_Load;
            groupBoxTask_SV.ResumeLayout(false);
            groupBoxTask_SV.PerformLayout();
            groupBoxOutput_SV.ResumeLayout(false);
            groupBoxOutput_SV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_SV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SV;
        private TextBox textBoxTask_SV;
        private Button buttonInfo_SV;
        private Button buttonSave_SV;
        private Button buttonRes_SV;
        private GroupBox groupBoxOutput_SV;
        private TextBox textBoxRes_SV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SV;
    }
}
