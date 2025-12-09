namespace Tyuiu.SvaykinVE.Sprint6.Task2.V8
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
            textBoxTask_SV = new TextBox();
            buttonInfo_SV = new Button();
            groupBoxOutput_SV = new GroupBox();
            chart_SV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_SV = new DataGridView();
            ColumnX_SV = new DataGridViewTextBoxColumn();
            ColumnFx_SV = new DataGridViewTextBoxColumn();
            groupBoxInput_SV = new GroupBox();
            textBoxInputStop_SV = new TextBox();
            textBoxStopTxt_SV = new TextBox();
            textBoxInputStart_SV = new TextBox();
            textBoxStartTxt_SV = new TextBox();
            buttonRes_SV = new Button();
            groupBoxTask_SV.SuspendLayout();
            groupBoxOutput_SV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_SV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SV).BeginInit();
            groupBoxInput_SV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SV
            // 
            groupBoxTask_SV.Controls.Add(textBoxTask_SV);
            groupBoxTask_SV.Controls.Add(buttonInfo_SV);
            groupBoxTask_SV.Location = new Point(12, 13);
            groupBoxTask_SV.Name = "groupBoxTask_SV";
            groupBoxTask_SV.Size = new Size(363, 288);
            groupBoxTask_SV.TabIndex = 0;
            groupBoxTask_SV.TabStop = false;
            groupBoxTask_SV.Text = "Условие";
            // 
            // textBoxTask_SV
            // 
            textBoxTask_SV.BorderStyle = BorderStyle.None;
            textBoxTask_SV.Location = new Point(7, 23);
            textBoxTask_SV.Multiline = true;
            textBoxTask_SV.Name = "textBoxTask_SV";
            textBoxTask_SV.ReadOnly = true;
            textBoxTask_SV.Size = new Size(331, 213);
            textBoxTask_SV.TabIndex = 5;
            textBoxTask_SV.Text = "Написать программу, которая выводит таблицу значений функции f(x) = cos(2x) + (sin(x)/ (x+2,5))+2x\r\nпроизвести табулирование f(x) на заданном диапазоне [-5; 5]";
            // 
            // buttonInfo_SV
            // 
            buttonInfo_SV.BackColor = SystemColors.Highlight;
            buttonInfo_SV.Location = new Point(308, 241);
            buttonInfo_SV.Name = "buttonInfo_SV";
            buttonInfo_SV.Size = new Size(49, 41);
            buttonInfo_SV.TabIndex = 4;
            buttonInfo_SV.Text = "?";
            buttonInfo_SV.UseVisualStyleBackColor = false;
            buttonInfo_SV.Click += buttonInfo_SV_Click;
            // 
            // groupBoxOutput_SV
            // 
            groupBoxOutput_SV.Controls.Add(chart_SV);
            groupBoxOutput_SV.Controls.Add(dataGridView_SV);
            groupBoxOutput_SV.Location = new Point(381, 13);
            groupBoxOutput_SV.Name = "groupBoxOutput_SV";
            groupBoxOutput_SV.Size = new Size(441, 426);
            groupBoxOutput_SV.TabIndex = 1;
            groupBoxOutput_SV.TabStop = false;
            groupBoxOutput_SV.Text = "Вывод данных";
            groupBoxOutput_SV.Enter += groupBoxOutput_SV_Enter;
            // 
            // chart_SV
            // 
            chartArea1.Name = "ChartArea1";
            chart_SV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_SV.Legends.Add(legend1);
            chart_SV.Location = new Point(126, 22);
            chart_SV.Name = "chart_SV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_SV.Series.Add(series1);
            chart_SV.Size = new Size(315, 187);
            chart_SV.TabIndex = 4;
            chart_SV.Click += chart_SV_Click;
            // 
            // dataGridView_SV
            // 
            dataGridView_SV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SV.Columns.AddRange(new DataGridViewColumn[] { ColumnX_SV, ColumnFx_SV });
            dataGridView_SV.Location = new Point(6, 22);
            dataGridView_SV.Name = "dataGridView_SV";
            dataGridView_SV.RowHeadersVisible = false;
            dataGridView_SV.Size = new Size(108, 398);
            dataGridView_SV.TabIndex = 4;
            // 
            // ColumnX_SV
            // 
            ColumnX_SV.HeaderText = "X";
            ColumnX_SV.Name = "ColumnX_SV";
            ColumnX_SV.ReadOnly = true;
            ColumnX_SV.Width = 50;
            // 
            // ColumnFx_SV
            // 
            ColumnFx_SV.HeaderText = "F(x)";
            ColumnFx_SV.Name = "ColumnFx_SV";
            ColumnFx_SV.ReadOnly = true;
            ColumnFx_SV.Width = 50;
            // 
            // groupBoxInput_SV
            // 
            groupBoxInput_SV.Controls.Add(textBoxInputStop_SV);
            groupBoxInput_SV.Controls.Add(textBoxStopTxt_SV);
            groupBoxInput_SV.Controls.Add(textBoxInputStart_SV);
            groupBoxInput_SV.Controls.Add(textBoxStartTxt_SV);
            groupBoxInput_SV.Location = new Point(12, 306);
            groupBoxInput_SV.Name = "groupBoxInput_SV";
            groupBoxInput_SV.Size = new Size(232, 132);
            groupBoxInput_SV.TabIndex = 2;
            groupBoxInput_SV.TabStop = false;
            groupBoxInput_SV.Text = "Ввод данных";
            // 
            // textBoxInputStop_SV
            // 
            textBoxInputStop_SV.Location = new Point(121, 56);
            textBoxInputStop_SV.Name = "textBoxInputStop_SV";
            textBoxInputStop_SV.Size = new Size(73, 23);
            textBoxInputStop_SV.TabIndex = 5;
            // 
            // textBoxStopTxt_SV
            // 
            textBoxStopTxt_SV.BackColor = SystemColors.Menu;
            textBoxStopTxt_SV.BorderStyle = BorderStyle.None;
            textBoxStopTxt_SV.Location = new Point(121, 35);
            textBoxStopTxt_SV.Name = "textBoxStopTxt_SV";
            textBoxStopTxt_SV.ReadOnly = true;
            textBoxStopTxt_SV.Size = new Size(73, 16);
            textBoxStopTxt_SV.TabIndex = 4;
            textBoxStopTxt_SV.Text = "Конец шага:";
            // 
            // textBoxInputStart_SV
            // 
            textBoxInputStart_SV.Location = new Point(6, 57);
            textBoxInputStart_SV.Name = "textBoxInputStart_SV";
            textBoxInputStart_SV.Size = new Size(75, 23);
            textBoxInputStart_SV.TabIndex = 3;
            // 
            // textBoxStartTxt_SV
            // 
            textBoxStartTxt_SV.BackColor = SystemColors.Menu;
            textBoxStartTxt_SV.BorderStyle = BorderStyle.None;
            textBoxStartTxt_SV.Location = new Point(6, 35);
            textBoxStartTxt_SV.Name = "textBoxStartTxt_SV";
            textBoxStartTxt_SV.ReadOnly = true;
            textBoxStartTxt_SV.Size = new Size(75, 16);
            textBoxStartTxt_SV.TabIndex = 2;
            textBoxStartTxt_SV.Text = "Старт шага:";
            // 
            // buttonRes_SV
            // 
            buttonRes_SV.Location = new Point(250, 307);
            buttonRes_SV.Name = "buttonRes_SV";
            buttonRes_SV.Size = new Size(125, 131);
            buttonRes_SV.TabIndex = 3;
            buttonRes_SV.Text = "Выполнить";
            buttonRes_SV.UseVisualStyleBackColor = true;
            buttonRes_SV.Click += buttonRes_SV_Click;
            // 
            // FormMain_SV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 450);
            Controls.Add(buttonRes_SV);
            Controls.Add(groupBoxInput_SV);
            Controls.Add(groupBoxOutput_SV);
            Controls.Add(groupBoxTask_SV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_SV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 8 | Свайкин В.Е.";
            Load += FormMain_SV_Load;
            groupBoxTask_SV.ResumeLayout(false);
            groupBoxTask_SV.PerformLayout();
            groupBoxOutput_SV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_SV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SV).EndInit();
            groupBoxInput_SV.ResumeLayout(false);
            groupBoxInput_SV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SV;
        private GroupBox groupBoxOutput_SV;
        private GroupBox groupBoxInput_SV;
        private Button buttonRes_SV;
        private TextBox textBoxStartTxt_SV;
        private TextBox textBoxInputStart_SV;
        private TextBox textBoxStopTxt_SV;
        private TextBox textBoxInputStop_SV;
        private Button buttonInfo_SV;
        private TextBox textBoxTask_SV;
        private DataGridView dataGridView_SV;
        private DataGridViewTextBoxColumn ColumnX_SV;
        private DataGridViewTextBoxColumn ColumnFx_SV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SV;
    }
}
