using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobile_bill
{
    public class BillCalculationService
    {
        public decimal CalculateBill(DateTime startTime, DateTime endTime)
        {
            decimal generatedBill = 0;
            var countableTime = startTime;

            while (countableTime <= endTime)
            {
                countableTime = countableTime.AddSeconds(Constants.Pulse);
                generatedBill += GetThePulseRate(countableTime);
            }

            return generatedBill.ConvertToTaka();
        }

        private int GetThePulseRate(DateTime theTime)
        {
            return theTime.IsPeekHour() ? 30 : 20;
        }
    }
}
