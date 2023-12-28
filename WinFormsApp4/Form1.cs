namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальное значение X
            textBox1.Text = "1";
            // значение X0
            textBox2.Text = "2,2";
            // значение Xk
            textBox3.Text = "0,2";
            // значение b
            textBox4.Text = "3,2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0;
            double xk;
            double dx;
            double b;
            if (!double.TryParse(textBox1.Text, out x0) || !double.TryParse(textBox2.Text, out xk) || !double.TryParse(textBox3.Text, out dx) || !double.TryParse(textBox4.Text, out b))
            {
                MessageBox.Show("Некорректный ввод данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (dx > Math.Abs(xk - x0))
            {
                MessageBox.Show("Некорректный ввод данных! Значение dx больше разности между xk и x0.");
                return;
            }
            if (!double.TryParse(textBox1.Text, out x0) || x0 > xk || dx <= 0 || dx > Math.Abs(xk - x0) || Math.Abs(x0) > 11111111111111)
            {
                MessageBox.Show("Некорректный ввод данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Считывание начальных данных
            x0 = Convert.ToDouble(textBox1.Text);
            xk = Convert.ToDouble(textBox2.Text);
            dx = Convert.ToDouble(textBox3.Text);
            b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = Environment.NewLine;
            // Цикл для табулирования функции
            double x = x0;
            for (x = x0; x <= xk; x += dx)
            {
                double y = 9 *( Math.Pow(x, 3) + Math.Pow(b, 3)) * Math.Tan(x);
                textBox5.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) +
                Environment.NewLine;
                x = x + dx;

            }
        }
    }
}