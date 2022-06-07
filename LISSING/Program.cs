using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену за 1 кг = ");
            double C = double.Parse(Console.ReadLine());
            Console.Write("Введите вес яблок = ");
            double V = double.Parse(Console.ReadLine());
            double x = C * V;
            Console.WriteLine($"Стоимость яблок = {x}");
        }
    }
}
