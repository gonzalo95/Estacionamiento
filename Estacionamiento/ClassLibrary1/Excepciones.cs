﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionIngreso : Exception
    {
        /// <summary>
        /// Constructor de clase con parametro
        /// </summary>
        /// <param name="mensaje">Mensaje adjunto en la excepcion</param>
        public ExcepcionIngreso(string mensaje) : base(mensaje) { }
    }

    public class ExcepcionPrecio : Exception
    {
        /// <summary>
        /// Constructor de clase con parametro
        /// </summary>
        /// <param name="mensaje">Mensaje adjunto en la excepcion</param>
        public ExcepcionPrecio(string mensaje) : base(mensaje) { }
    }

    public class ExcepcionEgreso : Exception
    {
        /// <summary>
        /// Constructor de clase con parametro
        /// </summary>
        /// <param name="mensaje">Mensaje adjunto en la excepcion</param>
        public ExcepcionEgreso(string mensaje) : base(mensaje) { }
    }
}
