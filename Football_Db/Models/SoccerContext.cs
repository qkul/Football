using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Football_Db.Models
{
    public class SoccerContext : DbContext
    {

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
    
}