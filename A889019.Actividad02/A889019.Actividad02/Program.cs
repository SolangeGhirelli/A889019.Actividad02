using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A889019.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {

            int CantidadDeEquipos;

            Console.WriteLine("Ingrese cantidad de equipos: ");
            string ingreso = Console.ReadLine();
            bool ValidarIngreso = Int32.TryParse(ingreso, out CantidadDeEquipos);

            do
            {
                if (!ValidarIngreso)
                {
                    Console.WriteLine("Ingreso incorrecto");
                    break;
                }
                if (CantidadDeEquipos < 2)
                {
                    Console.WriteLine("Ingrese más de dos equipos");
                    ingreso = Console.ReadLine();
                    ValidarIngreso = Int32.TryParse(ingreso, out CantidadDeEquipos);
                    break;
                }
                else
                {
                    Console.WriteLine($"Ingreso {CantidadDeEquipos} equipos.");
                    break;
                }

            } while (ValidarIngreso);

            List<int> NumeroDeEquipos = new List<int>(CantidadDeEquipos);

            for (int indice = 1; indice <= CantidadDeEquipos; indice++)
            {
                    Console.WriteLine($"Indique un nombre para {indice}: ");
                    string ingreso2 = Console.ReadLine();                    
            }

            Dictionary<int, string> Equipos = new Dictionary<int, string>();


            Console.ReadKey();

        }
    }
}
