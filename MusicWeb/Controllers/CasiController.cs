using MusicWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MusicWeb.Controllers
{
    public class CasiController : Controller
    {
        QLMusicEntities database = new QLMusicEntities();
        // GET: Casi
        public ActionResult Index()
        {
          //  if(idcasi==0)
            return View(database.Artists.ToList());
           /* else
            {
                return View(database.Artists.Where(s => s.ArtistID==idcasi));
            }*/
        }

    }
}