using Tyuiu.ShakhovDK.Sprint6.Task5.V23.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\unseld\source\repos\Tyuiu.ShakhovDK.Sprint6\Tyuiu.ShakhovDK.Sprint6.Task5.V23\bin\Debug\net8.0-windows\InPutDataFileTask5V23.txt";

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 Вариант 23 выполнил студент группы ИИПБ-24-2 Шахов Даниил Константинович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.chartDiag.Series[0].Points.Clear();
            double[] resArray = new double[ds.len];
            resArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < resArray.Length; i++)
            {
                dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(resArray[i]));
                chartDiag.Series[0].Points.AddXY(i, resArray[i]);
            }
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.Cursor = Cursors.Hand;
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            buttonHelp.Cursor = Cursors.Hand;
        }

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenFile.Cursor = Cursors.Hand;
        }
    }
}
