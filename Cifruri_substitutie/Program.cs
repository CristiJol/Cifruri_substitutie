using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifruri_substitutie
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var x = new Shift_by_n();
            //x.View();
            var y = new ROT13();
            y.View();
            //var z = new CaesarCypher();
            //z.View();
            Console.ReadKey();
        }
    }
}
