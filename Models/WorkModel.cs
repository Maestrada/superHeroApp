using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace superHeroApp.Models
{
    [DataContract]
    public class WorkModel
    {
        [DataMember(Name = "occupation")]
        public string Occupation { get; set; }
        [DataMember(Name = "base")]
        public string Base { get; set; }
    }
}