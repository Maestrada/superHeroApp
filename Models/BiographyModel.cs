using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace superHeroApp.Models
{
    [DataContract]
    public class BiographyModel
    {
        public BiographyModel()
        {
            this.Aliases = new List<string>();
        }
        [DataMember(Name = "full-name")]
        public string FullName { get; set; }
        [DataMember(Name = "alter-egos")]
        public string AlterEgos { get; set; }
        [DataMember(Name = "aliases")]
        public List<string> Aliases { get; set; }
        [DataMember(Name = "place-of-birth")]
        public string PlaceOfBirth { get; set; }
        [DataMember(Name = "first-appearance")]
        public string FirstAppearance { get; set; }
        [DataMember(Name = "publisher")]
        public string Publisher { get; set; }
        [DataMember(Name = "alignment")]
        public string Alignment { get; set; }
    }
}