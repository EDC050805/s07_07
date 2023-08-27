using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s07_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //definir variables
            string nombre;
            double peso, longitud;
            //leer datos
            Console.WriteLine("Datos del Dinosaurio");
            Console.Write("Ingrese nombre: ");
            nombre= Console.ReadLine();
            Console.Write("Ingrese peso en libras: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese longitud en pies: ");
            longitud = double.Parse(Console.ReadLine());
            //operaciones
            peso = peso / 2.20462;
            longitud = longitud * 0.3048;
            //mostrar resultados
            Console.WriteLine("Resultados del registro");
            Console.WriteLine("Nombre: {0}", nombre);
            Console.WriteLine("Peso en Kilogramos: {0}", peso);
            Console.WriteLine("Longitud en metros: {0}", longitud);
            Console.ReadKey();
        }
    }
}
