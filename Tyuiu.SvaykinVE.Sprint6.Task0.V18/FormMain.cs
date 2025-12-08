using Tyuiu.SvaykinVE.Sprint6.Task0.V18.Lib;
namespace Tyuiu.SvaykinVE.Sprint6.Task0.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonres_SV_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxResult_SV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxWrite_SV.Text)));
            }
            catch
            { MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBoxTask_SV_Click(object sender, EventArgs e)
        {

        }
        private void buttonInfo_SV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-25-1 Свайкин Владислав Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
