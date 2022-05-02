using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApplication.Models.Entities;

namespace MovieApplication.Database.Configurations
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasOne<Actor>(p => p.Actor)
                .WithMany(p => p.Photos)
                .HasForeignKey(p => p.ActorId);

            // SEEDING PHOTOS
           builder.HasData(
             new Photo() { PhotoId = 1, Url = "https://m.media-amazon.com/images/M/MV5BMTg0NzYwMzc0OV5BMl5BanBnXkFtZTcwMjc0NTk1Nw@@._V1_SY1000_CR0,0,1335,1000_AL_.jpg",ActorId = 1 },
             new Photo() { PhotoId = 2, Url = "https://m.media-amazon.com/images/M/MV5BMTM0NjA1NzYxN15BMl5BanBnXkFtZTYwNTE3MjQz._V1_.jpg", ActorId = 1 },
             new Photo() { PhotoId = 3, Url = "https://m.media-amazon.com/images/M/MV5BZjM5ZjI3MTctYmVhOS00NWM2LWE3MWItMDIxMzRlMTQ5NmZmXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg", ActorId = 2 },
             new Photo() { PhotoId = 4, Url = "https://m.media-amazon.com/images/M/MV5BYTMwMjVmMzYtMDk1NC00MGU4LWI5YzctNmU5NjFiZWEzZjBhXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg", ActorId = 2 },
             new Photo() { PhotoId = 5, Url = "https://m.media-amazon.com/images/M/MV5BNmFhMjQwNGMtZTVkOS00OWI0LTgwYTctNjA4NTA3NmVjMDNkXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg", ActorId = 2 },
             new Photo() { PhotoId = 6, Url = "https://m.media-amazon.com/images/M/MV5BOGQyOGRjN2YtMTg5OS00ODBmLWEyN2EtZDZiNDU1MWZhYzg0XkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg", ActorId = 3 },
             new Photo() { PhotoId = 7, Url = "https://m.media-amazon.com/images/M/MV5BMjAxMDVkMTktNmJjOC00YjRkLTkzMWMtYTM5YmUzZGY3MWZiXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg", ActorId = 3 },
             new Photo() { PhotoId = 8, Url = "https://m.media-amazon.com/images/M/MV5BMjNmYTdlYWMtN2U5MS00ZjdjLTgwZTQtYmExNDhlYmZlN2ZmXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" , ActorId = 3 },
             new Photo() { PhotoId = 9, Url = "https://m.media-amazon.com/images/M/MV5BNTMwNzU5NmItZjM3ZS00M2Y3LWI0N2EtYmI5MzcyOGE0NTM0XkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg" , ActorId = 3 },
             new Photo() { PhotoId = 10,Url = "https://m.media-amazon.com/images/M/MV5BNzc4ZGZmZDktOTFhMS00Y2RkLWEyZWUtNzYxNjljOTZiNTcwXkEyXkFqcGdeQXVyNjUxMjc1OTM@._V1_SY1000_SX1600_AL_.jpg", ActorId = 11 },
             new Photo() { PhotoId = 11, Url = "https://m.media-amazon.com/images/M/MV5BZGY5OTc5NWYtZmMxZS00NWEwLWExZjItZmE3YTVkY2I0MTc0XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg", ActorId = 11},
             new Photo() { PhotoId = 12, Url = "https://m.media-amazon.com/images/M/MV5BMDFkMTMwYjctMTRiNy00YWRiLTk3OTUtZDE3MmJiZWMxOTMyXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg", ActorId = 11 },
             new Photo() { PhotoId = 13, Url = "https://m.media-amazon.com/images/M/MV5BMjA3OTAzNzEwOF5BMl5BanBnXkFtZTgwOTMwODgyOTE@._V1_SY1000_CR0,0,666,1000_AL_.jpg", ActorId = 11 },
             new Photo() { PhotoId = 14, Url = "https://m.media-amazon.com/images/M/MV5BMjMzOTcwNjg5Nl5BMl5BanBnXkFtZTgwMTcyODY0NDM@._V1_SY1000_CR0,0,851,1000_AL_.jpg", ActorId = 11 },
             new Photo() { PhotoId = 15, Url = "https://m.media-amazon.com/images/M/MV5BMTcxMDc4MjMwM15BMl5BanBnXkFtZTgwMDY5NjgzNDE@._V1_SY1000_CR0,0,666,1000_AL_.jpg", ActorId = 12 },
             new Photo() { PhotoId = 16, Url = "https://m.media-amazon.com/images/M/MV5BMWE0MDhmMTYtNzY2YS00ZDM1LThlNzQtNWFiZWYwYWNhZGE2XkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg", ActorId = 12 },
             new Photo() { PhotoId = 17, Url = "https://m.media-amazon.com/images/M/MV5BNGRjNGYxOWItMGZjNS00ZGZhLTljMmItOTMxNmVmMGNhNzYwXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg", ActorId = 13 },
             new Photo() { PhotoId = 18, Url = "https://m.media-amazon.com/images/M/MV5BMGFiZDY3NWYtNTkxYS00NDk5LThhZTYtYTU5NWVkMDZkNGIyXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg",ActorId = 18 },
             new Photo() { PhotoId = 19, Url = "https://m.media-amazon.com/images/M/MV5BYjEyYjgzOGYtMzU0ZS00M2Q5LWIwYmItMmNjNjk0NGNmN2I2XkEyXkFqcGdeQXVyNTc0NjY1ODk@._V1_.jpg", ActorId = 18 },
             new Photo() { PhotoId = 20, Url = "https://m.media-amazon.com/images/M/MV5BNzA5MDQ0MzYtZTBhOS00YmYxLWE1MmMtNDgzYzI3MWZmMDMwXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_.jpg", ActorId = 18 },
             new Photo() { PhotoId = 21, Url = "https://m.media-amazon.com/images/M/MV5BNTQ3MDI3MDIyOF5BMl5BanBnXkFtZTgwMzYxNzY3NTM@._V1_SY1000_CR0,0,1487,1000_AL_.jpg", ActorId = 5 },
             new Photo() { PhotoId = 22, Url = "https://m.media-amazon.com/images/M/MV5BOTk3ODg1Nzg3NV5BMl5BanBnXkFtZTgwNDU0ODQ3NTM@._V1_.jpg", ActorId = 5 },
             new Photo() { PhotoId = 23, Url = "https://m.media-amazon.com/images/M/MV5BYTZjNDJlY2MtZjg3YS00NWYxLWIwMzctN2IxZWU3YjA2N2ExXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg", ActorId = 5 },
             new Photo() { PhotoId = 24, Url = "https://m.media-amazon.com/images/M/MV5BZDM0MDM5NzEtYTdiYS00NDM4LWI2YjMtNTViNWE5NTU4NmMwXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg",ActorId = 6 },
             new Photo() { PhotoId = 25, Url = "https://m.media-amazon.com/images/M/MV5BODJhMWIzODQtY2VhOC00YTlkLWJjY2QtZDVmMTRmM2U2MWQyXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg",ActorId = 7 },
             new Photo() { PhotoId = 26, Url = "https://m.media-amazon.com/images/M/MV5BY2EzYzBmYjItNjYxZC00MmNhLWI5ZTctYjlkMDVhNzQyNDY4XkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg",ActorId = 8 },
             new Photo() { PhotoId = 27, Url = "https://m.media-amazon.com/images/M/MV5BMjIzODIxNTc0MF5BMl5BanBnXkFtZTgwNDQzMDE1NjM@._V1_SX1500_CR0,0,1500,999_AL_.jpg", ActorId = 9 },
             new Photo() { PhotoId = 28, Url = "https://m.media-amazon.com/images/M/MV5BY2FkNWVlNWQtMjdmYS00ODg5LThiMTktNTU3Yzk3OWViZDhhXkEyXkFqcGdeQXVyNjUxMjc1OTM@._V1_SX1777_CR0,0,1777,755_AL_.jpg",ActorId = 10 },
             new Photo() { PhotoId = 29, Url = "https://m.media-amazon.com/images/M/MV5BYWU3NzRhNjAtMmE4Mi00OTdkLWJkNDQtZDFiNDJiYTMyNzk0XkEyXkFqcGdeQXVyNTc0NjY1ODk@._V1_.jpg", ActorId = 10 },
             new Photo() { PhotoId = 30, Url = "https://m.media-amazon.com/images/M/MV5BN2U2Njg4NTktM2QxMS00ZmQzLWFjNWEtOGIxOWU0YmY5OGQ5XkEyXkFqcGdeQXVyNTc0NjY1ODk@._V1_.jpg", ActorId = 10 },
             new Photo() { PhotoId = 31, Url = "https://m.media-amazon.com/images/M/MV5BZTBkODNhMjMtMzMzZi00MGYxLWIzNDktOTVhODlmYWU4Njk5XkEyXkFqcGdeQXVyNjUxMjc1OTM@._V1_SX1777_CR0,0,1777,752_AL_.jpg", ActorId = 10 },
             new Photo() { PhotoId = 32, Url = "https://m.media-amazon.com/images/M/MV5BM2JmYTA4NWUtZDM2Yi00YWJkLTlhMDktMDIwYTA4OTM4MTk4XkEyXkFqcGdeQXVyMDc2NTEzMw@@._V1_.jpg", ActorId = 14  },       
             new Photo() { PhotoId = 33, Url = "https://m.media-amazon.com/images/M/MV5BNTg5ZjI3ZDAtYmQ4MS00N2JmLWIzZGYtMDkyODhkNmIyMjJkXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg", ActorId = 14 },        
             new Photo() { PhotoId = 34, Url = "https://m.media-amazon.com/images/M/MV5BMTIyYzA2YmMtNmY3NS00N2VlLTk2OWQtNWJiODg3NGM4ZDE5XkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg", ActorId = 14 },               
             new Photo() { PhotoId = 35, Url = "https://m.media-amazon.com/images/M/MV5BNzc4MzNhMDItMmE2OS00YmU0LTllNWEtM2QyM2ZmMjI3NDAwXkEyXkFqcGdeQXVyMTI3MDk3MzQ@._V1_.jpg", ActorId = 15 },           
             new Photo() { PhotoId = 36, Url = "https://m.media-amazon.com/images/M/MV5BYjlkNGJhNzYtYzA4Zi00ZDIxLWEzNWQtZTMxOGVmNmYxYjgzXkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg", ActorId = 15 },          
             new Photo() { PhotoId = 37, Url = "https://m.media-amazon.com/images/M/MV5BNDY1MTgzMzktOTIwOC00YjBlLTkyYmItNzZlNDc5ZDA4YmM3XkEyXkFqcGdeQXVyMjUyNDk2ODc@._V1_.jpg", ActorId = 15 }           
               );
        }
    }
}
