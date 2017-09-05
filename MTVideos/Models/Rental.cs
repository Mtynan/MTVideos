﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MTVideos.Models
{
    public class Rental
    {

        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Movies Movies { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}