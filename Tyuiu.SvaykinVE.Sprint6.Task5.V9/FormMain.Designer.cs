namespace Tyuiu.SvaykinVE.Sprint6.Task5.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_SV = new GroupBox();
            buttonOpen_SV = new Button();
            buttonRes_SV = new Button();
            textBoxTask_SV = new TextBox();
            buttonInfo_SV = new Button();
            groupBoxOutput_SV = new GroupBox();
            dataGridViewRes_SV = new DataGridView();
            chart_SV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_SV.SuspendLayout();
            groupBoxOutput_SV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_SV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_SV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_SV
            // 
            groupBoxTask_SV.Controls.Add(buttonOpen_SV);
            groupBoxTask_SV.Controls.Add(buttonRes_SV);
            groupBoxTask_SV.Controls.Add(textBoxTask_SV);
            groupBoxTask_SV.Controls.Add(buttonInfo_SV);
            groupBoxTask_SV.Dock = DockStyle.Top;
            groupBoxTask_SV.Location = new Point(0, 0);
            groupBoxTask_SV.Name = "groupBoxTask_SV";
            groupBoxTask_SV.Size = new Size(800, 89);
            groupBoxTask_SV.TabIndex = 2;
            groupBoxTask_SV.TabStop = false;
            groupBoxTask_SV.Text = "Условие";
            // 
            // buttonOpen_SV
            // 
            buttonOpen_SV.BackColor = Color.FromArgb(255, 255, 128);
            buttonOpen_SV.Location = new Point(549, 22);
            buttonOpen_SV.Name = "buttonOpen_SV";
            buttonOpen_SV.Size = new Size(74, 61);
            buttonOpen_SV.TabIndex = 2;
            buttonOpen_SV.Text = "Открыть файл";
            buttonOpen_SV.UseVisualStyleBackColor = false;
            buttonOpen_SV.Click += buttonOpen_SV_Click;
            // 
            // buttonRes_SV
            // 
            buttonRes_SV.BackColor = Color.FromArgb(0, 192, 0);
            buttonRes_SV.Location = new Point(466, 22);
            buttonRes_SV.Name = "buttonRes_SV";
            buttonRes_SV.Size = new Size(77, 61);
            buttonRes_SV.TabIndex = 6;
            buttonRes_SV.Text = "Выполнить";
            buttonRes_SV.UseVisualStyleBackColor = false;
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
            groupBoxOutput_SV.Controls.Add(dataGridViewRes_SV);
            groupBoxOutput_SV.Controls.Add(chart_SV);
            groupBoxOutput_SV.Dock = DockStyle.Left;
            groupBoxOutput_SV.Location = new Point(0, 89);
            groupBoxOutput_SV.Name = "groupBoxOutput_SV";
            groupBoxOutput_SV.Size = new Size(800, 361);
            groupBoxOutput_SV.TabIndex = 3;
            groupBoxOutput_SV.TabStop = false;
            groupBoxOutput_SV.Text = "Вывод данных";
            groupBoxOutput_SV.Enter += groupBoxOutput_SV_Enter;
            // 
            // dataGridViewRes_SV
            // 
            dataGridViewRes_SV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_SV.Location = new Point(12, 22);
            dataGridViewRes_SV.Name = "dataGridViewRes_SV";
            dataGridViewRes_SV.ReadOnly = true;
            dataGridViewRes_SV.ScrollBars = ScrollBars.Vertical;
            dataGridViewRes_SV.Size = new Size(191, 317);
            dataGridViewRes_SV.TabIndex = 6;
            // 
            // chart_SV
            // 
            chartArea1.Name = "ChartArea1";
            chart_SV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_SV.Legends.Add(legend1);
            chart_SV.Location = new Point(209, 22);
            chart_SV.Name = "chart_SV";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_SV.Series.Add(series1);
            chart_SV.Size = new Size(585, 317);
            chart_SV.TabIndex = 5;
            // 
            // FormMain_SV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxOutput_SV);
            Controls.Add(groupBoxTask_SV);
            Name = "FormMain_SV";
            Text = "Спринт 6 | Таск 5 | Вариант 9 | Свайкин В.Е.";
            Load += Form1_Load;
            groupBoxTask_SV.ResumeLayout(false);
            groupBoxTask_SV.PerformLayout();
            groupBoxOutput_SV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_SV).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_SV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SV;
        private Button buttonOpen_SV;
        private Button buttonRes_SV;
        private TextBox textBoxTask_SV;
        private Button buttonInfo_SV;
        private GroupBox groupBoxOutput_SV;
        private DataGridView dataGridViewRes_SV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SV;
    }
}
