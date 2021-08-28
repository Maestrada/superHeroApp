using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace superHeroApp.Models
{
    [DataContract ]
    public class PowerStatsModel
    {
        [DataMember(Name = "stringelligence")]
        public string stringelligence { get; set; }
        [DataMember(Name = "strength")]
        public string Strength { get; set; }
        [DataMember(Name = "speed")]
        public string Speed { get; set; }
        [DataMember(Name = "durability")]
        public string Durability { get; set; }
        [DataMember(Name = "power")]
        public string Power { get; set; }
        [DataMember(Name = "combat")]
        public string Combat { get; set; }
    }
}