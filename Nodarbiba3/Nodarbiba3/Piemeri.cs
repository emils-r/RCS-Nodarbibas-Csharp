using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba3
{
    class Piemeri
    {

        public static void Zvaigznes(int x)
        {
            String[] masivs = new String[x];

            String a = "*";

            for (int i = 1; i < masivs.Length; i++)
            {
                masivs[i] = masivs[i - 1] + a;
                Console.WriteLine(masivs[i]);
            }
            for (int j = x - 2; j >= 0; j--)
            {
                Console.WriteLine(masivs[j]);
            }
        }

        public static void Mekletajs(int x)
        {
            int[] masivs = { 1, 3, 6, 3, 9, 1 };

            bool atrasts = false;

            for (int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] == x)
                {
                    Console.WriteLine(x + " atrodas masiva indeksaa " + i);
                    atrasts = true;
                }
            }
            if (!atrasts)
            {
                Console.WriteLine("Skaitlis netika atrasts");
            }
        }

        public static void DivdimensijuMasivs(int x, int y)
        {
            int[,] masivs = new int[x, y];

            for (int i = 0; i < masivs.GetLength(0); i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write((1 + i) + "-" + (1 + j) + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
