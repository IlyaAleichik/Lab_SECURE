using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquare
{
    class MagicSquare
    {
        public void Magic_Square()
        {
            string randomLine = "ЙЦУКЕНГШЩЗХФЪЫВАПРОЛДЖЭЧСМИТЬБЮ";
            Random rand = new Random();

            Console.WriteLine("*******************************************" +
                              "\nShifr Magic Square                       **" +
                              "\n*******************************************");
            Console.WriteLine("Введите сообщение:\n");
            String line = Console.ReadLine().ToUpper().Replace(" ", "");
            Console.WriteLine("Введите кол-во j");
            int dj = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во i");
            int di = Convert.ToInt32(Console.ReadLine());

            //int d = (int)Math.Ceiling(Math.Sqrt(line.Length));
            //if (d % 2 != 1)
            //d++;
            int d = (int)Math.Ceiling(Math.Sqrt(line.Length));
            
            Console.WriteLine("\nМагический квадрат: " + dj.ToString() + "x "+ di.ToString() + "\n");
            int[,] quad = new int[d, di];
            for (int j = 0; j < dj; j++)
            {
                for (int i = 0; i < di; i++)
                {
                    quad[i, j] = di * (((i + 1) + (j + 1) - 1 + (di / 2)) % dj) + (((i + 1) + 2 * (j + 1) - 2) % di) + 1;
                    Console.Write(quad[i, j].ToString() + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nШифрование сообщения:\n");
            string cryptedString = "";
            for (int j = 0; j < dj; j++)
            {
                for (int i = 0; i < di; i++)
                {
                    if ((quad[i, j] - 1) < line.Length)
                    {
                        Console.Write(line[quad[i, j] - 1] + "\t");
                        cryptedString += line[quad[i, j] - 1];
                    }
                    else
                    {
                        char randomChar = randomLine[rand.Next(0, randomLine.Length - 1)];
                        Console.Write(randomChar + "\t");
                        cryptedString += randomChar;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nЗашифрованная строка:\n");
            Console.WriteLine(cryptedString);
           
        }

    }
}
