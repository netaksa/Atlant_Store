using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Atlant_Store.Models;

namespace Atlant_Store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Catalog()
        {
            ViewData["Message"] = "Your application description page.";
            List<Album> albums=new List<Album>();
            Artist Artist= new Artist { Name = "Zeca Pagodinho" };
            Genre genres=  new Genre { Name = "Pop" };
            Album ddd = new Album { Title = "Black Light Syndrome", Genre = genres, Price = 8.99M, Artist = Artist, AlbumArtUrl = "imgUrl" };
            albums.Add(ddd);
                     albums.Add(ddd);
                              albums.Add(ddd);
                                       albums.Add(ddd);

                                                albums.Add(ddd);
                                                         albums.Add(ddd);

                                                                  albums.Add(ddd);
                                                                           albums.Add(ddd);         albums.Add(ddd);

                                                                                    albums.Add(ddd);
                                                                                             albums.Add(ddd);         albums.Add(ddd);

                                                                                                      albums.Add(ddd);         albums.Add(ddd);

                                                                                                               albums.Add(ddd);         albums.Add(ddd);
                                                                                                                        albums.Add(ddd);
                                                                                                                         albums.Add(ddd);
                     albums.Add(ddd);
                              albums.Add(ddd);
                                       albums.Add(ddd);

                                                albums.Add(ddd);
                                                         albums.Add(ddd);

                                                                  albums.Add(ddd);
                                                                           albums.Add(ddd);         albums.Add(ddd);

                                                                                    albums.Add(ddd);
                                                                                             albums.Add(ddd);         albums.Add(ddd);

                                                                                                      albums.Add(ddd);         albums.Add(ddd);

                                                                                                               albums.Add(ddd);         albums.Add(ddd);
                                                                                                                        albums.Add(ddd); albums.Add(ddd);
                     albums.Add(ddd);
                              albums.Add(ddd);
                                       albums.Add(ddd);

                                                albums.Add(ddd);
                                                         albums.Add(ddd);

                                                                  albums.Add(ddd);
                                                                           albums.Add(ddd);         albums.Add(ddd);

                                                                                    albums.Add(ddd);
                                                                                             albums.Add(ddd);         albums.Add(ddd);

                                                                                                      albums.Add(ddd);         albums.Add(ddd);

                                                                                                               albums.Add(ddd);         albums.Add(ddd);
                                                                                                                        albums.Add(ddd); albums.Add(ddd);
                     albums.Add(ddd);
                              albums.Add(ddd);
                                       albums.Add(ddd);

                                                albums.Add(ddd);
                                                         albums.Add(ddd);

                                                                  albums.Add(ddd);
                                                                           albums.Add(ddd);         albums.Add(ddd);

                                                                                    albums.Add(ddd);
                                                                                             albums.Add(ddd);         albums.Add(ddd);

                                                                                                      albums.Add(ddd);         albums.Add(ddd);

                                                                                                               albums.Add(ddd);         albums.Add(ddd);
                                                                                                                        albums.Add(ddd); albums.Add(ddd);
                     albums.Add(ddd);
                              albums.Add(ddd);
                                       albums.Add(ddd);

                                                albums.Add(ddd);
                                                         albums.Add(ddd);

                                                                  albums.Add(ddd);
                                                                           albums.Add(ddd);         albums.Add(ddd);

                                                                                    albums.Add(ddd);
                                                                                             albums.Add(ddd);         albums.Add(ddd);

                                                                                                      albums.Add(ddd);         albums.Add(ddd);

                                                                                                               albums.Add(ddd);         albums.Add(ddd);
                                                                                                                        albums.Add(ddd); albums.Add(ddd);
                     albums.Add(ddd);
                              albums.Add(ddd);
                                       albums.Add(ddd);

                                                albums.Add(ddd);
                                                         albums.Add(ddd);

                                                                  albums.Add(ddd);
                                                                           albums.Add(ddd);         albums.Add(ddd);

                                                                                    albums.Add(ddd);
                                                                                             albums.Add(ddd);         albums.Add(ddd);

                                                                                                      albums.Add(ddd);         albums.Add(ddd);

                                                                                                               albums.Add(ddd);         albums.Add(ddd);
                                                                                                                        albums.Add(ddd); albums.Add(ddd);
                     albums.Add(ddd);
                              albums.Add(ddd);
                                       albums.Add(ddd);

                                                albums.Add(ddd);
                                                         albums.Add(ddd);

                                                                  albums.Add(ddd);
                                                                           albums.Add(ddd);         albums.Add(ddd);

                                                                                    albums.Add(ddd);
                                                                                             albums.Add(ddd);         albums.Add(ddd);

                                                                                                      albums.Add(ddd);         albums.Add(ddd);

                                                                                                               albums.Add(ddd);         albums.Add(ddd);
                                                                                                                        albums.Add(ddd); albums.Add(ddd);
                     albums.Add(ddd);
                              albums.Add(ddd);
                                       albums.Add(ddd);

                                                albums.Add(ddd);
                                                         albums.Add(ddd);

                                                                  albums.Add(ddd);
                                                                           albums.Add(ddd);         albums.Add(ddd);

                                                                                    albums.Add(ddd);
                                                                                             albums.Add(ddd);         albums.Add(ddd);

                                                                                                      albums.Add(ddd);         albums.Add(ddd);

                                                                                                               albums.Add(ddd);         albums.Add(ddd);
                                                                                                                        albums.Add(ddd);
            return View(albums);
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
