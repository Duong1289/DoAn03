using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class FAQCategory
    {
        [Key]
        [Required]
        [MaxLength(5)]
        public string? Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? CategoryName { get; set; }
        public ICollection<FAQ> FAQ { get; set; }
    }
}
