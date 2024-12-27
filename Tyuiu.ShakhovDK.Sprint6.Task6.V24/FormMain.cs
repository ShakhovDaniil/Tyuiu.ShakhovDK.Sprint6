using System.Text;
using Tyuiu.ShakhovDK.Sprint6.Task6.V24.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        public string openFilePath;

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            string[] lines = File.ReadAllLines(openFilePath);
            StringBuilder numberedText = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    numberedText.AppendLine($"{i + 1}: {lines[i]}");
                }
            }

            textBoxIn.Text = numberedText.ToString().TrimEnd();
            groupBoxInput.Text = groupBoxInput.Text + "  " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenFile.Cursor = Cursors.Hand;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp.Cursor = Cursors.Hand;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.Cursor = Cursors.Hand;
        }
    }
}
