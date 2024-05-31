using EjerciciosDePrueba.Repositories;

namespace ProyectoTesteoLibros
{
    public class TestLibros
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestObtenerLibros()
        {
            LibrosRepositorio librosRepositorio = new LibrosRepositorio();
            var libros = await librosRepositorio.ObtenerLibrosAsync();
            Assert.Pass();
        }
    }
}