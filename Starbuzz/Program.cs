using System;

namespace Starbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage expresso = new Expresso();
            Console.WriteLine($"Expresso => {expresso.GetDescription()} Preço {expresso.Cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);

            Console.WriteLine($"beverage2 => {beverage2.GetDescription()} Preço {beverage2.Cost()}");

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Whip(beverage3);
            beverage3 = new Soy(beverage3);

            Console.WriteLine($"beverage3 => {beverage3.GetDescription()} Preço {beverage3.Cost()}");

            Console.ReadLine();
        }
    }
}
