using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse2
{
    class LetterDictionary
    {

        
        public string l_Dictionary(char a)
        {

            Dictionary<char, string> morseCode = new Dictionary<char, string>();


            morseCode.Add('A', "*-");
            morseCode.Add('B', "-***");
            morseCode.Add('C', "-*-*");
            morseCode.Add('D', "-**");
            morseCode.Add('E', "*");
            morseCode.Add('F', "**-*");
            morseCode.Add('G', "--*");
            morseCode.Add('H', "****");
            morseCode.Add('I', "**");
            morseCode.Add('J', "*---");
            morseCode.Add('K', "-*-");
            morseCode.Add('L', "*-**");
            morseCode.Add('M', "--");
            morseCode.Add('N', "-*");
            morseCode.Add('O', "---");
            morseCode.Add('P', "*--*");
            morseCode.Add('Q', "--*-");
            morseCode.Add('R', "*-*");
            morseCode.Add('S', "***");
            morseCode.Add('T', "-");
            morseCode.Add('U', "**-");
            morseCode.Add('V', "***-");
            morseCode.Add('W', "*--");
            morseCode.Add('X', "-**-");
            morseCode.Add('Y', "-*--");
            morseCode.Add('Z', "--**");
            morseCode.Add('a', "*-");
            morseCode.Add('b', "-***");
            morseCode.Add('c', "-*-*");
            morseCode.Add('d', "-**");
            morseCode.Add('e', "*");
            morseCode.Add('f', "**-*");
            morseCode.Add('g', "--*");
            morseCode.Add('h', "****");
            morseCode.Add('i', "**");
            morseCode.Add('j', "*---");
            morseCode.Add('k', "-*-");
            morseCode.Add('l', "*-**");
            morseCode.Add('m', "--");
            morseCode.Add('n', "-*");
            morseCode.Add('o', "---");
            morseCode.Add('p', "*--*");
            morseCode.Add('q', "--*-");
            morseCode.Add('r', "*-*");
            morseCode.Add('s', "***");
            morseCode.Add('t', "-");
            morseCode.Add('u', "**-");
            morseCode.Add('v', "***-");
            morseCode.Add('w', "*--");
            morseCode.Add('x', "-**-");
            morseCode.Add('y', "-*--");
            morseCode.Add('z', "--**");
            //////
            morseCode.Add('А', "*-");
            morseCode.Add('Б', "-***");
            morseCode.Add('В', "*--");
            morseCode.Add('Г', "--*");
            morseCode.Add('Д', "-**");
            morseCode.Add('Е', "*");
            morseCode.Add('Ж', "***-");
            morseCode.Add('З', "--**");
            morseCode.Add('И', "**");
            morseCode.Add('Й', "*---");
            morseCode.Add('К', "-*-");
            morseCode.Add('Л', "*-**");
            morseCode.Add('М', "--");
            morseCode.Add('Н', "-*");
            morseCode.Add('О', "---");
            morseCode.Add('П', "*--*");
            morseCode.Add('Р', "*-*");
            morseCode.Add('С', "***");
            morseCode.Add('Т', "-");
            morseCode.Add('У', "**-");
            morseCode.Add('Ф', "**-*");
            morseCode.Add('Х', "****");
            morseCode.Add('Ц', "-*-*");
            morseCode.Add('Ч', "---*");
            morseCode.Add('Ш', "----");
            morseCode.Add('Щ', "--*-");
            morseCode.Add('Ъ', "*--*-*");
            morseCode.Add('Ы', "-*--");
            morseCode.Add('Ь', "-**-");
            morseCode.Add('Э', "**-**");
            morseCode.Add('Ю', "**--");
            morseCode.Add('Я', "*-*-");
            morseCode.Add('а', "*-");
            morseCode.Add('б', "-***");
            morseCode.Add('в', "*--");
            morseCode.Add('г', "--*");
            morseCode.Add('д', "-**");
            morseCode.Add('е', "*");
            morseCode.Add('ж', "***-");
            morseCode.Add('з', "--**");
            morseCode.Add('и', "**");
            morseCode.Add('й', "*---");
            morseCode.Add('к', "-*-");
            morseCode.Add('л', "*-**");
            morseCode.Add('м', "--");
            morseCode.Add('н', "-*");
            morseCode.Add('о', "---");
            morseCode.Add('п', "*--*");
            morseCode.Add('р', "*-*");
            morseCode.Add('с', "***");
            morseCode.Add('т', "-");
            morseCode.Add('у', "**-");
            morseCode.Add('ф', "**-*");
            morseCode.Add('х', "****");
            morseCode.Add('ц', "-*-*");
            morseCode.Add('ч', "---*");
            morseCode.Add('ш', "----");
            morseCode.Add('щ', "--*-");
            morseCode.Add('ъ', "*--*-*");
            morseCode.Add('ы', "-*--");
            morseCode.Add('ь', "-**-");
            morseCode.Add('э', "**-**");
            morseCode.Add('ю', "**--");
            morseCode.Add('я', "*-*-");
            morseCode.Add(' ', "/");


            return morseCode[a];



        }
        
    }
}
