using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketGame.Models
{
    public class Tick 
    {
        public int TickId { get; set; }
        public int Number { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
    }
}
