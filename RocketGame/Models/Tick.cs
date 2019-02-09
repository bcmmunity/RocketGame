using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketGame.Models
{
    public class Tick 
    {
        public int TickId { get; set; }
        public long Start { get; set; }
        public long Finish { get; set; }
    }
}
