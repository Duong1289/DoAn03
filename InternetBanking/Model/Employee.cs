namespace InternetBanking.Model
{
    public class Employee
    {
        [Key]
        public string? EmpId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Phone { get; set; }
        public bool? Status { get; set; }
        public string? RoleId { get; set; }
        public string? ManageBy { get; set;}
        public string? BranchId { get; set; }
    }
}
