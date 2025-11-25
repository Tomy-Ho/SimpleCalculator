using SimpleCalculator.Code;

namespace SimpleCalculator
{
    public partial class CalculatorUI : Form
    {
        private String operation = "";
        private String currentInput = "";
        private String tempStringNum = "";
        private double firstOperand = 0;
        private double secondOperand = 0;
        private double tempNum = 0;
        private double result = 0;
        private Calculating calculating;

        public void setResult(double newResult)
        {
            this.result = newResult;
        }

        public double getFirstOperand()
        {
            return this.firstOperand;
        }

        public double getSecondOperand()
        {
            return this.secondOperand;
        }

        public String getOperation()
        {
            return this.operation;
        }

        public CalculatorUI()
        {
            InitializeComponent();
            this.calculating = new Calculating(this);
        }

        private void clearAllVariables()
        {
            operation = " ";
            currentInput = " ";
            tempStringNum = " ";
            firstOperand = 0;
            secondOperand = 0;
            tempNum = 0;
            result = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            //Button 0
            Button button = (Button)sender;
            tempStringNum += button.Text;
            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Button 1
            Button button = (Button)sender;
            tempStringNum += button.Text;
            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Button 2
            Button button = (Button)sender;
            tempStringNum += button.Text;
            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Button 3
            Button button = (Button)sender;
            tempStringNum += button.Text;
            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Button 4
            Button button = (Button)sender;
            tempStringNum += button.Text;
            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Button 5
            Button button = (Button)sender;
            tempStringNum += button.Text;
            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Button 6
            Button button = (Button)sender;
            tempStringNum += button.Text;
            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Button 7
            Button button = (Button)sender;
            tempStringNum += button.Text;
            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Button 8
            Button button = (Button)sender;
            tempStringNum += button.Text;
            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Button 9
            Button button = (Button)sender;
            tempStringNum += button.Text;
            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Button %
            Button button = (Button)sender;
            operation = button.Text;
            currentInput += operation;
            textBox1.Text = currentInput;
            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Button ^
            Button button = (Button)sender;
            operation = button.Text;
            currentInput += operation;
            textBox1.Text = currentInput;
            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Button =
            secondOperand = tempNum;
            calculating.calculate();
            Button button = (Button)sender;
            textBox1.Multiline = true;
            operation = button.Text;
            String stringResult = operation + " " + result;
            textBox1.Text = currentInput + Environment.NewLine + stringResult;
            clearAllVariables();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Button /
            Button button = (Button)sender;
            operation = button.Text;
            currentInput += operation;
            textBox1.Text = currentInput;
            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Button +
            Button button = (Button)sender;
            operation = button.Text;
            currentInput += operation;
            textBox1.Text = currentInput;
            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Button x
            Button button = (Button)sender;
            operation = button.Text;
            currentInput += operation;
            textBox1.Text = currentInput;
            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Button -
            Button button = (Button)sender;
            operation = button.Text;
            currentInput += operation;
            textBox1.Text = currentInput;
            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Button Del
            Button button = (Button)sender;
            textBox1.Clear();
            clearAllVariables();
        }
    }
}
