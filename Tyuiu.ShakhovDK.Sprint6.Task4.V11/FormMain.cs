using Tyuiu.ShakhovDK.Sprint6.Task4.V11.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task4.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 Вариант 11 выполнил студент группы ИИПБ-24-2 Шахов Даниил Константинович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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
                chartFunction.Series[0].Points.Clear();
                textBoxResult.Text = "";

                for (int i = 0; i < len; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutputFile Task4V11.txt";
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранён успешно.\nОткрыть его в блокноте?", "Сообщение",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
