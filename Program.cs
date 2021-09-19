using System;

namespace mobile_bill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Start time: ");
                var inputStartTime = Console.ReadLine();
                Console.Write("Enter End time: ");
                var inputEndTime = Console.ReadLine();

                var startTime = GetConvertedDateTime(inputStartTime, "Start");
                var endTime = GetConvertedDateTime(inputEndTime, "End");

                var billCalculationService = new BillCalculationService();
                var generatedBill = billCalculationService.CalculateBill(startTime, endTime);

                Console.WriteLine("{0} taka", generatedBill);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Someting went wrong!  {0}", ex.Message);
            }
        }

        private static DateTime GetConvertedDateTime(string inputTime, string prefix)
        {
            return Convert.ToDateTime(inputTime.Replace($"{prefix} time:", string.Empty));
        }
    }
}
