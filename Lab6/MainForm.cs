namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (rimRadioButton.Checked)
            {
                RimForm form = new RimForm();
                form.Text = "Добавление нового объекта (по диску)...";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    double d = Convert.ToDouble(form.textBoxD.Text);
                    double n = Convert.ToDouble(form.textBoxN.Text);
                    TByRim rim = new TByRim(d, n);
                    listBoxWheels.Items.Add(rim);
                }
            }
            else if (widthRadioButton.Checked)
            {
                WidthForm form = new WidthForm();
                form.Text = "Добавление нового объекта (по ширине)...";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    double d = Convert.ToDouble(form.textBoxD.Text);
                    double n = Convert.ToDouble(form.textBoxN.Text);
                    double k = Convert.ToDouble(form.textBoxK.Text);
                    TByWidth width = new TByWidth(d, n, k);
                    listBoxWheels.Items.Add(width);
                }
            }
            else if (diameterRadioButton.Checked)
            {
                DiameterForm form = new DiameterForm();
                form.Text = "Добавление нового объекта (по диаметру)...";
                if (form.ShowDialog() == DialogResult.OK)
                {
                    double d = Convert.ToDouble(form.textBoxD.Text);
                    double n = Convert.ToDouble(form.textBoxN.Text);
                    TByDiameter diameter = new TByDiameter(d, n);
                    listBoxWheels.Items.Add(diameter);
                }
            }
            else
            {
                MessageBox.Show("Не выбран тип добавляемого объекта", "Внимание");
                return;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxWheels.SelectedIndex != -1)
            {
                listBoxWheels.Items.Remove(listBoxWheels.SelectedItem);
                // Видимо, сброс индекса был лишним
            }
            else
            {
                MessageBox.Show("Не выбран удаляемый объект", "Внимание");
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {

            Type itemType = listBoxWheels.SelectedItem.GetType();
            if (itemType == typeof(TByRim))
            {
                RimForm rimForm = new RimForm();
                TByRim rim = listBoxWheels.Items[listBoxWheels.SelectedIndex] as TByRim;
                rimForm.textBoxD.Text = rim.D.ToString();
                rimForm.textBoxN.Text = rim.N.ToString();
                if (rimForm.ShowDialog() == DialogResult.OK)
                {
                    rim.D = Convert.ToDouble(rimForm.textBoxD.Text);
                    rim.N = Convert.ToDouble(rimForm.textBoxN.Text);
                    listBoxWheels.Items[listBoxWheels.SelectedIndex] = rim;
                }
            }
            else if (itemType == typeof(TByWidth))
            {
                WidthForm widthForm = new WidthForm();
                TByWidth width = listBoxWheels.Items[listBoxWheels.SelectedIndex] as TByWidth;
                widthForm.textBoxD.Text = width.D.ToString();
                widthForm.textBoxN.Text = width.N.ToString();
                widthForm.textBoxK.Text = width.K.ToString();
                if (widthForm.ShowDialog() == DialogResult.OK)
                {
                    width.D = Convert.ToDouble(widthForm.textBoxD.Text);
                    width.N = Convert.ToDouble(widthForm.textBoxN.Text);
                    width.K = Convert.ToDouble(widthForm.textBoxK.Text);
                    listBoxWheels.Items[listBoxWheels.SelectedIndex] = width;
                }
            }
            else if (itemType == typeof(TByDiameter))
            {
                DiameterForm diameterForm = new DiameterForm();
                TByDiameter diameter = listBoxWheels.Items[listBoxWheels.SelectedIndex] as TByDiameter;
                diameterForm.textBoxD.Text = diameter.D.ToString();
                diameterForm.textBoxN.Text = diameter.N.ToString();
                if (diameterForm.ShowDialog() == DialogResult.OK)
                {
                    diameter.D = Convert.ToDouble(diameterForm.textBoxD.Text);
                    diameter.N = Convert.ToDouble(diameterForm.textBoxN.Text);
                    listBoxWheels.Items[listBoxWheels.SelectedIndex] = diameter;
                }
            }

        }

        private void listBoxWheels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWheels.SelectedIndex != -1)
            {
                TWheel wheel = listBoxWheels.Items[listBoxWheels.SelectedIndex] as TWheel;
                resultTextBox.Text = wheel.Calculate().ToString();
                buttonRemove.Enabled = buttonModify.Enabled = true;
            }
            else
            {
                buttonRemove.Enabled = buttonModify.Enabled = false;
                resultTextBox.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxWheels.SelectedIndex = -1;
        }
    }
}