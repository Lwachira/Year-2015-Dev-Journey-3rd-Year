using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using AviaCo.Models;

namespace AviaCo.Controllers
{
    public class CUSTOMERsController : Controller
    {
        private AVIACOContext _context;

        public CUSTOMERsController(AVIACOContext context)
        {
            _context = context;    
        }

        // GET: CUSTOMERs
        public IActionResult Index()
        {
            return View(_context.CUSTOMER.ToList());
        }

        // GET: CUSTOMERs/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CUSTOMER cUSTOMER = _context.CUSTOMER.Single(m => m.CUS_CODE == id);
            if (cUSTOMER == null)
            {
                return HttpNotFound();
            }

            return View(cUSTOMER);
        }

        // GET: CUSTOMERs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CUSTOMERs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CUSTOMER cUSTOMER)
        {
            if (ModelState.IsValid)
            {
                _context.CUSTOMER.Add(cUSTOMER);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cUSTOMER);
        }

        // GET: CUSTOMERs/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CUSTOMER cUSTOMER = _context.CUSTOMER.Single(m => m.CUS_CODE == id);
            if (cUSTOMER == null)
            {
                return HttpNotFound();
            }
            return View(cUSTOMER);
        }

        // POST: CUSTOMERs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CUSTOMER cUSTOMER)
        {
            if (ModelState.IsValid)
            {
                _context.Update(cUSTOMER);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cUSTOMER);
        }

        // GET: CUSTOMERs/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CUSTOMER cUSTOMER = _context.CUSTOMER.Single(m => m.CUS_CODE == id);
            if (cUSTOMER == null)
            {
                return HttpNotFound();
            }

            return View(cUSTOMER);
        }

        // POST: CUSTOMERs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            CUSTOMER cUSTOMER = _context.CUSTOMER.Single(m => m.CUS_CODE == id);
            _context.CUSTOMER.Remove(cUSTOMER);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
