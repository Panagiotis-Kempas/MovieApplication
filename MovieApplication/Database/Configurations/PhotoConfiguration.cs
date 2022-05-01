using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApplication.Models.Entities;

namespace MovieApplication.Database.Configurations
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            throw new NotImplementedException();
        }
    }
}
