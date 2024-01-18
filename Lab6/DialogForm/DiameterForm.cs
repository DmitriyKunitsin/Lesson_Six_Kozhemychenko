namespace Programming
{
    public partial class DiameterForm : Form
    {
        public DiameterForm()
        {
            InitializeComponent();
        }

        private void DiameterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    double D;
                    if (textBoxD.Text.Trim() != "")
                    {
                        try
                        {
                            D = Convert.ToDouble(textBoxD.Text);
                            if (D <= 0)
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
                        try
                        {
                            double N = Convert.ToDouble(textBoxN.Text);
                            if (N < 0 || N >= D)
                            {
                                textBoxN.Focus();
                                throw new Exception($"Значение размера в диаметре должно находиться в диапазоне (0; {Convert.ToDouble(textBoxD.Text)}) (т.е. до самого диаметра)!");
                            }
                        }
                        catch (FormatException)
                        {
                            textBoxN.Focus();
                            throw new FormatException($"Некорректное значение размера в диаметре (размер может быть задан только вещественным числом в диапазоне (0; {Convert.ToDouble(textBoxD.Text)})");
                        }
                    }
                    else
                    {
                        textBoxN.Focus();
                        throw new Exception("Не указано значение размера в диаметре (> 0)!");
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
