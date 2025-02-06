using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MyMovieApp.Models;


namespace MyMovieApp.Controllers;

public class  MovieController : Controller
{
    private readonly MovieContext _context;

    public MovieController(MovieContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }
}
