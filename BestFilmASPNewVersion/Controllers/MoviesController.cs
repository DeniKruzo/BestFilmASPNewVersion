using BestFilmASPNewVersion.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFilmASPNewVersion.Controllers
{
    public class MoviesController : Controller
    {
       
        private readonly IMovieRepository _repo;
        //private int _pageSize = 2;

        public MoviesController(IMovieRepository repo)
        {
            _repo = repo;
        }

        public IActionResult ListView()
        {
            var movies = _repo.Movies;
            return View(movies);
        }

        //public IActionResult ListView(string genre, int page = 1)
        //{
        //    //магия тернарных операторов
        //    var moviesOfGenre = genre == null
        //        ? _repo.Movies
        //        : _repo
        //        .Movies
        //        .Where(p => p.Genre == genre);

        //    var moviesForPage = moviesOfGenre
        //        .Skip((page - 1) * _pageSize) // -1 тк первую не надо скипать
        //        .Take(_pageSize)
        //        .ToList();

        //    //Пытаемся настроить количество страниц, тк остаются хвостики
        //    int pagesQuantity = (int)(
        //        Math.Ceiling(
        //        moviesOfGenre.Count() / (float)_pageSize)
        //        );

        //    var model = new PageInfoModel()
        //    {
        //        ActiveGenre = genre,
        //        CurrentPage = page,
        //        PagesQuantity = pagesQuantity,
        //        Movies = moviesForPage.ToList()
        //    };

        //    return View(model);
        //}

    }
}
