using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace superHeroApp.Models
{
    [DataContract]
    public class ConnectionsModel
    {
        [DataMember(Name = "group-affiliation")]
        public string GroupAffiliation { get; set; }
        [DataMember(Name = "relatives")]
        public string Relatives { get; set; }

    }
}