using System.Collections.Generic;
using ViewingsApp.Models.Database;

namespace ViewingsApp.Data
{
    public class SamplePropertyGenerator
    {
        public static IList<Property> GetSampleProperties()
        {
            return new List<Property>
            {
                new Property
                {
                    Name = "13 Clove Point",
                    Postcode = "SE5 8DE",
                    ImageUrl = "/images/house_01.jpg"
                },
                new Property
                {
                    Name = "8294 Hallows Junction",
                    Postcode = "NW2 4JB",
                    ImageUrl = "/images/house_02.jpg"
                },
                new Property
                {
                    Name = "5 South Crossing",
                    Postcode = "E15 3AF",
                    ImageUrl = "/images/house_03.jpg"
                },
                new Property
                {
                    Name = "69 Ridge Oak Center",
                    Postcode = "N17 8NU",
                    ImageUrl = "/images/house_04.jpg"
                },
                new Property
                {
                    Name = "1 Mandrake Road",
                    Postcode = "N12 8PE",
                    ImageUrl = "/images/house_05.jpg"
                },
                new Property
                {
                    Name = "6 Troy Road",
                    Postcode = "E4 6BW",
                    ImageUrl = "/images/house_06.jpg"
                }
            };
        }
    }
}