using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Web_Projekt_TE15C_2.Models
{
    public class Articles
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseTime { get; set; }
        public string ArticleText { get; set; }
        public string ImageFile { get; set; }
    }
}