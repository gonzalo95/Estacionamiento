using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;

namespace Main
{
    class Ejercicio
    {
        static void Main(string[] args)
        {
            int opcion;
            Estacionamiento estacionamiento = new Estacionamiento();

            do
            {
                Console.WriteLine(
                    "MENU:\n" +
                    "1.- Cantidad estacionados\n" +
                    "2.- Espacios disponibles\n" +
                    "3.- Ingresar precio\n" +
                    "4.- Consultar precio\n" +
                    "5.- Ingreso vehiculo\n" +
                    "6.- Egreso vehiculo\n" +
                    "7.- Facturar\n" +
                    "8.- Salir\n"
                    );

                int.TryParse(Console.ReadLine(), opcion);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Cantidad estacionados: " + estacionamiento.CantidadEstacionados);
                        break;

                    case 2:
                        Console.WriteLine("Espacios disponibles: " + estacionamiento.EspaciosDisponibles);
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("Ingrese el precio: ");
                            estacionamiento.PrecioPorDia = int.Parse(Console.ReadLine());
                        }
                        catch (ExcepcionPrecio excepcion)
                        {
                            Console.WriteLine(excepcion.Message);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Precio por dia: $" + estacionamiento.PrecioPorDia);
                        break;

                    case 5:
                        try
                        {
                            estacionamiento.IngresoDetectado();
                        }
                        catch (ExcepcionIngreso excepcion)
                        {
                            Console.WriteLine(excepcion.Message);
                        }
                        break;

                    case 6:
                        try
                        {
                            estacionamiento.EgresoDetectado();
                        }
                        catch (ExcepcionEgreso excepcion)
                        {
                            Console.WriteLine(excepcion.Message);
                        }
                        break;

                    case 7:
                        estacionamiento.FacturarEstadia(estacionamiento.PrecioPorDia);
                        break;

                    case 8:
                        Console.WriteLine("Gracias por utilizar nuestro servicio");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
            while (opcion != 8);
        }
    }
}
