using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Web_Projekt_TE15C_2.Models
{
    public class WebContext : DbContext
    {
        public DbSet<Articles> Articles { get; set; }
        public DbSet<GameDevelopers> GamesDevelopers { get; set; }
        public DbSet<Games> Games { get; set; }
    }
}