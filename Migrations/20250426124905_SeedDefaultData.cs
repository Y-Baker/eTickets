using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eTickets.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "This is the bio of the first actor", "Actor 1", "http://dotnethow.net/images/actors/actor-1.jpeg" },
                    { 2, "This is the bio of the second actor", "Actor 2", "http://dotnethow.net/images/actors/actor-2.jpeg" },
                    { 3, "This is the bio of the third actor", "Actor 3", "http://dotnethow.net/images/actors/actor-3.jpeg" },
                    { 4, "This is the bio of the fourth actor", "Actor 4", "http://dotnethow.net/images/actors/actor-4.jpeg" },
                    { 5, "This is the bio of the fifth actor", "Actor 5", "http://dotnethow.net/images/actors/actor-5.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Description", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, "This is the description of the first cinema", "http://dotnethow.net/images/cinemas/cinema-1.jpeg", "Cinema 1" },
                    { 2, "This is the description of the second cinema", "http://dotnethow.net/images/cinemas/cinema-2.jpeg", "Cinema 2" },
                    { 3, "This is the description of the third cinema", "http://dotnethow.net/images/cinemas/cinema-3.jpeg", "Cinema 3" },
                    { 4, "This is the description of the fourth cinema", "http://dotnethow.net/images/cinemas/cinema-4.jpeg", "Cinema 4" },
                    { 5, "This is the description of the fifth cinema", "http://dotnethow.net/images/cinemas/cinema-5.jpeg", "Cinema 5" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Bio", "FullName", "ProfilePictureURL" },
                values: new object[,]
                {
                    { 1, "This is the bio of the first producer", "Producer 1", "http://dotnethow.net/images/producers/producer-1.jpeg" },
                    { 2, "This is the bio of the second producer", "Producer 2", "http://dotnethow.net/images/producers/producer-2.jpeg" },
                    { 3, "This is the bio of the third producer", "Producer 3", "http://dotnethow.net/images/producers/producer-3.jpeg" },
                    { 4, "This is the bio of the fourth producer", "Producer 4", "http://dotnethow.net/images/producers/producer-4.jpeg" },
                    { 5, "This is the bio of the fifth producer", "Producer 5", "http://dotnethow.net/images/producers/producer-5.jpeg" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Category", "CinemaId", "Description", "EndDate", "ImageURL", "Name", "Price", "ProducerId", "StartDate" },
                values: new object[,]
                {
                    { 1, 0, 1, "This is the Shawshank Redemption description", new DateTime(2025, 5, 6, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7505), "http://dotnethow.net/images/movies/movie-1.jpeg", "The Shawshank Redemption", 39.990000000000002, 1, new DateTime(2025, 4, 16, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7500) },
                    { 2, 1, 2, "This is the No Country For Old Men description", new DateTime(2025, 5, 11, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7516), "http://dotnethow.net/images/movies/movie-2.jpeg", "No Country for Old Men", 29.989999999999998, 2, new DateTime(2025, 4, 21, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7514) },
                    { 3, 2, 3, "This is the Life description", new DateTime(2025, 5, 16, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7524), "http://dotnethow.net/images/movies/movie-3.jpeg", "Life", 19.989999999999998, 3, new DateTime(2025, 4, 19, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7522) },
                    { 4, 5, 4, "This is the Ghost movie description", new DateTime(2025, 5, 3, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7532), "http://dotnethow.net/images/movies/movie-4.jpeg", "Ghost", 39.5, 4, new DateTime(2025, 4, 26, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7530) },
                    { 5, 3, 1, "This is the Race movie description", new DateTime(2025, 4, 21, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7539), "http://dotnethow.net/images/movies/movie-6.jpeg", "Race", 39.5, 2, new DateTime(2025, 4, 16, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7537) },
                    { 6, 7, 1, "This is the Scoob movie description", new DateTime(2025, 4, 24, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7547), "http://dotnethow.net/images/movies/movie-7.jpeg", "Scoob", 39.5, 3, new DateTime(2025, 4, 16, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7545) },
                    { 7, 2, 1, "This is the Cold Soles movie description", new DateTime(2025, 5, 16, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7555), "http://dotnethow.net/images/movies/movie-8.jpeg", "Cold Soles", 39.5, 5, new DateTime(2025, 4, 29, 15, 49, 4, 305, DateTimeKind.Local).AddTicks(7553) }
                });

            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 6 },
                    { 3, 7 },
                    { 4, 7 },
                    { 5, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
