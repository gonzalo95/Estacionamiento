using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionIngreso : Exception
    {
        public ExcepcionIngreso(string mensaje) : base(mensaje) { }
    }
}
