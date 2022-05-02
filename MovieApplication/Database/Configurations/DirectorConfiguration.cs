﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApplication.Models.Entities;

namespace MovieApplication.Database.Configurations
{
    public class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.HasData(



                //SEEDING DIRECTORS
            new Director() { DirectorId = 1, FirstName = "James", LastName = "Cameron", Email = "JamesCameron@gmail.com", DateOfBirth = new DateTime(1954, 9, 16), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0MjMzOTg2MF5BMl5BanBnXkFtZTcwMTM3NjQxMw@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.Canada },          
            new Director() { DirectorId = 2, FirstName = "Quentin", LastName = "Tarantino", Email = "QuentinTarantino@gmail.com", DateOfBirth = new DateTime(1963, 3, 27), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTgyMjI3ODA3Nl5BMl5BanBnXkFtZTcwNzY2MDYxOQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America },          
            new Director() { DirectorId = 3, FirstName = "Christopher", LastName = "Nolan", Email = "ChristopherNolan@gmail.com", DateOfBirth = new DateTime(1970, 6, 30), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNjE3NDQyOTYyMV5BMl5BanBnXkFtZTcwODcyODU2Mw@@._V1_UY317_CR7,0,214,317_AL_.jpg", Country = Country.United_States_of_America },          
            new Director() { DirectorId = 4, FirstName = "Michael", LastName = "Bay", Email = "Bay@gmail.com", DateOfBirth = new DateTime(1965, 2, 17), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTc2NzcyMDU5NV5BMl5BanBnXkFtZTcwODc1OTM0NA@@._V1_UY317_CR7,0,214,317_AL_.jpg", Country = Country.United_States_of_America },          
            new Director() { DirectorId = 5, FirstName = "Jean-Jacques", LastName = "Annaud", Email = "Annaud@gmail.com", DateOfBirth = new DateTime(1943, 10, 1), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTA2OTE0NDk3ODJeQTJeQWpwZ15BbWU3MDUxNzkzMDk@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.France },           
            new Director() { DirectorId = 6, FirstName = "Oliver", LastName = "Stone", Email = "Stone@gmail.com", DateOfBirth = new DateTime(1946, 9, 15), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTMwMjExMTY3OV5BMl5BanBnXkFtZTcwNjY3MDA2MQ@@._V1_UY317_CR2,0,214,317_AL_.jpg", Country = Country.United_States_of_America },
            new Director() { DirectorId = 7, FirstName = "Dominic", LastName = "Sena", Email = "Sena@gmail.com", DateOfBirth = new DateTime(1949, 4, 26), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMjg4Mzg0Nl5BMl5BanBnXkFtZTcwMDY1NjkyNA@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America },
            new Director() { DirectorId = 8, FirstName = "Neil", LastName = "LaBute", Email = "Annaud@gmail.com", DateOfBirth = new DateTime(1963, 3, 19), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOTgxNzI4MDMwNl5BMl5BanBnXkFtZTcwMjExOTA2Nw@@._V1_UY317_CR57,0,214,317_AL_.jpg", Country = Country.United_States_of_America },           
            new Director() { DirectorId = 9, FirstName = "John", LastName = "Madden", Email = "Madden@gmail.com", DateOfBirth = new DateTime(1949, 4, 8), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg2NTg2MTM5N15BMl5BanBnXkFtZTYwOTk5MTc0._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America },          
            new Director() { DirectorId = 10, FirstName = "Rob", LastName = "Marshall", Email = "Marshall@gmail.com", DateOfBirth = new DateTime(1960, 9, 17), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTUwMjAxNTE2MF5BMl5BanBnXkFtZTYwMjA0MTQ1._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America },       
            new Director() { DirectorId = 11, FirstName = "David", LastName = "Yates", Email = "Yates@gmail.com", DateOfBirth = new DateTime(1963, 10, 8), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTY2NTU4NjY4M15BMl5BanBnXkFtZTYwNjIxOTI1._V1_UY317_CR10,0,214,317_AL_.jpg", Country = Country.United_Kingdom },       
            new Director() { DirectorId = 12, FirstName = "Kevin", LastName = "Smith", Email = "Smith@gmail.com", DateOfBirth = new DateTime(1970, 8, 2), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjQ0NzI0ODM2MV5BMl5BanBnXkFtZTgwMjc3Njg4NTM@._V1_UY317_CR2,0,214,317_AL_.jpg", Country = Country.United_States_of_America },        
            new Director() { DirectorId = 13, FirstName = "Florian", LastName = "Henckel von Donnersmarck", Email = "Donnersmarck@gmail.com", DateOfBirth = new DateTime(1973, 5, 2), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI0MTk2NDY5OV5BMl5BanBnXkFtZTcwODY2ODQ1MQ@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.Germany },           
            new Director() { DirectorId = 14, FirstName = "Tim", LastName = "Burton", Email = "Burton@gmail.com", DateOfBirth = new DateTime(1958, 8, 25), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTcwNTc4NTMzOF5BMl5BanBnXkFtZTYwMzc5ODYz._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America },      
            new Director() { DirectorId = 15, FirstName = "Robert", LastName = "Stromberg", Email = "Stromberg@gmail.com", DateOfBirth = new DateTime(1965, 4, 17), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTI3NDEzNTE1MV5BMl5BanBnXkFtZTcwMTI2MzMyMw@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America },          
            new Director() { DirectorId = 16, FirstName = "James", LastName = "Mangold", Email = "Mangold@gmail.com", DateOfBirth = new DateTime(1963, 12, 16), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg5MjY0ODg1MF5BMl5BanBnXkFtZTYwMjUzMjc0._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America },            
            new Director() { DirectorId = 17, FirstName = "Clint", LastName = "Eastwood", Email = "Eastwood@gmail.com", DateOfBirth = new DateTime(1930, 5, 31), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg3MDc0MjY0OV5BMl5BanBnXkFtZTcwNzU1MDAxOA@@._V1_UY317_CR10,0,214,317_AL_.jpg", Country = Country.United_States_of_America },         
            new Director() { DirectorId = 18, FirstName = "Phillip", LastName = "Noyce", Email = "Noyce@gmail.com", DateOfBirth = new DateTime(1950, 4, 29), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTQ0NDIyNTYzOF5BMl5BanBnXkFtZTcwNTczNDc2Mw@@._V1_UY317_CR18,0,214,317_AL_.jpg", Country = Country.France },            
            new Director() { DirectorId = 19, FirstName = "Tom", LastName = "Hooper", Email = "Hooper@gmail.com", DateOfBirth = new DateTime(1972, 10, 5), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTMyOTQ5MTE5OV5BMl5BanBnXkFtZTcwNjMxNjA0NA@@._V1_UY317_CR7,0,214,317_AL_.jpg", Country = Country.United_Kingdom },        
            new Director() { DirectorId = 20, FirstName = "James", LastName = "Marsh", Email = "Marsh@gmail.com", DateOfBirth = new DateTime(1963, 4, 30), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTg0NTE1NTY3Ml5BMl5BanBnXkFtZTcwMDc1NjYzNA@@._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_Kingdom },          
            new Director() { DirectorId = 21, FirstName = "Elia", LastName = "Kazan", Email = "Kazan@gmail.com", DateOfBirth = new DateTime(1909, 7, 9), DateOfDeath = new DateTime(2003, 9, 28), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMjI0OTg0NTk0N15BMl5BanBnXkFtZTgwMTQyOTE3MDI@._V1_UY317_CR52,0,214,317_AL_.jpg", Country = Country.Greece },            
            new Director() { DirectorId = 22, FirstName = "Nicholas", LastName = "Ray", Email = "Ray@gmail.com", DateOfBirth = new DateTime(1911, 9, 7), DateOfDeath = new DateTime(1979, 6, 16), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BZWQ3ZmZlMWUtOTdhZS00Mzk4LTk0YjEtYzM4MWNmNmMyNjY2XkEyXkFqcGdeQXVyMjUxODE0MDY@._V1_UY317_CR19,0,214,317_AL_.jpg", Country = Country.United_States_of_America },          
            new Director() { DirectorId = 23, FirstName = "Blake", LastName = "Edwards", Email = "Edwards@gmail.com", DateOfBirth = new DateTime(1922, 6, 22), DateOfDeath = new DateTime(2010, 12, 15), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTUwMjAzNDc0NF5BMl5BanBnXkFtZTYwNzM0NDU2._V1_UY317_CR0,0,214,317_AL_.jpg", Country = Country.United_States_of_America },            
            new Director() { DirectorId = 24, FirstName = "Stanley", LastName = "Donen", Email = "Donen@gmail.com", DateOfBirth = new DateTime(1924, 4, 13), DateOfDeath = new DateTime(2019, 2, 21), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNTQ0MDgxNzEtYWUyZC00MjhkLThmOTItOTU5ZmZjYTg4Zjc3XkEyXkFqcGdeQXVyMjUxODE0MDY@._V1_UY317_CR21,0,214,317_AL_.jpg", Country = Country.United_States_of_America },     
            new Director() { DirectorId = 25, FirstName = "Hal", LastName = "Ashby", Email = "Ashby@gmail.com", DateOfBirth = new DateTime(1929, 9, 2), DateOfDeath = new DateTime(1988, 12, 27), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BNTE4MjI2Njc4MF5BMl5BanBnXkFtZTcwNDA0NjIyOA@@._V1_UY317_CR28,0,214,317_AL_.jpg", Country = Country.United_States_of_America },          
            new Director() { DirectorId = 26, FirstName = "Ernst", LastName = "Marischka", Email = "Marischka@gmail.com", DateOfBirth = new DateTime(1893, 2, 2), DateOfDeath = new DateTime(1963, 5, 12), PhotoUrl = "https://alchetron.com/cdn/ernst-marischka-a682a930-5fca-4829-a8dc-fee814dd6f5-resize-750.jpeg", Country = Country.Austria },
            new Director() { DirectorId = 27, FirstName = "David", LastName = "Zucker", Email = "Zucker@gmail.com", DateOfBirth = new DateTime(1947, 10, 16), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOTE1MmRkMTAtMzJhMC00ZTViLTg1NWYtNGM3Yjc0YWZkMDBhXkEyXkFqcGdeQXVyMTExMjU1MDQ3._V1_UY317_CR17,0,214,317_AL_.jpg", Country = Country.United_States_of_America },       
            new Director() { DirectorId = 28, FirstName = "Curtis", LastName = "Hanson", Email = "Hanson@gmail.com", DateOfBirth = new DateTime(1945, 3, 24), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTM3MzIzMzExOV5BMl5BanBnXkFtZTcwMTEyNjA1Mw@@._V1_UY317_CR28,0,214,317_AL_.jpg", Country = Country.United_States_of_America },
            new Director() { DirectorId = 29, FirstName = "Wayne", LastName = "Kramer", Email = "Kramer@gmail.com", DateOfBirth = new DateTime(1965, 5, 26), DateOfDeath = null, PhotoUrl = "https://m.media-amazon.com/images/M/MV5BOTQ2OTNkYTEtM2U4Yy00ZDBlLTk2MTAtMmIwYzdkODliYTgwXkEyXkFqcGdeQXVyMjQ2NTAxMDk@._V1_UY317_CR133,0,214,317_AL_.jpg", Country = Country.South_Africa },         
            new Director() { DirectorId = 30, FirstName = "Alfred", LastName = "Hitchcock", Email = "Hitchcock@gmail.com", DateOfBirth = new DateTime(1899, 8, 13), DateOfDeath = new DateTime(1980, 4, 29), PhotoUrl = "https://m.media-amazon.com/images/M/MV5BMTQxOTg3ODc2NV5BMl5BanBnXkFtZTYwNTg0NTU2._V1_UX214_CR0,0,214,317_AL_.jpg", Country = Country.United_Kingdom }
            );
        }
    }
}