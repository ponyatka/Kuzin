namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Clear();
            comboBox1.Items.Add("����� ����������");
            comboBox1.Items.Add("������� �����");
            comboBox1.Items.Add("����� ����");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "����� ����������":
                        if (double.TryParse(textBox1.Text, out double radius))
                        {
                            double circumference = 2 * Math.PI * radius;
                            label3.Text = circumference.ToString();
                        }
                        break;
                }
                {
                    if (comboBox1.SelectedItem != null)
                    {
                        if (comboBox1.SelectedItem != null)
                        {
                            switch (comboBox1.SelectedItem.ToString())
                            {
                                case "������� �����":

                                    if (double.TryParse(textBox1.Text, out var radius)) // ����������� ������� ���������� ����������
                                    {
                                        var volume = Math.PI * Math.Pow(radius, 2);

                                        label3.Text = volume.ToString("N3");
                                    }
                                    break;
                            }

                            {
                                if (comboBox1.SelectedItem != null)
                                {
                                    switch (comboBox1.SelectedItem.ToString())
                                    {
                                        case "����� ����":
                                            if (double.TryParse(textBox1.Text, out var radius)) // ����������� ������� ���������� ����������
                                            {
                                                var volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

                                                label3.Text = volume.ToString("N3");
                                            }
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
                        