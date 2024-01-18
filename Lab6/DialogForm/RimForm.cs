namespace Programming
{
    public partial class RimForm : Form
    {
        public RimForm()
        {
            InitializeComponent();
        }

        private void RimForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (textBoxD.Text.Trim() != "")
                    {
                        try
                        {
                            if (Convert.ToDouble(textBoxD.Text) <= 0)
                            {
                                textBoxD.Focus();
                                throw new Exception("Некорректное значение диаметра (> 0)!");
                            }
                        }
                        catch (FormatException)
                        {
                            textBoxD.Focus();
                            throw new FormatException("Некорректное значение диаметра (диаметр может быть задан только положительным вещественным числом)");
                        }
                    }
                    else
                    {
                        textBoxD.Focus();
                        throw new Exception("Не указано значение диаметра (> 0)!");
                    }
                    if (textBoxN.Text.Trim() != "")
                    {
                        double N;
                        try
                        {
                            N = Convert.ToDouble(textBoxN.Text);
                            if (N <= 0 || N >= 1)
                            {
                                textBoxN.Focus();
                                throw new Exception($"Значение доли покрышки должно находиться в диапазоне (0; 1)!");
                            }
                        }
                        catch (FormatException)
                        {
                            textBoxN.Focus();
                            throw new FormatException($"Некорректное значение доли покрышки (значение доли может быть задано только вещественным числом в диапазоне (0; 1)");
                        }
                    }
                    else
                    {
                        textBoxN.Focus();
                        throw new Exception("Не указано значение доли покрышки (0; 1)!");
                    }
                }
                catch (Exception ex)
                {
                    e.Cancel = true;
                    MessageBox.Show(ex.Message + "\nПовторите ввод или нажмите на кнопку \"Отмена\"", "Ошибка!");
                }
            }
        }
    }
}
