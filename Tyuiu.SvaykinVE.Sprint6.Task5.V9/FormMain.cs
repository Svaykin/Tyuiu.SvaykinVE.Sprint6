using Tyuiu.SvaykinVE.Sprint6.Task5.V9.Lib;
namespace Tyuiu.SvaykinVE.Sprint6.Task5.V9
{
    public partial class FormMain_SV : Form
    {
        public FormMain_SV()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\svayk\Downloads\InPutDataFileTask5V9.txt";
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonRes_SV_Click(object sender, EventArgs e)
        {
            dataGridViewRes_SV.ColumnCount = 2;
            dataGridViewRes_SV.Columns[0].Width = 20;
            dataGridViewRes_SV.Columns[1].Width = 50;

            this.chart_SV.ChartAreas[0].AxisX.Title = "Îñü X";
            this.chart_SV.ChartAreas[0].AxisY.Title = "Îñü Y";

            chart_SV.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewRes_SV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart_SV.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }
        private void groupBoxOutput_SV_Enter(object sender, EventArgs e)
        {

        }

        private void buttonInfo_SV_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_SV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
