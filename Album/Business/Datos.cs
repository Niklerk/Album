using Album.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Album.Business
{
    public class Datos
    {
        public string ObtenerDatosAPI(string url)
        {
            using (var client = new HttpClient())
            {
                HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, url);
                HttpResponseMessage resp = client.SendAsync(m).Result;
                return resp.Content.ReadAsStringAsync().Result;
                
            }
        }
    }
}
