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
                    "6 - Listar latas disponibles - detalle completo" + Environment.NewLine +
                    "99 - Salir" + Environment.NewLine)
                    ;

                _respuesta = Console.ReadLine();
                try
                {
                C.SeleccionarOpcion(_respuesta);

                switch (_respuesta)
                    {
                        case "1": C.EncenderMaquina();
                            Console.WriteLine("La máquina fue encendida a las: " + System.DateTime.Now);
                            break;
                        case "2": C.MostrarLatas(out msg);
                            Console.WriteLine(msg);
                            break;
                        case "3":
                            try
                            {
                                C.PedirDatos(out L);
                                C.AgregarLata(L);
                            }
                            catch (MaquinaApagada ex)
                            {
                                Console.WriteLine("La máquina está apagada.");
                                Console.ReadLine();
                            }
                            catch (CodigoYaExistente ex)
                            {
                                Console.WriteLine("El código ingresado ya existe o no es válido.");
                                Console.ReadLine();
                            }
                            catch (CapacidadInsuficienteException ex)
                            {
                                Console.WriteLine("No hay más capacidad de almacenamiento.");
                                Console.ReadLine();
                            }
                            break;
                        case "99":
                            flag = false;
                            Console.WriteLine("Gracias por utilizar la expendedora. Presione cualquier tecla para salir.");
                            Console.ReadLine();
                            break;
                        default:
                            break;
                    }
                    //flag = false;
                }
                catch (OperacionInvalida Ex1)
                {
                    Console.WriteLine("Operación inválida. Intente nuevamente");
                }
            }
            
        }
    }
}
