using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace superHeroApp.Models
{
   [DataContract]
    public class HeroModel
    {
        public HeroModel()
        {
            this.PowerStats = new PowerStatsModel();
            this.Appearance = new AppearanceModel();
            this.Biography = new BiographyModel();
            this.Connections = new ConnectionsModel();
            this.Image = new ImageModel();
        }
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "image")]
        public ImageModel Image  { get; set; }
        [DataMember(Name = "powerstats")]
        public PowerStatsModel PowerStats { get; set; }
        [DataMember(Name = "appearance")]
        public  AppearanceModel Appearance { get; set; }
        [DataMember(Name = "biography")]
        public BiographyModel Biography { get; set; }
        [DataMember(Name = "work")]
        public WorkModel Work { get; set; }
        [DataMember(Name = "connections")]
        public ConnectionsModel Connections { get; set; }

    }
}