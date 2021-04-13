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
        public Controlador()
        {

        }

        public List<Lata> _latas = new List<Lata>();
        public void AgregarLata(Lata L)
        {
            _latas.Add(L);
            return;
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
            bool flag;
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
