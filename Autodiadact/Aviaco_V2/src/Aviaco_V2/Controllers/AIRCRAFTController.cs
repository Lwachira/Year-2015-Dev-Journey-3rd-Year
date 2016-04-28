using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Aviaco_V2.Models;

namespace Aviaco_V2.Controllers
{
    public class AIRCRAFTController : Controller
    {
        private AVIACOContext _context;

        public AIRCRAFTController(AVIACOContext context)
        {
            _context = context;    
        }

        // GET: AIRCRAFT
        public IActionResult Index()
        {
            var aVIACOContext = _context.AIRCRAFT.Include(a => a.AC_NUMBER);
            return View(aVIACOContext.ToList());
        }

        // GET: AIRCRAFT/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            AIRCRAFT aIRCRAFT = _context.AIRCRAFT.Single(m => m.AC_NUMBER == id);
            if (aIRCRAFT == null)
            {
                return HttpNotFound();
            }

            return View(aIRCRAFT);
        }

        // GET: AIRCRAFT/Create
        public IActionResult Create()
        {
            ViewData["MOD_CODE"] = new SelectList(_context.MODEL, "MOD_CODE", "MOD_CODENavigation");
            return View();
        }

        // POST: AIRCRAFT/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AIRCRAFT aIRCRAFT)
        {
            if (ModelState.IsValid)
            {
                _context.AIRCRAFT.Add(aIRCRAFT);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["MOD_CODE"] = new SelectList(_context.MODEL, "MOD_CODE", "MOD_CODENavigation", aIRCRAFT.MOD_CODE);
            return View(aIRCRAFT);
        }

        // GET: AIRCRAFT/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            AIRCRAFT aIRCRAFT = _context.AIRCRAFT.Single(m => m.AC_NUMBER == id);
            if (aIRCRAFT == null)
            {
                return HttpNotFound();
            }
            ViewData["MOD_CODE"] = new SelectList(_context.MODEL, "MOD_CODE", "MOD_CODENavigation", aIRCRAFT.MOD_CODE);
            return View(aIRCRAFT);
        }

        // POST: AIRCRAFT/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AIRCRAFT aIRCRAFT)
        {
            if (ModelState.IsValid)
            {
                _context.Update(aIRCRAFT);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["MOD_CODE"] = new SelectList(_context.MODEL, "MOD_CODE", "MOD_CODENavigation", aIRCRAFT.MOD_CODE);
            return View(aIRCRAFT);
        }

        // GET: AIRCRAFT/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            AIRCRAFT aIRCRAFT = _context.AIRCRAFT.Single(m => m.AC_NUMBER == id);
            if (aIRCRAFT == null)
            {
                return HttpNotFound();
            }

            return View(aIRCRAFT);
        }

        // POST: AIRCRAFT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            AIRCRAFT aIRCRAFT = _context.AIRCRAFT.Single(m => m.AC_NUMBER == id);
            _context.AIRCRAFT.Remove(aIRCRAFT);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
