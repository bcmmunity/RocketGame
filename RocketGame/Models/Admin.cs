using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketGame.Models
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string password { get; set; }
        public string mail { get; set; }
        public string key { get; set; }
    }
}
