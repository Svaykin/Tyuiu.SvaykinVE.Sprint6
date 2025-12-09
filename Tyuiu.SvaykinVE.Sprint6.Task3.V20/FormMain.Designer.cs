namespace Tyuiu.SvaykinVE.Sprint6.Task3.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SV));
            groupBoxTask_SV = new GroupBox();
            dataGridViewMtrx_SV = new DataGridView();
            textBoxTask_SV = new TextBox();
            buttonInfo_SV = new Button();
            buttonRes_SV = new Button();
            groupBoxOutput_SV = new GroupBox();
            groupBoxTask_SV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_SV).BeginInit();
            groupBoxOutput_SV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SV
            // 
            groupBoxTask_SV.Controls.Add(textBoxTask_SV);
            groupBoxTask_SV.Controls.Add(buttonRes_SV);
            groupBoxTask_SV.Controls.Add(buttonInfo_SV);
            groupBoxTask_SV.Location = new Point(12, 12);
            groupBoxTask_SV.Name = "groupBoxTask_SV";
            groupBoxTask_SV.Size = new Size(418, 426);
            groupBoxTask_SV.TabIndex = 1;
            groupBoxTask_SV.TabStop = false;
            groupBoxTask_SV.Text = "Условие";
            // 
            // dataGridViewMtrx_SV
            // 
            dataGridViewMtrx_SV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMtrx_SV.Location = new Point(60, 22);
            dataGridViewMtrx_SV.Name = "dataGridViewMtrx_SV";
            dataGridViewMtrx_SV.Size = new Size(258, 354);
            dataGridViewMtrx_SV.TabIndex = 2;
            dataGridViewMtrx_SV.CellContentClick += dataGridViewMtrx_SV_CellContentClick;
            // 
            // textBoxTask_SV
            // 
            textBoxTask_SV.BorderStyle = BorderStyle.None;
            textBoxTask_SV.Location = new Point(6, 22);
            textBoxTask_SV.Multiline = true;
            textBoxTask_SV.Name = "textBoxTask_SV";
            textBoxTask_SV.ReadOnly = true;
            textBoxTask_SV.Size = new Size(331, 213);
            textBoxTask_SV.TabIndex = 5;
            textBoxTask_SV.Text = resources.GetString("textBoxTask_SV.Text");
            // 
            // buttonInfo_SV
            // 
            buttonInfo_SV.BackColor = SystemColors.Highlight;
            buttonInfo_SV.Location = new Point(6, 379);
            buttonInfo_SV.Name = "buttonInfo_SV";
            buttonInfo_SV.Size = new Size(49, 41);
            buttonInfo_SV.TabIndex = 4;
            buttonInfo_SV.Text = "?";
            buttonInfo_SV.UseVisualStyleBackColor = false;
            buttonInfo_SV.Click += buttonInfo_SV_Click;
            // 
            // buttonRes_SV
            // 
            buttonRes_SV.BackColor = SystemColors.Window;
            buttonRes_SV.Location = new Point(275, 346);
            buttonRes_SV.Name = "buttonRes_SV";
            buttonRes_SV.Size = new Size(113, 41);
            buttonRes_SV.TabIndex = 6;
            buttonRes_SV.Text = "Выполнить";
            buttonRes_SV.UseVisualStyleBackColor = false;
            buttonRes_SV.Click += buttonRes_SV_Click;
            // 
            // groupBoxOutput_SV
            // 
            groupBoxOutput_SV.Controls.Add(dataGridViewMtrx_SV);
            groupBoxOutput_SV.Location = new Point(436, 12);
            groupBoxOutput_SV.Name = "groupBoxOutput_SV";
            groupBoxOutput_SV.Size = new Size(351, 420);
            groupBoxOutput_SV.TabIndex = 7;
            groupBoxOutput_SV.TabStop = false;
            groupBoxOutput_SV.Text = "Вывод данных";
            // 
            // FormMain_SV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxTask_SV);
            Controls.Add(groupBoxOutput_SV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_SV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 20 | Свайкин В.Е.";
            groupBoxTask_SV.ResumeLayout(false);
            groupBoxTask_SV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_SV).EndInit();
            groupBoxOutput_SV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SV;
        private TextBox textBoxTask_SV;
        private Button buttonInfo_SV;
        private DataGridView dataGridViewMtrx_SV;
        private Button buttonRes_SV;
        private GroupBox groupBoxOutput_SV;
    }
}
