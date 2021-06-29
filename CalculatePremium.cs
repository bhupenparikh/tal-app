using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tal_app
{
    public class CalculatePremium
    {
        [JsonProperty("dob")]
        public DateTime Dob { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("occupation")]
        public string Occupation { get; set; }
        [JsonProperty("deathsum")]
        public float DeathSum { get; set; }

    }
}
