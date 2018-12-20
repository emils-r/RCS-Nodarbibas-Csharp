using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba2
{
    class Piemers
    {
        public void TestaIzvade()
        {
            Console.WriteLine("vii");
        }

        // static --> nav nepieciešams objekts
        public static void TestaIzvade2()
        {
            Console.WriteLine("vii2");
        }

        public void Cikli()
        {
            /*for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("sup");
            }*/

            String izvele = "";

            while (izvele != "jaa")
            {
                Console.WriteLine("Vai gribat iziet? jaa/ne");
                izvele = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("Vai tiešām gribat iziet? jaa/ne");
                izvele = Console.ReadLine();
            } while (izvele != "jaa");

        }


    }
}
