using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodarbiba5
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevumi masivs = new Uzdevumi();
            masivs.PirmaisMajasdarbs();

            masivs.OtraisMajasdarbs();

            Console.ReadLine();
        }

    }
}
