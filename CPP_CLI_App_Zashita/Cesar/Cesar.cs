using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar { 
class Cesar {

    public static string Alphabet { get; set; }
    public static int Shift { private get; set; }


    public static string Encryption(string text)
    {
        text = text.ToLower();
        var res = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
            for (int j = 0; j < Alphabet.Length; j++)
                if (text[i] == Alphabet[j]) res.Append(Alphabet[(j + Shift) % Alphabet.Length]);

        return res.ToString();
    }
    public static string Decryption(string crypt)
    {
        crypt = crypt.ToLower();
        var res = new StringBuilder();
        for (int i = 0; i < crypt.Length; i++)
            for (int j = 0; j < Alphabet.Length; j++)
                if (crypt[i] == Alphabet[j]) res.Append(Alphabet[(j - Shift + Alphabet.Length) % Alphabet.Length]);

        return res.ToString();
    }

   


    


    private void f_Exit()
    {
        Console.WriteLine("\n////////////////////////////////////////////" +
                          "\n//           Желаете повторить y/n        //" +
                          "\n////////////////////////////////////////////");
        char c = Convert.ToChar(Console.ReadLine());
        if (c == 'y')
        {
            Console.Clear();
           

        }
        else { }



    }
}
}
