using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasdarbsDzejolis
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] dzejolaRindas = System.IO.File.ReadAllLines(@"D:\Emils\Documents\GitHub\RCS-Nodarbibas-Csharp\MajasdarbsDzejolis\dzejolis.txt");
            String[] jaunsDzejolis = new string[dzejolaRindas.Length];

            for (int i = 0; i < dzejolaRindas.Length; i++)
            {
                jaunsDzejolis[i] = dzejolaRindas[dzejolaRindas.Length - 1 - i];
                Console.WriteLine(jaunsDzejolis[i]);
            }

            System.IO.File.WriteAllLines(@"D:\Emils\Documents\GitHub\RCS-Nodarbibas-Csharp\MajasdarbsDzejolis\JaunsDzejolis.txt", jaunsDzejolis);
            Console.ReadLine();
        }
    }
}
