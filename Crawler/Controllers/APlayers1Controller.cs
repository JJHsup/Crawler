using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Crawler.Data;
using Crawler.Models;
using System.Web.Routing;
using Crawler.Service;

namespace Crawler.Controllers
{
    [RoutePrefix("api/[Controller]/[action]")]
    public class APlayers1Controller : ApiController
    {
        public string GetPlayers()
        {
            GetPlayerService service = new GetPlayerService();
            string result = service.Crawler();
            return result;
        }
    }
}