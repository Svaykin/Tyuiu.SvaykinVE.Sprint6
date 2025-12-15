using Tyuiu.SvaykinVE.Sprint6.Task7.V8.Lib;
namespace Tyuiu.SvaykinVE.Sprint6.Task7.V8
{
    public partial class FormMain_SV : Form
    {
        public FormMain_SV()
        {
            InitializeComponent();
        }
        int rows;
        int columns;
        string openFilePath;
        DataService ds = new DataService();
        private void groupBoxTask_SV_Enter(object sender, EventArgs e)
        {

        }
        private void dataGridViewIn_SV_CellContentClick(object sender, EventArgs e)
        {

        }
        private void buttonSave_SV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SV.FileName = "OutPutFileTask7.csv";
            openFileDialogTask_SV.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialogTask_SV.ShowDialog();

            string path = openFileDialogTask_SV.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_SV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_SV.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonRes_SV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_SV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonSave_SV.Enabled = true;
        }
        private void buttonOpen_SV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SV.ShowDialog();
            openFilePath = openFileDialogTask_SV.FileName;

            string filedata = File.ReadAllText(openFilePath);

            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
        

            dataGridViewIn_SV.ColumnCount = columns;
            dataGridViewIn_SV.RowCount = rows;
            dataGridViewOut_SV.ColumnCount = columns;
            dataGridViewOut_SV.RowCount = rows;

            for (int i = 0; i<columns; i++)
            {
                dataGridViewIn_SV.Columns[i].Width = 35;
                dataGridViewOut_SV.Columns[i].Width = 35;
            }

            for (int i = 0; i<rows; i++)
            {
                for (int j = 0; j<columns; j++)
                {
                    dataGridViewIn_SV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonRes_SV.Enabled = true;
        }

        private void buttonInfo_SV_Click(object sender, EventArgs e)
        {
            FormAbout_SV FA = new FormAbout_SV();
            FA.ShowDialog();
        }
        private void groupBox_SV_Enter(object sender, EventArgs e)
        {

        }
    }
}
