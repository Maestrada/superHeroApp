using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace superHeroApp.Models
{
    [DataContract]
    public class ResultModel
    {
        public ResultModel()
        {
            this.Results = new List<HeroModel>();
        }
        [DataMember(Name = "response")]
        public string Response { get; set; }
        [DataMember(Name = "results-for")]
        public string ResultsFor { get; set; }
        [DataMember(Name = "results")]
        public List<HeroModel> Results { get; set; }
    }
}