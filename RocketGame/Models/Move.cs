using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketGame.Models
{
    public class Move 
    {
        public int MoveId { get; set; }
        public string Type { get; set; }
        public string Result { get; set; }
        public Team To { get; set; }
        public DateTime Time { get; set; }
        public Tick Tick { get; set; }
        public User User { get; set; }
    }
}
