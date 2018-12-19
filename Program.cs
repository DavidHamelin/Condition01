using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rainy = true; // if (!rainy) ---> ! = négation
            if (rainy == true) Console.WriteLine("Bonjour, il ne pleut pas aujourd'hui, bonne journée !");
            //if (rainy) Console.WriteLine("Bonjour, il ne pleut pas aujourd'hui, bonne journée !");
            else Console.WriteLine("Bonjour, il pleut aujourd'hui, vous devriez prendre votre parapluie !");  
        }
    }
}
