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

        public Estacionamiento(int precioPorDia, int estacionados)
        {
            this.PrecioPorDia = precioPorDia;
            this.estacionados = estacionados;
        }

        public Estacionamiento() : this(0, 0) { }

        public int CantidadEstacionados
        {
            get
            {
                return this.estacionados;
            }
        }

        public int EspaciosDisponibles
        {
            get
            {
                return capacidadMaxima - this.CantidadEstacionados;
            }
        }

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

        public void FacturarEstadia(int PrecioPorDia)
        {
            int total;
            this.PrecioPorDia = PrecioPorDia;
            total = this.PrecioPorDia * this.CantidadEstacionados;
            Console.WriteLine("Total facturacion: " + total);
            ServicioExterno.EnviarEmail("Facturacion", "Total facturacion: " + total, mail);
        }
    }
}
