using System;
using eTickets.Data.Interface;
using eTickets.Data.Repos;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services;

public class MovieService : BaseRepository<Movie>, IMovieService
{
    private readonly AppDbContext context;

    public MovieService(AppDbContext context) : base(context)
    {
        this.context = context;
    }

    public Task<Movie?> GetMovieById(int id)
    {
        var movieDetails = context.Movies
            .Include(n => n.Cinema)
            .Include(n => n.Producer)
            .Include(n => n.ActorMovies).ThenInclude(n => n.Actor)
            .FirstOrDefaultAsync(n => n.Id == id);
        
        return movieDetails;
    }
}
