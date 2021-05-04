using Microsoft.EntityFrameworkCore;
using simple_movie_api_dotnet.Entities;

namespace simple_movie_api_dotnet.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActorEntity> Actor { get; set; }
        public virtual DbSet<MovieGenreEntity> MovieGenre { get; set; }
        public virtual DbSet<MovieEntity> Movie { get; set; }
    }
}
