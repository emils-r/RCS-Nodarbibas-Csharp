using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasdarbsKalkulators
{
    class Program
    {
        static void Main(string[] args)
        {
            String atbilde;
            do
            {
                Console.WriteLine("Izvēlies darbību ( +  -  *  /  ^ ):");
                String darbiba = Console.ReadLine();

                int x = Ievade("Ievadi 1. skaitli:");
                int y = Ievade("Ievadi 2. skaitli:");

                Console.WriteLine(Darbibas.Darbiba(darbiba, x, y));
                Console.WriteLine();

                Console.WriteLine("Ievadi 'y', lai atkārtotu");
                atbilde = Console.ReadLine();
                Console.WriteLine();

            } while (atbilde == "y");
            //Console.ReadLine();
        }

        public static int Ievade(String ievade)
        {
            Console.WriteLine(ievade);
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        
    }
}
