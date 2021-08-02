using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleSquare
{
    class DoubleSquare
    {
        private Char[] alp = "абвгдеёжзийклмнопрстуфхцчшъыьэюя".ToCharArray();

        struct TablePosition
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
            char replace = 'ъ';

            foreach (char c in Text)
            {
                char rc = c;
                if (!even) // 1й знак биграммы
                {
                    //запоминаем его 
                    prev = rc;
                    even = true;
                }
                else
                {
                    //  ищем второй символ биграммы
                    if (prev == rc) //если он такой же как и первый
                    {
                        if (prev != replace) // а первый на Replacer
                        {
                            //то возвращаем из Replacera в конец
                            bi += prev;
                            bi += replace;
                            // и будем считать, что нашли первый символ
                            prev = rc;
                        }
                    }
                    else
                    {
                        // если они оба разные то продолжаем поиск
                        bi += prev;
                        bi += rc;
                        even = false;
                    }
                }
            }

            // когда мы ищем другой знак, а ряд уже закончился
            // при этом первый знак на replace-сe
            if (even && prev != replace)
            {
                bi += prev; bi += replace;
            }
            return bi;
        }

        private int Mod(int x, int m)
        {
            return (x % m + m) % m;
        }

        private string Play(string KeyL, string KeyR, string Text, bool ModeCrypt = true)
        {

            char[,] MatrixL, MatrixR;
            int y = 8, x = 4;
            String key_alp_L = "", key_alp_R = "";
            var PositionsL = new Dictionary<char, TablePosition>();
            var PositionsR = new Dictionary<char, TablePosition>();
            foreach (char c in KeyL)
            {
                if (!key_alp_L.Contains(c))
                {
                    key_alp_L += c;
                }
            }

            foreach (char c in KeyR)
            {
                if (!key_alp_R.Contains(c))
                {
                    key_alp_R += c;
                }
            }

            foreach (char c in alp)
            {
                if (!key_alp_L.Contains(c))
                {
                    key_alp_L += c;

                }
            }

            foreach (char c in alp)
            {
                if (!key_alp_R.Contains(c))
                {
                    key_alp_R += c;
                }
            }

            MatrixL = new char[x, y];
            MatrixR = new char[x, y];

            int i = 0;
            Console.WriteLine("Левая таблица\n");
            for (int r = 0; r < x; r++)
            {
                for (int c = 0; c < y; c++)
                {
                    MatrixL[r, c] = key_alp_L[i];
                    PositionsL.Add(key_alp_L[i], new TablePosition(r, c));
                    Console.Write(key_alp_L[i] + " ");
                    i++;
                }
                Console.WriteLine("");
            }
            i = 0;
            Console.WriteLine("Правая таблица\n");
            for (int r = 0; r < x; r++)
            {
                for (int c = 0; c < y; c++)
                {
                    MatrixR[r, c] = key_alp_R[i];
                    PositionsR.Add(key_alp_R[i], new TablePosition(r, c));
                    Console.Write(key_alp_R[i] + " ");
                    i++;
                }
                Console.WriteLine("");
            }
            int shift = ModeCrypt ? 1 : -1;
            StringBuilder sb = new StringBuilder();
            // происоходи разбивание на бишки
            var chars = Bigrams(Text).GetEnumerator();
            bool flag = false;
            while (chars.MoveNext())
            {
                flag = !flag;
                TablePosition p1, p2;
                // получаем координаты символов бишки в таблице
                // при дешифровку, когда шифротекст явлется ошибочным
                // т.е. нечетный или не входит в алфавит
                if (flag)
                {
                    p1 = PositionsL[chars.Current];
                    chars.MoveNext();
                    p2 = PositionsL[chars.Current];
                }
                else
                {
                    p1 = PositionsR[chars.Current];
                    chars.MoveNext();
                    p2 = PositionsR[chars.Current];
                }
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
                    throw new ArgumentException("Неправильная биграмма");
                if (flag)
                {
                    sb.Append(MatrixL[p1.Row, p2.Column]);
                    sb.Append(MatrixL[p2.Row, p1.Column]);
                }
                else
                {
                    sb.Append(MatrixR[p1.Row, p2.Column]);
                    sb.Append(MatrixR[p2.Row, p1.Column]);
                }
            }
            return sb.ToString();
        }



        public void StartShifr()
        {

            Console.WriteLine("*******************************************" +
                            "\nShifr Double Square Winstona            **" +
                            "\n*******************************************");
            Console.WriteLine("Введите левый ключ\n");
            string l = (Console.ReadLine());
            Console.WriteLine("Введите правый ключ\n");
            string r = (Console.ReadLine());


            ret:

            Console.WriteLine("Введите текст\n");
                String s2 = Console.ReadLine();


                 Console.WriteLine("\nУдаление символов не из алфавита\n");


            

                s2 = s2.ToLower();
                String s = "";
                foreach (var c in s2)
                    if (alp.Contains(c))
                        s += c;
                Console.WriteLine(s);
                Console.WriteLine("\n1-Расшифрровать\n2-Зашифровать\n");
                int i = Int32.Parse(Console.ReadLine());
                switch (i) {

                    case 1:
                        Console.WriteLine("Расшифрованный текст:\n  " + Play(l, r, s, false));
                        break;
                    case 2:
                        Console.WriteLine("Зашифрованный текст:\n  " + Play(l, r, s));
                        break;

                }    
               
            Console.WriteLine("\n");
            
            Console.WriteLine("\n////////////////////////////////////////////////////////////////" +
                          "\n//           Продолжить работу с программой y/n               //" +
                          "\n////////////////////////////////////////////////////////////////");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'y')
            {

                goto ret;

            }
            else { }





        }

     

    }
}
