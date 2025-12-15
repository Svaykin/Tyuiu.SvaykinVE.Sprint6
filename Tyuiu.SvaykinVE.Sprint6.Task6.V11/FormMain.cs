using Tyuiu.SvaykinVE.Sprint6.Task6.V11.Lib;

namespace Tyuiu.SvaykinVE.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void groupBoxTask_SV_Enter(object sender, EventArgs e)
        {

        }
        private void buttonOpen_SV_Click(object sender, EventArgs e)
        {
            textBoxOutput_SV.Text = ds.CollectTextFromFile(openFilePath);
            textBoxOutput_SV.Enabled = true;
            buttonOpen_SV.Enabled = false;
            buttonOpen_SV.Enabled = true;
        }
        private void buttonRes_SV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SV.ShowDialog();
            openFilePath = openFileDialogTask_SV.FileName;

            textBoxInput_SV.Multiline = true;

            textBoxInput_SV.Text = File.ReadAllText(openFilePath);
            textBoxPath_SV.Text = textBoxPath_SV.Text + " " + openFileDialogTask_SV.FileName;
            buttonOpen_SV.Enabled = true;
        }
        private void buttonInfo_SV_Click(object sender, EventArgs e)
        {
            formAbout FA = new formAbout();
            FA.ShowDialog();
        }

        private void textBoxTask_SV_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialogTask_SV_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
