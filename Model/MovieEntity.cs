using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace simple_movie_api_dotnet.Entities
{
    [Table("movies")]
    public class MovieEntity
    {
        [Key]
        public int Id { get; set; }

        [Key, Column("title")]
        public string Title;

        [Key, Column("premier_on")]
        public DateTime PremierOn;

        [Key, Column("created_at")]
        public DateTime CreatedAt;

        [Key, Column("updated_at")]
        public DateTime UpdatedAt;

        [Key, Column("movie_genre_id")]
        public MovieGenreEntity MovieGenre;
    }
}
