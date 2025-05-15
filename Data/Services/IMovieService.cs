using System;
using eTickets.Data.Interface;
using eTickets.Models;

namespace eTickets.Data.Services;

public interface IMovieService : IBaseRepository<Movie>
{
    Task<Movie?> GetMovieById(int id);
}
