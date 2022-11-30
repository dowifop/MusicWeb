using MusicWeb.Models;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using System;
using System.Web;
using System.IO;

namespace MusicWeb.Controllers

{
    public class UsersController : Controller
    {
        QLMusicEntities database = new QLMusicEntities();
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }       
        [HttpPost]
        public ActionResult LoginAccount(Account _user)
        {
            var check = database.Accounts.Where(s => s.AccountID == _user.AccountID
                && s.Email == _user.Email && s.PasswordAccount == _user.PasswordAccount).FirstOrDefault();
            if (check == null) //login sai thông tin
            {
                ViewBag.ErrorInfo = "Sai thông tin";
                return View("Index");
            }
            else
            {
                database.Configuration.ValidateOnSaveEnabled = false;
                Session["AccountID"] = _user.AccountID;
                Session["Email"] = _user.Email;
                // Session["PasswordAccount"] = _user.PasswordAccount;
                return RedirectToAction("Index", "Casi");
            }
        }
        public ActionResult Dangkitk()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangkitk(Account _user)
        {
            if (ModelState.IsValid)
            {
               var check_ID = database.Accounts.Where(s => s.AccountID == _user.AccountID).FirstOrDefault();       
                if (check_ID == null)
                {
                    database.Configuration.ValidateOnSaveEnabled = false;
                    database.Accounts.Add(_user);
                    database.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.ErrorRegister = "Yêu cầu nhập lại";
                    return View();
                }           
            }            
            return View();
        }
        public ActionResult LogOutAcount(Account _user)
        {
            Session.Abandon();
            return RedirectToAction("Index", "Users");
        }
        public ActionResult NhapThongTin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NhapThongTin(NguoiDung pro)
        {
            database.Configuration.ValidateOnSaveEnabled = false;
            database.NguoiDungs.Add(pro);
            database.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}