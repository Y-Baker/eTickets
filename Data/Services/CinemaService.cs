using System;
using eTickets.Data.Repos;
using eTickets.Models;

namespace eTickets.Data.Services;

public class CinemaService : BaseRepository<Cinema>, ICinemaService
{
    public CinemaService(AppDbContext context) : base(context)
    {
    }
}
