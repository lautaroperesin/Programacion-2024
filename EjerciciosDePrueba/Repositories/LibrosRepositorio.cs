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

        public async Task<ObservableCollection<Libro>?> ObtenerLibrosAsync()
        {
            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Libro>>(response);
        }

        public async Task<Libro?> AgregarAsync(string nombre, int paginas, string autor, string editorial, string genero, string sinopsis, string portada_url)
        {
            // Creamos un objeto del tipo Libro con los parámetros que llegan
            Libro libro = new Libro()
            {
                nombre = nombre,
                paginas = paginas,
                autor = autor,
                editorial = editorial,
                genero = genero,
                sinopsis = sinopsis,
                portada_url = portada_url
            };

            // Enviamos por POST el objeto que creamos a la URL de la API
            var libroJson = new StringContent(
                    JsonConvert.SerializeObject(libro),
                    Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlApi,
                new StringContent(
                    JsonConvert.SerializeObject(libro),
                    Encoding.UTF8, "application/json"));

            // Retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Libro>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<Libro?> ActualizarAsync(string nombre, int paginas, string autor, string editorial, string genero, string sinopsis, string portada_url, string id)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Libro libro = new Libro()
            {
                nombre = nombre,
                paginas = paginas,
                autor = autor,
                editorial = editorial,
                genero = genero,
                sinopsis = sinopsis,
                portada_url = portada_url
            };

            //enviamos por PUT el objeto que creamos a la URL de la API
            var librojson = new StringContent(
                    JsonConvert.SerializeObject(libro),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, librojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Libro>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<Libro?> ObtenerPorIdAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Libro>(response);
        }

        public async Task<bool> EliminarAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
    }
}
