using System;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Utils;

public static class Extenstions
{
    public static void SeedDefaultData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cinema>().HasData(new List<Cinema>()
        {
            new Cinema()
            {
                Id = 1,
                Name = "Cinema 1",
                Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                Description = "This is the description of the first cinema"
            },
            new Cinema()
            {
                Id = 2,
                Name = "Cinema 2",
                Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                Description = "This is the description of the second cinema"
            },
            new Cinema()
            {
                Id = 3,
                Name = "Cinema 3",
                Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                Description = "This is the description of the third cinema"
            },
            new Cinema()
            {
                Id = 4,
                Name = "Cinema 4",
                Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                Description = "This is the description of the fourth cinema"
            },
            new Cinema()
            {
                Id = 5,
                Name = "Cinema 5",
                Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                Description = "This is the description of the fifth cinema"
            }
        });

        modelBuilder.Entity<Actor>().HasData(new List<Actor>()
        {
            new Actor()
            {
                Id = 1,
                FullName = "Actor 1",
                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                Bio = "This is the bio of the first actor"
            },
            new Actor()
            {
                Id = 2,
                FullName = "Actor 2",
                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg",
                Bio = "This is the bio of the second actor"
            },
            new Actor()
            {
                Id = 3,
                FullName = "Actor 3",
                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg",
                Bio = "This is the bio of the third actor"
            },
            new Actor()
            {
                Id = 4,
                FullName = "Actor 4",
                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg",
                Bio = "This is the bio of the fourth actor"
            },
            new Actor()
            {
                Id = 5,
                FullName = "Actor 5",
                ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg",
                Bio = "This is the bio of the fifth actor"
            }
        });

        modelBuilder.Entity<Producer>().HasData(new List<Producer>()
        {
            new Producer()
            {
                Id = 1,
                FullName = "Producer 1",
                ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg",
                Bio = "This is the bio of the first producer"
            },
            new Producer()
            {
                Id = 2,
                FullName = "Producer 2",
                ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg",
                Bio = "This is the bio of the second producer"
            },
            new Producer()
            {
                Id = 3,
                FullName = "Producer 3",
                ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg",
                Bio = "This is the bio of the third producer"
            },
            new Producer()
            {
                Id = 4,
                FullName = "Producer 4",
                ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg",
                Bio = "This is the bio of the fourth producer"
            },
            new Producer()
            {
                Id = 5,
                FullName = "Producer 5",
                ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg",
                Bio = "This is the bio of the fifth producer"
            }
        });

        modelBuilder.Entity<Movie>().HasData(new List<Movie>()
        {
            new Movie()
            {
                Id = 1,
                Name = "The Shawshank Redemption",
                Description = "This is the Shawshank Redemption description",
                Price = 39.99,
                ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                StartDate = DateTime.Now.AddDays(-10),
                EndDate = DateTime.Now.AddDays(10),
                CinemaId = 1,
                ProducerId = 1,
                Category = Category.Action
            },
            new Movie()
            {
                Id = 2,
                Name = "No Country for Old Men",
                Description = "This is the No Country For Old Men description",
                Price = 29.99,
                ImageURL = "http://dotnethow.net/images/movies/movie-2.jpeg",
                StartDate = DateTime.Now.AddDays(-5),
                EndDate = DateTime.Now.AddDays(15),
                CinemaId = 2,
                ProducerId = 2,
                Category = Category.Comedy
            },
            new Movie()
            {
                Id = 3,
                Name = "Life",
                Description = "This is the Life description",
                Price = 19.99,
                ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                StartDate = DateTime.Now.AddDays(-7),
                EndDate = DateTime.Now.AddDays(20),
                CinemaId = 3,
                ProducerId = 3,
                Category = Category.Drama
            },
            new Movie()
            {
                Id = 4,
                Name = "Ghost",
                Description = "This is the Ghost movie description",
                Price = 39.50,
                ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(7),
                CinemaId = 4,
                ProducerId = 4,
                Category = Category.Horror
            },
            new Movie()
            {
                Id = 5,
                Name = "Race",
                Description = "This is the Race movie description",
                Price = 39.50,
                ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                StartDate = DateTime.Now.AddDays(-10),
                EndDate = DateTime.Now.AddDays(-5),
                CinemaId = 1,
                ProducerId = 2,
                Category = Category.Documentary
            },
            new Movie()
            {
                Id = 6,
                Name = "Scoob",
                Description = "This is the Scoob movie description",
                Price = 39.50,
                ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                StartDate = DateTime.Now.AddDays(-10),
                EndDate = DateTime.Now.AddDays(-2),
                CinemaId = 1,
                ProducerId = 3,
                Category = Category.Cartoon
            },
            new Movie()
            {
                Id = 7,
                Name = "Cold Soles",
                Description = "This is the Cold Soles movie description",
                Price = 39.50,
                ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                StartDate = DateTime.Now.AddDays(3),
                EndDate = DateTime.Now.AddDays(20),
                CinemaId = 1,
                ProducerId = 5,
                Category = Category.Drama
            }
        });

        modelBuilder.Entity<ActorMovie>().HasData(new List<ActorMovie>()
        {
            new ActorMovie()
            {
                ActorId = 1,
                MovieId = 1
            },
            new ActorMovie()
            {
                ActorId = 2,
                MovieId = 1
            },
            new ActorMovie()
            {
                ActorId = 3,
                MovieId = 2
            },
            new ActorMovie()
            {
                ActorId = 4,
                MovieId = 3
            },
            new ActorMovie()
            {
                ActorId = 5,
                MovieId = 4
            },
            new ActorMovie()
            {
                ActorId = 1,
                MovieId = 5
            },
            new ActorMovie()
            {
                ActorId = 2,
                MovieId = 6
            },
            new ActorMovie()
            {
                ActorId = 3,
                MovieId = 6
            },
            new ActorMovie()
            {
                ActorId = 3,
                MovieId = 7
            },
            new ActorMovie()
            {
                ActorId = 4,
                MovieId = 7
            },
            new ActorMovie()
            {
                ActorId = 5,
                MovieId = 7
            }
        });
    }
}
