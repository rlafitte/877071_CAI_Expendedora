using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.Libreria.Entidades;
using Expendedora.Libreria;

namespace Expendedora.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string _respuesta="";
            Lata L = new Lata();
            while (flag)
            {
                Console.WriteLine("Bienvenido. Ingrese la opción deseada: ");
                Console.WriteLine("1 - Encender máquina" + Environment.NewLine +
                    "2 - Listar latas disponibles" + Environment.NewLine +
                    "3 - Insertar lata" + Environment.NewLine +
                    "4 - Comprar lata" + Environment.NewLine +
                    "5 - Consultar saldo" + Environment.NewLine +
                    "6 - Listar latas disponibles - detalle completo" + Environment.NewLine);

                _respuesta = Console.ReadLine();
                
            }
        }
    }
}
