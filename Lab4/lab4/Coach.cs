using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace lab4
{
    public class Coach
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        public List<Season> Seasons { get; set; }

        public class Season
        {
            [JsonIgnore]
            public int Id { get; set; }
            public string School { get; set; }
        }
    }
}
