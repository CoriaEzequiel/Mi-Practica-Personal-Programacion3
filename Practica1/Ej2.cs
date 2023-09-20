using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Ej2
{
    internal class Ej2 : Interface1
    {
        public void Execute()
        {
            Console.Write("Ingrese el nombre de la persona: ");
            string? personName = Console.ReadLine();

            Console.Write("Ingrese el nombre de una ciudad: ");
            string? cityName = Console.ReadLine();

            
            Console.WriteLine($"Hola {personName} bienvenido a {cityName} ");
            Console.ReadLine();
        }
    }
}