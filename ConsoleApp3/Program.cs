using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int n, k;

            while (true)
            {
                Console.Write("Введіть n (більше 0): ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    break;
                Console.WriteLine("Помилка - некоректно введене значення.");

            }

            while (true)
            {
                Console.Write("Введіть k (більше 0): ");
                if (int.TryParse(Console.ReadLine(), out k) && k > 0)
                    break;
                Console.WriteLine("Помилка - некоректно введене значення.");

            }

            Console.WriteLine("Введіть номер значення яке необхідно обчислити: \n 1. Сума 1^n+2^(n/2)+...+k^(n/k); \n 2. Сума 1^k+2^k+...+n^k; \n 3. Сума 1/n+1/n^2+3/n^3+...+k/n^k.");
            Console.WriteLine("Ваш вибір: ");

            int choice;
            int.TryParse(Console.ReadLine(), out choice);

            double result = 0;

            switch (choice)
            {
                case 1:
                    for (int i = 1; i <= k; i++)
                        result += Math.Pow(i, (double)n / i);
                    Console.WriteLine("Сума 1: " + result);
                    break;
                case 2:
                    for (int i = 1; i <= n; i++)
                        result += Math.Pow(i, k);
                    Console.WriteLine("Сума 2: " + result);
                    break;
                case 3:
                    for (int i = 1; i <= k; i++)
                        result += (double)i / Math.Pow(n, i);
                    Console.WriteLine("Сума 3: " + result);
                    break;
                default:
                    Console.WriteLine("Некоректний вибір. За замовчуванням обчислюються всі варіанти.");

                    result = 0;
                    for (int i = 1; i <= k; i++)
                        result += Math.Pow(i, (double)n / i);
                    Console.WriteLine("Сума 1: " + result);

                    result = 0;
                    for (int i = 1; i <= n; i++)
                        result += Math.Pow(i, k);
                    Console.WriteLine("Сума 2: " + result);

                    result = 0;
                    for (int i = 1; i <= k; i++)
                        result += (double)i / Math.Pow(n, i);
                    Console.WriteLine("Сума 3: " + result);
                    break;
            }
        }
    }

}