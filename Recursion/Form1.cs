using System.Globalization;

namespace Recursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFactorial(int n)
        {
            if (n == 0) return 1;
            return n * RecursiveFactorial(n - 1);

        }

        public int RecursiveFibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        public int RecursivePower(int baseNum, int exponent)
        {
            if (exponent == 0) return 1;
            return baseNum * RecursivePower(baseNum, exponent - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtArrayInput.Text);
            int result = RecursiveFactorial(number);
            lblSumResult.Text = $"Factorial: {result}";

        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0) return numbers[0];
            return numbers[n] + RecursiveSum(numbers, n - 1);


        }

        private void CalculateSum_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(' ').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }

        private void CalculateFibonacci_Click(object sender, EventArgs e)
        {

            int number = int.Parse(txtArrayInput.Text);
            int result = RecursiveFibonacci(number);
            lblSumResult.Text = $"Fibonacci: {result}";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int baseNum = int.Parse(txtArrayInput.Text);
            int exponent = int.Parse(txtArrayInput.Text);
            int result = RecursivePower(baseNum, exponent);
            lblSumResult.Text = $"Result: {result}";

        }
    }
}
