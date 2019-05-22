using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace Pruebas_unitarias
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void TestConstructorSinParametros()
        {
            Estacionamiento estacionamiento = new Estacionamiento();

            Assert.AreEqual(estacionamiento.CantidadEstacionados, null);
            Assert.AreEqual(estacionamiento.EspaciosDisponibles, 100);
            Assert.AreEqual(estacionamiento.PrecioPorDia, 0);
        }

        [TestMethod]
        public void TestConstructorConParametros()
        {
            Estacionamiento estacionamiento = new Estacionamiento(100, 100);

            Assert.AreEqual(estacionamiento.CantidadEstacionados, 100);
            Assert.AreEqual(estacionamiento.EspaciosDisponibles, 0);
            Assert.AreEqual(estacionamiento.PrecioPorDia, 100);
        }

        [TestMethod]
        public void TestIngresoYEgreso()
        {
            Estacionamiento estacionamiento = new Estacionamiento();

            for (int i = 0; i < 100; i++)
            {
                estacionamiento.IngresoDetectado();
            }
            Assert.IsTrue(estacionamiento.EspaciosDisponibles == 0);
            Assert.IsTrue(estacionamiento.CantidadEstacionados == 100);

            for (int i = 0; i < 100; i++)
            {
                estacionamiento.EgresoDetectado();
            }
            Assert.IsTrue(estacionamiento.EspaciosDisponibles == 100);
            Assert.IsTrue(estacionamiento.CantidadEstacionados is null);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionPrecio))]
        public void TestPrecioNegativo()
        {
            Estacionamiento estacionamiento = new Estacionamiento();

            estacionamiento.PrecioPorDia = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionIngreso))]
        public void TestExcepcionIngreso()
        {
            Estacionamiento estacionamiento = new Estacionamiento();

            for (int i = 0; i < 101; i++)
            {
                estacionamiento.IngresoDetectado();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionEgreso))]
        public void TestExcepcionEgreso()
        {
            Estacionamiento estacionamiento = new Estacionamiento();

            estacionamiento.EgresoDetectado();
        }
    }
}
