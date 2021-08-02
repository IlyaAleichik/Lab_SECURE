using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Morse2
{
    class Program
    {

        

    
        static void Main(string[] args)
        {
            Console.Clear();
            Program p = new Program();
            int num = 0;
            

            Console.WriteLine("Выберите способ \n 1. Из текста в морза");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (num) {

               
                case 1:
                    p.text_morse();
                    break;


            }


        }



        public void text_morse()
        {
            LetterDictionary lett = new LetterDictionary();
            string input = Console.ReadLine();
            Console.Clear();
            string result;
            FileStream fstream = new FileStream("morse.txt", FileMode.OpenOrCreate);
            for (int i = 0; i < input.Length; i++)
            {

                char letter = input[i];
                result = lett.l_Dictionary(letter);                                                  //morseCode[letter];
                Console.Write(result);
                byte[] array = System.Text.Encoding.Default.GetBytes(result);
                fstream.Write(array, 0, array.Length);

            }
            Console.ReadKey();
        }

    }
}
