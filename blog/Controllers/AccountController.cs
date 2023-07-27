// controller/AccountController.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}