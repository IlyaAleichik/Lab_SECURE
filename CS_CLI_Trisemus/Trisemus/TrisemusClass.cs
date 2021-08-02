using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trisemus
{
    class TrisemusClass
    {

        public void f_Trisemus () {

            Console.WriteLine("Введите сообщение \n");

            string s = Console.ReadLine();

        char[,] kluch = {
                           {'б','а','н','д','е','р'},
                           {'о','л','ь','в','г','ё'},
                           {'ж','з','и','й','к','м'},
                           {'п','с','т','у','ф','х'},
                           {'ц','ч','ш','щ','ъ','ы'},
                           {'э','ю','я','_','_','_'},
                           };


            Console.WriteLine("\n Зашифрованное  сообщение :\n");
            string temp;
        string s1 = "";
            for (int q = 0; q<s.Length; q++)
            {
                for (int i = 0; i< 6; i++)
                {
                    for (int j = 0; j< 6; j++)
                    {
                        if (s[q] == kluch[i, j])
                        {

                            temp = Convert.ToString(kluch[i + 1, j]);
                            s1 += temp;
                            
                        }

                    }
                }
            }
            Console.WriteLine(s1);

            f_Exit();
        }

        private void f_Exit()
        {
            try { 
            Console.WriteLine("\n Желаете повторить y/n");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == 'y')
            {
                Console.Clear();
                f_Trisemus();

            }
            else { }
            }
            catch { }


        }


    }
}
