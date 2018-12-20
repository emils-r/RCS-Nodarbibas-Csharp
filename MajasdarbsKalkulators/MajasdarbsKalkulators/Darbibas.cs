using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasdarbsKalkulators
{
    class Darbibas
    {

        public static String Darbiba(String a, int x, int y)
        {
            String b = "Rezultāts ir ";
            switch (a)
            {
                case "+": return b + Saskaitit(x, y);

                case "-": return b + Atnemt(x, y);

                case "*": return b + Reizinat(x, y);

                case "/": return b + Dalit(x, y);

                case "^": return b + Pakape(x, y);

                default: return "Kļūda ievadē";
            }
        }

        private static int Saskaitit(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        private static int Atnemt(int x, int y)
        {
            int sum = x - y;
            return sum;
        }

        private static int Reizinat(int x, int y)
        {
            int sum = x * y;
            return sum;
        }

        private static double Dalit(int x, int y)
        {
            double sum = x / (y * 1f);
            return sum;
        }

        private static int Pakape(int x, int y)
        {
            int temp = x;
            for (int i = 1; i < y; i++)
            {
                x *= temp;
            }
            return x;
        }

    }
}
