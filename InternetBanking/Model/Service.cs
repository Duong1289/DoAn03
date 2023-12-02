using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class Service
    {
        [Key]
        [Required]
        [MaxLength(5)]
        public string? Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? ServiceName { get; set; }


        [ForeignKey("ServicesTypes")]
        [Required]
        [MaxLength(5)]
        public string? ServiceTypeId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string? Content { get; set;}

        [Required]
        public double? Amount { get; set; }


        [ForeignKey("Employees")]
        [Required]
        [MaxLength(5)]
        public string? EmployeeID { get; set; }


        [ForeignKey("Accounts")]
        [Required]
        [MaxLength(5)]
        public string? AccountNumber { get; set;}


        [ForeignKey("Customers")]
        [Required]
        [MaxLength(20)]
        public string? CustomerPersonalId { get; set; }

        [Required]
        public double? Interest { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? CreatedDate { get; set; }= DateTime.Now;

        [Required]
        public bool? Status { get; set; }
    }
}
