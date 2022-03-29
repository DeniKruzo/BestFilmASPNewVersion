using BestFilmASPNewVersion.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFilmASPNewVersion.Abstract
{
    public interface IMovieRepository
    {
        //Привет Linq
        IQueryable<Movie> Movies { get;}
    }
}
