using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ApiBraws.Classi
{
  
        public class preferiti
        {
        
        [Key]
        public int IdN { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string usermame { get; set; }
        
    }
        public class tool
        {
            public string id { get; set; }
        }
        public class Brawler
        {
            public int id { get; set; }
            public string name { get; set; }
            public int power { get; set; }
            public int rank { get; set; }
            public int trophies { get; set; }
            public int highestTrophies { get; set; }
            public List<Gear> gears { get; set; }
            public List<StarPower> starPowers { get; set; }
            public List<Gadget> gadgets { get; set; }
        }

        public class Club
        {
        }

        public class Gadget
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class Gear
        {
            public int id { get; set; }
            public string name { get; set; }
            public int level { get; set; }
        }

        public class Icon
        {
            public int id { get; set; }
        }

        public class Root
        {
            public string tag { get; set; }
            public string name { get; set; }
            public string nameColor { get; set; }
            public Icon icon { get; set; }
            public int trophies { get; set; }
            public int highestTrophies { get; set; }
            public int highestPowerPlayPoints { get; set; }
            public int expLevel { get; set; }
            public int expPoints { get; set; }
            public bool isQualifiedFromChampionshipChallenge { get; set; }

            [JsonProperty("3vs3Victories")]
            public int _3vs3Victories { get; set; }
            public int soloVictories { get; set; }
            public int duoVictories { get; set; }
            public int bestRoboRumbleTime { get; set; }
            public int bestTimeAsBigBrawler { get; set; }
            public Club club { get; set; }
            public List<Brawler> brawlers { get; set; }
        }

        public class StarPower
        {
            public int id { get; set; }
            public string name { get; set; }
        }
    }

