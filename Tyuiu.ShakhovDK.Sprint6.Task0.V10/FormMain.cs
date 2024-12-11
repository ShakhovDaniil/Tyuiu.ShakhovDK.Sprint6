using System.Drawing.Text;
using System.Security.AccessControl;
using Tyuiu.ShakhovDK.Sprint6.Task0.V10.Lib;
namespace Tyuiu.ShakhovDK.Sprint6.Task0.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxVar_X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(int.Parse(textBoxVar_X.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Вариант 10 выполнил студент группы ИИПБ-24-2 Шахов Даниил Константинович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
