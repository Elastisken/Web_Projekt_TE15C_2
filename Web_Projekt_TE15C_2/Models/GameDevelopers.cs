using System;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web_Projekt_TE15C_2.Models
{
    public class GameDevelopers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Games> Games { get; set; }
    }
}