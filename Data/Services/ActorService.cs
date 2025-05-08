using System;
using eTickets.Data.Repos;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services;

public class ActorService : BaseRepository<Actor>, IActorService
{
    public ActorService(AppDbContext context) : base(context)
    {
    }
}
