using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    public class TestDiasDeVida
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testeo1año1mes1dia()
        {
            int diasDeVida = ProgramEjercicios.CalcularDiasDeVida(1, 1, 1);
            Assert.That(diasDeVida, Is.EqualTo(396));
        }
        [Test]
        public void Testeo10años10meses1dia()
        {
            int diasDeVida = ProgramEjercicios.CalcularDiasDeVida(10, 10, 1);
            Assert.That(diasDeVida, Is.EqualTo(3951));
        }
    }
}
