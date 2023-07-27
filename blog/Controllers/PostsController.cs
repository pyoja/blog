using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog.Models;
using System.Data.Entity;
using System.Net;
using blog.Data;

namespace blog.Controllers
{
    public class PostsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Posts
        public ActionResult Index()
        {
            var posts = db.Posts.ToList(); //Posts 테이블에서 모든 게시물을 조회합니다.
            return View(posts); //게시물 목록을 View에 전달합니다.
        }

        // GET: Posts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) //id가 Null이면 에러 메시지를 반환합니다.
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Post post = db.Posts.Find(id); //id에 해당하는 게시물을 조회합니다.
            if (post == null) //게시물이 없으면 404 에러를 반환합니다.
            {
                return HttpNotFound();
            }

            return View(post); //조회한 게시물을 View에 전달합니다.
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "No,Title,Content,ImgUrl,Like,Comment,RegDate,DelState")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Add(post); //게시물을 DB에 추가합니다.
                db.SaveChanges(); //변경사항을 DB에 저장합니다.
                return RedirectToAction("Index"); //Index 페이지로 redirect합니다.
            }

            return View(post); //게시물 작성 페이지로 이동합니다.
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post); //게시물 수정 페이지로 이동합니다.
        }

        // POST: Posts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "No,Title,Content,ImgUrl,Like,Comment,RegDate,DelState")] Post post)
        {
            if (ModelState.IsValid)
            {
                db.Entry(post).State = EntityState.Modified; //DB의 해당 게시물을 수정합니다.
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(post);
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }

            return View(post); //게시물 삭제 페이지로 이동합니다.
        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Post post = db.Posts.Find(id);
            db.Posts.Remove(post); //DB에서 해당 게시물을 삭제합니다.
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose(); //DbContext를 해제합니다.
            }
            base.Dispose(disposing);
        }
    }
}
