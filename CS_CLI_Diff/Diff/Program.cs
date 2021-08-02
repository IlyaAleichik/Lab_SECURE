using System;
using System.Text;
using System.Collections.Generic;

namespace Diff
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            decimal g, p, a, b, A, B, K1, K2;
            p = 19;
            g = 3;

            // и тип g < p && g > 1 должно быть
            // g^(p-1) mod p = 1

            a = rand.Next(0, 10);
            b = rand.Next(5, 15);

            Console.WriteLine($"Ключек Анатолия - {a}, ключек его Бати - {b}");

            A = SoNiceFunction(g, a, p);
            B = SoNiceFunction(g, b, p);

            Console.WriteLine($"Открытый ключек Анатолия - {A}, Открытый ключек его Бати - {B}");

            K1 = SoNiceFunction(B, a, p); // g^ключек mod p
            K2 = SoNiceFunction(A, b, p);

            Console.WriteLine($"{K1} : {K2}");
        }
        static decimal SoNiceFunction(decimal g, decimal step, decimal p)
        {
            decimal t = g;
            for (int i = 0; i < step; i++)
                t *= g;
            return t % p;
        }
    }
}