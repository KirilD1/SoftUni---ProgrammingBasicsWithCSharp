using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cm = double.Parse(Console.ReadLine());
            double inch = 2.54;
            double cmtoinch = cm * inch;
            Console.WriteLine(cmtoinch);
        }
    }
}
