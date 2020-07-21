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
                    StartTime = 9,
                    EndTime = 19
                },
                new Agent
                {
                    Name = "Mark",
                    StartTime = 8,
                    EndTime = 16,
                },
                new Agent
                {
                    Name = "Martin",
                    StartTime = 10,
                    EndTime = 18,
                }
            };
        }
    }
}