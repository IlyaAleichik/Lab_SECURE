using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigener
{
    class Program
    {
        
            static void Main(string[] args)
            {
            //Цикл для повтора задачи
            do
            {
                //Путь к файлу

                Console.WriteLine("Введте строку");
                string s = Console.ReadLine(); //Строка, к которой применяется шифрованияе
                string result = ""; //Строка - результат шифрования
                string key = ""; //Строка - ключ шифра
                string key_on_s = ""; //Ключ длиной строки
                int x = 0, y = 0; //Координаты нового символа из таблицы Виженера

                char dublicat; //Дубликат прописной буквы

                //Формирование таблицы Виженера на алфавите кирилицы
                int shift = 0;
                char[,] tabula_recta = new char[32, 32]; //Таблица Виженера
                string alfabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
                //Формирование таблицы
                for (int i = 0; i < 32; i++)
                    for (int j = 0; j < 32; j++)
                    {
                        shift = j + i;
                        if (shift >= 32) shift = shift % 32;
                        tabula_recta[i, j] = alfabet[shift];
                    }
                //Вывод сообщения на экран

                //Запрос ключа 
                Console.WriteLine("Введите ключ шифра");
                //Считывание ключа
                //Объявление флага, для считывания ключа
                bool flag = false;
                //Пока не будет введен ключ из разрешенных символов (прописные и строчные буквы кирилицы)
                while (flag != true)
                {
                    flag = true;
                    //Считывание строки
                    key = Console.ReadLine();
                    //Цикл по каждому элементу ключа
                    for (int i = 0; i < key.Length; i++)
                    {
                        //Если элемент ключа не принадлежит алфавиту кирилицы, изменить флаг
                        if ((Convert.ToInt32(key[i]) < 1072) || (Convert.ToInt32(key[i]) > 1103))
                            flag = false;
                    }

                }

                if (key.Length > 0)
                {


                    //Выполение шифрования
                    //Формирование строки, длиной шифруемой, состоящей из повторений ключа
                    for (int i = 0; i < s.Length; i++)
                    {
                        key_on_s += key[i % key.Length];
                    }
                    //Шифрование при помощи таблицы
                    for (int i = 0; i < s.Length; i++)
                    {
                        //Если не кириллица
                        if (((int)(s[i]) < 1072) || ((int)(s[i]) > 1103))
                            result += s[i];
                        else
                        {
                            //Поиск в первом столбце строки, начинающейся с символа ключа
                            int l = 0;
                            flag = false;
                            //Пока не найден символ
                            while ((l < 32) && (flag == false))
                            {
                                //Если символ найден
                                if (key_on_s[i] == tabula_recta[l, 0])
                                {
                                    //Запоминаем в х номер строки
                                    x = l;
                                    flag = true;
                                }
                                l++;
                            }


                            dublicat = s[i];

                            l = 0;
                            flag = false;
                            //Пока не найден столбец в первой строке с символом строки
                            while ((l < 32) && (flag == false))
                            {
                                //Проверка совпадения
                                if (dublicat == tabula_recta[0, l])
                                {
                                    //Запоминаем номер столбца
                                    y = l;
                                    flag = true;
                                }
                                l++;
                            }

                            result += tabula_recta[x, y];
                        }
                    }
                    //Вывод на экран зашифрованной строки
                    Console.WriteLine("Строка успешно зашифрована!");

                    Console.WriteLine(result);
                }


                Console.WriteLine("Для выхода из программы нажмите Escape");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
