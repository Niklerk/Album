using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Album.Models
{
    public class AlbumModel
    {
        [DisplayName("Album Id")]
        public int userId { get; set; }
        public int id { get; set; }
        [DisplayName("Titulo")]
        public string title { get; set; }
    }
}
