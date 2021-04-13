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

            string _respuesta = "";
            string msg = "";

            Lata L = new Lata();
            Controlador C = new Controlador();
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
                try
                {
                C.SeleccionarOpcion(_respuesta);

                switch (_respuesta)
                    {
                        case "1": C.EncenderMaquina();
                            Console.WriteLine("La máquina fue encendida a las: " + System.DateTime.Now);
                            Console.ReadLine();
                            break;
                        case "2": C.MostrarLatas(out msg);
                            Console.WriteLine(msg);
                            Console.ReadLine();
                            break;
                        case "3":
                            try
                            {
                                C.AgregarLata(L);
                            }
                            catch (MaquinaApagada ex)
                            {
                                Console.WriteLine("La máquina está apagada.");
                            }
                            break;
                        default:
                            break;
                    }
                    flag = false;
                }
                catch (OperacionInvalida Ex1)
                {
                    Console.WriteLine("Operación inválida. Intente nuevamente");
                }
            }
            
        }
    }
}
