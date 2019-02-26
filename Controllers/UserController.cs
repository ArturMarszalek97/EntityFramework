using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;
using WebApplication7.DAL;

namespace WebApplication7.Controllers
{
    public class UserController : Controller
    {
        public List<User> userList
        {
           get
          {
              UserBL users = new UserBL();
             List<User> userList = users.GetUsers();
              return userList;
          }
         }
        // GET: User
        public ActionResult Index()
        {
           // UserBL users = new UserBL();
            //List<User> userList = users.GetUsers();
            return View(userList);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User u)
        {
            UserBL userBL = new UserBL();
            userBL.AddUser(u);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            User model = userList.Where(u => u.UserID == id).Single();
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(User model)
        {
            
            UserBL userBL = new UserBL();
            userBL.EditUser(model);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {

            UserBL userBL = new UserBL();
            userBL.RemoveUser(id);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            User user = userList.Where(u => u.UserID == id).Single();
            return View("Details", user);
        }

    }
}