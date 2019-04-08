using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionPrecio : Exception
    {
        /// <summary>
        /// Constructor de clase con parametro
        /// </summary>
        /// <param name="mensaje">Mensaje adjunto en la excepcion</param>
        public ExcepcionPrecio(string mensaje) : base(mensaje) { }
    }
}
