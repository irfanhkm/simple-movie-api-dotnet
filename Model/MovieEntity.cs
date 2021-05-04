using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace simple_movie_api_dotnet.Model
{
    [Table("movies")]
    public class MovieEntity
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("premier_on")]
        public DateTime PremierOn { get; set; }

        [ForeignKey("movie_genre_id"), Column("movie_genre_id")]
        public int MovieGenreId { get; set; }

        public virtual MovieGenreEntity MovieGenre { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

}
