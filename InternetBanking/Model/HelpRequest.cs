using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class HelpRequest
    {
        [Key]
        public string? Id { get; set; }
        public string? Acc {  get; set; }
        public string? PersonalId { get; set; }
        public string? RequestTypeId { get; set; }
        public string? EmpId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? Status { get; set; }
    }
}
