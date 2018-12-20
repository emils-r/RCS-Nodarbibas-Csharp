using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba1
{
    class Program
    {
        static void Main(string[] args) 
        {
            //PirmaisUzdevums();

            //int a = Piemers();
            //int b = Piemers2(5, a);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Piemers3();

            /*
            Console.WriteLine("Ievadi x: ");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ievadi y: ");
            int y = Convert.ToInt16(Console.ReadLine());
            */

            /*
            Console.WriteLine("Ievadiet skaitli: ");
            int skaitlis1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ievadiet skaitli: ");
            int skaitlis2 = Convert.ToInt16(Console.ReadLine());
            Darbiba(skaitlis1, skaitlis2);
            */

            int x = SkaitlaIevade("Ievadi x: ");
            int y = SkaitlaIevade("Ievadi y: ");

            Darbiba(x, y);
            

            Console.ReadLine();
        }
        
        static void PirmaisUzdevums()
        {
            Console.WriteLine("Ievadi savu vārdu:");
            String vards = Console.ReadLine();
            Console.WriteLine("Labdien, " + vards + "!");
            Console.WriteLine(2 + 5);
        }

        static int Piemers()
        {
            return 5 + 3;
        }

        static int Piemers2(int a, int b)
        {
            return a + b;
        }

        static void Piemers3()
        {
            Console.WriteLine("Ievadiet tekstu:");
            String ievade = Console.ReadLine();
            int a = 5;
            if (ievade == "teksts" && ievade.Length > 5)
            {
                Console.WriteLine("1");
            }
            else if ( ievade == "vii" && a == 5 )
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }
        }

        static void Darbiba(int x, int y)
        {
            Console.WriteLine("Saskaitīt (+) vai atņemt (-)?");
            String darbiba = Console.ReadLine();

            if (darbiba != "+" && darbiba != "-")
            {
                Console.WriteLine("Kļūda ievadē");
            }
            else if (darbiba == "-")
            {
                Console.WriteLine("Rezultāts ir " + (x - y));
            }
            else
            {
                Console.WriteLine("Rezultāts ir " + (x + y));
            }
        }

        static int SkaitlaIevade(String text)
        {
            Console.WriteLine(text);
            int a = Convert.ToInt16(Console.ReadLine());
            return a;
        }

    }
}
