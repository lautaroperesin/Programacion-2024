using EjerciciosDePrueba.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Repositories
{
    public class LibrosRepositorio
    {
        string urlApi = "https://ingenieria2023-ec45.restdb.io/rest/libros";
        HttpClient client = new HttpClient();

        public LibrosRepositorio()
        {
            // Configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "64f8c70e68885478480bfe86");
        }

        public async Task<ObservableCollection<Libro>> ObtenerLibrosAsync()
        {
            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Libro>>(response);
        }
    }
}
