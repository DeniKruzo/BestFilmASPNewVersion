using BestFilmASPNewVersion.Abstract;
using BestFilmASPNewVersion.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFilmASPNewVersion.Data
{
    public class SimpleMovieRepository  : IMovieRepository
    {
        public IQueryable<Movie> Movies => new List<Movie>()
        {
                    new Movie()
                    {
                        Name = "Мстители",
                        ImageUrl ="",
                        Actor = "Роберт Дауни мл",
                        Genre = "Боевик",
                        Discription = "The Avengers",
                        Country = "США",
                        Rating = 7.8f,
                        Realease = 2012
                    },
                    new Movie()
                    {
                        Name = "Крик 5",
                        ImageUrl ="",
                        Actor = "Мелисса Баррера",
                        Genre = "Ужасы",
                        Discription = "Scream",
                        Country = "США",
                        Rating = 6.3f,
                        Realease = 2022
                    }

        }.AsQueryable();
    }
}
