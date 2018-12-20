using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba5
{
    class Uzdevumi
    {
        public void PirmaisMajasdarbs()
        {
            // atrast masīva lielāko skaitli
            int[] skaitluMasivs = { 1, 2, 3, 7, 9, 11, 19 };
            int max = skaitluMasivs[0];

            for (int i = 1; i < skaitluMasivs.Length; i++)
            {
                if (skaitluMasivs[i] > max)
                {
                    max = skaitluMasivs[i];
                }
            }
            Console.WriteLine("Lielākais masīva skaitlis ir " + max);
        }

        public void OtraisMajasdarbs()
        {
            // apgriezt masīvu otrādi
            int[] skaitluMasivs = { 1, 2, 3, 7, 9, 11, 19 };

            int[] masivsSkaitlu = new int[skaitluMasivs.Length];

            for(int i = 0; i < masivsSkaitlu.Length; i++)
            {
                masivsSkaitlu[i] = skaitluMasivs[skaitluMasivs.Length - i - 1];
                Console.Write(masivsSkaitlu[i] + " ");
            }
        }



    }
}
