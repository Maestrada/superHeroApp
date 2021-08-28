using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace superHeroApp.Models
{
    public class BiographyModel
    {
        public string FullName { get; set; }
        public string AlterEgos { get; set; }
        public List<string> Aliases { get; set; }
        public string PlaceOfBirth { get; set; }
        public string FirstAppearance { get; set; }
        public string Publisher { get; set; }
        public string Alignment { get; set; }
    }
}