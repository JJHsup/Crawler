using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Crawler.Data;
using Crawler.Models;

namespace Crawler.Controllers
{
    public class BPlayersController : Controller
    {
        private CrawlerContext db = new CrawlerContext();

        // GET: BPlayers
        public ActionResult Index()
        {
            return View(db.BPlayers.ToList());
        }

        // GET: BPlayers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BPlayer bPlayer = db.BPlayers.Find(id);
            if (bPlayer == null)
            {
                return HttpNotFound();
            }
            return View(bPlayer);
        }

        // GET: BPlayers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BPlayers/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,G,PTS,TRB,AST,FG,FG3,FT,eFG,PER,WS")] BPlayer bPlayer)
        {
            if (ModelState.IsValid)
            {
                db.BPlayers.Add(bPlayer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bPlayer);
        }

        // GET: BPlayers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BPlayer bPlayer = db.BPlayers.Find(id);
            if (bPlayer == null)
            {
                return HttpNotFound();
            }
            return View(bPlayer);
        }

        // POST: BPlayers/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,G,PTS,TRB,AST,FG,FG3,FT,eFG,PER,WS")] BPlayer bPlayer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bPlayer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bPlayer);
        }

        // GET: BPlayers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BPlayer bPlayer = db.BPlayers.Find(id);
            if (bPlayer == null)
            {
                return HttpNotFound();
            }
            return View(bPlayer);
        }

        // POST: BPlayers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BPlayer bPlayer = db.BPlayers.Find(id);
            db.BPlayers.Remove(bPlayer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
