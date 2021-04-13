using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Expendedora.Acciones.Entidades;

namespace Expendedora.Acciones.Entidades
{
    public class Excepciones : Exception
    {
    }
    public class CapacidadInsuficienteException : Exception
    {

    } 
    public class DineroInsuficienteException : Exception
    {

    }
    public class SinStockException : Exception
    {

    }
    public class CodigoInvalidoException : Exception
    {

    }
    public class OperacionInvalida : Excepciones
    {

    }
}
