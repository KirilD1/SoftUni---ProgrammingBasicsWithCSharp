using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogPacks = int.Parse(Console.ReadLine());
            int catPacks = int.Parse(Console.ReadLine());
            double dogFoodPice = 2.5;
            int catFoodPrice = 4;
            double dogFoodSum = dogFoodPice * dogPacks;
            int catFoodSum = catFoodPrice * catPacks;
            double totalSum = dogFoodSum + catFoodSum;
            Console.WriteLine($"{totalSum} lv.");
        }
    }
}
