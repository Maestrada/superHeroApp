using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace superHeroApp.Models
{
    [DataContract]
    public class AppearanceModel
    {
        public AppearanceModel()
        {
            this.Weight = new List<string>();
            this.Height = new List<string>();
        }
        [DataMember(Name = "gender")]
        public string Gender { get; set; }
        [DataMember(Name = "race")]
        public string Race { get; set; }
        [DataMember(Name = "height")]
        public List<string>  Height { get; set; }
        [DataMember(Name = "weight")]
        public List<string> Weight { get; set; }
        [DataMember(Name = "eye-color")]
        public string EyeColor { get; set; }
        [DataMember(Name = "hair-color")]
        public string HairColor { get; set; }
    }
}