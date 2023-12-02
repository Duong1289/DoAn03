using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class HelpRequest
    {
        [Key]
        [Required]
        [MaxLength(5)]
        public string? Id { get; set; }

        [Required]
        [MaxLength(5)]
        public string? AccId {  get; set; }


        [ForeignKey("Customers")]
        [Required]
        [MaxLength(20)]
        public string? CustomerPersonalId { get; set; }


        [ForeignKey("Employees")]
        [Required]
        [MaxLength(5)]
        public string? EmployeeId { get; set; }

        [ForeignKey("HelpRequestTypes")]
        [Required]
        [MaxLength(5)]
        public string? RequestTypeId { get; set; }


        [Required]
        [MaxLength(1000)]
        public string? Content {  get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        [DefaultValue(false)]
        public bool? Status { get; set; }
    }
}
