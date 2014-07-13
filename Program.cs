using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace практика_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите значение а");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение c");
            c = Convert.ToDouble(Console.ReadLine());

            if (a > 0 & b > 0 & c > 0 && a + b > c && a + c > b && c + b > a)
                if (a *a + b *b==c*c||a *a+ c * c== b * b|| c * c + b * b == a * a)
                    Console.WriteLine("треугольник прямоугольный");
                else
                    if (a * a + b * b > c * c && a * a + c * c > b * b && c * c + b * b > a * a)
                        Console.WriteLine("треугольник остроугольный");
                    else
                        Console.WriteLine("треугольник тупоугольный");
            else
                Console.WriteLine("треугольник не существует");
            Console.ReadKey();

        }
    }
}
