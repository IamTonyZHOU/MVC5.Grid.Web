﻿using NonFactors.Mvc.Grid.Web.Context;
using System.Threading;
using System.Web.Mvc;

namespace Mvc.Grid.Web.Controllers
{
    public class JavascriptController : Controller
    {
        [HttpGet]
        public ActionResult RowClicked()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult Reload()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ReloadGrid()
        {
            return PartialView("_ReloadGrid", PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult ReloadEvents()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ReloadEventsGrid()
        {
            Thread.Sleep(500);

            return PartialView("_ReloadGrid", PeopleRepository.GetPeople());
        }
    }
}
