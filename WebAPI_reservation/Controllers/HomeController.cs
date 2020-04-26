using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI_reservation.Models;

namespace WebAPI_reservation.Controllers
{
    public class HomeController : Controller
    {
        private BookRepository repository = BookRepository.Current;

        public ViewResult Index()
        {
            return View(repository.GetAll());
        }

        // GET: Home
        public ActionResult Add(Book newBook)
        {
            if (ModelState.IsValid)
            {
                repository.Add(newBook);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult Remove(int id)
        {
            repository.Remove(id);
            return RedirectToAction("Index");
        }

        public ActionResult Update(Book upBook)
        {
            if (ModelState.IsValid)
            {
                repository.Update(upBook);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }
    }
}