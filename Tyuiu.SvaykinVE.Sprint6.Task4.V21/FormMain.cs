using Tyuiu.SvaykinVE.Sprint6.Task4.V21.Lib;
namespace Tyuiu.SvaykinVE.Sprint6.Task4.V21
{
    public partial class FormMain_SV : Form
    {
        public FormMain_SV()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonRes_SV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = -5;
                int stopStep = 5;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chart_SV.ChartAreas[0].AxisX.Title = "Îñü X";
                this.chart_SV.ChartAreas[0].AxisY.Title = "Îñü Y";

                textBoxRes_SV.Text = "";

                chart_SV.Series[0].Points.Clear();
                for (int i = 0; i < len; i++, startStep++)
                {
                    this.chart_SV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxRes_SV.AppendText(valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxTask_SV_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxRes_SV_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonSave_SV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V21.txt";
                File.WriteAllText(path, textBoxRes_SV.Text);

                DialogResult dialogResult = MessageBox.Show(this, $"Файл {path} сохранён успешно!\n Открыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfo_SV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-25-1 Свайкин Владислав Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
