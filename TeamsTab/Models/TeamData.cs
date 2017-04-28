using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamsTab.Models
{
    public class TeamData
    {
        public TeamData()
        {
        }

        public string User { get; set; }
        public string Tenant { get; set; }
        public string Group { get; set;}
        public string Entity { get; set; }
        public string Locale { get; set; }
    }
}
