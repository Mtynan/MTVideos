using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MTVideos.Models
{
    public class Movies
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Date Released")]
        public DateTime DateReleased { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }

        public Genres Genre { get; set; }

        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
    }
}