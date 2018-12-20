using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba2
{
    class Uzdevums1
    {
        public static void Zvaigznes()
        {
            for (int j = 1; j < 4; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Zvaigznes1()
        {
            String a = "";

            for (int i = 0; i < 4; i++)
            {
                a += "*";
                Console.WriteLine(a);
            }
        }

        public static void Zvaigznes2()
        {
            for (int i = 0; i < 5; i++)
            {
                int a = 0;
                while (a <= i)
                {
                    Console.Write("*");
                    a++;
                }
                Console.WriteLine();
            }
        }

        public static void Zvaigznes3()
        {
            for (int i = 0; i < 6; i++)
            {
                int a = 0;
                do
                {
                    Console.Write("*");
                    a++;
                } while (a <= i);

                Console.WriteLine();
            }
        }

        public int Kapinam(int a, int b)
        {
            int temp = a;

            for(int i = 1; i < b; i++)
            {
                a *= temp;
            }

            return a;
        }
    }
}
