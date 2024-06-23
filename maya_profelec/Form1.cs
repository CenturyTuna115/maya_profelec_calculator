using System.Data;

namespace maya_profelec
{
    public partial class Form1 : Form

    {
        private string input = string.Empty;
        private string operand1 = string.Empty;
        private string operand2 = string.Empty;
        private char operation;
        private double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        string option;
        double results;
        string temp;

        private void AppendDigit(string digit)
        {
            temp += digit;
            textBox1.Text += digit;

        }

        private void bt1(object sender, EventArgs e)
        {
            AppendDigit("1");
        }

        private void bt2(object sender, EventArgs e)
        {
            AppendDigit("2");
        }

        private void bt3(object sender, EventArgs e)
        {
            AppendDigit("3");
        }

        private void bt4(object sender, EventArgs e)
        {
            AppendDigit("4");
        }

        private void bt5(object sender, EventArgs e)
        {
            AppendDigit("5");
        }

        private void bt6(object sender, EventArgs e)
        {
            AppendDigit("6");
        }

        private void bt7(object sender, EventArgs e)
        {
            AppendDigit("7");
        }

        private void bt8(object sender, EventArgs e)
        {
            AppendDigit("8");
        }

        private void bt9(object sender, EventArgs e)
        {
            AppendDigit("9");
        }

        private void bt0(object sender, EventArgs e)
        {
            AppendDigit("0");
        }

        private void btdot(object sender, EventArgs e)
        {
            AppendDigit(".");
        }

        private void btequal(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(temp))
                {
                    DataTable dt = new DataTable();
                    object result = dt.Compute(temp, "");
                    textBox1.Text = result.ToString();
                    textBox2.Text = temp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btmulti(object sender, EventArgs e)
        {
            option = "*";
            AppendDigit("*");
            if (option == "*") { }
        }

        private void btdivide(object sender, EventArgs e)
        {
            option = "/";
            AppendDigit("/");
        }

        private void btminus(object sender, EventArgs e)
        {
            option = "-";
            AppendDigit("-");
        }

        private void btplus(object sender, EventArgs e)
        {
            option = "+";
            AppendDigit("+");
        }

        private void btback(object sender, EventArgs e)
        {
            textBox1.Clear();
            results = 0;
            num1 = 0;
            num2 = 0;
            temp = "";

        }

        private void btdel(object sender, EventArgs e)
        {
            temp = temp.Remove(temp.Length - 1);
            textBox1.Text = temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
