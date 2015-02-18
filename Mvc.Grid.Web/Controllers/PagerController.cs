﻿using NonFactors.Mvc.Grid.Web.Context;
using System.Web.Mvc;

namespace Mvc.Grid.Web.Controllers
{
    public class PagerController : Controller
    {
        [HttpGet]
        public ActionResult PagesToDisplay()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult InitialPage()
        {
            return View(PeopleRepository.GetPeople());
        }

        [HttpGet]
        public ActionResult RowsPerPage()
        {
            return View(PeopleRepository.GetPeople());
        }
    }
}
