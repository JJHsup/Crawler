using Crawler.Data;
using Crawler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crawler.Repository
{
    public class PlayerRepository
    {
        private readonly CrawlerContext db = new CrawlerContext();

        public void PlayerPost(List<string> players)
        {
            if (players.Count() <= 9)
            {
                YPlayer player = new YPlayer()
                {
                    Name = players[8],
                    G = players[7],
                    PTS = players[6],
                    TRB = players[5],
                    AST = players[4],
                    FG = players[3],
                    FG3 = string.Empty,
                    FT = players[2],
                    eFG = string.Empty,
                    PER = players[1],
                    WS = players[0]
                };
                db.YPlayers.Add(player);
            }
            else
            {
                YPlayer player = new YPlayer()
                {
                    Name = players[10],
                    G = players[9],
                    PTS = players[8],
                    TRB = players[7],
                    AST = players[6],
                    FG = players[5],
                    FG3 = players[4],
                    FT = players[3],
                    eFG = players[2],
                    PER = players[1],
                    WS = players[0]
                };
                db.YPlayers.Add(player);
            }
            db.SaveChanges();
        }
    }
}