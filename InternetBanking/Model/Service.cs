using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class Service
    {
        [Key]
        public string? Id { get; set; }
        public string? ServiceName { get; set; }
        [ForeignKey("ServicesTypes")]
        public string? ServiceTypeId { get; set; }
        public string? Content { get; set;}
        public double? Amount { get; set; }
        [ForeignKey("Employees")]
        public string? EmployeeID { get; set; }
        public string? AccountNumber { get; set;}
        public string? PersonalId { get; set; }
        public double? Interest { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Status { get; set; }
    }
}
