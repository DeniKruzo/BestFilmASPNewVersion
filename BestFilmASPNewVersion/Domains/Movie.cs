using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BestFilmASPNewVersion.Domains
{
    public class Movie
    {
        public long MovieId { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        //ссылка на картинку
        [Display(Name = "Изображение")]
        public string ImageUrl { get; set; }

        //год выхода фильма
        [Display(Name = "Год выхода")]
        public int Realease { get; set; }

        //оценка фильма по КиноПоиску от 1 до 10
        [Display(Name = "Рейтинг")]
        public float Rating { get; set; }

        [Display(Name = "Описание")]
        public string Discription { get; set; }

        //жанр
        [Display(Name = "Жанр")]
        public string Genre { get; set; }

        //гл.Персонаж фильма
        [Display(Name = "Актёр")]
        public string Actor { get; set; }

        [Display(Name = "Страна")]
        public string Country { get; set; }
    }
}
