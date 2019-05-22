using System;
using System.Collections.Generic;
using System.Text;
using Excepciones;

namespace Entidades
{
    public class Estacionamiento : IParkingLot
    {
        private const int capacidadMaxima = 100;
        private const string mail = "encargado@gmail.com";
        private int precioPorDia;
        private int estacionados;

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="precioPorDia">Precio de facturacion</param>
        /// <param name="estacionados">Cantidad de autos estacionados</param>
        public Estacionamiento(int precioPorDia, int estacionados)
        {
            this.PrecioPorDia = precioPorDia;
            this.estacionados = estacionados;
        }

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Estacionamiento() : this(0, 0) { }

        /// <summary>
        /// Propiedad de solo lectura; permite obtener la cantidad de autos estacionados
        /// </summary>
        public int? CantidadEstacionados
        {
            get
            {
                if (this.estacionados == 0)
                    return null;
                else
                    return this.estacionados;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura; permite obtener la cantidad de espacios disponibles
        /// </summary>
        public int EspaciosDisponibles
        {
            get
            {
                return this.CantidadEstacionados is null ? capacidadMaxima : capacidadMaxima - (int)this.CantidadEstacionados;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura; permite consultar o modificar el precio de facturacion
        /// </summary>
        public int PrecioPorDia
        {
            get
            {
                return this.precioPorDia;
            }
            set
            {
                if (value >= 0)
                {
                    this.precioPorDia = value;
                }
                else
                {
                    throw new ExcepcionPrecio("El precio  debe ser positivo");
                }
            }
        }

        /// <summary>
        /// Metodo que indica el ingreso de un auto; aumenta la cantidad de autos estacionados
        /// </summary>
        public void IngresoDetectado()
        {
            if (this.EspaciosDisponibles == 0)
            {
                throw new ExcepcionIngreso("No hay espacios disponibles");
            }
            else
            {
                Console.WriteLine("Se ha detectado un ingreso");
                this.estacionados++;
            }
        }

        /// <summary>
        /// Metodo que indica el egreso de un auto; reduce la cantidad de autos estacionados
        /// </summary>
        public void EgresoDetectado()
        {
            if (this.estacionados == 0)
            {
                throw new ExcepcionEgreso("No hay autos estacionados");
            }
            else
            {
                Console.WriteLine("Se ha detectado un egreso");
                this.estacionados--;
            }
        }

        /// <summary>
        /// Metodo que muestra el total facturado e informa el monto via mail al encargado
        /// </summary>
        /// <param name="PrecioPorDia">Precio de facturacion</param>
        public void FacturarEstadia(int PrecioPorDia)
        {
            int total;
            this.PrecioPorDia = PrecioPorDia;
            total = this.PrecioPorDia * (int)this.CantidadEstacionados;
            Console.WriteLine("Total facturacion: " + total);
            ServicioExterno.EnviarEmail("Facturacion", "Total facturacion: " + total, mail);
        }
    }
}
