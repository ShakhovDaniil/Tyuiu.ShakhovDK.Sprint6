using Tyuiu.ShakhovDK.Sprint6.Task1.V20.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task1.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
                textBoxResult.Text = "";
                textBoxResult.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult.AppendText("|     X     |    F(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+-----------+-----------+" + Environment.NewLine);
                string strline;

                for (int i = 0; i < len; i++)
                {
                    strline = String.Format("|{0,6:d}     |  {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxResult.AppendText(strline + Environment.NewLine);
                    startValue++;
                }
                textBoxResult.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 1 ������� 20 �������� ������� ������ ����-24-2 ����� ������ ��������������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
