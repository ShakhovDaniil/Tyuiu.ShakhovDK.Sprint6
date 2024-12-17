using Tyuiu.ShakhovDK.Sprint6.Task3.V29.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task3.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[,] { { -2, -13, -15, -9, -17 },
                                   { 13, -20, -15, 27, 18  },
                                   { -12, -1, -20, 13, 0   },
                                   { 15, 32, 18, -12, -18  },
                                   { 16, 5, 3, -5, -8      }
                                                             };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 Вариант 29 выполнил студент группы ИИПБ-24-2 Шахов Даниил Константинович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            int[,] res_matrix = ds.Calculate(mtrx);
            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(res_matrix[i, j]);
                }
            }
        }
        private void textBoxCondition_Enter(object sender, EventArgs e)
        {
            groupBoxTask.Focus();
        }
    }
}
