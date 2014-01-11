using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jokes.Controllers
{
    public class JokesController : Controller
    {
        //
        // GET: /Jokes/
        public ActionResult Index()
        {
            return View();
        }
	}
}