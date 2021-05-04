using simple_movie_api_dotnet.Dto;
using simple_movie_api_dotnet.Model;

namespace simple_movie_api_dotnet.Factory
{
    public class MovieGenreFactory
    {
        public static MovieGenreEntity parsingDto(MovieGenreDto dto)
        {
            return new MovieGenreEntity()
            {
                Name = dto.NamaGenre,
            };
        }
    }
}
