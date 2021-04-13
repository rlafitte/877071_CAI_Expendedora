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
        bool _maquina = false;
        public Controlador()
        {

        }

        public List<Lata> _latas = new List<Lata>();
        public void MostrarLatas(out string msg)
        {
            msg = "";
            //Lata L = new Lata();
            //Lata L2 = new Lata();
            //L.Codigo = "1";
            //L.Nombre = "pepe";
            //L.Cantidad = 2;            
            //L2.Codigo = "4";
            //L2.Nombre = "pape";
            //L2.Cantidad = 5;
            //_latas.Add(L);
            //_latas.Add(L2);
            foreach (Lata i in _latas)
            {
                msg += i.Codigo + ")" + i.Nombre + "[" + i.Cantidad + "]" + Environment.NewLine;
            }
        }
        public void AgregarLata(Lata L)
        {
            if (_maquina)
            {
            _latas.Add(L);
            return;
            }
            else
            {
                throw new MaquinaApagada();
            }
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
            if (!_maquina)
            {
                _maquina = true;
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
            if (_id > 6 || _id < 1)
            {
                throw new OperacionInvalida();
            }

        }
    }
}
