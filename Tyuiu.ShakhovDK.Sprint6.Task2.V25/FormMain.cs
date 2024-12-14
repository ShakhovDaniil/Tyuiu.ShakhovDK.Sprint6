using Tyuiu.ShakhovDK.Sprint6.Task2.V25.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task2.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 1 ������� 20 �������� ������� ������ ����-24-2 ����� ������ ��������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_of_the_range.Text);
                int endValue = Convert.ToInt32(textBoxEndValue_of_the_range.Text);
                int len = ds.GetMassFunction(startValue, endValue).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, endValue);
                this.chartFunction.Titles.Add("������ �������");
                this.chartFunction.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "��� Y";


                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewResult.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Blue;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone.BackColor = Color.Green;
        }
    }
}
