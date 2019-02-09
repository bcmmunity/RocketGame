using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketGame.Models
{
    public class User 
    {
        public Team Team { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Intellect { get; set; }
        public int Power { get; set; }
        public bool InRocket { get; set; }
    }
}
