using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            DateTime fechaNacimiento;
            double peso;

            Console.WriteLine("Ingrese Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese FechaNacimiento");
            fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese Peso");
            peso = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("****************Datos Ingresados ****************");
            Console.WriteLine("Nombre:" + nombre);
            Console.WriteLine("Edad:" + edad);
            Console.WriteLine("Nacimiento:" + fechaNacimiento);
            Console.WriteLine("Peso:" + peso);
            Console.ReadKey();

        }
    }
}
