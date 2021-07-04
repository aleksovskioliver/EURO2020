    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EURO2020.Models
{
    public class NationalTeam
    {
        public Team Team { get; set; }
        public List<Player> Players { get; set; }
        public int selectedPlayerId { get; set; }
        public int TeamId { get; set; }
    }
}