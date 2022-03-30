using BestFilmASPNewVersion.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFilmASPNewVersion.Models
{
    /// <summary>
    /// для передачи состояния страницы - номер
    /// </summary>
    public class PageInfoModel
    {
        public string ActiveGenre { get; set; }

        public int CurrentPage { get; set; }

        public int PagesQuantity { get; set; }


        // + передача фильмов, тк она передавалась, вместо этого класса
        public List<Movie> Movies { get; set; }
    }
}
