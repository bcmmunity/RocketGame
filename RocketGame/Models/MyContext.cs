using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RocketGame.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        } 
        
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Move> Moves { get; set; } 
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Tick> Ticks { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
