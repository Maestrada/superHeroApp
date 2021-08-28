using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace superHeroApp.Models
{
    public class HeroModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public PowerStatsModel PowerStats { get; set; }
        public  AppearanceModel Appearance { get; set; }
        public BiographyModel Biography { get; set; }
        public WorkModel Work { get; set; }
        public ConnectionsModel Connections { get; set; }

    }
}