using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusedAPIProject
{

    public partial class Data
    {
        [JsonProperty("color")]
        public string color { get; set; }

        [JsonProperty("capacity")]
        public string capacity { get; set; }

        [JsonProperty("price")]
        public object price { get; set; }

        [JsonProperty("generation")]
        public string generation { get; set; }

        [JsonProperty("year")]
        public int year { get; set; }

        [JsonProperty("CPU model")]
        public string cpuModel { get; set; }

        [JsonProperty("Hard disk size")]
        public string Harddisksize { get; set; }

        [JsonProperty("Strap Colour")]
        public string Strapcolour { get; set; }

        [JsonProperty("Case Size")]
        public string Casesize { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("Screen size")]
        public double Screensize { get; set; }

        [JsonProperty("capacity GB")]
        public int capacityGB { get; set; }


    }
}
