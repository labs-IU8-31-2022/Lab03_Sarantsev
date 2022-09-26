using System;

namespace lab03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("TASK 1");

            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(4, 5, 6);
            Vector v3 = new Vector(4, 5, 6);
            Console.WriteLine($"The result of +: {v1 + v2}");
            Console.WriteLine($"The result of *: {v1 * v2}");
            Console.WriteLine($"The result of * with value: {5 * v1}");
            Console.WriteLine($"The result of <: {v1 < v2}");
            Console.WriteLine($"The result of >: {v1 > v2}");
            Console.WriteLine($"The result of !=: {v1 != v3}");
            Console.WriteLine($"The result of !=: {v2 == v3}");

            Console.WriteLine("TASK 2");

            var cars_catalog = new CarsCatalog(new[]
            {
                new Car("car1", 120, "engine1"),
                new Car("car2", 220, "engine2"),
                new Car("car3", 320, "engine3")
            });
            Car car0 = new Car("car0", 50, "engine0");
            Console.WriteLine(car0.ToString());
            var car1 = cars_catalog[0];
            var car2 = cars_catalog[1];
            var car3 = cars_catalog[2];
            Console.WriteLine($"Сomparison: {car1 == car2}");
            Console.WriteLine(cars_catalog[0]);
            Console.WriteLine(cars_catalog[1]);
            Console.WriteLine(cars_catalog[2]);

            Console.WriteLine("TASK 3");
            Console.WriteLine("Enter a variant of exchange: \n1) RUB to USD \n2) RUB to EUR \n3) EUR to RUB \n4) EUR to USD \n5) USD to RUB \n6) USD to EUR");
            int choose = Convert.ToInt16(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the exchange rate: ");
                        double rate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the value: ");
                        double value = Convert.ToDouble(Console.ReadLine());
                        CurrencyRUB currencyRUB = new CurrencyRUB(value, rate);
                        CurrencyUSD currencyUSD = currencyRUB;
                        Console.WriteLine(currencyUSD.ValueUSD);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the exchange rate: ");
                        double rate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the value: ");
                        double value = Convert.ToDouble(Console.ReadLine());
                        CurrencyRUB currencyRUB = new CurrencyRUB(value, rate);
                        CurrencyEUR currencyEUR = currencyRUB;
                        Console.WriteLine(currencyEUR.ValueEUR);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter the exchange rate: ");
                        double rate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the value: ");
                        double value = Convert.ToDouble(Console.ReadLine());
                        CurrencyEUR currencyEUR = new CurrencyEUR(value, rate);
                        CurrencyRUB currencyRUB = currencyEUR;
                        Console.WriteLine(currencyRUB.ValueRUB);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter the exchange rate: ");
                        double rate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the value: ");
                        double value = Convert.ToDouble(Console.ReadLine());
                        CurrencyEUR currencyEUR = new CurrencyEUR(value, rate);
                        CurrencyUSD currencyUSD = currencyEUR;
                        Console.WriteLine(currencyUSD.ValueUSD);
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Enter the exchange rate: ");
                        double rate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the value: ");
                        double value = Convert.ToDouble(Console.ReadLine());
                        CurrencyUSD currencyUSD = new CurrencyUSD(value, rate);
                        CurrencyRUB currencyRUB = currencyUSD;
                        Console.WriteLine(currencyRUB.ValueRUB);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Enter the exchange rate: ");
                        double rate = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the value: ");
                        double value = Convert.ToDouble(Console.ReadLine());
                        CurrencyUSD currencyUSD = new CurrencyUSD(value, rate);
                        CurrencyEUR currencyEUR = currencyUSD;
                        Console.WriteLine(currencyEUR.ValueEUR);
                        break;
                    }
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
