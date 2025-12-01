using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Code
{
    internal class CalcHistory
    {
        private List<HistoryData> calculatorHistory;
        private static CalcHistory history;
        private CalcHistory()
        {
            calculatorHistory = new List<HistoryData>();
        }
        
        public static CalcHistory GetHistoryInstance()
        {
            if(history == null)
            {
                history = new CalcHistory();
            }
            return history;
        }

        public List<HistoryData> getHistoryList()
        {
            return calculatorHistory;
        }

    }
}
