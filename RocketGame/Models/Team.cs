using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace RocketGame.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public int Fuel { get; set; }
        public int Power { get; set; }
    }
}
