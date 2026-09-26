using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double a, b, c;

            Console.WriteLine("Розв'язання квадратного рівняння");

            while (true)
            {
                Console.Write("Введіть a: ");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                Console.WriteLine("Помилка - некоректно введене значення.");

            }


            while (true)
            {
                Console.Write("Введіть b: ");
                if (double.TryParse(Console.ReadLine(), out b))
                    break;
                Console.WriteLine("Помилка - некоректно введене значення.");

            }

            while (true)
            {
                Console.Write("Введіть c: ");
                if (double.TryParse(Console.ReadLine(), out c))
                    break;
                Console.WriteLine("Помилка - некоректно введене значення.");

            }

            if (a == 0)
            {
                Console.WriteLine("Це лінійне рівняння");
                return;
            }

            double d = b * b - 4 * a * c;
            Console.WriteLine("Дискримінант дорівнює " + d);

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine("Корені квадратного рівняння: х1 = " + x1 + ", x2 = " + x2);
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Корінь квадратного рівняння: x =" + x);
            }
            else
            {
                Console.WriteLine("Квадратне рівняння не має розв'язку");
            }

        }
    }

}

