using System.Collections.Generic;
using simple_movie_api_dotnet.Dmo;
using simple_movie_api_dotnet.Dto;
using simple_movie_api_dotnet.Model;

namespace simple_movie_api_dotnet.Factory
{
    public class MovieGenreFactory
    {
        public static MovieGenreEntity ParsingDto(MovieGenreDto dto)
        {
            return new MovieGenreEntity()
            {
                Name = dto.Name,
            };
        }

        public static List<MovieGenreDmo> ParsingListMovieGenre(List<MovieGenreEntity> param)
        {
            List<MovieGenreDmo> Datas = new();
            param.ForEach((data) => Datas.Add(ShowMovieGenre(data)));
            return Datas;
        }

        public static MovieGenreDmo ShowMovieGenre(MovieGenreEntity dto)
        {
            return new MovieGenreDmo()
            {
                Id = dto.Id,
                Name = dto.Name,
            };
        }
    }
}
