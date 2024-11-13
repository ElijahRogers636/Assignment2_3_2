using System;

namespace Assignment2_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BillTotal newBill = new BillTotal();
            Console.WriteLine("Bill Total: $" + newBill.BillBeforeTax.ToString("0.00"));
            Console.WriteLine("Please Enter a tip percentage");
            newBill.TipSuggestions();
            Console.WriteLine();
            Console.Write("Tip Percentage: %");
            double tipPercentage = Convert.ToDouble(Console.ReadLine());

            // Bill Details
            if (tipPercentage >= 0)
            {
                double tipAmount = Math.Round(newBill.TipCalculation(tipPercentage), 2);
                double billEndAmount = newBill.BillTotalAmount(tipAmount);
                Console.WriteLine();
                Console.WriteLine("NC Sales Tax: $" + Math.Round(newBill.SalesTaxCalculator(), 2).ToString("0.00"));
                Console.WriteLine();
                Console.WriteLine("Tip Amount: $" + tipAmount.ToString("0.00"));
                Console.WriteLine();
                Console.WriteLine("Bill Total: $" + billEndAmount.ToString("0.00"));
                newBill.BillEndAmount = billEndAmount;
            }
            else
            {
                Console.WriteLine("Tip Cannot Be Negative");
            }
        }
    }
}
