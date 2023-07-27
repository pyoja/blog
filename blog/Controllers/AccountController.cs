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
        private readonly ApplicationDbContext _context;

        public AccountController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        public JsonResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                // 회원 가입 처리 코드 작성
                _context.Users.Add(new User
                {
                    Name = model.Name,
                    Id = model.Id,
                    Password = model.Password,
                    RegDate = DateTime.Now,
                    DelState = 0
                });

                _context.SaveChanges();

                return Json(new { result = "success" });
            }
            else
            {
                return Json(new { result = "fail" });
            }
        }

        // GET: All Users
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
