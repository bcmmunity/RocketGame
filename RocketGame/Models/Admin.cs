using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RocketGame.Models
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Key { get; set; }
    }
}
