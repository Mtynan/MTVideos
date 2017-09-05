﻿using MTVideos.Dtos;
using MTVideos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MTVideos.Controllers.Api
{
    public class RentalController : ApiController
    {
        private ApplicationDbContext _context;

        [HttpPost]
        public IHttpActionResult CreateNewRentals (NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id));

            foreach (var movie in movies)
            {
                var rental = new Rental
                {
                    Customer = customer,
                    Movies = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

            _context.SaveChanges();

            return Ok();
        }

    }
}
