using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShelburneMemorialWeb.Controllers
{
    public class StoneInformation : Controller
    {
        // GET: StoneInformation
        public ActionResult Index()
        {
            return View("StoneInformation");
        }

        // GET: StoneInformation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoneInformation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoneInformation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoneInformation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoneInformation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoneInformation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoneInformation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
