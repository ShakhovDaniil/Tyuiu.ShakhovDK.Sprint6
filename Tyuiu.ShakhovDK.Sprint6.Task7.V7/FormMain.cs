using System.Text;
using Tyuiu.ShakhovDK.Sprint6.Task7.V7.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task6.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        DataService ds = new DataService();
        static int columns;
        static int rows;
        static string openFilePath = "";

        public static int[,] LoadFromDataFile(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
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
            return arrayValues;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromDataFile(openFilePath);
            dataGridViewIn.ColumnCount = columns;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = columns;
            dataGridViewOut.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonDone.Enabled = true;
        }

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenFile.Cursor = Cursors.Hand;
            toolTipInfo.ToolTipTitle = "Открыть файл";
        }

        private void buttonAboutProgram_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonAboutProgram_MouseEnter(object sender, EventArgs e)
        {
            buttonAboutProgram.Cursor = Cursors.Hand;
            toolTipInfo.ToolTipTitle = "О программе";

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayResult = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = arrayResult[r, c];
                }
            }
            buttonSaveFile.Enabled = true;
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.Cursor = Cursors.Hand;
            toolTipInfo.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();
            string path = saveFileDialogMatrix.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut.RowCount;
            int columns = dataGridViewOut.ColumnCount;

            string str = "";
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (c != columns - 1)
                    {
                        str += dataGridViewOut.Rows[r].Cells[c].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut.Rows[r].Cells[c].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void buttonSaveFile_MouseEnter(object sender, EventArgs e)
        {
            buttonSaveFile.Cursor = Cursors.Hand;
            toolTipInfo.ToolTipTitle = "Сохранить";


        }
    }
}
