using Microsoft.AspNetCore.Mvc;
using simple_movie_api_dotnet.Dmo;
using simple_movie_api_dotnet.Dto;
using simple_movie_api_dotnet.Factory;
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
        public ActionResult<MovieGenreDmo> GetMovieGenre()
        {
            var data = _repository.GetAll();
            return new JsonResult(ResponseDmo.Success(data));
        }

        [HttpPost("")]
        public ActionResult<MovieGenreDto> Add([FromBody] MovieGenreDto dto)
        {
            var entity = MovieGenreFactory.ParsingDto(dto);
            _repository.Save(entity);
            return new JsonResult(ResponseDmo.Success(MovieGenreFactory.ShowMovieGenre(entity), 201));
        }
    }
}