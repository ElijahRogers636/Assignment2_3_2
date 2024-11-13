using System;

namespace Assignment2_3_2
{
	// Class should be instantiated with bill amount
	public class BillTotal
	{
		public double NcSalesTax { get; set; } = 0.0475;
		public double BillBeforeTax { get; set; }
		public double BillEndAmount { get; set; }

        Random rand = new Random();

        public BillTotal() 
		{
			//Random bill generation on class instantiation with a max of $200 (Rounds because we are dealing with money)
            BillBeforeTax = Math.Round((rand.NextDouble() * 200), 2);
		}


        // Calculates the total tip amount based on BillBeforeTax (Does not round for a more accurate number)
        public double TipCalculation(double tipPercentage)
		{

			return (BillBeforeTax * (tipPercentage / 100));

        }

		// Calculates tip suggestions for 10%, 15%, 20%, and 25% and displays them
		public void TipSuggestions()
		{
			Console.WriteLine("Suggested Tip Percentages: ");
			Console.Write("| 10%: " + Math.Round((BillBeforeTax * 0.10), 2).ToString("0.00") + " | ");
            Console.Write("15%: " + Math.Round((BillBeforeTax * 0.15), 2).ToString("0.00") + " | ");
            Console.Write("20%: " + Math.Round((BillBeforeTax * 0.20), 2).ToString("0.00") + " | ");
            Console.Write("25%: " + Math.Round((BillBeforeTax * 0.25), 2).ToString("0.00") + " |");
        }

		// Calculates the sales tax for NC (Does not round for a more accurate number)
        public double SalesTaxCalculator()
        {
            return BillBeforeTax * NcSalesTax;
        }

        // Calculate the total plus tip
		// (Rounds because this is the end of calcualtions and adds rounded bill tax and sales tax calulation to be more in line with whats shown on console)
        public double BillTotalAmount(double tipAmount)
		{
			double totalBillPlusTax = Math.Round(BillBeforeTax, 2) + Math.Round(SalesTaxCalculator(), 2);

			return Math.Round((totalBillPlusTax + tipAmount), 2);
		}

	}
}
