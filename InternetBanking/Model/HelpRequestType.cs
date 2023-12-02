﻿using System.ComponentModel.DataAnnotations;

namespace InternetBanking.Model
{
    public class HelpRequestType
    {
        [Key]
        public string? RequestTypeId { get; set; }
        public string? ServiceName { get; set; }
        public string? Description { get; set;}
        public ICollection<HelpRequest> HelpRequests { get; set; }
    }
}
