using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApplication.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfDeath = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    DirectorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfDeath = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.DirectorId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kind = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photos_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    ProductionYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Watched = table.Column<bool>(type: "bit", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "DirectorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovies",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovies", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_ActorMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Country", "DateOfBirth", "DateOfDeath", "Email", "FirstName", "LastName", "PhotoUrl", "Salary", "Telephone" },
                values: new object[,]
                {
                    { 1, 186, new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LeonardoDiCaprio@gmail.com", "Leonardo", "DiCaprio", "https://m.media-amazon.com/images/M/MV5BMjI0MTg3MzI0M15BMl5BanBnXkFtZTcwMzQyODU2Mw@@._V1_UY317_CR10,0,214,317_AL_.jpg", 50000000.0, "691-52-13-212" },
                    { 2, 185, new DateTime(1975, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "KateWinslet@gmail.com", "Kate", "Winslet", "https://m.media-amazon.com/images/M/MV5BODgzMzM2NTE0Ml5BMl5BanBnXkFtZTcwMTcyMTkyOQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", 45000000.0, "694-56-54-653" },
                    { 3, 186, new DateTime(1966, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BillyZane@gmail.com", "Billy", "Zane", "https://m.media-amazon.com/images/M/MV5BMTI5NzA2NTE0NF5BMl5BanBnXkFtZTcwNzAxMTUxMw@@._V1_UY317_CR15,0,214,317_AL_.jpg", 40000000.0, "694-56-45-644" },
                    { 4, 186, new DateTime(1963, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BradPitt@gmail.com", "Brad", "Pitt", "https://m.media-amazon.com/images/M/MV5BMjA1MjE2MTQ2MV5BMl5BanBnXkFtZTcwMjE5MDY0Nw@@._V1_UX214_CR0,0,214,317_AL_.jpg", 30000000.0, "695-34-54-656" },
                    { 5, 8, new DateTime(1990, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MargotRobbie@gmail.com", "Margot", "Robbie", "https://m.media-amazon.com/images/M/MV5BMTgxNDcwMzU2Nl5BMl5BanBnXkFtZTcwNDc4NzkzOQ@@._V1_UY317_CR12,0,214,317_AL_.jpg", 20000000.0, "696-34-34-456" },
                    { 6, 186, new DateTime(1981, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "JosephGordonLevitt@gmail.com", "Joseph", "Gordon-Levitt", "https://m.media-amazon.com/images/M/MV5BZTk5ZGQ0OGQtYWYwMy00ZTE1LWE0NWUtMTQ2MmYxMWUxZWM3XkEyXkFqcGdeQXVyMjAyNzk2Nw@@._V1_UY317_CR6,0,214,317_AL_.jpg", 50000000.0, "694-54-54-856" },
                    { 7, 32, new DateTime(1987, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EllenPage@gmail.com", "Ellen", "Page", "https://m.media-amazon.com/images/M/MV5BMTU3MzM3MDYzMV5BMl5BanBnXkFtZTcwNzk1Mzc3NA@@._V1_UX214_CR0,0,214,317_AL_.jpg", 10000000.0, "691-23-54-456" },
                    { 8, 185, new DateTime(1976, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SamWorthington@gmail.com", "Sam", "Worthington", "https://m.media-amazon.com/images/M/MV5BMTc5NTMyMjIwMV5BMl5BanBnXkFtZTcwNTMyNjYwMw@@._V1_UY317_CR6,0,214,317_AL_.jpg", 500000.0, "693-46-36-75" },
                    { 9, 186, new DateTime(1978, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ZoeSaldana@gmail.com", "Zoe", "Saldana", "https://m.media-amazon.com/images/M/MV5BMTM2MjIwOTc0Nl5BMl5BanBnXkFtZTcwNzQ5ODM1Mw@@._V1_UX214_CR0,0,214,317_AL_.jpg", 50000000.0, "691-46-36-257" },
                    { 10, 186, new DateTime(1949, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SigourneyWeaver@gmail.com", "Sigourney", "Weaver", "https://m.media-amazon.com/images/M/MV5BMTk1MTcyNTE3OV5BMl5BanBnXkFtZTcwMTA0MTMyMw@@._V1_UY317_CR12,0,214,317_AL_.jpg", 4000000.0, "694-64-34-456" },
                    { 11, 186, new DateTime(1950, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EdHarris@gmail.com", "Ed", "Harris", "", 400000.0, "695-21-65-652" },
                    { 12, 186, new DateTime(1956, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MichaelBiehn@gmail.com", "Michael", "Biehn", "", 500000.0, "695-21-65-344" },
                    { 13, 186, new DateTime(1958, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mastrantonio@gmail.com", "Mary", "Mastrantonio", "", 456000.0, "699-54-37-757" },
                    { 14, 185, new DateTime(1930, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Connery@gmail.com", "Sean", "Connery", "https://m.media-amazon.com/images/M/MV5BMzcwNTM4MzctYjQzMi00NTA2LTljYWItNTYzNmE1MTYxN2RlXkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UY317_CR16,0,214,317_AL_.jpg", 356000.0, "695-56-26-122" },
                    { 15, 186, new DateTime(1964, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cage@gmail.com", "Nicolas", "Cage", "https://m.media-amazon.com/images/M/MV5BMjUxMjE4MTQxMF5BMl5BanBnXkFtZTcwNzc2MDM1NA@@._V1_UY317_CR9,0,214,317_AL_.jpg", 2565000.0, "695-56-26-123" },
                    { 16, 186, new DateTime(1969, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Slater@gmail.com", "Christian", "Slater", "https://m.media-amazon.com/images/M/MV5BMTY5ODA1ODY2Nl5BMl5BanBnXkFtZTgwNjcwNDczNzE@._V1_UX214_CR0,0,214,317_AL_.jpg", 256000.0, "695-56-26-123" },
                    { 17, 9, new DateTime(1928, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qualtinger@gmail.com", "Helmut", "Qualtinger", "https://m.media-amazon.com/images/M/MV5BZGY5ZDI4YzEtYmViOS00YmY4LTk2OWQtN2I5OGU0NTdhNDk5XkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_UY317_CR162,0,214,317_AL_.jpg", 2346000.0, "695-56-16-123" },
                    { 18, 186, new DateTime(1991, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Woodley@gmail.com", "Shailene", "Woodley", "https://m.media-amazon.com/images/M/MV5BOTIxNTE2NTQ3Nl5BMl5BanBnXkFtZTcwMzMwOTk2Nw@@._V1_UX214_CR0,0,214,317_AL_.jpg", 146000.0, "695-56-16-432" },
                    { 19, 186, new DateTime(1960, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MelissaLeo@gmail.com", "Melissa", "Leo", "https://m.media-amazon.com/images/M/MV5BMTc3MDAxOTkyOF5BMl5BanBnXkFtZTcwOTg1MDIzNA@@._V1_UY317_CR8,0,214,317_AL_.jpg", 4567000.0, "695-43-16-432" },
                    { 20, 186, new DateTime(1950, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Perlman@gmail.com", "Ron", "Perlman", "https://m.media-amazon.com/images/M/MV5BMTY0NzAzMTEyOV5BMl5BanBnXkFtZTcwNjYwMzYwNg@@._V1_UY317_CR2,0,214,317_AL_.jpg", 336700.0, "695-43-54-432" },
                    { 21, 185, new DateTime(1984, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Foy@gmail.com", "Claire", "Foy", "https://m.media-amazon.com/images/M/MV5BNTI5OTMwNzM4NV5BMl5BanBnXkFtZTcwNDY1NjkyNA@@._V1_UY317_CR7,0,214,317_AL_.jpg", 6736000.0, "695-43-54-654" },
                    { 22, 186, new DateTime(1932, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Burstyn@gmail.com", "Ellen", "Burstyn", "https://m.media-amazon.com/images/M/MV5BMTU4MjYxMDc3MF5BMl5BanBnXkFtZTYwNzU3MDIz._V1_UX214_CR0,0,214,317_AL_.jpg", 367000.0, "695-53-54-654" },
                    { 23, 186, new DateTime(1983, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sobieski@gmail.com", "Leelee", "Sobieski", "https://m.media-amazon.com/images/M/MV5BMTI4NDc0MzMzMV5BMl5BanBnXkFtZTYwOTc3Mjk2._V1_UY317_CR12,0,214,317_AL_.jpg", 357000.0, "695-53-64-654" },
                    { 24, 164, new DateTime(1974, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Cruz@gmail.com", "Penélope", "Cruz", "https://m.media-amazon.com/images/M/MV5BMTM0Mzc1MTc2OF5BMl5BanBnXkFtZTcwMzE4MzQxMw@@._V1_UX214_CR0,0,214,317_AL_.jpg", 2757000.0, "695-53-64-544" },
                    { 25, 185, new DateTime(1940, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hurt@gmail.com", "John", "Hurt", "https://m.media-amazon.com/images/M/MV5BMTM1NTgyMTAyOV5BMl5BanBnXkFtZTcwMTE4MjQwNA@@._V1_UY317_CR5,0,214,317_AL_.jpg", 7525000.0, "695-53-64-543" },
                    { 26, 186, new DateTime(1963, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Depp@gmail.com", "Johnny", "Depp", "https://m.media-amazon.com/images/M/MV5BMTM0ODU5Nzk2OV5BMl5BanBnXkFtZTcwMzI2ODgyNQ@@._V1_UY317_CR4,0,214,317_AL_.jpg", 756000.0, "695-23-64-543" },
                    { 27, 185, new DateTime(1942, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "McShane@gmail.com", "Ian", "McShane", "https://m.media-amazon.com/images/M/MV5BNDZjYzFjNWYtOTA2Yy00MjY5LWI4OGQtM2RlNDU5ZTlhMjU0XkEyXkFqcGdeQXVyNzE0OTI2MzY@._V1_UY317_CR12,0,214,317_AL_.jpg", 7525000.0, "699-23-64-543" },
                    { 28, 185, new DateTime(1982, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Redmayne@gmail.com", "Eddie", "Redmayne", "https://m.media-amazon.com/images/M/MV5BMTU0MjEyNzQyM15BMl5BanBnXkFtZTcwMTc4ODUxOQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", 756000.0, "699-35-64-543" },
                    { 29, 185, new DateTime(1980, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Waterston@gmail.com", "Katherine", "Waterston", "https://m.media-amazon.com/images/M/MV5BMTczMTI1MjQzN15BMl5BanBnXkFtZTgwNjY2ODY2NDE@._V1_UY317_CR194,0,214,317_AL_.jpg", 2576000.0, "699-35-67-543" },
                    { 30, 186, new DateTime(1984, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sudol@gmail.com", "Alison", "Sudol", "https://m.media-amazon.com/images/M/MV5BMTY5NTg4MDI3M15BMl5BanBnXkFtZTgwNzM2Mzc1MDI@._V1_UX214_CR0,0,214,317_AL_.jpg", 565000.0, "699-35-67-345" },
                    { 31, 186, new DateTime(1985, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kendrick@gmail.com", "Anna", "Kendrick", "https://m.media-amazon.com/images/M/MV5BMjIzOTA0OTQyN15BMl5BanBnXkFtZTcwMjE1OTIwMw@@._V1_UY317_CR5,0,214,317_AL_.jpg", 5456000.0, "699-35-56-256" },
                    { 32, 186, new DateTime(1949, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Streep@gmail.com", "Meryl", "Streep", "https://m.media-amazon.com/images/M/MV5BMTU4Mjk5MDExOF5BMl5BanBnXkFtZTcwOTU1MTMyMw@@._V1_UY317_CR6,0,214,317_AL_.jpg", 756000.0, "699-65-56-256" },
                    { 33, 186, new DateTime(1980, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Pine@gmail.com", "Chris", "Pine", "https://m.media-amazon.com/images/M/MV5BMTM4OTQ4NTU3NV5BMl5BanBnXkFtZTcwNjEwNDU0OQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", 5645000.0, "699-65-56-456" },
                    { 34, 186, new DateTime(1978, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Long@gmail.com", "Justin", "Long", "https://m.media-amazon.com/images/M/MV5BMjIwNTEwODY4NF5BMl5BanBnXkFtZTgwMzg0ODMwMjE@._V1_UY317_CR15,0,214,317_AL_.jpg", 257000.0, "699-65-56-246" },
                    { 35, 186, new DateTime(1940, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parks@gmail.com", "Michael", "Parks", "https://m.media-amazon.com/images/M/MV5BMTc1NDM3NjU5NV5BMl5BanBnXkFtZTcwNDEzNTcyNA@@._V1_UX214_CR0,0,214,317_AL_.jpg", 478000.0, "699-65-46-246" },
                    { 36, 186, new DateTime(1988, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Osment@gmail.com", "Haley Joel", "Osment", "https://m.media-amazon.com/images/M/MV5BZjY0MjRhNjEtNGVlYi00YzZhLWFhNDEtMjlhNjBiNzM3Y2RkXkEyXkFqcGdeQXVyMjQxMDQzMjA@._V1_UY317_CR104,0,214,317_AL_.jpg", 874000.0, "699-65-22-246" },
                    { 37, 186, new DateTime(1975, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jolie@gmail.com", "Angelina", "Jolie", "https://m.media-amazon.com/images/M/MV5BODg3MzYwMjE4N15BMl5BanBnXkFtZTcwMjU5NzAzNw@@._V1_UY317_CR22,0,214,317_AL_.jpg", 678000.0, "699-65-11-246" },
                    { 38, 185, new DateTime(1971, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bettany@gmail.com", "Paul", "Bettany", "https://m.media-amazon.com/images/M/MV5BNjUzMDIzNjkxMl5BMl5BanBnXkFtZTgwNjgyNzA0MjI@._V1_UY317_CR131,0,214,317_AL_.jpg", 876000.0, "699-65-11-222" },
                    { 39, 185, new DateTime(1966, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Carter@gmail.com", "Helena Bonham", "Carter", "https://m.media-amazon.com/images/M/MV5BMTUzMzUzMDg5MV5BMl5BanBnXkFtZTcwMDA5NDMwNA@@._V1_UY317_CR4,0,214,317_AL_.jpg", 335000.0, "699-65-11-223" },
                    { 40, 185, new DateTime(1946, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2016, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rickman@gmail.com", "Alan", "Rickman", "https://m.media-amazon.com/images/M/MV5BMTUwNTc4MTg4Ml5BMl5BanBnXkFtZTcwNDY2MjkxOA@@._V1_UY317_CR10,0,214,317_AL_.jpg", 753000.0, "697-65-11-223" },
                    { 41, 186, new DateTime(1971, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ryder@gmail.com", "Winona", "Ryder", "https://m.media-amazon.com/images/M/MV5BMTQ3NzM3MTc2NF5BMl5BanBnXkFtZTcwODMxNjA0NA@@._V1_UY317_CR9,0,214,317_AL_.jpg", 4676000.0, "697-65-11-224" },
                    { 42, 186, new DateTime(1948, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Wiest@gmail.com", "Dianne", "Wiest", "https://m.media-amazon.com/images/M/MV5BMTM1NjM4MTUwN15BMl5BanBnXkFtZTcwOTU0MTUyMw@@._V1_UY317_CR7,0,214,317_AL_.jpg", 356000.0, "697-65-11-225" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Country", "DateOfBirth", "DateOfDeath", "Email", "FirstName", "LastName", "PhotoUrl", "Salary", "Telephone" },
                values: new object[,]
                {
                    { 43, 186, new DateTime(1998, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fanning@gmail.com", "Elle", "Fanning", "https://m.media-amazon.com/images/M/MV5BN2I3N2UwMzQtNjhlYy00NmEwLTgwMDgtNmY5MzNlOGE4NDQxXkEyXkFqcGdeQXVyNDIzOTc1MDY@._V1_UY317_CR131,0,214,317_AL_.jpg", 764000.0, "699-54-37-888" },
                    { 44, 161, new DateTime(1973, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Copley@gmail.com", "Sharlto", "Copley", "https://m.media-amazon.com/images/M/MV5BY2Q5ZDlmYmMtYTdhMy00MDIzLTkyNmUtMTM0MzU3YmI4NTIxXkEyXkFqcGdeQXVyNTU5ODEyOTE@._V1_UX214_CR0,0,214,317_AL_.jpg", 764000.0, "697-24-25-266" },
                    { 45, 186, new DateTime(1977, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DuVall@gmail.com", "Clea", "DuVall", "https://m.media-amazon.com/images/M/MV5BMjU0NDc3MTM4NV5BMl5BanBnXkFtZTcwMjY4Mzc1OA@@._V1_UY317_CR1,0,214,317_AL_.jpg", 1256000.0, "697-24-25-263" },
                    { 46, 186, new DateTime(1958, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Feore@gmail.com", "Colm", "Feore", "https://m.media-amazon.com/images/M/MV5BMTY2MDYzNjA2MF5BMl5BanBnXkFtZTYwMzQxMjE2._V1_UX214_CR0,0,214,317_AL_.jpg", 1565000.0, "697-24-25-264" },
                    { 47, 186, new DateTime(1968, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ryan@gmail.com", "Amy", "Ryan", "https://m.media-amazon.com/images/M/MV5BMTY0MTcwMzM0Nl5BMl5BanBnXkFtZTcwODIyMjM3NA@@._V1_UY317_CR3,0,214,317_AL_.jpg", 1456000.0, "697-24-25-265" },
                    { 48, 186, new DateTime(1967, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Schreiber@gmail.com", "Liev", "Schreiber", "https://m.media-amazon.com/images/M/MV5BMjM5NjI1NzA1Ml5BMl5BanBnXkFtZTgwNDc0ODM3ODE@._V1_UY317_CR14,0,214,317_AL_.jpg", 1567000.0, "697-24-25-365" },
                    { 49, 185, new DateTime(1977, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ejiofor@gmail.com", "Chiwetel", "Ejiofor", "https://m.media-amazon.com/images/M/MV5BNzA5MDEyMTY3Nl5BMl5BanBnXkFtZTgwODQ0MjcxMDE@._V1_UY317_CR6,0,214,317_AL_.jpg", 1678000.0, "697-24-35-365" },
                    { 50, 8, new DateTime(1968, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jackman@gmail.com", "Hugh", "Jackman", "https://m.media-amazon.com/images/M/MV5BNDExMzIzNjk3Nl5BMl5BanBnXkFtZTcwOTE4NDU5OA@@._V1_UX214_CR0,0,214,317_AL_.jpg", 1367000.0, "697-24-34-365" },
                    { 51, 123, new DateTime(1964, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Crowe@gmail.com", "Russell", "Crowe", "https://m.media-amazon.com/images/M/MV5BMTQyMTExNTMxOF5BMl5BanBnXkFtZTcwNDg1NzkzNw@@._V1_UX214_CR0,0,214,317_AL_.jpg", 1783000.0, "697-24-35-365" },
                    { 52, 186, new DateTime(1982, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hathaway@gmail.com", "Anne", "Hathaway", "https://m.media-amazon.com/images/M/MV5BNjQ5MTAxMDc5OF5BMl5BanBnXkFtZTcwOTI0OTE4OA@@._V1_UY317_CR1,0,214,317_AL_.jpg", 1873000.0, "697-24-36-365" },
                    { 53, 168, new DateTime(1988, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Vikander@gmail.com", "Alicia,", "Vikander", "https://m.media-amazon.com/images/M/MV5BZmMxYzk1OWEtMjE0MC00NTRlLTgwNTEtMGQ1YjA1Yzg1Nzc3XkEyXkFqcGdeQXVyMjQwMDg0Ng@@._V1_UY317_CR3,0,214,317_AL_.jpg", 3578000.0, "697-24-37-365" },
                    { 54, 186, new DateTime(1986, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Heard@gmail.com", "Amber", "Heard", "https://m.media-amazon.com/images/M/MV5BMjA4NDkyODA3M15BMl5BanBnXkFtZTgwMzUzMjYzNzM@._V1_UY317_CR51,0,214,317_AL_.jpg", 3785000.0, "697-34-37-365" },
                    { 55, 185, new DateTime(1958, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jones@gmail.com", "Felicity", "Jones", "https://m.media-amazon.com/images/M/MV5BMjA0MTIwMzIyN15BMl5BanBnXkFtZTgwNDEyMzg1NDE@._V1_UX214_CR0,0,214,317_AL_.jpg", 1343000.0, "697-44-37-365" },
                    { 56, 185, new DateTime(1990, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Prior@gmail.com", "Tom", "Prior", "https://m.media-amazon.com/images/M/MV5BMjIwMjQzNDUzN15BMl5BanBnXkFtZTgwNzI1MDU4MDE@._V1_UX214_CR0,0,214,317_AL_.jpg", 3655000.0, "697-54-37-365" },
                    { 57, 186, new DateTime(1924, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brando@gmail.com", "Marlon", "Brando", "https://m.media-amazon.com/images/M/MV5BMTg3MDYyMDE5OF5BMl5BanBnXkFtZTcwNjgyNTEzNA@@._V1_UY317_CR97,0,214,317_AL_.jpg", 3565000.0, "697-64-37-365" },
                    { 58, 186, new DateTime(1912, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malden@gmail.com", "Karl", "Malden", "https://m.media-amazon.com/images/M/MV5BMTM1MjY3Njk5Ml5BMl5BanBnXkFtZTYwNTYwMzI2._V1_UX214_CR0,0,214,317_AL_.jpg", 3545000.0, "699-64-37-365" },
                    { 59, 186, new DateTime(1911, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cobb@gmail.com", "Lee J", "Cobb", "https://m.media-amazon.com/images/M/MV5BNDc3MTM0MDQyMF5BMl5BanBnXkFtZTYwMTczMTg2._V1_UX214_CR0,0,214,317_AL_.jpg", 5645000.0, "699-24-37-365" },
                    { 60, 186, new DateTime(1931, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1955, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dean@gmail.com", "James", "Dean", "https://m.media-amazon.com/images/M/MV5BMTg5NTgzMTkzNl5BMl5BanBnXkFtZTYwMTQwNjI2._V1_UX214_CR0,0,214,317_AL_.jpg", 6542000.0, "699-34-37-365" },
                    { 61, 32, new DateTime(1896, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1983, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Massey@gmail.com", "Raymond", "Massey", "https://m.media-amazon.com/images/M/MV5BMTg3ODY2MzkyMF5BMl5BanBnXkFtZTcwMjc2NTg2OA@@._V1_UY317_CR20,0,214,317_AL_.jpg", 6545000.0, "699-44-37-365" },
                    { 62, 186, new DateTime(1925, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harris@gmail.com", "Julie", "Harris", "https://m.media-amazon.com/images/M/MV5BMTkzODM1MjUwOV5BMl5BanBnXkFtZTcwMDY4NDgwMw@@._V1_UY317_CR11,0,214,317_AL_.jpg", 6547000.0, "699-54-37-365" },
                    { 63, 186, new DateTime(1938, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wood@gmail.com", "Natalie", "Wood", "https://m.media-amazon.com/images/M/MV5BMTI3NjM5OTgxNF5BMl5BanBnXkFtZTYwOTg4NTM2._V1_UY317_CR2,0,214,317_AL_.jpg", 3678000.0, "699-54-37-222" },
                    { 64, 186, new DateTime(1939, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1976, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mineo@gmail.com", "Sal", "Mineo", "https://m.media-amazon.com/images/M/MV5BMTI2Nzc2NTUxOF5BMl5BanBnXkFtZTcwNjU2ODAyMw@@._V1_UY317_CR15,0,214,317_AL_.jpg", 654000.0, "699-54-37-333" },
                    { 65, 16, new DateTime(1929, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hepburn@gmail.com", "Audrey", "Hepburn", "https://m.media-amazon.com/images/M/MV5BMTM4MTY3NTQyMF5BMl5BanBnXkFtZTYwMTk2MzQ2._V1_UX214_CR0,0,214,317_AL_.jpg", 535000.0, "699-54-37-334" },
                    { 66, 186, new DateTime(1928, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peppard@gmail.com", "George", "Peppard", "https://m.media-amazon.com/images/M/MV5BMTY1OTczNDE2NF5BMl5BanBnXkFtZTcwMTY5Mzg3Mw@@._V1_UX214_CR0,0,214,317_AL_.jpg", 7654000.0, "699-54-37-335" },
                    { 67, 186, new DateTime(1926, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neal@gmail.com", "Patricia", "Neal", "https://m.media-amazon.com/images/M/MV5BMTgzMjk3OTkwN15BMl5BanBnXkFtZTYwMDM5NDM2._V1_UY317_CR19,0,214,317_AL_.jpg", 7652000.0, "699-54-37-336" },
                    { 68, 185, new DateTime(1904, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grant@gmail.com", "Cary", "Grant", "https://m.media-amazon.com/images/M/MV5BNzYyODM4NDU1MV5BMl5BanBnXkFtZTYwMjI1ODM2._V1_UY317_CR16,0,214,317_AL_.jpg", 3578000.0, "699-54-37-337" },
                    { 69, 186, new DateTime(1920, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthau@gmail.com", "Walter", "Matthau", "https://m.media-amazon.com/images/M/MV5BMTU1NjYzOTc0NV5BMl5BanBnXkFtZTYwMjAxNDQ2._V1_UY317_CR11,0,214,317_AL_.jpg", 3675000.0, "699-54-37-388" },
                    { 70, 185, new DateTime(1925, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sellers@gmail.com", "Peter", "Sellers", "https://m.media-amazon.com/images/M/MV5BMTI0MjE1MjczMF5BMl5BanBnXkFtZTYwMDIxNTQ2._V1_UY317_CR23,0,214,317_AL_.jpg", 3567000.0, "699-54-37-389" },
                    { 71, 186, new DateTime(1958, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1934, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "MacLaine@gmail.com", "Shirley", "MacLaine", "https://m.media-amazon.com/images/M/MV5BMTI0MTE5MjQ1MF5BMl5BanBnXkFtZTYwMzU2MDg1._V1_UY317_CR2,0,214,317_AL_.jpg", 4567000.0, "699-54-37-244" },
                    { 72, 186, new DateTime(1901, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1981, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas@gmail.com", "Melvyn", "Douglas", "https://m.media-amazon.com/images/M/MV5BMjA5MDMxMDAxMV5BMl5BanBnXkFtZTYwODg1NDQ2._V1_UY317_CR16,0,214,317_AL_.jpg", 1575000.0, "699-54-37-555" },
                    { 73, 9, new DateTime(1917, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lom@gmail.com", "Herbert", "Lom", "https://m.media-amazon.com/images/M/MV5BNzg5OTc0OTA3Ml5BMl5BanBnXkFtZTcwOTIyOTYyMQ@@._V1_UY317_CR14,0,214,317_AL_.jpg", 515000.0, "699-54-37-523" },
                    { 74, 185, new DateTime(1954, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Down@gmail.com", "Lesley-Anne", "Down", "https://m.media-amazon.com/images/M/MV5BMjEzODY2NTE1OF5BMl5BanBnXkFtZTYwOTAxOTk0._V1_UY317_CR32,0,214,317_AL_.jpg", 257000.0, "699-54-37-524" },
                    { 75, 9, new DateTime(1938, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schneider@gmail.com", "Romy", "Schneider", "https://m.media-amazon.com/images/M/MV5BMTg4NDI2NzA3OF5BMl5BanBnXkFtZTcwNDM1OTQyOA@@._V1_UY317_CR20,0,214,317_AL_.jpg", 345000.0, "699-54-37-525" },
                    { 76, 64, new DateTime(1928, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2014, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bohm@gmail.com", "Karlheinz", "Böhm", "https://m.media-amazon.com/images/M/MV5BNTA4NGJmYWUtMWI4ZS00NGNlLWE0NmUtN2U3MmRiZTUwODA5XkEyXkFqcGdeQXVyMzI5NDcxNzI@._V1_UY317_CR4,0,214,317_AL_.jpg", 457000.0, "699-54-37-526" },
                    { 77, 64, new DateTime(1909, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schneider@gmail.com", "Magda", "Schneider", "https://m.media-amazon.com/images/M/MV5BZWI5ZDM4ZWItMmRiNy00ZWIwLWIxOWEtMGVmNDM2ZmVhYTJlXkEyXkFqcGdeQXVyNTk5NzQ5Ng@@._V1_UY317_CR24,0,214,317_AL_.jpg", 742000.0, "699-54-37-527" },
                    { 78, 32, new DateTime(1926, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nielsen@gmail.com", "Leslie", "Nielsen", "https://m.media-amazon.com/images/M/MV5BMTI3MTE1NjM4N15BMl5BanBnXkFtZTYwNzI3MTI0._V1_UX214_CR0,0,214,317_AL_.jpg", 542000.0, "699-54-37-528" },
                    { 79, 186, new DateTime(1945, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Presley@gmail.com", "Priscilla", "Presley", "https://m.media-amazon.com/images/M/MV5BMTY5MDkzOTU1NV5BMl5BanBnXkFtZTcwNTIxNzAyMg@@._V1_UY317_CR4,0,214,317_AL_.jpg", 865000.0, "699-54-37-529" },
                    { 80, 186, new DateTime(1947, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Simpson@gmail.com", "O.J.", "Simpson", "https://m.media-amazon.com/images/M/MV5BMjE5NTYzNTg2N15BMl5BanBnXkFtZTcwMzEwMTAxMw@@._V1_UY317_CR10,0,214,317_AL_.jpg", 8654000.0, "699-54-37-530" },
                    { 81, 186, new DateTime(1972, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mathers@gmail.com", "Eminem", "Mathers", "https://m.media-amazon.com/images/M/MV5BMjI0MDAxMDYwOV5BMl5BanBnXkFtZTcwMTQ1MjE2Mw@@._V1_UY317_CR10,0,214,317_AL_.jpg", 654000.0, "699-54-37-532" },
                    { 82, 186, new DateTime(1977, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2009, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Murphy@gmail.com", "Brittany", "Murphy", "https://m.media-amazon.com/images/M/MV5BMTc4MjM0MzMwNl5BMl5BanBnXkFtZTYwMTU4NDg1._V1_UY317_CR8,0,214,317_AL_.jpg", 876000.0, "699-54-37-666" },
                    { 83, 186, new DateTime(1953, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Basinger@gmail.com", "Kim", "Basinger", "https://m.media-amazon.com/images/M/MV5BMTQyMDkxNjcxNV5BMl5BanBnXkFtZTcwODMyNzgyOA@@._V1_UY317_CR20,0,214,317_AL_.jpg", 856000.0, "699-54-37-667" },
                    { 84, 186, new DateTime(1973, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Walker@gmail.com", "Paul", "Walker", "https://m.media-amazon.com/images/M/MV5BMjIwODc0OTk2Nl5BMl5BanBnXkFtZTcwOTQ5MDA0Mg@@._V1_UX214_CR0,0,214,317_AL_.jpg", 6676000.0, "699-54-37-668" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Country", "DateOfBirth", "DateOfDeath", "Email", "FirstName", "LastName", "PhotoUrl", "Salary", "Telephone" },
                values: new object[,]
                {
                    { 85, 32, new DateTime(1993, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bright@gmail.com", "Cameron", "---", "https://m.media-amazon.com/images/M/MV5BMTk2NjE4NDA3N15BMl5BanBnXkFtZTcwNDE5ODk5Mg@@._V1_UY317_CR7,0,214,317_AL_.jpg", 5676000.0, "699-54-37-669" },
                    { 86, 186, new DateTime(1952, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Palminteri@gmail.com", "Chazz", "Palminteri", "https://m.media-amazon.com/images/M/MV5BMjExNjU4NTUzOV5BMl5BanBnXkFtZTgwMTY3MDMzMTE@._V1_UY317_CR17,0,214,317_AL_.jpg", 545000.0, "699-54-37-700" },
                    { 87, 186, new DateTime(1908, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stewart@gmail.com", "James", "Stewart", "https://m.media-amazon.com/images/M/MV5BMjIwNzMzODY0NV5BMl5BanBnXkFtZTcwMDk3NDQyOA@@._V1_UY317_CR20,0,214,317_AL_.jpg", 765000.0, "699-54-37-702" },
                    { 88, 186, new DateTime(1929, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kelly@gmail.com", "Greys", "Kelly", "https://m.media-amazon.com/images/M/MV5BMTgzNjI4MzY1NF5BMl5BanBnXkFtZTYwMTM4MzQ2._V1_UY317_CR17,0,214,317_AL_.jpg", 7654000.0, "699-54-37-703" },
                    { 89, 186, new DateTime(1914, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1968, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Corey@gmail.com", "Wendell", "Corey", "https://m.media-amazon.com/images/M/MV5BMTgwODk5NjE1MF5BMl5BanBnXkFtZTcwMjY3MDgwOA@@._V1_UY317_CR9,0,214,317_AL_.jpg", 7656000.0, "699-54-37-755" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "DirectorId", "Country", "DateOfBirth", "DateOfDeath", "Email", "FirstName", "LastName", "PhotoUrl" },
                values: new object[,]
                {
                    { 1, 32, new DateTime(1954, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "JamesCameron@gmail.com", "James", "Cameron", "https://m.media-amazon.com/images/M/MV5BMjI0MjMzOTg2MF5BMl5BanBnXkFtZTcwMTM3NjQxMw@@._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 2, 186, new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "QuentinTarantino@gmail.com", "Quentin", "Tarantino", "https://m.media-amazon.com/images/M/MV5BMTgyMjI3ODA3Nl5BMl5BanBnXkFtZTcwNzY2MDYxOQ@@._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 3, 186, new DateTime(1970, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ChristopherNolan@gmail.com", "Christopher", "Nolan", "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_UY317_CR7,0,214,317_AL_.jpg" },
                    { 4, 186, new DateTime(1965, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bay@gmail.com", "Michael", "Bay", "https://m.media-amazon.com/images/M/MV5BMTc2NzcyMDU5NV5BMl5BanBnXkFtZTcwODc1OTM0NA@@._V1_UY317_CR7,0,214,317_AL_.jpg" },
                    { 5, 60, new DateTime(1943, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Annaud@gmail.com", "Jean-Jacques", "Annaud", "https://m.media-amazon.com/images/M/MV5BMTA2OTE0NDk3ODJeQTJeQWpwZ15BbWU3MDUxNzkzMDk@._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 6, 186, new DateTime(1946, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stone@gmail.com", "Oliver", "Stone", "https://m.media-amazon.com/images/M/MV5BMTMwMjExMTY3OV5BMl5BanBnXkFtZTcwNjY3MDA2MQ@@._V1_UY317_CR2,0,214,317_AL_.jpg" },
                    { 7, 186, new DateTime(1949, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sena@gmail.com", "Dominic", "Sena", "https://m.media-amazon.com/images/M/MV5BMjAxMjg4Mzg0Nl5BMl5BanBnXkFtZTcwMDY1NjkyNA@@._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 8, 186, new DateTime(1963, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Annaud@gmail.com", "Neil", "LaBute", "https://m.media-amazon.com/images/M/MV5BOTgxNzI4MDMwNl5BMl5BanBnXkFtZTcwMjExOTA2Nw@@._V1_UY317_CR57,0,214,317_AL_.jpg" },
                    { 9, 186, new DateTime(1949, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Madden@gmail.com", "John", "Madden", "https://m.media-amazon.com/images/M/MV5BMTg2NTg2MTM5N15BMl5BanBnXkFtZTYwOTk5MTc0._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 10, 186, new DateTime(1960, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marshall@gmail.com", "Rob", "Marshall", "https://m.media-amazon.com/images/M/MV5BMTUwMjAxNTE2MF5BMl5BanBnXkFtZTYwMjA0MTQ1._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 11, 185, new DateTime(1963, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yates@gmail.com", "David", "Yates", "https://m.media-amazon.com/images/M/MV5BMTY2NTU4NjY4M15BMl5BanBnXkFtZTYwNjIxOTI1._V1_UY317_CR10,0,214,317_AL_.jpg" },
                    { 12, 186, new DateTime(1970, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Smith@gmail.com", "Kevin", "Smith", "https://m.media-amazon.com/images/M/MV5BMjQ0NzI0ODM2MV5BMl5BanBnXkFtZTgwMjc3Njg4NTM@._V1_UY317_CR2,0,214,317_AL_.jpg" },
                    { 13, 64, new DateTime(1973, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Donnersmarck@gmail.com", "Florian", "Henckel von Donnersmarck", "https://m.media-amazon.com/images/M/MV5BMTI0MTk2NDY5OV5BMl5BanBnXkFtZTcwODY2ODQ1MQ@@._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 14, 186, new DateTime(1958, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Burton@gmail.com", "Tim", "Burton", "https://m.media-amazon.com/images/M/MV5BMTcwNTc4NTMzOF5BMl5BanBnXkFtZTYwMzc5ODYz._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 15, 186, new DateTime(1965, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Stromberg@gmail.com", "Robert", "Stromberg", "https://m.media-amazon.com/images/M/MV5BMTI3NDEzNTE1MV5BMl5BanBnXkFtZTcwMTI2MzMyMw@@._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 16, 186, new DateTime(1963, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mangold@gmail.com", "James", "Mangold", "https://m.media-amazon.com/images/M/MV5BMTg5MjY0ODg1MF5BMl5BanBnXkFtZTYwMjUzMjc0._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 17, 186, new DateTime(1930, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Eastwood@gmail.com", "Clint", "Eastwood", "https://m.media-amazon.com/images/M/MV5BMTg3MDc0MjY0OV5BMl5BanBnXkFtZTcwNzU1MDAxOA@@._V1_UY317_CR10,0,214,317_AL_.jpg" },
                    { 18, 60, new DateTime(1950, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Noyce@gmail.com", "Phillip", "Noyce", "https://m.media-amazon.com/images/M/MV5BMTQ0NDIyNTYzOF5BMl5BanBnXkFtZTcwNTczNDc2Mw@@._V1_UY317_CR18,0,214,317_AL_.jpg" },
                    { 19, 185, new DateTime(1972, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hooper@gmail.com", "Tom", "Hooper", "https://m.media-amazon.com/images/M/MV5BMTMyOTQ5MTE5OV5BMl5BanBnXkFtZTcwNjMxNjA0NA@@._V1_UY317_CR7,0,214,317_AL_.jpg" },
                    { 20, 185, new DateTime(1963, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Marsh@gmail.com", "James", "Marsh", "https://m.media-amazon.com/images/M/MV5BMTg0NTE1NTY3Ml5BMl5BanBnXkFtZTcwMDc1NjYzNA@@._V1_UX214_CR0,0,214,317_AL_.jpg" },
                    { 21, 66, new DateTime(1909, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kazan@gmail.com", "Elia", "Kazan", "https://m.media-amazon.com/images/M/MV5BMjI0OTg0NTk0N15BMl5BanBnXkFtZTgwMTQyOTE3MDI@._V1_UY317_CR52,0,214,317_AL_.jpg" },
                    { 22, 186, new DateTime(1911, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ray@gmail.com", "Nicholas", "Ray", "https://m.media-amazon.com/images/M/MV5BZWQ3ZmZlMWUtOTdhZS00Mzk4LTk0YjEtYzM4MWNmNmMyNjY2XkEyXkFqcGdeQXVyMjUxODE0MDY@._V1_UY317_CR19,0,214,317_AL_.jpg" },
                    { 23, 186, new DateTime(1922, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edwards@gmail.com", "Blake", "Edwards", "https://m.media-amazon.com/images/M/MV5BMTUwMjAzNDc0NF5BMl5BanBnXkFtZTYwNzM0NDU2._V1_UY317_CR0,0,214,317_AL_.jpg" },
                    { 24, 186, new DateTime(1924, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donen@gmail.com", "Stanley", "Donen", "https://m.media-amazon.com/images/M/MV5BNTQ0MDgxNzEtYWUyZC00MjhkLThmOTItOTU5ZmZjYTg4Zjc3XkEyXkFqcGdeQXVyMjUxODE0MDY@._V1_UY317_CR21,0,214,317_AL_.jpg" },
                    { 25, 186, new DateTime(1929, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashby@gmail.com", "Hal", "Ashby", "https://m.media-amazon.com/images/M/MV5BNTE4MjI2Njc4MF5BMl5BanBnXkFtZTcwNDA0NjIyOA@@._V1_UY317_CR28,0,214,317_AL_.jpg" },
                    { 26, 9, new DateTime(1893, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1963, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marischka@gmail.com", "Ernst", "Marischka", "https://alchetron.com/cdn/ernst-marischka-a682a930-5fca-4829-a8dc-fee814dd6f5-resize-750.jpeg" },
                    { 27, 186, new DateTime(1947, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Zucker@gmail.com", "David", "Zucker", "https://m.media-amazon.com/images/M/MV5BOTE1MmRkMTAtMzJhMC00ZTViLTg1NWYtNGM3Yjc0YWZkMDBhXkEyXkFqcGdeQXVyMTExMjU1MDQ3._V1_UY317_CR17,0,214,317_AL_.jpg" },
                    { 28, 186, new DateTime(1945, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hanson@gmail.com", "Curtis", "Hanson", "https://m.media-amazon.com/images/M/MV5BMTM3MzIzMzExOV5BMl5BanBnXkFtZTcwMTEyNjA1Mw@@._V1_UY317_CR28,0,214,317_AL_.jpg" },
                    { 29, 161, new DateTime(1965, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kramer@gmail.com", "Wayne", "Kramer", "https://m.media-amazon.com/images/M/MV5BOTQ2OTNkYTEtM2U4Yy00ZDBlLTk2MTAtMmIwYzdkODliYTgwXkEyXkFqcGdeQXVyMjQ2NTAxMDk@._V1_UY317_CR133,0,214,317_AL_.jpg" },
                    { 30, 185, new DateTime(1899, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hitchcock@gmail.com", "Alfred", "Hitchcock", "https://m.media-amazon.com/images/M/MV5BMTQxOTg3ODc2NV5BMl5BanBnXkFtZTYwNTg0NTU2._V1_UX214_CR0,0,214,317_AL_.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Kind" },
                values: new object[,]
                {
                    { 1, "Drama" },
                    { 2, "Comedy" },
                    { 3, "Action" },
                    { 4, "Adventure" },
                    { 5, "Crime" },
                    { 6, "Biography" },
                    { 7, "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Kind" },
                values: new object[] { 8, "Mystery" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Country", "DirectorId", "Duration", "GenreId", "PhotoUrl", "Price", "ProductionYear", "Rating", "Title", "TrailerUrl", "Watched" },
                values: new object[,]
                {
                    { 1, 186, 1, 194, 1, "https://m.media-amazon.com/images/M/MV5BMDdmZGU3NDQtY2E5My00ZTliLWIzOTUtMTY4ZGI1YjdiNjk3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_UX182_CR0,0,182,268_AL_.jpg", 9.8000000000000007, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7999999999999998, "Titanic", "https://www.youtube.com/watch?v=b0KYvGa_nN8", false },
                    { 2, 186, 3, 148, 3, "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_UX182_CR0,0,182,268_AL_.jpg", 16.0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.8000000000000007, "Inception", "https://www.youtube.com/watch?v=YoHD9XEInc0", false },
                    { 3, 186, 2, 161, 2, "https://m.media-amazon.com/images/M/MV5BOTg4ZTNkZmUtMzNlZi00YmFjLTk1MmUtNWQwNTM0YjcyNTNkXkEyXkFqcGdeQXVyNjg2NjQwMDQ@._V1_UX182_CR0,0,182,268_AL_.jpg", 7.7000000000000002, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002, "Once Upon a Time... in Hollywood", "https://www.youtube.com/watch?v=ELeMaP8EPAA", false },
                    { 4, 186, 1, 162, 3, "https://m.media-amazon.com/images/M/MV5BMTYwOTEwNjAzMl5BMl5BanBnXkFtZTcwODc5MTUwMw@@._V1_UX182_CR0,0,182,268_AL_.jpg", 13.5, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7999999999999998, "Avatar", "https://www.youtube.com/watch?v=6ziBFh3V1aM", false },
                    { 5, 186, 1, 171, 4, "https://m.media-amazon.com/images/M/MV5BYWMzMDNlMDQtMTYyYi00OTM3LTllZDYtYThhMTk5MzNhZTRhXkEyXkFqcGdeQXVyMDUyOTUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", 13.0, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5999999999999996, "The Abyss", "https://www.youtube.com/watch?v=4zbpL3LeW7k", false },
                    { 6, 186, 4, 136, 3, "https://m.media-amazon.com/images/M/MV5BZDJjOTE0N2EtMmRlZS00NzU0LWE0ZWQtM2Q3MWMxNjcwZjBhXkEyXkFqcGdeQXVyNDk3NzU2MTQ@._V1_UX182_CR0,0,182,268_AL_.jpg", 13.0, new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5999999999999996, "The Rock", "https://www.youtube.com/watch?v=313n0wga2xo", false },
                    { 7, 186, 5, 170, 5, "https://m.media-amazon.com/images/M/MV5BZjEyZTdhNDMtMWFkMS00ZmRjLWEyNmEtZDU3MWFkNDEzMDYwXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX182_CR0,0,182,268_AL_.jpg", 18.0, new DateTime(1986, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5999999999999996, "Der Name der Rose", "https://www.youtube.com/watch?v=wrWpJkWPVNI", false },
                    { 8, 186, 6, 134, 6, "https://m.media-amazon.com/images/M/MV5BMTg2MzYzNzgzOF5BMl5BanBnXkFtZTgwOTg4NzQ4OTE@._V1_UX182_CR0,0,182,268_AL_.jpg", 10.0, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.2999999999999998, "Snowden", "https://www.youtube.com/watch?v=QlSAiI3xMh4", false },
                    { 9, 186, 7, 95, 3, "https://m.media-amazon.com/images/M/MV5BMzc3MjYxNzg2N15BMl5BanBnXkFtZTcwNzQyMTkwNA@@._V1_UX182_CR0,0,182,268_AL_.jpg", 9.0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.4000000000000004, "Season of the Witch", "https://www.youtube.com/watch?v=PE6QUf1b-Xw", false },
                    { 10, 186, 8, 102, 7, "https://m.media-amazon.com/images/M/MV5BOGQwN2UyM2YtNzNhOC00YjU5LWI0ZDgtZjMxZjM5ZmI0YjRmXkEyXkFqcGdeQXVyMTMxMTY0OTQ@._V1_UY268_CR1,0,182,268_AL_.jpg", 8.0, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7000000000000002, "The Wicker Man", "https://www.youtube.com/watch?v=QITzuunu-SU", false },
                    { 11, 186, 9, 131, 1, "https://m.media-amazon.com/images/M/MV5BMjEwMzE5ODcyMF5BMl5BanBnXkFtZTcwODQ1NjEyMQ@@._V1_UY268_CR1,0,182,268_AL_.jpg", 7.0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.9000000000000004, "Captain Corelli's Mandolin", "https://www.youtube.com/watch?v=xjjGrxipPGQ", false },
                    { 12, 186, 10, 136, 3, "https://m.media-amazon.com/images/M/MV5BMjE5MjkwODI3Nl5BMl5BanBnXkFtZTcwNjcwMDk4NA@@._V1_UX182_CR0,0,182,268_AL_.jpg", 5.0, new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.5999999999999996, "Pirates of the Caribbean: On Stranger Tides", "https://www.youtube.com/watch?v=0BXCVe8Yww4", false },
                    { 13, 186, 11, 174, 4, "https://m.media-amazon.com/images/M/MV5BYWVlMDI5N2UtZTIyMC00NjZkLWI5Y2QtODM5NGE5MzA0NmVjXkEyXkFqcGdeQXVyNzU3NjUxMzE@._V1_UX182_CR0,0,182,268_AL_.jpg", 12.0, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.5999999999999996, "Fantastic Beasts and Where to Find Them", "https://www.youtube.com/watch?v=vvFybpmyB9E", false },
                    { 14, 186, 10, 165, 4, "https://m.media-amazon.com/images/M/MV5BMTY4MzQ4OTY3NF5BMl5BanBnXkFtZTgwNjM5MDI3MjE@._V1_UX182_CR0,0,182,268_AL_.jpg", 11.0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.9000000000000004, "Into the Woods", "https://www.youtube.com/watch?v=7pjy5MK1X70", false },
                    { 15, 186, 12, 102, 2, "https://m.media-amazon.com/images/M/MV5BNmQyMmUzMmYtMTA4OS00ZmRjLWE0NWYtNjc0ZGM0N2E4YzQ5XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg", 6.0, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.2999999999999998, "Tusk", "https://www.youtube.com/watch?v=BCQJnOn0ru0", false },
                    { 16, 186, 13, 103, 3, "https://m.media-amazon.com/images/M/MV5BMTMyMzc3OTkwMV5BMl5BanBnXkFtZTcwMjc0MTgwNA@@._V1_UX182_CR0,0,182,268_AL_.jpg", 8.0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.0, "The Tourist", "https://www.youtube.com/watch?v=5XtbLezJtMg", false },
                    { 17, 186, 14, 116, 1, "https://m.media-amazon.com/images/M/MV5BMTg3NjUxMzM5NV5BMl5BanBnXkFtZTcwMzQ1NjQzMw@@._V1_UX182_CR0,0,182,268_AL_.jpg", 9.5, new DateTime(2007, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.2999999999999998, "Sweeney Todd: The Demon Barber of Fleet Street", "https://www.youtube.com/watch?v=_4R72KROZ20", false },
                    { 18, 186, 14, 105, 1, "https://m.media-amazon.com/images/M/MV5BNDUxN2I5NDUtZjdlMC00NjlmLTg0OTQtNjk0NjAxZjFmZTUzXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg", 12.5, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.9000000000000004, "Edward Scissorhands", "https://www.youtube.com/watch?v=TBHIO60whNw", false },
                    { 19, 186, 15, 119, 3, "https://m.media-amazon.com/images/M/MV5BZjJiYTExOTAtNWU0Yi00NzJjLTkwOTgtOTU2NWM1ZjJmYWVhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", 11.5, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.7000000000000002, "Maleficent", "https://www.youtube.com/watch?v=n0OFH4xpPr4", false },
                    { 20, 186, 16, 127, 6, "https://m.media-amazon.com/images/M/MV5BNzdjZDYwM2QtMGNlZS00MGQzLTlhMjctYTU4NWI5MWJlYmQwXkEyXkFqcGdeQXVyMTAwMzUyOTc@._V1_UX182_CR0,0,182,268_AL_.jpg", 10.5, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.2999999999999998, "Girl, Interrupted", "https://www.youtube.com/watch?v=5BHHUBZf7y4", false },
                    { 21, 186, 17, 141, 6, "https://m.media-amazon.com/images/M/MV5BOTA1Mzg3NjIxNV5BMl5BanBnXkFtZTcwNzU2NTc5MQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", 8.5, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002, "Changeling", "https://www.youtube.com/watch?v=PmfjureC-5I", false },
                    { 22, 186, 19, 100, 3, "https://m.media-amazon.com/images/M/MV5BMjIyODA2NDg4NV5BMl5BanBnXkFtZTcwMjg4NDAwMw@@._V1_UX182_CR0,0,182,268_AL_.jpg", 11.0, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6.4000000000000004, "Salt", "https://www.youtube.com/watch?v=QZ40WlshNwU", false },
                    { 23, 186, 19, 158, 1, "https://m.media-amazon.com/images/M/MV5BMTQ4NDI3NDg4M15BMl5BanBnXkFtZTcwMjY5OTI1OA@@._V1_UX182_CR0,0,182,268_AL_.jpg", 12.0, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5999999999999996, "Les Misérables", "https://www.youtube.com/watch?v=YmvHzCLP6ug", false },
                    { 24, 186, 20, 119, 6, "https://m.media-amazon.com/images/M/MV5BMjA0NjA4NjE2Nl5BMl5BanBnXkFtZTgwNzIxNTY2NjE@._V1_UX182_CR0,0,182,268_AL_.jpg", 14.0, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0999999999999996, "The Danish Girl", "https://www.youtube.com/watch?v=d88APYIGkjk", false },
                    { 25, 186, 21, 163, 6, "https://m.media-amazon.com/images/M/MV5BMTAwMTU4MDA3NDNeQTJeQWpwZ15BbWU4MDk4NTMxNTIx._V1_UX182_CR0,0,182,268_AL_.jpg", 16.5, new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002, "The Theory of Everything", "https://www.youtube.com/watch?v=Salz7uGp72c", false },
                    { 26, 186, 21, 108, 5, "https://m.media-amazon.com/images/M/MV5BY2I0MWFiZDMtNWQyYy00Njk5LTk3MDktZjZjNTNmZmVkYjkxXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX182_CR0,0,182,268_AL_.jpg", 18.5, new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0999999999999996, "On the Waterfront", "https://www.youtube.com/watch?v=QOLHbQjtSFs", false },
                    { 27, 186, 22, 118, 1, "https://m.media-amazon.com/images/M/MV5BNTYzNjI3MWUtZjg3Yi00ZDBkLWIwM2YtYmUyZGZjN2RiZjI5XkEyXkFqcGdeQXVyMDI2NDg0NQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", 13.5, new DateTime(1955, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.9000000000000004, "East of Eden", "https://www.youtube.com/watch?v=IqVoIQ5UsT8", false },
                    { 28, 186, 23, 111, 1, "https://m.media-amazon.com/images/M/MV5BMjMwNWIwYzAtMWVhZi00YzQ2LTlmNGYtOTg3NDdkNTRjOWI2XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX182_CR0,0,182,268_AL_.jpg", 12.5, new DateTime(1955, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002, "Rebel Without a Cause", "https://www.youtube.com/watch?v=wXRgAXU1-T4", false },
                    { 29, 186, 24, 105, 2, "https://m.media-amazon.com/images/M/MV5BNGEwMTRmZTQtMDY4Ni00MTliLTk5ZmMtOWMxYWMyMTllMDg0L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX182_CR0,0,182,268_AL_.jpg", 11.5, new DateTime(1961, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.7000000000000002, "Breakfast at Tiffany's", "https://www.youtube.com/watch?v=-XcLVQCDtbM", false },
                    { 30, 186, 25, 18, 2, "https://m.media-amazon.com/images/M/MV5BMTA0Y2UyMDUtZGZiOS00ZmVkLTg3NmItODQyNTY1ZjU1MWE4L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX182_CR0,0,182,268_AL_.jpg", 7.0, new DateTime(1963, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.9000000000000004, "Charade", "https://www.youtube.com/watch?v=C6T2Q4XO7uA", false },
                    { 31, 186, 23, 110, 2, "https://m.media-amazon.com/images/M/MV5BY2JkZTcxYjEtNmUwNi00MjIzLWE1YjUtMDYzNWJjYWQwMzA5XkEyXkFqcGdeQXVyNzM0MTUwNTY@._V1_UX182_CR0,0,182,268_AL_.jpg", 6.0, new DateTime(1979, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.0, "Being There", "https://www.youtube.com/watch?v=oOOghKacg40", false },
                    { 32, 186, 26, 103, 2, "https://m.media-amazon.com/images/M/MV5BZjhiNDU3NDEtNzFlMC00NTU2LThlMGMtNTA1ODJkNjIxN2RjXkEyXkFqcGdeQXVyMjI4MjA5MzA@._V1_UX182_CR0,0,182,268_AL_.jpg", 9.0, new DateTime(1976, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.2000000000000002, "The Pink Panther Strikes Again", "https://www.youtube.com/watch?v=VVnX-cPXpFA", false },
                    { 33, 186, 27, 102, 2, "https://m.media-amazon.com/images/M/MV5BMjdhNTBjMmMtZmVlNi00NWRhLWEwNjItM2ZjYzkzMzhhNDZhXkEyXkFqcGdeQXVyNDE5MTU2MDE@._V1_UY268_CR1,0,182,268_AL_.jpg", 3.5, new DateTime(1955, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.0, "Sissi", "https://www.youtube.com/watch?v=G2irBCrSakE", false },
                    { 34, 186, 28, 85, 2, "https://m.media-amazon.com/images/M/MV5BODk1ZWM4ZjItMjFhZi00MDMxLTgxNmYtODFhNWZlZTkwM2UwXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UX182_CR0,0,182,268_AL_.jpg", 3.3999999999999999, new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5999999999999996, "The Naked Gun: From the Files of Police Squad!", "https://www.youtube.com/watch?v=PACTQutbow4", false },
                    { 35, 186, 29, 110, 1, "https://m.media-amazon.com/images/M/MV5BOWI3MDIzZmYtN2Y3MC00YTljLWFiYmYtNWIzMjg1ZWQ1ODlhXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_UX182_CR0,0,182,268_AL_.jpg", 7.0999999999999996, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.5999999999999996, "8 Mile", "https://www.youtube.com/watch?v=axGVrfwm9L4", false },
                    { 36, 186, 30, 122, 8, "https://m.media-amazon.com/images/M/MV5BMTIwOTAzMDc4MF5BMl5BanBnXkFtZTcwNjY5MzIzMQ@@._V1_UX182_CR0,0,182,268_AL_.jpg", 9.5, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.4000000000000004, "Running Scared", "https://www.youtube.com/watch?v=D8mGXIb1Nog", false },
                    { 37, 186, 22, 112, 8, "https://m.media-amazon.com/images/M/MV5BNGUxYWM3M2MtMGM3Mi00ZmRiLWE0NGQtZjE5ODI2OTJhNTU0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY268_CR0,0,182,268_AL_.jpg", 12.0, new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8.4000000000000004, "Rear Window", "https://www.youtube.com/watch?v=m01YktiEZCw", false }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "ActorId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://m.media-amazon.com/images/M/MV5BMTg0NzYwMzc0OV5BMl5BanBnXkFtZTcwMjc0NTk1Nw@@._V1_SY1000_CR0,0,1335,1000_AL_.jpg" },
                    { 2, 1, "https://m.media-amazon.com/images/M/MV5BMTM0NjA1NzYxN15BMl5BanBnXkFtZTYwNTE3MjQz._V1_.jpg" },
                    { 3, 2, "https://m.media-amazon.com/images/M/MV5BZjM5ZjI3MTctYmVhOS00NWM2LWE3MWItMDIxMzRlMTQ5NmZmXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" },
                    { 4, 2, "https://m.media-amazon.com/images/M/MV5BYTMwMjVmMzYtMDk1NC00MGU4LWI5YzctNmU5NjFiZWEzZjBhXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" },
                    { 5, 2, "https://m.media-amazon.com/images/M/MV5BNmFhMjQwNGMtZTVkOS00OWI0LTgwYTctNjA4NTA3NmVjMDNkXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "ActorId", "Url" },
                values: new object[,]
                {
                    { 6, 3, "https://m.media-amazon.com/images/M/MV5BOGQyOGRjN2YtMTg5OS00ODBmLWEyN2EtZDZiNDU1MWZhYzg0XkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg" },
                    { 7, 3, "https://m.media-amazon.com/images/M/MV5BMjAxMDVkMTktNmJjOC00YjRkLTkzMWMtYTM5YmUzZGY3MWZiXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" },
                    { 8, 3, "https://m.media-amazon.com/images/M/MV5BMjNmYTdlYWMtN2U5MS00ZjdjLTgwZTQtYmExNDhlYmZlN2ZmXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" },
                    { 9, 3, "https://m.media-amazon.com/images/M/MV5BNTMwNzU5NmItZjM3ZS00M2Y3LWI0N2EtYmI5MzcyOGE0NTM0XkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" },
                    { 10, 11, "https://m.media-amazon.com/images/M/MV5BNzc4ZGZmZDktOTFhMS00Y2RkLWEyZWUtNzYxNjljOTZiNTcwXkEyXkFqcGdeQXVyNjUxMjc1OTM@._V1_SY1000_SX1600_AL_.jpg" },
                    { 11, 11, "https://m.media-amazon.com/images/M/MV5BZGY5OTc5NWYtZmMxZS00NWEwLWExZjItZmE3YTVkY2I0MTc0XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg" },
                    { 12, 11, "https://m.media-amazon.com/images/M/MV5BMDFkMTMwYjctMTRiNy00YWRiLTk3OTUtZDE3MmJiZWMxOTMyXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg" },
                    { 13, 11, "https://m.media-amazon.com/images/M/MV5BMjA3OTAzNzEwOF5BMl5BanBnXkFtZTgwOTMwODgyOTE@._V1_SY1000_CR0,0,666,1000_AL_.jpg" },
                    { 14, 11, "https://m.media-amazon.com/images/M/MV5BMjMzOTcwNjg5Nl5BMl5BanBnXkFtZTgwMTcyODY0NDM@._V1_SY1000_CR0,0,851,1000_AL_.jpg" },
                    { 15, 12, "https://m.media-amazon.com/images/M/MV5BMTcxMDc4MjMwM15BMl5BanBnXkFtZTgwMDY5NjgzNDE@._V1_SY1000_CR0,0,666,1000_AL_.jpg" },
                    { 16, 12, "https://m.media-amazon.com/images/M/MV5BMWE0MDhmMTYtNzY2YS00ZDM1LThlNzQtNWFiZWYwYWNhZGE2XkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" },
                    { 17, 13, "https://m.media-amazon.com/images/M/MV5BNGRjNGYxOWItMGZjNS00ZGZhLTljMmItOTMxNmVmMGNhNzYwXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg" },
                    { 18, 18, "https://m.media-amazon.com/images/M/MV5BMGFiZDY3NWYtNTkxYS00NDk5LThhZTYtYTU5NWVkMDZkNGIyXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" },
                    { 19, 18, "https://m.media-amazon.com/images/M/MV5BYjEyYjgzOGYtMzU0ZS00M2Q5LWIwYmItMmNjNjk0NGNmN2I2XkEyXkFqcGdeQXVyNTc0NjY1ODk@._V1_.jpg" },
                    { 20, 18, "https://m.media-amazon.com/images/M/MV5BNzA5MDQ0MzYtZTBhOS00YmYxLWE1MmMtNDgzYzI3MWZmMDMwXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_.jpg" },
                    { 21, 5, "https://m.media-amazon.com/images/M/MV5BNTQ3MDI3MDIyOF5BMl5BanBnXkFtZTgwMzYxNzY3NTM@._V1_SY1000_CR0,0,1487,1000_AL_.jpg" },
                    { 22, 5, "https://m.media-amazon.com/images/M/MV5BOTk3ODg1Nzg3NV5BMl5BanBnXkFtZTgwNDU0ODQ3NTM@._V1_.jpg" },
                    { 23, 5, "https://m.media-amazon.com/images/M/MV5BYTZjNDJlY2MtZjg3YS00NWYxLWIwMzctN2IxZWU3YjA2N2ExXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" },
                    { 24, 6, "https://m.media-amazon.com/images/M/MV5BZDM0MDM5NzEtYTdiYS00NDM4LWI2YjMtNTViNWE5NTU4NmMwXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" },
                    { 25, 7, "https://m.media-amazon.com/images/M/MV5BODJhMWIzODQtY2VhOC00YTlkLWJjY2QtZDVmMTRmM2U2MWQyXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" },
                    { 26, 8, "https://m.media-amazon.com/images/M/MV5BY2EzYzBmYjItNjYxZC00MmNhLWI5ZTctYjlkMDVhNzQyNDY4XkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" },
                    { 27, 9, "https://m.media-amazon.com/images/M/MV5BMjIzODIxNTc0MF5BMl5BanBnXkFtZTgwNDQzMDE1NjM@._V1_SX1500_CR0,0,1500,999_AL_.jpg" },
                    { 28, 10, "https://m.media-amazon.com/images/M/MV5BY2FkNWVlNWQtMjdmYS00ODg5LThiMTktNTU3Yzk3OWViZDhhXkEyXkFqcGdeQXVyNjUxMjc1OTM@._V1_SX1777_CR0,0,1777,755_AL_.jpg" },
                    { 29, 10, "https://m.media-amazon.com/images/M/MV5BYWU3NzRhNjAtMmE4Mi00OTdkLWJkNDQtZDFiNDJiYTMyNzk0XkEyXkFqcGdeQXVyNTc0NjY1ODk@._V1_.jpg" },
                    { 30, 10, "https://m.media-amazon.com/images/M/MV5BN2U2Njg4NTktM2QxMS00ZmQzLWFjNWEtOGIxOWU0YmY5OGQ5XkEyXkFqcGdeQXVyNTc0NjY1ODk@._V1_.jpg" },
                    { 31, 10, "https://m.media-amazon.com/images/M/MV5BZTBkODNhMjMtMzMzZi00MGYxLWIzNDktOTVhODlmYWU4Njk5XkEyXkFqcGdeQXVyNjUxMjc1OTM@._V1_SX1777_CR0,0,1777,752_AL_.jpg" },
                    { 32, 14, "https://m.media-amazon.com/images/M/MV5BM2JmYTA4NWUtZDM2Yi00YWJkLTlhMDktMDIwYTA4OTM4MTk4XkEyXkFqcGdeQXVyMDc2NTEzMw@@._V1_.jpg" },
                    { 33, 14, "https://m.media-amazon.com/images/M/MV5BNTg5ZjI3ZDAtYmQ4MS00N2JmLWIzZGYtMDkyODhkNmIyMjJkXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" },
                    { 34, 14, "https://m.media-amazon.com/images/M/MV5BMTIyYzA2YmMtNmY3NS00N2VlLTk2OWQtNWJiODg3NGM4ZDE5XkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" },
                    { 35, 15, "https://m.media-amazon.com/images/M/MV5BNzc4MzNhMDItMmE2OS00YmU0LTllNWEtM2QyM2ZmMjI3NDAwXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg" },
                    { 36, 15, "https://m.media-amazon.com/images/M/MV5BYjlkNGJhNzYtYzA4Zi00ZDIxLWEzNWQtZTMxOGVmNmYxYjgzXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" },
                    { 37, 15, "https://m.media-amazon.com/images/M/MV5BNDY1MTgzMzktOTIwOC00YjBlLTkyYmItNzZlNDc5ZDA4YmM3XkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 2 },
                    { 6, 8 },
                    { 7, 2 },
                    { 8, 4 },
                    { 9, 4 },
                    { 10, 4 },
                    { 11, 5 },
                    { 11, 6 },
                    { 12, 5 },
                    { 13, 5 },
                    { 14, 6 },
                    { 14, 7 },
                    { 15, 6 },
                    { 15, 9 },
                    { 15, 10 },
                    { 15, 11 },
                    { 17, 7 },
                    { 18, 7 },
                    { 20, 8 },
                    { 21, 8 },
                    { 22, 9 },
                    { 23, 9 },
                    { 24, 10 },
                    { 25, 10 },
                    { 26, 11 },
                    { 26, 12 },
                    { 27, 11 },
                    { 28, 12 },
                    { 28, 16 },
                    { 28, 17 },
                    { 28, 18 },
                    { 29, 12 },
                    { 30, 13 },
                    { 30, 23 },
                    { 30, 24 }
                });

            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 31, 13 },
                    { 32, 13 },
                    { 33, 14 },
                    { 34, 14 },
                    { 35, 14 },
                    { 36, 15 },
                    { 37, 15 },
                    { 38, 15 },
                    { 39, 16 },
                    { 39, 19 },
                    { 39, 20 },
                    { 39, 21 },
                    { 40, 16 },
                    { 41, 17 },
                    { 42, 17 },
                    { 43, 18 },
                    { 43, 20 },
                    { 44, 18 },
                    { 45, 19 },
                    { 46, 19 },
                    { 47, 20 },
                    { 48, 21 },
                    { 49, 21 },
                    { 52, 22 },
                    { 53, 22 },
                    { 54, 22 },
                    { 55, 23 },
                    { 56, 23 },
                    { 57, 24 },
                    { 58, 24 },
                    { 59, 25 },
                    { 60, 25 },
                    { 61, 25 },
                    { 62, 26 },
                    { 62, 27 },
                    { 63, 26 },
                    { 64, 26 },
                    { 65, 27 },
                    { 66, 27 },
                    { 67, 28 },
                    { 67, 29 },
                    { 68, 28 }
                });

            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 69, 28 },
                    { 70, 29 },
                    { 71, 29 },
                    { 72, 30 },
                    { 72, 31 },
                    { 73, 30 },
                    { 74, 30 },
                    { 75, 31 },
                    { 76, 31 },
                    { 77, 32 },
                    { 78, 32 },
                    { 79, 32 },
                    { 80, 33 },
                    { 81, 33 },
                    { 82, 33 },
                    { 83, 34 },
                    { 84, 34 },
                    { 85, 34 },
                    { 86, 35 },
                    { 87, 35 },
                    { 88, 35 },
                    { 89, 36 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_MovieId",
                table: "ActorMovies",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ActorId",
                table: "Photos",
                column: "ActorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovies");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
