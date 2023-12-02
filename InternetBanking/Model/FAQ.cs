using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class FAQ
    {
        [Key]
        [Required]
        [MaxLength(5)]
        public string? Id { get; set; }

        [Required]
        [MaxLength(300)]
        public string? Question { get; set; }

        [Required]
        [MaxLength(1000)]
        public string? Answer { get; set; }


        [ForeignKey("FAQCategories")]
        [Required]
        [MaxLength(5)]
        public string? FAQCategoryId { get; set; }
        
    }
}
