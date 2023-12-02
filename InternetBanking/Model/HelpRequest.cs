using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetBanking.Model
{
    public class HelpRequest
    {
        [Key]
        public string? Id { get; set; }
        public string? Acc {  get; set; }
        [ForeignKey("Customers")]
        public string? CustomerPersonalId { get; set; }
        [ForeignKey("HelpRequestTypes")]
        public string? RequestTypeId { get; set; }
        [ForeignKey("Employees")]
        public string? EmployeeId { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public bool? Status { get; set; }
    }
}
