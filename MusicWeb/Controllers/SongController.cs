using MusicWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicWeb.Controllers
{
    public class SongController : Controller
    {
        QLMusicEntities database = new QLMusicEntities();
        // GET: Song
        //public ActionResult Index(int id)
        //{
        //    if (id == 1)
        //        return View(database.Songs.Where(s => s.ArtistID == id));
        //    else
        //        return View();
        //}
        public ActionResult Song1()
        {
            return View();
        }
        public ActionResult Song2()
        {
            return View();
        }
        public ActionResult Song3()
        {
            return View();
        }

        public ActionResult Song4()
        {
            return View();
        }

        public ActionResult Song5()
        {
            return View();
        }

        public ActionResult Song6()
        {
            return View();
        }

        public ActionResult Song7()
        {
            return View();
        }

        public ActionResult Song8()
        {
            return View();
        }

        public ActionResult Song9()
        {
            return View();
        }

        public ActionResult Song10()
        {
            return View();
        }
        public ActionResult Song11()
        {
            return View();
        }
        public ActionResult SongPlaylist()
        {
            return View(database.Songs.ToList());
        }
        public ActionResult Song12()
        {
            return View();
        }
    }
}