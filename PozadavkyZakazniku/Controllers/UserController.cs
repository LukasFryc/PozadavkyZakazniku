using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PozadavkyZakazniku.Service.Interfaces;
using PozadavkyZakazniku.Model;

namespace PozadavkyZakazniku.Web.Controllers
{
    public class UserController : Controller
    {

        readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET: User
        public ActionResult Index()
        {
            ICollection<UserModel> uzivatele = userService.GetUsers();
            return View(uzivatele);
        }

        public ActionResult Detail(int ID)
        {
            UserModel uzivatel = userService.GetUser(ID);
            return View(uzivatel);
        }

        [HttpPost]
        public ActionResult Create(UserModel user)
        {
            UserModel uzivatel = userService.CreateUser(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {            
            return View();

        }

        public ActionResult Delete(int ID)
        {
            userService.DeleteUser(ID);
            return RedirectToAction("Index");
        }

    }
}