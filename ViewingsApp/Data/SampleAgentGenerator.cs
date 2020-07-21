using System.Collections.Generic;
using ViewingsApp.Models.Database;

namespace ViewingsApp.Data
{
    public class SampleAgentGenerator
    {
        public static IList<Agent> GetSampleAgents()
        {
            return new List<Agent>
            {
                new Agent
                {
                    Name = "Esteban",
                    ImageUrl = "/images/person_01.jpg",
                    StartTime = 9,
                    EndTime = 19
                },
                new Agent
                {
                    Name = "Mark",
                    ImageUrl = "/images/person_02.jpg",
                    StartTime = 8,
                    EndTime = 16,
                },
                new Agent
                {
                    Name = "Martin",
                    ImageUrl = "/images/person_03.jpg",
                    StartTime = 10,
                    EndTime = 18,
                }
            };
        }
    }
}