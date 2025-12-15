namespace Tyuiu.SvaykinVE.Sprint6.Task7.V8
{
    partial class FormAbout_SV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SV));
            buttonOk_SV = new Button();
            textBox_SV = new TextBox();
            SuspendLayout();
            // 
            // buttonOk_SV
            // 
            buttonOk_SV.Location = new Point(246, 271);
            buttonOk_SV.Name = "buttonOk_SV";
            buttonOk_SV.Size = new Size(75, 23);
            buttonOk_SV.TabIndex = 3;
            buttonOk_SV.Text = "Ок";
            buttonOk_SV.UseVisualStyleBackColor = true;
            buttonOk_SV.Click += buttonOk_SV_Click;
            // 
            // textBox_SV
            // 
            textBox_SV.BorderStyle = BorderStyle.None;
            textBox_SV.Location = new Point(181, 116);
            textBox_SV.Multiline = true;
            textBox_SV.Name = "textBox_SV";
            textBox_SV.ReadOnly = true;
            textBox_SV.Size = new Size(438, 218);
            textBox_SV.TabIndex = 2;
            textBox_SV.Text = resources.GetString("textBox_SV.Text");
            // 
            // FormAbout_SV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 354);
            Controls.Add(buttonOk_SV);
            Controls.Add(textBox_SV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAbout_SV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk_SV;
        private TextBox textBox_SV;
    }
}