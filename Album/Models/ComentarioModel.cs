using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Album.Models
{
    public class ComentarioModel
    {
        public int postId { get; set; }
        public int id { get; set; }
        [DisplayName("Nombre")]
        public string name { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Comentario")]
        public string body { get; set; }
        
    }
}
