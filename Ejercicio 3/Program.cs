using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las calificaciones parciales (CP1 CP2 CP3):");
            double cp1 = Convert.ToDouble(Console.ReadLine());
            double cp2 = Convert.ToDouble(Console.ReadLine());
            double cp3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del examen final (CEF):");
            double cef = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del trabajo final (CTF):");
            double ctf = Convert.ToDouble(Console.ReadLine());

            double nf = 0.55 * (cp1 + cp2 + cp3) / 3 + 0.30 * cef + 0.15 * ctf;

            Console.WriteLine($"La calificación final del alumno es: {nf:F2}");
        }
    }
}
