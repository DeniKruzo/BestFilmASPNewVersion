using BestFilmASPNewVersion.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFilmASPNewVersion.Components
{
    /// <summary>
    /// Виджет с жанрами
    /// </summary>
    public class GenreMenuViewComponent : ViewComponent
    {
        private readonly IMovieRepository repo;

        public GenreMenuViewComponent(IMovieRepository repo)
        {
            this.repo = repo;
        }

        public IViewComponentResult Invoke()
        {
            var genre = repo.Movies
                .Select(p => p.Genre)
                .Distinct()  // делим, чтобы не было повторений
                .OrderBy(x => x) // сортируем по алфавиту
                .ToList();

            return View(genre);
        }
    }
}
