using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTVideos.Dtos
{
    public class MoviesDto
    {
 
        public byte Id { get; set; }
        public string Name { get; set; }
    
        [Required]
        public DateTime DateReleased { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Range(1, 20)]
        public int NumberInStock { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}