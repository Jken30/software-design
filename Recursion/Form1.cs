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
            int result = RecursiveSum(numbers, numbers.Length -1);
            lblSumResult.Text = $"Sum: {result}";
        }
    }
}
