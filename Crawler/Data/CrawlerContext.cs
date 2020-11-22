using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Crawler.Data
{
    public class CrawlerContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CrawlerContext() : base("name=CrawlerContext")
        {
        }

        public System.Data.Entity.DbSet<Crawler.Models.APlayer> APlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.BPlayer> BPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.CPlayer> CPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.DPlayer> DPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.EPlayer> EPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.FPlayer> FPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.GPlayer> GPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.HPlayer> HPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.IPlayer> IPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.JPlayer> JPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.KPlayer> KPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.LPlayer> LPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.MPlayer> MPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.NPlayer> NPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.OPlayer> OPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.PPlayer> PPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.QPlayer> QPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.RPlayer> RPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.SPlayer> SPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.TPlayer> TPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.UPlayer> UPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.VPlayer> VPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.WPlayer> WPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.XPlayer> XPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.YPlayer> YPlayers { get; set; }

        public System.Data.Entity.DbSet<Crawler.Models.ZPlayer> ZPlayers { get; set; }
    }
}
