using SimpleCalculator.Code;
using System.Globalization;

namespace SimpleCalculator
{
    public partial class CalculatorUI : Form
    {
        private string operation = "";
        private string currentInput = "";
        private string tempStringNum = "";
        private double firstOperand = 0;
        private double secondOperand = 0;
        private double tempNum = 0;
        private double result = 0;
        private Calculating calculating;
        private string originalHistoryButtonText;

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
            originalHistoryButtonText = button20.Text;
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
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            Button button = (Button)sender;
            tempStringNum += button.Text;

            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Button 1
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            Button button = (Button)sender;
            tempStringNum += button.Text;

            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Button 2
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            Button button = (Button)sender;
            tempStringNum += button.Text;

            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Button 3
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            Button button = (Button)sender;
            tempStringNum += button.Text;

            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Button 4
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            Button button = (Button)sender;
            tempStringNum += button.Text;

            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Button 5
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            Button button = (Button)sender;
            tempStringNum += button.Text;

            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Button 6
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            Button button = (Button)sender;
            tempStringNum += button.Text;

            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Button 7
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            Button button = (Button)sender;
            tempStringNum += button.Text;

            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Button 8
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            Button button = (Button)sender;
            tempStringNum += button.Text;

            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Button 9
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            Button button = (Button)sender;
            tempStringNum += button.Text;

            tempNum = Convert.ToDouble(tempStringNum);
            currentInput += button.Text;
            textBox1.Text = currentInput;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Button %
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }
            Button button = (Button)sender;
            operation = button.Text;

            currentInput += " " + operation + " ";
            textBox1.Text = currentInput;

            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Button ^
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }
            Button button = (Button)sender;
            operation = button.Text;

            currentInput += " " + operation + " ";
            textBox1.Text = currentInput;

            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Button =
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }

            secondOperand = tempNum;
            calculating.calculate();

            HistoryData historyData = new HistoryData(firstOperand.ToString(), operation, secondOperand.ToString(), result.ToString());
            CalcHistory.GetHistoryInstance().getHistoryList().Add(historyData);

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
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }
            Button button = (Button)sender;
            operation = button.Text;

            currentInput += " " + operation + " ";
            textBox1.Text = currentInput;

            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Button +
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }
            Button button = (Button)sender;
            operation = button.Text;

            currentInput += " " + operation + " ";
            textBox1.Text = currentInput;

            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Button x
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }
            Button button = (Button)sender;
            operation = button.Text;

            currentInput += " " + operation + " ";
            textBox1.Text = currentInput;

            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Button -
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }
            Button button = (Button)sender;
            operation = button.Text;

            currentInput += " " + operation + " ";
            textBox1.Text = currentInput;

            firstOperand = tempNum;
            tempNum = 0;
            tempStringNum = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Button Del
            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }
            Button button = (Button)sender;
            textBox1.Clear();
            clearAllVariables();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Button History
            textBox1.Clear();
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            string historyText = " ";
            Button button = (Button)sender;

            if (textBox1.Text.Equals("Esc"))
            {
                button20.Text = originalHistoryButtonText;
            }
            else
            {
                button.Text = "Esc";
            }
            foreach (HistoryData data in CalcHistory.GetHistoryInstance().getHistoryList())
            {
                historyText = data.firstOpperand + " " + data.operation + " " + data.secondOpperand + "\n= " + data.result;
                textBox1.Text += historyText + Environment.NewLine;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (tempStringNum.Contains(","))
            {
                return;
            }

            tempStringNum += ",";

            currentInput += ",";
            textBox1.Text = currentInput;
        }
    }
}
