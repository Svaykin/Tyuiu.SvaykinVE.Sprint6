using System.Drawing.Drawing2D;
using Tyuiu.SvaykinVE.Sprint6.Task3.V20.Lib;
namespace Tyuiu.SvaykinVE.Sprint6.Task3.V20
{
    public partial class FormMain_SV : Form
    {
        public FormMain_SV()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -14, 17, -19, 3, 2 }, { -4, -14, -19, -9, -1 }, { 1, 0, 13, 14, 8 }, { 13, 7, 8, -3, -15 }, { 2, -20, 12, -14, 4 } };
        private void buttonRes_SV_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] mtrx = ds.Calculate(matrix);
                int rows = matrix.GetUpperBound(0) + 1;
                int columns = matrix.Length / rows;
                dataGridViewMtrx_SV.ColumnCount = columns;
                dataGridViewMtrx_SV.RowCount = rows;
                for (int i = 0; i < columns; i++)
                {
                    dataGridViewMtrx_SV.Columns[i].Width = 50;

                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMtrx_SV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                    }
                }


            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfo_SV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-25-1 Свайкин Владислав Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxResult_SV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMtrx_SV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
