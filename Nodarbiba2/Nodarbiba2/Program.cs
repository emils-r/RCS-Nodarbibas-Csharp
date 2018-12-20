using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Piemers piem = new Piemers();
            //piem.TestaIzvade();
            //Piemers.TestaIzvade2();
            //piem.Cikli();

            //Uzdevums1.Zvaigznes();
            //Uzdevums1.Zvaigznes1();
            //Uzdevums1.Zvaigznes2();
            //Uzdevums1.Zvaigznes3();

            Uzdevums1 uzd = new Uzdevums1();
            String atbilde;

            do
            {
                int x = SkaitlaIevade("Ievadi bāzi:");
                int y = SkaitlaIevade("Ievadi pakāpi:");

                int rez = uzd.Kapinam(x, y);
                Console.WriteLine("Rezultats ir " + rez);
                Console.WriteLine();

                Console.WriteLine("Vai atkārtot? yes/no");
                atbilde = Console.ReadLine();
                if (atbilde == "yes")
                {
                    Console.WriteLine();
                }

            } while (atbilde == "yes");
            
            //Console.ReadKey();
        }

        static int SkaitlaIevade(String a)
        {
            Console.WriteLine(a);
            int x = Convert.ToInt16(Console.ReadLine());
            return x;
        }
        
    }
}

// mājasdarbs - kalkulators, cilvēks ievada 2 skaitlus un izvelas darbibu
// pec darbibas izpildes jābūt izvēlei iziet no programmas