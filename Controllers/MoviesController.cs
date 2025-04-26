using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers;

public class MoviesController : Controller
{
    private readonly AppDbContext context;

    public MoviesController(AppDbContext context)
    {
        this.context = context;
    }

    public async Task<IActionResult> Index()
    {
        var movies = await context.Movies.Include(e => e.Cinema).OrderBy(e => e.StartDate).ToListAsync();
        return View(movies);
    }
}

