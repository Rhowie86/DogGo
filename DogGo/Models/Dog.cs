using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{
    public class Dog
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int OwnerId { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public string Notes { get; set; }
        [Required]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }

    }
}