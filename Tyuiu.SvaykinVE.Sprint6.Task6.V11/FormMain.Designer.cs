namespace Tyuiu.SvaykinVE.Sprint6.Task6.V11
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_SV = new GroupBox();
            textBoxPath_SV = new TextBox();
            textBoxOutput_SV = new TextBox();
            textBoxOutputTxt_SV = new TextBox();
            textBoxInputTxt_SV = new TextBox();
            textBoxInput_SV = new TextBox();
            textBoxTask_SV = new TextBox();
            buttonOpen_SV = new Button();
            buttonRes_SV = new Button();
            buttonInfo_SV = new Button();
            openFileDialogTask_SV = new OpenFileDialog();
            toolTip_SV = new ToolTip(components);
            groupBoxTask_SV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SV
            // 
            groupBoxTask_SV.Controls.Add(textBoxPath_SV);
            groupBoxTask_SV.Controls.Add(textBoxOutput_SV);
            groupBoxTask_SV.Controls.Add(textBoxOutputTxt_SV);
            groupBoxTask_SV.Controls.Add(textBoxInputTxt_SV);
            groupBoxTask_SV.Controls.Add(textBoxInput_SV);
            groupBoxTask_SV.Controls.Add(textBoxTask_SV);
            groupBoxTask_SV.Dock = DockStyle.Bottom;
            groupBoxTask_SV.Location = new Point(0, 79);
            groupBoxTask_SV.Name = "groupBoxTask_SV";
            groupBoxTask_SV.Size = new Size(800, 371);
            groupBoxTask_SV.TabIndex = 3;
            groupBoxTask_SV.TabStop = false;
            groupBoxTask_SV.Text = "Условие";
            groupBoxTask_SV.Enter += groupBoxTask_SV_Enter;
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
            // textBoxOutput_SV
            // 
            textBoxOutput_SV.Location = new Point(445, 111);
            textBoxOutput_SV.Multiline = true;
            textBoxOutput_SV.Name = "textBoxOutput_SV";
            textBoxOutput_SV.ReadOnly = true;
            textBoxOutput_SV.Size = new Size(343, 248);
            textBoxOutput_SV.TabIndex = 9;
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
            // textBoxInput_SV
            // 
            textBoxInput_SV.Location = new Point(15, 111);
            textBoxInput_SV.Multiline = true;
            textBoxInput_SV.Name = "textBoxInput_SV";
            textBoxInput_SV.ReadOnly = true;
            textBoxInput_SV.Size = new Size(424, 248);
            textBoxInput_SV.TabIndex = 6;
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
            textBoxTask_SV.TextChanged += textBoxTask_SV_TextChanged;
            // 
            // buttonOpen_SV
            // 
            buttonOpen_SV.BackColor = SystemColors.ButtonFace;
            buttonOpen_SV.Enabled = false;
            buttonOpen_SV.Image = Properties.Resources.folder_go;
            buttonOpen_SV.Location = new Point(95, 12);
            buttonOpen_SV.Name = "buttonOpen_SV";
            buttonOpen_SV.Size = new Size(74, 61);
            buttonOpen_SV.TabIndex = 2;
            toolTip_SV.SetToolTip(buttonOpen_SV, "Выполнить");
            buttonOpen_SV.UseVisualStyleBackColor = false;
            buttonOpen_SV.Click += buttonOpen_SV_Click;
            // 
            // buttonRes_SV
            // 
            buttonRes_SV.BackColor = SystemColors.ButtonFace;
            buttonRes_SV.Image = Properties.Resources.folder_add;
            buttonRes_SV.Location = new Point(12, 12);
            buttonRes_SV.Name = "buttonRes_SV";
            buttonRes_SV.Size = new Size(77, 61);
            buttonRes_SV.TabIndex = 6;
            toolTip_SV.SetToolTip(buttonRes_SV, "Выбрать файл");
            buttonRes_SV.UseVisualStyleBackColor = false;
            buttonRes_SV.Click += buttonRes_SV_Click;
            // 
            // buttonInfo_SV
            // 
            buttonInfo_SV.BackColor = SystemColors.Highlight;
            buttonInfo_SV.Location = new Point(718, 12);
            buttonInfo_SV.Name = "buttonInfo_SV";
            buttonInfo_SV.Size = new Size(70, 61);
            buttonInfo_SV.TabIndex = 4;
            buttonInfo_SV.Text = "?";
            buttonInfo_SV.UseVisualStyleBackColor = false;
            buttonInfo_SV.Click += buttonInfo_SV_Click;
            // 
            // openFileDialogTask_SV
            // 
            openFileDialogTask_SV.FileName = "openFileDialogTask_SV";
            openFileDialogTask_SV.FileOk += openFileDialogTask_SV_FileOk;
            // 
            // toolTip_SV
            // 
            toolTip_SV.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOpen_SV);
            Controls.Add(buttonRes_SV);
            Controls.Add(groupBoxTask_SV);
            Controls.Add(buttonInfo_SV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 11 | Свайкин В.Е.";
            groupBoxTask_SV.ResumeLayout(false);
            groupBoxTask_SV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SV;
        private Button buttonOpen_SV;
        private Button buttonRes_SV;
        private TextBox textBoxTask_SV;
        private Button buttonInfo_SV;
        private TextBox textBoxOutput_SV;
        private TextBox textBoxOutputTxt_SV;
        private TextBox textBoxInputTxt_SV;
        private TextBox textBoxInput_SV;
        private TextBox textBoxPath_SV;
        private OpenFileDialog openFileDialogTask_SV;
        private ToolTip toolTip_SV;
    }
}
