using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());
            double pricePerMeter = 7.61;
            double discountpercent = 0.18;
            double priceTotal = squareMeters * pricePerMeter;
            double discountAmount = priceTotal * discountpercent;
            double priceWithDiscount = priceTotal - discountAmount;

            Console.WriteLine($"The final price is: {priceWithDiscount} lv.");
            Console.WriteLine($"The discount is: {discountAmount} lv.");
                
         }
    }
}
