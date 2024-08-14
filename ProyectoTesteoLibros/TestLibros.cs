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
            Assert.That(libros.Count, Is.Not.EqualTo(0));
        }

        [Test]
        public async Task TestAgregarLibro()
        {
            LibrosRepositorio librosRepositorio = new LibrosRepositorio();
            //var libro = await librosRepositorio.AgregarAsync("LibroText", 20, "AutorText", "EditorialText", "GeneroText", "SinopsisText", "PortadaText");
            //Assert.That(libro.nombre, Is.EqualTo("LibroText"));
        }

        [Test]
        public async Task TestEliminarLibro()
        {
            LibrosRepositorio librosRepositorio = new LibrosRepositorio();
            var borrado = await librosRepositorio.EliminarAsync("665a14dcb384736b000011f1");
            Assert.That(borrado, Is.EqualTo(true));
        }

        [Test]
        public async Task TestObtenerLibro()
        {
            LibrosRepositorio librosRepositorio = new LibrosRepositorio();
            var libro = await librosRepositorio.ObtenerPorIdAsync("653860edb4422a5c00000013");
            Assert.That(libro.nombre, Is.EqualTo("Nueva Comedia Americana"));
        }

        [Test]
        public async Task TestActualizarLibro()
        {
            LibrosRepositorio librosRepositorio = new LibrosRepositorio();
            //var libro = await librosRepositorio.ActualizarAsync("LibroActualizado", 20, "AutorText", "EditorialText", "GeneroText", "SinopsisText", "PortadaText", "65147e48c3119e6f000001f6");
            //Assert.That(libro.nombre, Is.EqualTo("LibroActualizado"));
        }
    }
}