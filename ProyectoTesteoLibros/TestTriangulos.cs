using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    public class TestTriangulos
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEquilatero()
        {
            string resultado = ProgramEjercicios.ImprimirTipoDeTriangulo(1, 1, 1);
            Assert.That(resultado, Is.EqualTo("equilatero"));
        }
        [Test]
        public void TestIsoceles()
        {
            string resultado = ProgramEjercicios.ImprimirTipoDeTriangulo(1, 1, 2);
            Assert.That(resultado, Is.EqualTo("isoceles"));
        }
        [Test]
        public void TestEscaleno()
        {
            string resultado = ProgramEjercicios.ImprimirTipoDeTriangulo(1, 2, 3);
            Assert.That(resultado, Is.EqualTo("escaleno"));
        }
    }
}
