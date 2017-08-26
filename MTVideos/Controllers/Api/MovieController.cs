﻿using AutoMapper;
using MTVideos.Dtos;
using MTVideos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MTVideos.Controllers.Api
{
    public class MovieController : ApiController
    {

        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<MoviesDto> GetMovies()
        {
            return _context.Movies.ToList().Select(Mapper.Map<Movies, MoviesDto>);
        }

        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movies, MoviesDto>(movie));
        }

        [HttpPost]
        public IHttpActionResult CreateMovie(MoviesDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MoviesDto, Movies>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MoviesDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                return NotFound();

            Mapper.Map(movieDto, movieInDb);
            _context.SaveChanges();

            return Ok();     

        }

        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                return NotFound();

            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();

            return Ok();

        }

    }


   
}