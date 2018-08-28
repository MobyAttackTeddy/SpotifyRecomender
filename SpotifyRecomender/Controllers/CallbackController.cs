using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpotifyRecomender.Models;

namespace SpotifyRecomender.Controllers
{
    public class CallbackController : Controller
    {
        // GET: Callback

        public void Store(string access_token)
        {

            Session["access_token"] = access_token ;

        }

        public ActionResult Index()
        {
            
            return View(new SpotifyRecomender.Models.AuthenticationResponse());
        }
    }
}