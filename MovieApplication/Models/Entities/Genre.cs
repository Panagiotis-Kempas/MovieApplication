namespace MovieApplication.Models.Entities
{
    public class Genre
    {
        public Guid GenreId { get; set; }
        public string Kind { get; set; }

        //Navigation Properties
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
