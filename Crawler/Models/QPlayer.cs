using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crawler.Models
{
    public class QPlayer
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string G { get; set; }
        public string PTS { get; set; }
        public string TRB { get; set; }
        public string AST { get; set; }
        public string FG { get; set; }
        public string FG3 { get; set; }
        public string FT { get; set; }
        public string eFG { get; set; }
        public string PER { get; set; }
        public string WS { get; set; }
    }
}