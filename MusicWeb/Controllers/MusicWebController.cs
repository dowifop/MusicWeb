using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicWeb.Models;
namespace MusicWeb.Controllers
{
    public class MusicWebController : Controller
    {
        QLMusicEntities database = new QLMusicEntities();
        // GET: MusicWeb
      
      public ActionResult Home()
        {
            return View();
        }
        public ActionResult Users()
        {
            return View(database.NguoiDungs.ToList());
        }
    }
}