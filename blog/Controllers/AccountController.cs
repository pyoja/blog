﻿// controller/AccountController.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using blog.Data;
using blog.Models;

namespace blog.Controllers
{
    public class AccountController : Controller
    {
<<<<<<< HEAD
        private readonly ApplicationDbContext _context;

        public AccountController()
        {
            _context = new ApplicationDbContext();
=======
        private readonly AppDbContext _context;

        public AccountController()
        {
            _context = new AppDbContext();
>>>>>>> adeadff366e31d24dcdfb3092236b73f076c2a7c
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(User model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Users.Add(new User
                    {
                        Id = model.Id,
                        Password = model.Password,
                        Reg_date = DateTime.Now,
                        Del_state = 0
                    });

                    await _context.SaveChangesAsync();
                    return Json(new { success = true });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Error: " + ex.Message });
            }

            return Json(new { success = false, message = "유효하지 않은 입력입니다" });
        }




        // GET: All Users
        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        // 로그인
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
<<<<<<< HEAD
        public ActionResult Login(LoginViewModel model)
=======
        public async Task<ActionResult> Login(LoginViewModel model)
>>>>>>> adeadff366e31d24dcdfb3092236b73f076c2a7c
        {
            if (!ModelState.IsValid)
                return View(model);

<<<<<<< HEAD
            var user = _userManager.Find(model.Id, model.Password);
=======
            var user = _context.Users.FirstOrDefault(u => u.Id == model.Id && u.Password == model.Password);
>>>>>>> adeadff366e31d24dcdfb3092236b73f076c2a7c
            if (user == null)
            {
                ModelState.AddModelError("", "ID 또는 비밀번호가 잘못되었습니다.");
                return View(model);
            }
<<<<<<< HEAD

            // 로그인 성공한 경우, 인증 및 쿠키 설정
            FormsAuthentication.SetAuthCookie(model.Id, true);
            // 로그인에 성공하면 PostsController의 Index 액션으로 이동
            return RedirectToAction("Index", "Posts");
        }


    }
}
=======
            // 로그인 성공한 경우, 인증 및 쿠키 설정
            FormsAuthentication.SetAuthCookie(model.Id, true);
            return RedirectToAction("Index", "Posts");
        }

    }
}
>>>>>>> adeadff366e31d24dcdfb3092236b73f076c2a7c
