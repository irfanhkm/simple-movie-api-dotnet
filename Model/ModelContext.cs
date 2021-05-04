using System.Collections.Generic;
using dotenv.net;
using Microsoft.EntityFrameworkCore;

namespace simple_movie_api_dotnet.Model
{
    public class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ActorEntity> Actor { get; set; }
        public DbSet<MovieGenreEntity> MovieGenre { get; set; }
        public DbSet<MovieEntity> Movie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IDictionary<string, string> env = DotEnv.Read();
                optionsBuilder.UseMySQL(env["CONNECTION_STRING"]);
            }
        }
    }
}
