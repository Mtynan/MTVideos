using MTVideos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTVideos.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genres> Genres { get; set; }
        public Movies Movies { get; set; }
        public string Title
        {
            get
            {
                if (Movies != null && Movies.Id != 0)
                {
                    return "Edit Movie";
                }
                return "New Movie";
            }
        }
    }
}
