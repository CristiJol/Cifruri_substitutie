using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifruri_substitutie
{
    public class ROT13 : Shift_by_n
    {
        public override char Cipher(char ch, int key)
        {
            key = 13;
            return base.Cipher(ch, key);
        }
        public override void View()
        {
            Console.WriteLine("ROT13 :");
            base.View();
        }
    }
}
