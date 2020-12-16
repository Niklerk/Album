using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Album.Models
{
    public class FotoModel
    {
        public int albumId { get; set; }
        public int id { get; set; }
        [DisplayName("Titulo")]
        public string title { get; set; }
        [DisplayName("Url")]
        public string url { get; set; }
        [DisplayName("Imagen")]
        public string thumbnailUrl { get; set; }
        
    }
}
