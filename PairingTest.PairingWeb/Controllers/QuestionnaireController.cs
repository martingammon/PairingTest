using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PairingTest.PairingWeb.Controllers
{
    public class QuestionnaireController : Controller
    {
        // GET: Questionnaire
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Questionnaire()
        {
            return PartialView();
        }
    }
}