using BestFilmASPNewVersion.Domains;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFilmASPNewVersion.Models //Будет нужен, если будем грузить картинку с сайта в проект.
{
    /// <summary>
    /// Работа с файлами
    /// вставляем картинку
    /// </summary>
    public class MovieViewModel : Movie
    {
        public IFormFile FilePicture{ get; set; }

        public MovieViewModel()
        {

        }

        //Если лень писать все проп - делай рефрексию, а пока так
        public MovieViewModel(Movie entity)
        {
            MovieId = entity.MovieId;
            Name = entity.Name;
            ImageUrl = entity.ImageUrl;
            Realease = entity.Realease;
            Rating = entity.Rating;
            Discription = entity.Discription;
            Genre = entity.Genre;
            Actor = entity.Actor;
            Country = entity.Country;
        }
    }
}
