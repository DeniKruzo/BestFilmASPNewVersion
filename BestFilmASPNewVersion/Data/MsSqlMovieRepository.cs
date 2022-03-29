using BestFilmASPNewVersion.Abstract;
using BestFilmASPNewVersion.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFilmASPNewVersion.Data
{
    public class MsSqlMovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MsSqlMovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //get
        public IQueryable<Movie> Movies => _context.Movies;
    }
}
