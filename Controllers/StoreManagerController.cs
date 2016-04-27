using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    [Authorize(Roles="Administrator")]
    public class StoreManagerController : Controller
    {
        private MusicStoreEntities db = new MusicStoreEntities();

        public ActionResult Index()
        {
            var albums = db.Albums.Include(a => a.Genre).Include(a => a.Artist);
            return View(albums.ToList());
        }

        //
        // GET: /StoreManager/Details/5

        public ActionResult Details(int id)
        {
            return View(db.Albums.Find(id));
        }

        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name");
            ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Album objAlbum)
        {
            if (ModelState.IsValid)
            {
                db.Albums.Add(objAlbum);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", objAlbum.GenreId);
            ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId", "Name", objAlbum.ArtistId);
            return View(objAlbum);
        }

        //
        // GET: /StoreManager/Edit/5

        public ActionResult Edit(int id)
        {
            Album objAlbum = db.Albums.Find(id);
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", objAlbum.GenreId);
            ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId", "Name", objAlbum.ArtistId);
            return View(objAlbum);
        }

        //
        // POST: /StoreManager/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection objFormData, Album objAlbum)
        {
            if(ModelState.IsValid)
            {
                objAlbum.AlbumId = id;
                db.Entry(objAlbum).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", objAlbum.GenreId);
            ViewBag.ArtistId = new SelectList(db.Artists, "ArtistId", "Name", objAlbum.ArtistId);
            return View(objAlbum);
        }

        //
        // GET: /StoreManager/Delete/5

        public ActionResult Delete(int id)
        {
            return View(db.Albums.Find(id));
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Album obj = db.Albums.Find(id);
            db.Albums.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
