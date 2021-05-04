﻿
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

        public object Save(MovieGenreEntity factory)
        {
            return context.MovieGenre.Add(factory);
        }

        public ICollection<MovieGenreEntity> GetAll()
        {
            return context.MovieGenre.ToList();
        }
    }
}