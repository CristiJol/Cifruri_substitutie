using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifruri_substitutie
{
    public class Shift_by_n
    {
        int key = int.Parse(Console.ReadLine());
        public virtual char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += Cipher(ch, key);

            return output;
        }
        public string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
        public virtual void View ()
        {
            Console.WriteLine("Scrieti o informatie :");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Informatia criptata : ");

            string cipherText = Encipher(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Informatia decriptata : ");

            string t = Decipher(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");
        }
    }
}
