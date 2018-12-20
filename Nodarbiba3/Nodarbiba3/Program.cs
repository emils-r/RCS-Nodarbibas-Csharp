using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba3
{
    class Program
    {
        static void Main(string[] args)
        {
            String atbilde;
            do
            {
                //Console.WriteLine("Ievadi meklejamo skaitli"); //Mekletajs
                //Console.WriteLine("Ievadi rindu skaitu");      //Zvaigznes
                Console.WriteLine("Ievadi rindu skaitu"); // 2D masivs
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ievadi kolonnu skaitu");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                //Piemeri.Mekletajs(x);
                //Piemeri.Zvaigznes(x);
                Piemeri.DivdimensijuMasivs(x, y);

                Console.WriteLine();
                Console.WriteLine("raksti 'y', lai atkārtotu");
                atbilde = Console.ReadLine();
                Console.WriteLine();

            } while (atbilde == "y");

        }
    }
}
