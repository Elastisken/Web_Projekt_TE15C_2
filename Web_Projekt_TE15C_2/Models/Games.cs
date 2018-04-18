using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace Web_Projekt_TE15C_2.Models
{
    public class Games
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public string genre { get; set; }

        public int? GameDeveloperID { get; set; }
        public virtual GameDevelopers GameDeveloper{get;set;}
    }
}