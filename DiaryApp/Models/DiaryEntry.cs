using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter a Title!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title Must Be Between 3 And 100 Characters!")]
        public string? Title { get; set; }

        [Required]
        public string? Content { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
