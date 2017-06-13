using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTVideos.Models
{
    public class Movies
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public DateTime DateReleased { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }

        public Genres Genre { get; set; }
        public byte GenreId { get; set; }
    }
}