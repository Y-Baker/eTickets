using System;
using eTickets.Data.Repos;
using eTickets.Models;

namespace eTickets.Data.Services;

public class ProducerService : BaseRepository<Producer>, IProducerService
{
    public ProducerService(AppDbContext context) : base(context)
    {
    }
}
