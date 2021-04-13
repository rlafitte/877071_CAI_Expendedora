using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.Libreria.Entidades;

namespace Expendedora.Libreria.Entidades
{
    public class Controlador
    {
        bool _encendida = false;
        public List<Lata> _latas = new List<Lata>();
        private string _proveedor;
        private int _capacidad;
        private double _dinero;

        public Controlador()
        {

        }

        public void MostrarLatas(out string msg)
        {
            msg = "";
            Lata L = new Lata();
            Lata L2 = new Lata();
            L.Codigo = "1";
            L.Nombre = "pepe";
            L.Cantidad = 2;
            L2.Codigo = "4";
            L2.Nombre = "pape";
            L2.Cantidad = 5;
            _latas.Add(L);
            _latas.Add(L2);
            foreach (Lata i in _latas)
            {
                msg += i.Codigo + ")" + i.Nombre + "[" + i.Cantidad + "]" + Environment.NewLine;
            }
        }
        public void AgregarLata(Lata L)
        {
            if (_encendida)
            {
               if (!BuscarLata(L.Codigo))
                {
                 _latas.Add(L);
                 return;
                }
               else
                {
                    throw new CodigoYaExistente();
                }
            }
            else
            {
                throw new MaquinaApagada();
            }
        }

        public bool BuscarLata(string codigo)
        {
            bool flag2 = true;
            Lata _lataBuscada = new Lata();
            try
            {
            _lataBuscada = _latas.FirstOrDefault(i => i.Codigo == codigo);
            //if (_lataBuscada.Codigo == null)
            //    {
                    if (string.IsNullOrEmpty(_lataBuscada.Codigo))
                    {
                    flag2 = false;
                    }
                //}

            }
            catch (NullReferenceException ex)
            {
            }
            catch (Exception ex)
            {

            }
            return flag2;          
        }
        public Lata ExtraerLata(string str, double dou)
        {
            Lata L = new Lata();
            return L;
        }
        public string GetBalance()
        {
            string str="";
            return str;
        }
        public int GetCapacidadRestante()
        {
            int i = 0;
            return i;
        }
        public void EncenderMaquina()
        {
            if (!_encendida)
            {
                _encendida = true;
            }
            return;
        }

        public void EstaVacia()
        {
            bool flag;
            return;
        }
        public void SeleccionarOpcion (string id)
        {
            int _id = Int32.Parse(id);
            if ((_id > 6 || _id < 1) && _id != 99)
            {
                throw new OperacionInvalida();
            }

        }
        public void PedirDatos(out Lata L)
        {      
            if (_encendida)
            {
            Lata L_new = new Lata();
            L = L_new;
            Console.WriteLine("Ingrese el código de lata");
            try
            {
                L_new.Codigo = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre de la lata");
                try
                {
                    L_new.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el sabor de la lata");
                    try
                    {
                    L_new.Sabor = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio de la lata");
                        try
                        {
                            L_new.Precio = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el volumen de la lata");
                            try
                            {
                                L_new.Volumen = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Ingrese la cantidad de la lata");
                                try
                                {
                                    L_new.Cantidad = Convert.ToInt32(Console.ReadLine());
                                    
                                    
                                }
                                catch (Exception ex)
                                {

                                }
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                catch (Exception ex)
                {

                }
            }
            catch (CodigoInvalidoException cod)
            {

            }
            }
            else
            {
                throw new MaquinaApagada();
            }
        }

    }
}
