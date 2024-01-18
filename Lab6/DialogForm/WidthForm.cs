namespace Programming
{
    public partial class WidthForm : Form
    {
        public WidthForm()
        {
            InitializeComponent();
        }

        private void WidthForm_FormClosing(object sender, FormClosingEventArgs e)
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
                                throw new Exception("Значение диаметра должно быть больше 0!");
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
                            if (Convert.ToDouble(textBoxN.Text) <= 0)
                            {
                                textBoxN.Focus();
                                throw new Exception($"Значение ширины покрышки должно быть больше 0!");
                            }
                        }
                        catch (FormatException)
                        {
                            textBoxN.Focus();
                            throw new FormatException($"Некорректное значение ширины покрышки (ширина может быть заданa только положительным вещественным числом)");
                        }
                    }
                    else
                    {
                        textBoxN.Focus();
                        throw new Exception("Не указано значение ширины покрышки (ширина может быть заданa только положительным вещественным числом)!");
                    }
                    if (textBoxK.Text.Trim() != "")
                    {
                        try
                        {
                            double K = Convert.ToDouble(textBoxK.Text);
                            if (K <= 0 || K >= 1)
                            {
                                textBoxK.Focus();
                                throw new Exception($"Значение доли в диаметре от шины должно находиться в диапазоне (0; 1)!");
                            }
                        }
                        catch (FormatException)
                        {
                            textBoxK.Focus();
                            throw new FormatException($"Некорректное значение доли в диаметре от шины (доля может быть заданa только вещественным числом в диапазоне (0; 1))");
                        }
                    }
                    else
                    {
                        textBoxK.Focus();
                        throw new Exception("Не указано значение доли в диаметре от шины (доля может быть заданa только вещественным числом в диапазоне (0; 1))");
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
