namespace Tyuiu.SvaykinVE.Sprint6.Task7.V8
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SV));
            openFileDialogTask_SV = new OpenFileDialog();
            toolTip_SV = new ToolTip(components);
            buttonSave_SV = new Button();
            buttonRes_SV = new Button();
            buttonOpen_SV = new Button();
            buttonInfo_SV = new Button();
            groupBoxTask_SV = new GroupBox();
            dataGridViewOut_SV = new DataGridView();
            dataGridViewIn_SV = new DataGridView();
            textBoxPath_SV = new TextBox();
            textBoxOutputTxt_SV = new TextBox();
            textBoxInputTxt_SV = new TextBox();
            textBoxTask_SV = new TextBox();
            groupBox_SV = new GroupBox();
            groupBoxTask_SV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SV).BeginInit();
            groupBox_SV.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTask_SV
            // 
            openFileDialogTask_SV.FileName = "openFileDialogTask_SV";
            // 
            // toolTip_SV
            // 
            toolTip_SV.ToolTipIcon = ToolTipIcon.Info;
            // 
            // buttonSave_SV
            // 
            buttonSave_SV.BackColor = SystemColors.ButtonFace;
            buttonSave_SV.Enabled = false;
            buttonSave_SV.Image = (Image)resources.GetObject("buttonSave_SV.Image");
            buttonSave_SV.Location = new Point(172, 12);
            buttonSave_SV.Name = "buttonSave_SV";
            buttonSave_SV.Size = new Size(74, 61);
            buttonSave_SV.TabIndex = 11;
            toolTip_SV.SetToolTip(buttonSave_SV, "Сохранить");
            buttonSave_SV.UseVisualStyleBackColor = false;
            buttonSave_SV.Click += buttonSave_SV_Click;
            // 
            // buttonRes_SV
            // 
            buttonRes_SV.BackColor = SystemColors.ButtonFace;
            buttonRes_SV.Enabled = false;
            buttonRes_SV.Image = (Image)resources.GetObject("buttonRes_SV.Image");
            buttonRes_SV.Location = new Point(92, 12);
            buttonRes_SV.Name = "buttonRes_SV";
            buttonRes_SV.Size = new Size(74, 61);
            buttonRes_SV.TabIndex = 7;
            toolTip_SV.SetToolTip(buttonRes_SV, "Выполнить");
            buttonRes_SV.UseVisualStyleBackColor = false;
            buttonRes_SV.Click += buttonRes_SV_Click;
            // 
            // buttonOpen_SV
            // 
            buttonOpen_SV.BackColor = SystemColors.ButtonFace;
            buttonOpen_SV.Image = Properties.Resources.folder;
            buttonOpen_SV.Location = new Point(9, 12);
            buttonOpen_SV.Name = "buttonOpen_SV";
            buttonOpen_SV.Size = new Size(77, 61);
            buttonOpen_SV.TabIndex = 10;
            toolTip_SV.SetToolTip(buttonOpen_SV, "Выбрать Файл");
            buttonOpen_SV.UseVisualStyleBackColor = false;
            buttonOpen_SV.Click += buttonOpen_SV_Click;
            // 
            // buttonInfo_SV
            // 
            buttonInfo_SV.BackColor = SystemColors.Highlight;
            buttonInfo_SV.Location = new Point(718, 12);
            buttonInfo_SV.Name = "buttonInfo_SV";
            buttonInfo_SV.Size = new Size(70, 61);
            buttonInfo_SV.TabIndex = 9;
            buttonInfo_SV.Text = "?";
            toolTip_SV.SetToolTip(buttonInfo_SV, "Справка");
            buttonInfo_SV.UseVisualStyleBackColor = false;
            buttonInfo_SV.Click += buttonInfo_SV_Click;
            // 
            // groupBoxTask_SV
            // 
            groupBoxTask_SV.Controls.Add(dataGridViewOut_SV);
            groupBoxTask_SV.Controls.Add(dataGridViewIn_SV);
            groupBoxTask_SV.Controls.Add(textBoxPath_SV);
            groupBoxTask_SV.Controls.Add(textBoxOutputTxt_SV);
            groupBoxTask_SV.Controls.Add(textBoxInputTxt_SV);
            groupBoxTask_SV.Controls.Add(textBoxTask_SV);
            groupBoxTask_SV.Location = new Point(3, 85);
            groupBoxTask_SV.Name = "groupBoxTask_SV";
            groupBoxTask_SV.Size = new Size(800, 378);
            groupBoxTask_SV.TabIndex = 8;
            groupBoxTask_SV.TabStop = false;
            groupBoxTask_SV.Text = "Условие";
            groupBoxTask_SV.Enter += groupBoxTask_SV_Enter;
            // 
            // dataGridViewOut_SV
            // 
            dataGridViewOut_SV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_SV.Location = new Point(436, 113);
            dataGridViewOut_SV.Name = "dataGridViewOut_SV";
            dataGridViewOut_SV.Size = new Size(352, 254);
            dataGridViewOut_SV.TabIndex = 12;
            // 
            // dataGridViewIn_SV
            // 
            dataGridViewIn_SV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_SV.Location = new Point(13, 111);
            dataGridViewIn_SV.Name = "dataGridViewIn_SV";
            dataGridViewIn_SV.Size = new Size(348, 254);
            dataGridViewIn_SV.TabIndex = 11;
            dataGridViewIn_SV.CellContentClick += dataGridViewIn_SV_CellContentClick;
            // 
            // textBoxPath_SV
            // 
            textBoxPath_SV.BackColor = SystemColors.Menu;
            textBoxPath_SV.BorderStyle = BorderStyle.None;
            textBoxPath_SV.Location = new Point(53, 89);
            textBoxPath_SV.Name = "textBoxPath_SV";
            textBoxPath_SV.ReadOnly = true;
            textBoxPath_SV.Size = new Size(161, 16);
            textBoxPath_SV.TabIndex = 10;
            // 
            // textBoxOutputTxt_SV
            // 
            textBoxOutputTxt_SV.BackColor = SystemColors.Menu;
            textBoxOutputTxt_SV.BorderStyle = BorderStyle.None;
            textBoxOutputTxt_SV.Location = new Point(445, 89);
            textBoxOutputTxt_SV.Name = "textBoxOutputTxt_SV";
            textBoxOutputTxt_SV.ReadOnly = true;
            textBoxOutputTxt_SV.Size = new Size(148, 16);
            textBoxOutputTxt_SV.TabIndex = 8;
            textBoxOutputTxt_SV.Text = "Конец шага:";
            // 
            // textBoxInputTxt_SV
            // 
            textBoxInputTxt_SV.BackColor = SystemColors.Menu;
            textBoxInputTxt_SV.BorderStyle = BorderStyle.None;
            textBoxInputTxt_SV.Location = new Point(15, 89);
            textBoxInputTxt_SV.Name = "textBoxInputTxt_SV";
            textBoxInputTxt_SV.ReadOnly = true;
            textBoxInputTxt_SV.Size = new Size(148, 16);
            textBoxInputTxt_SV.TabIndex = 7;
            textBoxInputTxt_SV.Text = "Ввод";
            // 
            // textBoxTask_SV
            // 
            textBoxTask_SV.BorderStyle = BorderStyle.None;
            textBoxTask_SV.Location = new Point(6, 22);
            textBoxTask_SV.Multiline = true;
            textBoxTask_SV.Name = "textBoxTask_SV";
            textBoxTask_SV.ReadOnly = true;
            textBoxTask_SV.Size = new Size(782, 61);
            textBoxTask_SV.TabIndex = 5;
            textBoxTask_SV.Text = resources.GetString("textBoxTask_SV.Text");
            // 
            // groupBox_SV
            // 
            groupBox_SV.Controls.Add(buttonInfo_SV);
            groupBox_SV.Controls.Add(buttonOpen_SV);
            groupBox_SV.Controls.Add(buttonRes_SV);
            groupBox_SV.Controls.Add(buttonSave_SV);
            groupBox_SV.Location = new Point(3, 6);
            groupBox_SV.Name = "groupBox_SV";
            groupBox_SV.Size = new Size(800, 73);
            groupBox_SV.TabIndex = 12;
            groupBox_SV.TabStop = false;
            groupBox_SV.Enter += this.groupBox_SV_Enter;
            // 
            // FormMain_SV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 466);
            Controls.Add(groupBoxTask_SV);
            Controls.Add(groupBox_SV);
            Name = "FormMain_SV";
            Text = "Спринт 6 | Таск 7 | Вариант 8 | Свайкин В.Е.";
            groupBoxTask_SV.ResumeLayout(false);
            groupBoxTask_SV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SV).EndInit();
            groupBox_SV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialogTask_SV;
        private ToolTip toolTip_SV;
        private GroupBox groupBoxTask_SV;
        private DataGridView dataGridViewOut_SV;
        private DataGridView dataGridViewIn_SV;
        private TextBox textBoxPath_SV;
        private TextBox textBoxOutputTxt_SV;
        private TextBox textBoxInputTxt_SV;
        private TextBox textBoxTask_SV;
        private GroupBox groupBox_SV;
        private Button buttonInfo_SV;
        private Button buttonOpen_SV;
        private Button buttonRes_SV;
        private Button buttonSave_SV;
    }
}
