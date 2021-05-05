
using System.Collections.Generic;
using System.Linq;
using simple_movie_api_dotnet.Model;

namespace simple_movie_api_dotnet.Repositories
{
    public class MovieGenreRepository
    {
        public ModelContext context;

        public MovieGenreRepository()
        {
            context = new ModelContext();
        }

        public object Save(MovieGenreEntity entity)
        {
            context.MovieGenre.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public List<MovieGenreEntity> GetAll()
        {
            return context.MovieGenre.ToList();
        }

        public MovieGenreEntity FindById(int id)
        {
            return context.MovieGenre.Where(movieGenre => movieGenre.Id == id).FirstOrDefault();
        }

        public bool Update(int id, MovieGenreEntity Entity)
        {
            var data = FindById(id);
            if (data == null)
            {
                // throw not found response << blum tau caranya
                return false;
            }

            data.Name = Entity.Name;
            context.SaveChanges();
            return true;
        }
    }
}
