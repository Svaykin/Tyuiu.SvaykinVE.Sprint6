using Tyuiu.SvaykinVE.Sprint6.Task2.V8.Lib;
namespace Tyuiu.SvaykinVE.Sprint6.Task2.V8
{
    public partial class FormMain_SV : Form
    {
        public FormMain_SV()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonInfo_SV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-25-1 Свайкин Владислав Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void groupBoxOutput_SV_Enter(object sender, EventArgs e)
        {

        }
        private void chart_SV_Click(object sender, EventArgs e)
        {

        }
        private void buttonRes_SV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_SV.Text);
                int stopStep = Convert.ToInt32(textBoxInputStop_SV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] m = new double[len];
                m = ds.GetMassFunction(startStep, stopStep);

                this.chart_SV.Titles.Add("График функции");
                this.chart_SV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart_SV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridView_SV.Rows.Add(Convert.ToString(startStep), Convert.ToString(m[i]));

                    this.chart_SV.Series[0].Points.AddXY(startStep, m[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormMain_SV_Load(object sender, EventArgs e)
        {

        }
        private void buttonRes_SV_MouseEnter(object sender, EventArgs e)
        {
            buttonRes_SV.BackColor = Color.Red;
        }

        private void buttonRes_SV_Leave(object sender, EventArgs e)
        {
            buttonRes_SV.BackColor = Color.Green;
        }

        private void buttonRes_SV_Down(object sender, MouseEventArgs e)
        {
            buttonRes_SV.BackColor = Color.Blue;
        }
    }
}
