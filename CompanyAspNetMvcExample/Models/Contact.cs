using System.ComponentModel.DataAnnotations;

namespace CompanyAspNetMvcExample.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Contact Name")]
        public string? Name { get; set; }

        [Required]
        public string? Phone { get; set; }

        public string? AnotherPhone { get; set; }

        [Required]
        public string? Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

    }
}