using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebsiteCrud.Model
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Artist { get; set; }

        public string Lyrics { get; set; }
    }
}
