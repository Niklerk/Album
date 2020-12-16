using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Album.Models;
using Album.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace Album.Controllers
{
    public class AlbumController : Controller
    {
        // GET: AlbumController
        public ActionResult Index()
        {
            string url = "https://jsonplaceholder.typicode.com/albums";
            Datos datos = new Datos();
            var albums = JsonSerializer.Deserialize<List<AlbumModel>>(datos.ObtenerDatosAPI(url));
            return View(albums);
        }

        // GET: AlbumController/Details/5
        public ActionResult Details(int id)
        {
            string url = "https://jsonplaceholder.typicode.com/photos?albumId=" + id;
            Datos datos = new Datos();
            var fotos = JsonSerializer.Deserialize<List<FotoModel>>(datos.ObtenerDatosAPI(url));
            return View(fotos);
        }

        // GET: AlbumController/Details/5
        public PartialViewResult Comments(int id)
        {
            string url = "https://jsonplaceholder.typicode.com/comments?postId=" + id;
            Datos datos = new Datos();
            var comentarios = JsonSerializer.Deserialize<List<ComentarioModel>>(datos.ObtenerDatosAPI(url));
            return PartialView("_Comments", comentarios);
        }

    }
}
