using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionPrecio : Exception
    {
        public ExcepcionPrecio(string mensaje) : base(mensaje) { }
    }
}
