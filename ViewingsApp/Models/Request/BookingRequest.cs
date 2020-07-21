using System;

namespace ViewingsApp.Models.Request
{
    public class BookingRequest
    {
        public int AgentId { get; set; }
        public int PropertyId { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}