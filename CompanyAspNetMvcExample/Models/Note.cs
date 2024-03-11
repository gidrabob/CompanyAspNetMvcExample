using System.ComponentModel.DataAnnotations;

namespace CompanyAspNetMvcExample.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Note Name")]
        public string? Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string? NoteText { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public string? Tags { get; set; }

    }
}