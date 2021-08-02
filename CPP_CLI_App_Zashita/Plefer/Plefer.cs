using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plefer
{
    class Plefer
    {
       private struct TablePosition
        {
            public int Row;
            public int Column;

            public TablePosition(int Row, int Column)
            {
                this.Row = Row;
                this.Column = Column;
            }
        }

        private string Bigrams(string Text)
        {
            char prev = '\0';
            bool even = false;
            string bi = "";
            char Replacer = 'ъ';

            foreach (char c in Text)
            {
                char rc = c;

                if (!even)
                {
                    prev = rc;
                    even = true;
                }
                else
                {
                    if (prev == rc)
                    {
                        if (prev != Replacer)
                        {
                            bi += prev;
                            bi += Replacer;
                            prev = rc;
                        }
                    }
                    else
                    {
                        bi += prev;
                        bi += rc;
                        even = false;
                    }

                }
            }

            if (even && prev != Replacer)
            {
                bi += prev; bi += Replacer;
            }
            return bi;
        }

        private int Mod(int x, int m)
        {

            return (x % m + m) % m;
        }

        private string Play(string Key, string Text, bool ModeCrypt = true)
        {
            char[,] Matrix;
            int y = 8, x = 4;

            Char[] alp = "абвгдеёжзийклмнопрстуфхцчшъыьэюя".ToCharArray();

            String key_alp = "";

            var Positions = new Dictionary<char, TablePosition>();

            foreach (char c in Key)
            {

                if (!key_alp.Contains(c))
                {
                    key_alp += c;

                }
            }
            foreach (char c in alp)
            {
                if (!key_alp.Contains(c))
                {
                    key_alp += c;
                }
            }

            Matrix = new char[x, y];
            int i = 0;
            for (int r = 0; r < x; r++)
            {
                for (int c = 0; c < y; c++)
                {

                    Matrix[r, c] = key_alp[i];
                    Positions.Add(key_alp[i], new TablePosition(r, c));
                    Console.Write(key_alp[i] + " ");
                    i++;
                }
                Console.WriteLine("");
            }

            int shift = ModeCrypt ? 1 : -1;
            StringBuilder sb = new StringBuilder();

            var chars = Bigrams(Text).GetEnumerator();
            while (chars.MoveNext())
            {

                var p1 = Positions[chars.Current];
                chars.MoveNext();
                var p2 = Positions[chars.Current];

                int error = 0;
                if (p1.Column == p2.Column)
                {
                    p1.Row = Mod(p1.Row + shift, x);
                    p2.Row = Mod(p2.Row + shift, x);
                    error++;

                }
                else if (p1.Row == p2.Row)
                {
                    p1.Column = Mod(p1.Column + shift, y);
                    p2.Column = Mod(p2.Column + shift, y);
                    error++;


                }

                if (error == 2)
                    throw new ArgumentException("Неправильные биграммы");

                sb.Append(Matrix[p1.Row, p2.Column]);
                sb.Append(Matrix[p2.Row, p1.Column]);
            }

            return sb.ToString();
        }



        public void In()
        {
            Console.WriteLine("*******************************************" +
                              "\nShifr Pleifera                           **" +
                              "\n*******************************************");
            Console.WriteLine("Введите ключ\n");
            string k = (Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Введите текст\n");
                String s = Console.ReadLine();
                Console.WriteLine(Play(k, s));
                Console.WriteLine("\n");
            }
        }
    }
}
