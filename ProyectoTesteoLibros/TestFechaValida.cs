using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    public class TestFechaValida
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test31Abril()
        {
            bool resultado = ProgramEjercicios.ControlFechaValida(31, 4, 2000);
            Assert.IsFalse(resultado);
        }
        [Test]
        public void Test31Junio()
        {
            bool resultado = ProgramEjercicios.ControlFechaValida(31, 6, 2000);
            Assert.IsFalse(resultado);
        }
        [Test]
        public void Test29Febrero2024()
        {
            bool resultado = ProgramEjercicios.ControlFechaValida(29, 2, 2024);
            Assert.IsTrue(resultado);
        }
        [Test]
        public void Test30Febrero2024()
        {
            bool resultado = ProgramEjercicios.ControlFechaValida(30, 2, 2024);
            Assert.IsFalse(resultado);
        }
    }
}
