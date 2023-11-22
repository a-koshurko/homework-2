using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input Transaction Nominal:");
            var transNominal = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please input Trade Price:");
            var tradePrice = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Is transaction type Buy or Sell?");
            TransactionType trcType;
            var userInput = Console.ReadLine();
            trcType = (TransactionType)Enum.Parse(typeof(TransactionType), userInput, true);

            var currentValue = (int)trcType * transNominal * tradePrice;
            Console.WriteLine($"Your Current value is {currentValue}!");

            Console.WriteLine("Please input Original Price:");
            var originalPrice = Int32.Parse(Console.ReadLine());


            var factor = (trcType) = "-1" ? 1 : 0;
            var profitLoss = (tradePrice - originalPrice) * transNominal;
            Console.WriteLine($"Your Profit/Loss value is {profitLoss}!");

        }
    }
}