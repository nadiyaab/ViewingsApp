using System;
using System.Collections.Generic;
using ViewingsApp.Models.Database;

namespace ViewingsApp.Data
{
    public class SampleBookingGenerator
    {
        public static IEnumerable<Booking> GetSampleBookings(IList<Property> properties, IList<Agent> agents)
        {
            return new List<Booking>
            {
                new Booking
                {
                    AgentId = 1,
                    PropertyId = 3,
                    StartsAt = new DateTime(2020, 07, 22, 12, 0, 0),
                    EndsAt = new DateTime(2020, 07, 22, 12, 30, 0),
                    Name = "Glendon Durdy",
                    EmailAddress = "gdurdy0@goo.gl",
                    PhoneNumber = "680 374 8915",
                },
                new Booking
                {
                    AgentId = 2,
                    PropertyId = 1,
                    StartsAt = new DateTime(2020, 07, 22, 14, 0, 0),
                    EndsAt = new DateTime(2020, 07, 22, 14, 30, 0),
                    Name = "Leicester Stainer",
                    EmailAddress = "lstainer1@imgur.com",
                    PhoneNumber = "863 855 0574",
                },
                new Booking
                {
                    AgentId = 3,
                    PropertyId = 6,
                    StartsAt = new DateTime(2020, 07, 24, 10, 0, 0),
                    EndsAt = new DateTime(2020, 07, 24, 10, 30, 0),
                    Name = "Brandie Karlolczak",
                    EmailAddress = "bkarlolczak2@lycos.com",
                    PhoneNumber = "683 858 4458",
                },
                new Booking
                {
                    AgentId = 1,
                    PropertyId = 5,
                    StartsAt = new DateTime(2020, 07, 24, 12, 0, 0),
                    EndsAt = new DateTime(2020, 07, 24, 12, 30, 0),
                    Name = "Kassia Drewet",
                    EmailAddress = "kdrewet3@ezinearticles.com",
                    PhoneNumber = "909 240 5462",
                },
                new Booking
                {
                    AgentId = 3,
                    PropertyId = 1,
                    StartsAt = new DateTime(2020, 07, 25, 12, 0, 0),
                    EndsAt = new DateTime(2020, 07, 25, 12, 30, 0),
                    Name = "Matthias Carlon",
                    EmailAddress = "mcarlon4@forbes.com",
                    PhoneNumber = "244 113 9658",
                },
            };
        }
    }
}