using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using AviaCo.Models;

namespace AviaCo.Controllers
{
    public class CHARTERsController : Controller
    {
        private AVIACOContext _context;

        public CHARTERsController(AVIACOContext context)
        {
            _context = context;    
        }

        // GET: CHARTERs
        public IActionResult Index()
        {
           
            var aVIACOContext = _context.CHARTER.Include(c => c.AC_NUMBERNavigation).Include(c => c.CUS_CODENavigation);
            return View(aVIACOContext.ToList());
        }

        // GET: CHARTERs/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CHARTER cHARTER = _context.CHARTER.Single(m => m.CHAR_TRIP == id);
            if (cHARTER == null)
            {
                return HttpNotFound();
            }

            return View(cHARTER);
        }

        // GET: CHARTERs/Create
        public IActionResult Create()
        {
            ViewData["AC_NUMBER"] = new SelectList(_context.AIRCRAFT, "AC_NUMBER","AC_NUMBERNavigation");
            ViewData["CUS_CODE"] = new SelectList(_context.CUSTOMER, "CUS_CODE", "CUS_CODENavigation");
            return View();
        }

        // POST: CHARTERs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CHARTER cHARTER)
        {
            if (ModelState.IsValid)
            {
                _context.CHARTER.Add(cHARTER);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["AC_NUMBER"] = new SelectList(_context.AIRCRAFT, "AC_NUMBER", "AC_NUMBERNavigation", cHARTER.AC_NUMBER);

            ViewData["CUS_CODE"] = new SelectList(_context.CUSTOMER, "CUS_CODE", "CUS_CODENavigation", cHARTER.CUS_CODE);
            return View(cHARTER);
        }

        // GET: CHARTERs/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CHARTER cHARTER = _context.CHARTER.Single(m => m.CHAR_TRIP == id);
            if (cHARTER == null)
            {
                return HttpNotFound();
            }
            ViewData["AC_NUMBER"] = new SelectList(_context.AIRCRAFT, "AC_NUMBER", "AC_NUMBERNavigation", cHARTER.AC_NUMBER);
            ViewData["CUS_CODE"] = new SelectList(_context.CUSTOMER, "CUS_CODE", "CUS_CODENavigation", cHARTER.CUS_CODE);
            return View(cHARTER);
        }

        // POST: CHARTERs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CHARTER cHARTER)
        {
            if (ModelState.IsValid)
            {
                _context.Update(cHARTER);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["AC_NUMBER"] = new SelectList(_context.AIRCRAFT, "AC_NUMBER", "AC_NUMBERNavigation", cHARTER.AC_NUMBER);
            ViewData["CUS_CODE"] = new SelectList(_context.CUSTOMER, "CUS_CODE", "CUS_CODENavigation", cHARTER.CUS_CODE);
            return View(cHARTER);
        }

        // GET: CHARTERs/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            CHARTER cHARTER = _context.CHARTER.Single(m => m.CHAR_TRIP == id);
            if (cHARTER == null)
            {
                return HttpNotFound();
            }

            return View(cHARTER);
        }

        // POST: CHARTERs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            CHARTER cHARTER = _context.CHARTER.Single(m => m.CHAR_TRIP == id);
            _context.CHARTER.Remove(cHARTER);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
