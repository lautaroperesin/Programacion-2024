using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancionesDesktop.Models
{
    public class Cancion
    {
        public string _id {  get; set; }
        public string cancion { get; set; }
        public string artista { get; set; }
        public string portada_url { get; set; }
    }
}
