using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public interface IParkingLot
    {
        int CantidadEstacionados
        {
            get;
        }

        int EspaciosDisponibles
        {
            get;
        }

        int PrecioPorDia
        {
            get;
            set;
        }

        void IngresoDetectado();

        void EgresoDetectado();

        void FacturarEstadia(int PrecioPorDia);
    }
}
