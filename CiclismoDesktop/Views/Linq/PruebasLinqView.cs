using CiclismoDesktop.DataContext;
using CiclismoDesktop.Modelos;
using CiclismoDesktop.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CiclismoDesktop.Views.Linq
{
    public partial class PruebasLinqView : Form
    {
        #region Array JSON de peliculas
        JArray jsonArrayPeliculas = JArray.Parse(" [\r\n  { \"title\": \"El laberinto del fauno\", \"director\": \"Guillermo del Toro\", \"year\": 2006, \"genre\": \"Fantasía\" },\r\n  { \"title\": \"Amores perros\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2000, \"genre\": \"Drama\" },\r\n  { \"title\": \"Mar adentro\", \"director\": \"Alejandro Amenábar\", \"year\": 2004, \"genre\": \"Drama\" },\r\n  { \"title\": \"Todo sobre mi madre\", \"director\": \"Pedro Almodóvar\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"El secreto de sus ojos\", \"director\": \"Juan José Campanella\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"Roma\", \"director\": \"Alfonso Cuarón\", \"year\": 2018, \"genre\": \"Drama\" },\r\n  { \"title\": \"Y tu mamá también\", \"director\": \"Alfonso Cuarón\", \"year\": 2001, \"genre\": \"Drama\" },\r\n  { \"title\": \"La lengua de las mariposas\", \"director\": \"José Luis Cuerda\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"Biutiful\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2010, \"genre\": \"Drama\" },\r\n  { \"title\": \"La vida secreta de las palabras\", \"director\": \"Isabel Coixet\", \"year\": 2005, \"genre\": \"Drama\" },\r\n  { \"title\": \"Relatos salvajes\", \"director\": \"Damián Szifron\", \"year\": 2014, \"genre\": \"Comedia negra\" },\r\n  { \"title\": \"Hable con ella\", \"director\": \"Pedro Almodóvar\", \"year\": 2002, \"genre\": \"Drama\" },\r\n  { \"title\": \"El orfanato\", \"director\": \"J.A. Bayona\", \"year\": 2007, \"genre\": \"Terror\" },\r\n  { \"title\": \"Volver\", \"director\": \"Pedro Almodóvar\", \"year\": 2006, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"Abre los ojos\", \"director\": \"Alejandro Amenábar\", \"year\": 1997, \"genre\": \"Ciencia ficción\" },\r\n  { \"title\": \"Celda 211\", \"director\": \"Daniel Monzón\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"El hijo de la novia\", \"director\": \"Juan José Campanella\", \"year\": 2001, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"El espinazo del diablo\", \"director\": \"Guillermo del Toro\", \"year\": 2001, \"genre\": \"Terror\" },\r\n  { \"title\": \"La piel que habito\", \"director\": \"Pedro Almodóvar\", \"year\": 2011, \"genre\": \"Thriller\" },\r\n  { \"title\": \"La historia oficial\", \"director\": \"Luis Puenzo\", \"year\": 1985, \"genre\": \"Drama\" }\r\n]\r\n ");
        #endregion
        public PruebasLinqView()
        {
            InitializeComponent();
        }

        private void btnPruebaArray_Click(object sender, EventArgs e)
        {
            // Creamos un array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Con LINQ filtramos los numeros pares y creamos un nuevo array
            var numerosPares = (from num in numbers
                                where num % 2 == 0
                                select new { NumeroPar = num }).ToList();

            // Asignamos el nuevo array a la grilla
            dataGridResultados.DataSource = numerosPares;
        }

        private void btnPruebaSQL_Click(object sender, EventArgs e)
        {
            using (var context = new CiclismoContext())
            {
                var query = from cliente in context.Clientes
                            select cliente;

                dataGridResultados.DataSource = query.ToList();
            }
        }

        private void btnPruebaXML_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("XML/Libros.xml");
            var libros = from book in doc.Descendants("book")
                         select new
                         {
                             Titulo = book.Element("title")?.Value,
                             Autor = book.Element("author")?.Value,
                             Año = book.Element("year")?.Value,
                             Genero = book.Element("genre")?.Value
                         };

            dataGridResultados.DataSource = libros.ToList();
        }

        private void btnPruebaJSON_Click(object sender, EventArgs e)
        {
            var peliculas = from pelicula in jsonArrayPeliculas
                            select new
                            {
                                Title = pelicula["title"],
                                Año = pelicula["year"],
                                Genero = pelicula["genre"]
                            };
            dataGridResultados.DataSource = peliculas.ToList();
        }

        private void btnPruebaSelect_Click(object sender, EventArgs e)
        {
            var peliculas = jsonArrayPeliculas.Select(p => new
            {
                Title = p["title"],
                Año = p["year"],
                Genero = p["genre"]
            });

            dataGridResultados.DataSource = peliculas.ToList();
        }

        private void btnSelectMany_Click(object sender, EventArgs e)
        {
            // Creamos un array objects
            object[] objetos = { 1, "San Justo", true, new string[] { "Hola", "Mundo" }, 5, "Crespo", 7.5f, 8, 9, new string[] { "Santa fe", "Argentina" } };

            // Con LINQ filtramos los numeros pares y creamos un nuevo array
            var textosEnArray = objetos.OfType<string[]>().SelectMany(a => a).Select(s => new
            {
                TextosArray = s
            });

            // Asignamos el nuevo array a la grilla
            dataGridResultados.DataSource = textosEnArray;
        }

        private void btnPruebaWhere_Click(object sender, EventArgs e)
        {
            var pelis = jsonArrayPeliculas.ToObject<List<Pelicula>>();
            //var peliculas = pelis.Where(p => p.year > 2000).ToList();
            //var peliculas = pelis.Where(p => p.year.Equals(1985)).ToList();
            var peliculas = pelis.Where(p => p.title.Contains("Roma")).ToList();

            dataGridResultados.DataSource = peliculas;
        }

        private void btnWhereAvanzado_Click(object sender, EventArgs e)
        {
            var pelis = jsonArrayPeliculas.ToObject<List<Pelicula>>();
            dataGridResultados.DataSource = pelis.Where(
                p => p.title.Contains(txtFiltro.Text) ||
                p.director.Contains(txtFiltro.Text) ||
                p.genre.Contains(txtFiltro.Text)).ToList();
        }

        private void btnPruebaOrderBy_Click(object sender, EventArgs e)
        {
            using (var context = new CiclismoContext())
            {
                var clientes = context.Clientes.OrderBy(c => c.Nombre);

                dataGridResultados.DataSource = clientes.ToList();
            }
        }

        private void btnOrderByAvanzado_Click(object sender, EventArgs e)
        {
            using (var context = new CiclismoContext())
            {
                var clientes = context.Clientes.OrderBy(c => c.Pais).ThenBy(c => c.Nombre);

                dataGridResultados.DataSource = clientes.ToList();
            }
        }

        private void btnPruebaOfType_Click(object sender, EventArgs e)
        {
            // Creamos un array objects
            object[] objects = { 1, "San Justo", true, new string[] { "Hola", "Mundo" }, 5, "Crespo", 7.5f, 8, 9, 10 };

            // Con LINQ filtramos los numeros pares y creamos un nuevo array
            var textosEnArray = objects.OfType<int>().Select(s => new
            {
                NumerosEnteros = s
            });

            // Asignamos el nuevo array a la grilla
            dataGridResultados.DataSource = textosEnArray;
        }

        private void btnOrderByDescending_Click(object sender, EventArgs e)
        {
            using (var context = new ArgentinaContext())
            {
                // Extension Methods (Metodos de Extension)
                var provincias = context.Provincias.OrderByDescending(p => p.Nombre);

                // Query Expresion
                //var provincias = from p in context.Provincias
                //                 orderby p.Nombre descending
                //                 select p;

                dataGridResultados.DataSource = provincias.ToList();
            }
        }

        private void btnPruebaGroupBy_Click(object sender, EventArgs e)
        {
            using (var context = new ArgentinaContext())
            {
                var dptosAgrupadosPorProvincia = context.Departamentos.Include(d => d.Provincias).GroupBy(d => d.ProvinciasId).Select(d => new
                {
                    NroProvincia = d.Key,
                    Provincia = d.First().Provincias.Nombre,
                    Nro_Departamentos = d.Count()
                });

                dataGridResultados.DataSource = dptosAgrupadosPorProvincia.ToList();
            }
        }

        // TAREA: Mostrar la cantidad de localidades que tiene cada departamento de la provincia de Santa Fe
        private void btnGroupByTarea_Click(object sender, EventArgs e)
        {
            using (var context = new ArgentinaContext()) 
            {
                var localidadesPorDepartamento = context.Localidades
                    .Where(d=>d.Departamentos.Provincias.Nombre == "Santa Fe")
                    .Include(d => d.Departamentos)
                    .ThenInclude(d=>d.Provincias)   // ThenInclude, cuando una vinculacion es ternaria
                    .GroupBy(d=>d.DepartamentosId)
                    .Select(d=>new
                {
                    Departamento = d.First().Departamentos.Nombre,
                    CantidadLocalidades = d.Count()
                });

                dataGridResultados.DataSource = localidadesPorDepartamento.ToList();
            }
        }
    }
}
