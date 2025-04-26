using eTickets.Models;
using eTickets.Utils;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data;

public class AppDbContext : DbContext
{
    public virtual DbSet<Actor> Actors { get; set; }
    public virtual DbSet<Movie> Movies { get; set; }
    public virtual DbSet<ActorMovie> ActorMovies { get; set; }
    public virtual DbSet<Cinema> Cinemas { get; set; }
    public virtual DbSet<Producer> Producers { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActorMovie>().HasKey(e => new
        {
            e.MovieId,
            e.ActorId
        });

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ActorMovie>().HasOne(e => e.Movie).WithMany(e => e.ActorMovies).HasForeignKey(e => e.MovieId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ActorMovie>().HasOne(e => e.Actor).WithMany(e => e.ActorMovies).HasForeignKey(e => e.ActorId).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.SeedDefaultData();
    }
}
