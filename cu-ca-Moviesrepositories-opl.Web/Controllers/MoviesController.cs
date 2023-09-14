using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core_MovieShop_opl_Afst.Data;
using Core_MovieShop_opl_Afst_Web.ViewModels;
using Core_MovieShop_opl_Afst_Core.Entities;

namespace oe_h05_EFCore_RateAMovie_opl_Afst.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieDbContext _movieDbContext;


        public MoviesController(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var moviesIndexViewModel = new MoviesIndexViewModel
            {
                Movies = await _movieDbContext.Movies.Select(m =>
                new MoviesInfoViewModel
                {
                    Id = m.Id,
                    Name = m.Title,
                    Price = m.Price,
                    Image = m.Image,
                }).ToListAsync(),
            };
            moviesIndexViewModel.PageTitle = "Our movies";
            return View(moviesIndexViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Info(int id)
        {
            var movie = await _movieDbContext
                .Movies
                .Include(m => m.Company)
                .FirstOrDefaultAsync(m => m.Id == id);
            if(movie == null)
            {
                return NotFound();
            }
            var moviesInfoViewModel = new MoviesInfoViewModel
            {
                Id = movie.Id,
                Name = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                Company = new BaseViewModel 
                {
                    Id  = movie.Company.Id,
                    Name = movie.Company.Name,
                },
                Image = movie.Image,
            };
            moviesInfoViewModel.PageTitle = "Info";
            return View(moviesInfoViewModel);
        }
    }
}
