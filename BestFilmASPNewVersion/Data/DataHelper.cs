using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestFilmASPNewVersion.Data
{
    /// <summary>
    /// Заполняем бд из репозитория
    /// </summary>
    public class DataHelper
    {
        public static void Seed(IApplicationBuilder app)
        {
            var contex =
            app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            if (contex.Movies.Any()) return;

            contex.Movies.AddRange(new SimpleMovieRepository().Movies);
            contex.SaveChanges();
        }
    }
}
