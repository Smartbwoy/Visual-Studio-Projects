using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie=new Movie(){Name="Bad Boys"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer{Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie=movie,
                Customers = customers
            };

            
            //var viewResult=new ViewResult();
            //viewResult.ViewData.Model;
            return View(viewModel);
           //return Content("Working Hard");
           // return HttpNotFound();
           // return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }

        /*[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }*/

        /* public ActionResult Edit(int id)
         {
             return Content("id=" + id);
         }
         //movies
         public ActionResult Index(int? pageIndex, string sortBy)
         {
             if (!pageIndex.HasValue)
             {
                 pageIndex = 1;
             }
 
             if (String.IsNullOrWhiteSpace(sortBy))
             {
                 sortBy = "Name";
             }
 
             return Content(String.Format("pageIndex={0}&SsortBy={1}", pageIndex, sortBy));
         }*/
    }
}