using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataProcessor;
using itvitea_Restaurant.Models;


namespace itvitea_Restaurant.Controllers
{
    public class ConsumeablesController : Controller
    {
        // GET: ConsumeablesController
        public ActionResult Index()
        {
            List<ConsumeableOrders> result = Connection.List<ConsumeableOrders>("ConsumeableOrder");

            return View();
        }

        // GET: ConsumeablesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConsumeablesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConsumeablesController/Create
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

        // GET: ConsumeablesController/Completed/5
        public ActionResult Completed(int id)
        {
            return View();
        }

        // GET: ConsumeablesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConsumeablesController/Edit/5
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

        // GET: ConsumeablesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConsumeablesController/Delete/5
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
