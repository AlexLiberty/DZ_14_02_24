using System.Runtime.InteropServices;

namespace DZ_14_02_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Thread fibonacciThread;
        private bool isGenerating;
        private bool stopRequested = false;
        private bool isPaused;

        private struct FibonacciData
        {
            public int Index;
            public int Value;
        }
        private void generator_Button_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(start_textBox.Text, out int min) || !int.TryParse(end_textBox.Text, out int max))
            {
                MessageBox.Show("Помилка! Введіть число.");
                return;
            }

            if (min >= max)
            {
                MessageBox.Show("Мінімальне число має бути менше за максимальне.");
                return;
            }

            Random rand = new Random();
            for (int i = min; i <= max; i++)
            {
                int randomNumber = rand.Next(min, max + 1);
                result_textBox.Text += randomNumber.ToString() + " ";
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            result_textBox.Clear();
        }

        private void GenerateFibonacci(object objCount)
        {
            int count = (int)objCount;

            for (int i = 0; i < count && !stopRequested; i++)
            {
                    while (isPaused)
                    {
                        Thread.Sleep(100);
                    }           

                int fibNumber = CalculateFibonacci(i);

                FibonacciData data = new FibonacciData
                {
                    Index = i + 1,
                    Value = fibNumber
                };

                Invoke(new Action(() =>
                {
                    result_textBox.AppendText($"{data.Index}: {data.Value}" + "  |  ");
                }));

                Thread.Sleep(100);
            }

            isGenerating = false;
            stopRequested = false;
            isPaused = false;
        }
        private int CalculateFibonacci(int n)
        {
            if (n <= 1)
                return n;
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
        private void fibonachi_button_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(start_textBox.Text, out int count))
            {
                MessageBox.Show("Введіть число!");
                return;
            }

            if (isGenerating)
            {
                MessageBox.Show("Генератор запущений.");
                return;
            }

            if (isPaused)
            {
                isPaused = false;
                return;
            }

            isGenerating = true;

            fibonacciThread = new Thread(GenerateFibonacci);

            fibonacciThread.Start(count);
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            if (isGenerating && fibonacciThread != null)
            {
                stopRequested = true;
            }
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            if (isGenerating && fibonacciThread != null)
            {
                isPaused = true;
            }
        }

        private void resume_button_Click(object sender, EventArgs e)
        {
            if (isGenerating && fibonacciThread != null)
            {
                isPaused = false;
            }
        }
    }
}
