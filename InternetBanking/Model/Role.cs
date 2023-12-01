using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class Role
    {
        [Key]
        public string? RoleId { get; set; }
        public string? RoleName { get; set;}
    }
}
