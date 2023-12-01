using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class Service
    {
        [Key]
        public string? Id { get; set; }
        public string? ServiceName { get; set; }
        public string? ServiceType { get; set; }
        public string? Content { get; set;}
        public double? Amount { get; set; }
        public string? EmpId { get; set; }
        public string? AccountNumber { get; set;}
        public string? PersonalId { get; set; }
        public double? Interest { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Status { get; set; }
    }
}
