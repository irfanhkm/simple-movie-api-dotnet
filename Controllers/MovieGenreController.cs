using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using simple_movie_api_dotnet.Dto;
using simple_movie_api_dotnet.Factory;
using simple_movie_api_dotnet.Model;
using simple_movie_api_dotnet.Repositories;

namespace simple_movie_api_dotnet.Controllers
{
    [Route("api/movie-genre")]
    public class MovieGenreController : Controller
    {
        readonly MovieGenreRepository _repository;

        public MovieGenreController()
        {
            _repository = new MovieGenreRepository();
        }

        [HttpGet("")]
        public IEnumerable<MovieGenreEntity> GetMovieGenre()
        {
            return _repository.GetAll();
        }

        [HttpPost("")]
        public IActionResult Add([FromBody] MovieGenreDto dto)
        {
            return Ok(_repository.Save(MovieGenreFactory.parsingDto(dto)));
        }
    }
}