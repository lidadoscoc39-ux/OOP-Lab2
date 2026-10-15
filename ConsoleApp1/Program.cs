using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double x, y, z;

            
            while (true)
            {
                Console.Write("Введіть х: ");
                if (double.TryParse(Console.ReadLine(), out x))
                    break;
                Console.WriteLine("Помилка - некоректно введене значення.");
            }

            
            while (true)
            {
                Console.Write("Введіть y: ");
                if (double.TryParse(Console.ReadLine(), out y))
                    break;
                Console.WriteLine("Помилка - некоректно введене значення.");
            }

            
            while (true)
            {
                Console.Write("Введіть z (більше 0): ");
                if (double.TryParse(Console.ReadLine(), out z))
                {
                    if (z > 0)
                        break;
                    else
                        Console.WriteLine("Помилка: значення z має бути більшим за 0 для обчислення ln(z).");
                }
                else
                {
                    Console.WriteLine("Помилка - некоректно введене значення.");
                }
            }

           
            if (x - y == 0)
            {
                Console.WriteLine("Помилка: ділення на нуль (x дорівнює y у знаменнику дробу ln(z)/(x-y)).");
                return;
            }

            
            double innerFraction = Math.Log(z) / (x - y);
            double numerator = (y - x) * (Math.Cos(y) - innerFraction);
            double denominator = 1.0 + Math.Pow(x - z, 2);

            double s = numerator / denominator;
            s = Math.Round(s, 3);

            Console.WriteLine("Результат: s = " + s);
        }
    }
}