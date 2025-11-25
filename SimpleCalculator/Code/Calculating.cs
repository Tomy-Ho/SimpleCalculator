using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Code
{
    internal class Calculating
    {
        private CalculatorUI cUI { get; }
        private double tempResult = 0;

        public Calculating(CalculatorUI cUI) 
        {
            this.cUI = cUI;
        }

        public void calculate()
        {
            double firstNum = cUI.getFirstOperand();
            double secondNum = cUI.getSecondOperand();

            switch (cUI.getOperation())
            {
                case "+":
                    tempResult = firstNum + secondNum;
                    cUI.setResult(tempResult);
                    break;
                case "-":
                    tempResult = firstNum - secondNum;
                    cUI.setResult(tempResult);
                    break;
                case "x":
                    tempResult = firstNum * secondNum;
                    cUI.setResult(tempResult);
                    break;
                case "/":
                    tempResult = firstNum / secondNum;
                    cUI.setResult(tempResult);
                    break;
                case "%":
                    tempResult = firstNum % secondNum;
                    cUI.setResult(tempResult);
                    break;
                case "^":
                    tempResult = Math.Pow(firstNum, secondNum);
                    cUI.setResult(tempResult);
                    break;
                default:
                    break;
            }

        }
    }
}
