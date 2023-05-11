using System;
namespace csharptest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0: Console.WriteLine("ноль"); break;
                case 1: Console.WriteLine("один"); break;
                case 2: Console.WriteLine("два"); break;
                case 3: Console.WriteLine("три"); break;
                case 4: Console.WriteLine("четыре"); break;
                case 5: Console.WriteLine("пять"); break;
                case 6: Console.WriteLine("шесть"); break;
                case 7: Console.WriteLine("семь"); break;
                case 8: Console.WriteLine("восемь"); break;
                case 9: Console.WriteLine("девять"); break;
            }
        }
    }
}