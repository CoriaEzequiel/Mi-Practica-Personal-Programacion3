using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Ej1
{
    internal class Ej1 : Interface1
    {
        public void Execute()
        {
            int x = 1; int y = 2; int z = 3; int xyz = x + y + z;
            Console.WriteLine(xyz);

        }
    }
}
