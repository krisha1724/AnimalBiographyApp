using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalBiographyApp.Models
{
    public class Animal
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Species { get; set; }

        [Required]
        [StringLength(100)]
        public string Habitat { get; set; }

        [Required]
        public string Description { get; set; }

        [StringLength(200)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        [Required]
        public string Diet { get; set; }

        [Required]
        [Display(Name = "Conservation Status")]
        public string ConservationStatus { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        public Animal()
        {
            // Initialize required properties with empty strings
            Name = string.Empty;
            Species = string.Empty;
            Habitat = string.Empty;
            Description = string.Empty;
            ImageUrl = string.Empty;
            Diet = string.Empty;
            ConservationStatus = string.Empty;
            DateAdded = DateTime.Now;
        }
    }
}