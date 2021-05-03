using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace simple_movie_api_dotnet.Entities
{
    [Table("actors")]
    public class ActorEntity
    {
        [Key]
        public int Id { get; set; }

        [Key, Column("name")]
        public string Name;

        [Key, Column("age")]
        public int Age;
    }
}
