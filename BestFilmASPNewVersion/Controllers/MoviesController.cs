using BestFilmASPNewVersion.Abstract;
using BestFilmASPNewVersion.Models;
using Microsoft.AspNetCore.Hosting;
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
        private int _pageSize = 2;

        // серверное окружение - нужно будет для загрузки с сайта.
        private readonly IWebHostEnvironment _environment;

        public MoviesController(IMovieRepository repo)
        {
            _repo = repo;
        }

        
        //[Route("[controller]/[action]")]
        public IActionResult ListView(string genre, int helloy = 1)
        {
            //тернарный оператор
            var moviesOfGenre = genre == null
                ? _repo.Movies
                : _repo.Movies
                .Where(p => p.Genre == genre);

            var moviesForPage = moviesOfGenre
                .Skip((helloy - 1) * _pageSize) // -1 тк первую не надо скипать
                .Take(_pageSize)
                .ToList();

            //Пытаемся настроить количество страниц, тк остаются хвостики
            int pagesQuantity = (int)(
                Math.Ceiling(
                moviesOfGenre.Count() / (float)_pageSize)
                );

            var model = new PageInfoModel()
            {
                ActiveGenre = genre,
                CurrentPage = helloy,
                PagesQuantity = pagesQuantity,
                Movies = moviesForPage.ToList()
            };

            return View(model);
        }


        // для AngularJs
        public IActionResult AdvancedView()
        {

            return View();
        }

        // конектор 
        public JsonResult TestService()
        {
            var movie = _repo.Movies;

            return new JsonResult(movie);
        }

    }
}
