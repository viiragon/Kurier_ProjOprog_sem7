using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppKurierska.Models;

namespace AppKurierska.Controllers
{
    public class PaczkiController : Controller
    {
        [HttpGet]
        public ActionResult NadajBezLogowania()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult NadajBezLogowania(List<NadajPaczkeViewModel> model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult NadajPaczke()
        {
            List<NadajPaczkeViewModel> model = new List<NadajPaczkeViewModel>();
            model.Add(new NadajPaczkeViewModel());
            model.Add(new NadajPaczkeViewModel()
            {
                imie = "imie",
                nazwisko = "nazwisko"
            });

            return View(model);
        }

        [HttpPost]
        public ActionResult NadajPaczke(List<NadajPaczkeViewModel> model)
        {
            return View();
        }
    }
}