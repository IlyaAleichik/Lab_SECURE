using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class morseCode
{


    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            char letter = input[i];
            switch (letter)
            {
                case 'A': result += ".-"; break;
                case 'B': result += "-..."; break;
                case 'C': result += "-.-."; break;
                case 'D': result += "-.."; break;
                case 'E': result += "."; break;
                case 'F': result += "..-."; break;
                case 'G': result += "--."; break;
                case 'H': result += "...."; break;
                case 'I': result += ".."; break;
                case 'J': result += ".---"; break;
                case 'K': result += "-.-"; break;
                case 'L': result += ".-.."; break;
                case 'M': result += "--"; break;
                case 'N': result += "-."; break;
                case 'O': result += "--.-"; break;
                case 'P': result += ".--."; break;
                case 'Q': result += "--.-"; break;
                case 'R': result += ".-."; break;
                case 'S': result += "..."; break;
                case 'T': result += "-"; break;
                case 'U': result += "..--"; break;
                case 'V': result += "...-"; break;
                case 'W': result += ".--"; break;
                case 'X': result += "-.."; break;
                case 'Y': result += "-.--"; break;
                case 'Z': result += "--.."; break;
                default: result += "/"; break;
            }
        }


        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result);
        }
        

        Console.ReadKey();
       
    }



}