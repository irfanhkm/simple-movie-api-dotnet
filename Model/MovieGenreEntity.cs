using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace simple_movie_api_dotnet.Model
{
    [Table("movie_genres")]
    public class MovieGenreEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public List<MovieEntity> Movies { get; set; }
    }
}
