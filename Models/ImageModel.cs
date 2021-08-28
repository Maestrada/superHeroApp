using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace superHeroApp.Models
{
    [DataContract]
    public class ImageModel
    {
        [DataMember(Name = "url")]
        public string Url { get; set; }
    }
}