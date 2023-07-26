using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog.Data;
using blog.Models;

namespace blog.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        public JsonResult Register(User model)
        {
            // 회원 가입 처리 코드 작성
            using (var context = new ApplicationDbContext())
            {
                context.Users.Add(new User
                {
                    Name = model.Name,
                    Id = model.Id,
                    Password = model.Password,
                    RegDate = DateTime.Now,
                    DelState = 0
                });

                context.SaveChanges();
            }

            return Json(new { result = "success" });
        }

        // GET: All Users
        public IEnumerable<User> GetAllUsers()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Users.ToList();
            }
        }
    }
}
