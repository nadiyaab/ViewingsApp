using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ViewingsApp.Models.Request
{
    public class BookingRequest
    {
        public IEnumerable<SelectListItem> AllAgents { get; set; }
        public int AgentId { get; set; }
        public int PropertyId { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}