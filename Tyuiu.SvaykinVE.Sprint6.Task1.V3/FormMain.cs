using Tyuiu.SvaykinVE.Sprint6.Task1.V3.Lib;

namespace Tyuiu.SvaykinVE.Sprint6.Task1.V3
{
    public partial class FormMain_SV : Form
    {
        DataService ds = new DataService();
        public FormMain_SV()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox_SV_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonRes_SV_Click(object sender, EventArgs e)
        {
            try
            {   
                int start = Convert.ToInt32(textBoxInputStart_SV.Text);
                int end = Convert.ToInt32(textBoxInputStop_SV.Text);
                string Line;
                double[] valueArray = ds.GetMassFunction(start, end);
                textBoxRes_SV.Text = "";
                textBoxRes_SV.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxRes_SV.AppendText("|    X      |    f(x)   |" + Environment.NewLine);
                textBoxRes_SV.AppendText("+-----------+-----------+" + Environment.NewLine);
                for (int i = 0; i < valueArray.Length; i++)
                {
                    Line = String.Format("| {0,5:d}     |  {1, 7:f2}  | ", start, valueArray[i]);
                    textBoxRes_SV.AppendText(Line + Environment.NewLine);
                    start++;
                }
                textBoxRes_SV.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfo_SV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-25-1 Свайкин Владислав Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void textBoxTask_SV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
