using EFGetStarted.AspNet5.ExistingDb.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EFGetStarted.AspNet5.ExistingDb.Controllers
{
    public class BlogsController :Controller
    {
        private BloggingContext _context;

        public BlogsController(BloggingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View(_context.BLOG.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BLOG blog)
        {


            if (ModelState.IsValid)
            {
                _context.BLOG.Add(blog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }
    }
}
