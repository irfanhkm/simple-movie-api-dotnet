using System.Net;
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
        public ActionResult Add([FromBody] MovieGenreDto dto)
        {
            var entity = MovieGenreFactory.ParsingDto(dto);
            _repository.Save(entity);
            return new JsonResult(ResponseDmo.Success(MovieGenreFactory.ShowMovieGenre(entity), HttpStatusCode.Created));
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] MovieGenreDto dto)
        {
            bool Update = _repository.Update(id, MovieGenreFactory.ParsingDto(dto));
            if (Update)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public ActionResult Detail(int id)
        {
            var data = _repository.FindById(id);
            if (data != null)
            {
                return new JsonResult(ResponseDmo.Success(MovieGenreFactory.ShowMovieGenre(data)));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var data = _repository.FindById(id);
            if (data == null)
            {
                return NotFound();
            }
            _repository.DeleteById(id);
            return NoContent();
        }
    }
}