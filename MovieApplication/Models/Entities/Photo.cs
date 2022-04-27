using System.ComponentModel.DataAnnotations;

namespace MovieApplication.Models.Entities
{
    public class Photo
    {
        public Guid PhotoId { get; set; }
        [Display(Name = "Photo URL")]
        public string Url { get; set; }

        //Navigation Properties
        public virtual Actor Actor { get; set; }
    }
}
