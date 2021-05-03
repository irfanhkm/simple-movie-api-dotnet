using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace simple_movie_api_dotnet.Entities
{
    [Table("movie_genres")]
    public class MovieGenreEntity
    {
        [Key]
        public int Id { get; set; }

        [Key, Column("name")]
        public string Name;
    }
}
