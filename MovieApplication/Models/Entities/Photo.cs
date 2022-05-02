using System.ComponentModel.DataAnnotations;

namespace MovieApplication.Models.Entities
{
    public class Photo
    {
        public int PhotoId { get; set; }
        [Display(Name = "Photo URL")]
        public string Url { get; set; }

        // Foreign key(Actors)
        public int ActorId { get; set; }

        //Navigation Properties
        public virtual Actor? Actor { get; set; }
    }
}
