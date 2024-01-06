using Portfolio.Interfaces;
using Portfolio.Models;

namespace Portfolio.Servicios
{
    public class RepositorioProyecto: IRepositorioProyecto
    {
        public List<ProyectoDTO> ObtenerPRoyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO()
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado es ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL = "/img/amazon.png"
                },
                new ProyectoDTO()
                {
                    Titulo = "New York Times",
                    Descripcion = "Página de noticias en React",
                    Link = "https://nytimes.com",
                    ImagenURL = "/img/nyt.png"
                },
                new ProyectoDTO()
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado es ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL = "/img/amazon.png"
                },
                new ProyectoDTO()
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "/img/reddit.png"
                },
                new ProyectoDTO()
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en linea para comprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/img/steam.png"
                },
            };
        }
    }
}
