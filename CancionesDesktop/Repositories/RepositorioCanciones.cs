using CancionesDesktop.Models;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancionesDesktop.Repositories
{
    public class RepositorioCanciones
    {
        string urlApi = "https://spotify-d0ea.restdb.io/rest/playlists";
        HttpClient client = new HttpClient();

        public RepositorioCanciones()
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "652810d196c2501ea9e3ed3b");
        }

        public async Task<ObservableCollection<Cancion>?> ObtenerCancionesAsync()
        {
            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Cancion>>(response);
        }

        public async Task<Cancion?> AgregarAsync(string nombreCancion, string artista, string portada_url)
        {
            Cancion cancion = new Cancion()
            {
                cancion = nombreCancion,
                artista = artista,
                portada_url = portada_url
            };

            var cancionJson = new StringContent(
                    JsonConvert.SerializeObject(cancion),
                    Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlApi,
                new StringContent(
                    JsonConvert.SerializeObject(cancion),
                    Encoding.UTF8, "application/json"));

            return JsonConvert.DeserializeObject<Cancion>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<Cancion?> ActualizarAsync(string nombreCancion, string artista, string portada_url, string id)
        {
            Cancion cancion = new Cancion()
            {
                cancion = nombreCancion,
                artista = artista,
                portada_url = portada_url
            };

            var cancionJson = new StringContent(
                    JsonConvert.SerializeObject(cancion),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, cancionJson);

            return JsonConvert.DeserializeObject<Cancion>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<Cancion?> ObtenerPorIdAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Cancion>(response);
        }

        public async Task<bool> EliminarAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
    }
}