using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.Acciones.Entidades;
using Expendedora.Acciones;

namespace Expendedora.Acciones.Entidades
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        private int _cantidad;

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Sabor { get => _sabor; set => _sabor = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public double Volumen { get => _volumen; set => _volumen = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }

        public Lata()
        {
            
        }
        public Lata(string codigo)
        {
            _codigo = codigo;
        }
        public Lata(string codigo, string nombre, string sabor, double precio, double volumen, int cantidad)
        {
            _codigo = codigo;
            _nombre = nombre;
            _sabor = sabor;
            _precio = precio;
            _volumen = volumen;
            _cantidad = cantidad;
        }

    }
    //public double GetPrecioPorLitro()
    //{
    //    return;
    //}
  
}
