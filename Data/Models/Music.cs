using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Music
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        [Required]
        public string Image_Url { get; set; }
        [Required]
        public string Audio_Url { get; set; }
        public string Thumb { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
