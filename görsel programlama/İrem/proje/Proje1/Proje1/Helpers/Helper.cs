using Proje1.Enums;
using Proje1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1.Helpers
{
    class Helper
    {
        public static List<Movie> createMovies()
        {
            string basePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Karayip Korsanları",
                    category = Category.gerilim,
                    minute = "1 Saat 20 Dakika",
                    price = 60,
                    picturePath = basePath + "/pirates.jpeg"
                },
                   new Movie()
                {
                    movieName = "Island",
                    category = Category.macera,
                    minute = "2 Saat 10 Dakika",
                    price = 60,
                    picturePath = basePath + "/island.jpg"
                },
                new Movie()
                {
                    movieName = "Looper",
                    category = Category.bilimKurgu,
                    minute = "2 Saat 55 Dakika",
                    price = 20,
                    picturePath = basePath + "/looper.jpg"
                },
                new Movie()
                {
                    movieName = "Matrix",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 1 Dakika",
                    price = 30,
                    picturePath = basePath + "/matrix.jpg"
                },
                new Movie()
                {
                    movieName = "Mumya",
                    category = Category.komedi,
                    minute = "2 Saat 40 Dakika",
                    price = 50,
                    picturePath = basePath + "/mummy.jpg"
                },

             new Movie()
                {
                    movieName = "Pulp Fiction",
                    category = Category.bilimKurgu,
                    minute = "3 Saat 30 Dakika",
                    price = 200,
                    picturePath = basePath + "/pulp.jpg"
                },


            };
        }
    }
}
