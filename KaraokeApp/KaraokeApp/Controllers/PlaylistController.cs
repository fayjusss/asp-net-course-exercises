using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KaraokeApp.DAL;
using KaraokeApp.Models;

namespace KaraokeApp.Controllers
{
    public class PlaylistController : Controller
    {
        private PlaylistContext db = new PlaylistContext();

        // GET: Playlist
        public ActionResult Index()
        {
            var playlists = db.Playlists.Include(p => p.Singer).Include(p => p.Song);
            return View(playlists.ToList());
        }

        // GET: Playlist/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Playlist playlist = db.Playlists.Find(id);
            if (playlist == null)
            {
                return HttpNotFound();
            }
            return View(playlist);
        }

        // GET: Playlist/Create
        public ActionResult Create()
        {
            ViewBag.SingerID = new SelectList(db.Singers, "ID", "FirstName");
            ViewBag.SongID = new SelectList(db.Songs, "ID", "Title");
            return View();
        }

        // POST: Playlist/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,SongID,SingerID")] Playlist playlist)
        {
            if (ModelState.IsValid)
            {
                db.Playlists.Add(playlist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SingerID = new SelectList(db.Singers, "ID", "FirstName", playlist.SingerID);
            ViewBag.SongID = new SelectList(db.Songs, "ID", "Title", playlist.SongID);
            return View(playlist);
        }

        // GET: Playlist/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Playlist playlist = db.Playlists.Find(id);
            if (playlist == null)
            {
                return HttpNotFound();
            }
            ViewBag.SingerID = new SelectList(db.Singers, "ID", "FirstName", playlist.SingerID);
            ViewBag.SongID = new SelectList(db.Songs, "ID", "Title", playlist.SongID);
            return View(playlist);
        }

        // POST: Playlist/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,SongID,SingerID")] Playlist playlist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playlist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SingerID = new SelectList(db.Singers, "ID", "FirstName", playlist.SingerID);
            ViewBag.SongID = new SelectList(db.Songs, "ID", "Title", playlist.SongID);
            return View(playlist);
        }

        // GET: Playlist/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Playlist playlist = db.Playlists.Find(id);
            if (playlist == null)
            {
                return HttpNotFound();
            }
            return View(playlist);
        }

        // POST: Playlist/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Playlist playlist = db.Playlists.Find(id);
            db.Playlists.Remove(playlist);
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
