using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RSA
{
    class Program
    {
        static bool IsSimple(int nber)
        {
            if (nber < 2) return false;
            for(int i = 2; i <= nber / 2; i++)
            {
                if(nber % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static char[] characters = new char[] { '#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                        'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0', ',' };
        static void Main(string[] args)
        {
            Console.WriteLine();
            string message = Console.ReadLine().ToUpper();
            Random gay = new Random();
            
            int p = gay.Next(111, 133);
            int q = gay.Next(147, 177);

            while (!IsSimple(p))
            {
                p = gay.Next(111, 133);
            }
            while (!IsSimple(q))
            {
                q = gay.Next(147, 177);
            }

            long n = p * q;
            long m = (p - 1) * (q - 1);
            long d = Calculate_d(m);
            long e = Calculate_e(d, m);

            Console.WriteLine($"Открытый ключ: e - {e}, n - {n}");
            Console.WriteLine($"Закрытый ключ: d - {d}, n - {n}");

            List<string> result = RSA_Endoce(message, e, n);
            Console.Write("Сам текст в виде цифорок: ");
            foreach (string item in result)
                Console.Write($"{item} ");

            Console.WriteLine();

            string decresult = RSA_Dedoce(result, d, n);

            Console.WriteLine(decresult);
        }
        static private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) // если имеют общие делители
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        //вычисление параметра e
        static private long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }

        static private List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        //расшифровать
        static private string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi %= n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }
    }
}
