using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public interface IParkingLot
    {
        /// <summary>
        /// Propiedad de solo lectura; permite obtener la cantidad de autos estacionados
        /// </summary>
        int CantidadEstacionados
        {
            get;
        }

        /// <summary>
        /// Propiedad de solo lectura; permite obtener la cantidad de espacios disponibles
        /// </summary>
        int EspaciosDisponibles
        {
            get;
        }

        /// <summary>
        /// Propiedad de lectura y escritura; permite consultar o modificar el precio de facturacion
        /// </summary>
        int PrecioPorDia
        {
            get;
            set;
        }

        /// <summary>
        /// Metodo que indica el ingreso de un auto; aumenta la cantidad de autos estacionados
        /// </summary>
        void IngresoDetectado();

        /// <summary>
        /// Metodo que indica el egreso de un auto; reduce la cantidad de autos estacionados
        /// </summary>
        void EgresoDetectado();

        /// <summary>
        /// Metodo que muestra el total facturado e informa el monto via mail al encargado
        /// </summary>
        /// <param name="PrecioPorDia">Precio de facturacion</param>
        void FacturarEstadia(int PrecioPorDia);
    }
}
