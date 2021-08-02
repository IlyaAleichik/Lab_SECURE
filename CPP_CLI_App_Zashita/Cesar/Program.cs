using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cesar.Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Console.WriteLine("Введите шаг\n");
            Cesar.Shift = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сообщение\n");
            string text = Console.ReadLine();
            Console.WriteLine("Ваше сообщение: {0}", text);
            string crypt = Cesar.Decryption(text);
            Console.WriteLine("\nШифруем текст: {0}\n", crypt);
            text = " ";
            text = Cesar.Encryption(crypt);
            Console.WriteLine("\nДешифруем текст: {0}\n", text);
            Console.ReadKey();
        }
    }
}
