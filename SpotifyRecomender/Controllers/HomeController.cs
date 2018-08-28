using SpotifyRecomender.Handlers.ApiClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace SpotifyRecomender.Controllers
{
    public class HomeController : Controller
    {
        private const string ClientId = "662300158a1647a3b6a73bf0c4786ced";
        private const string ClientSecret = "dd07498ff0d14189a70cbc5a15814cf8";
        protected const string BaseUrl = "https://api.spotify.com/";
        public string getAuthUri()

        {
            return "https://accounts.spotify.com/authorize/?client_id=" + ClientId +
            "&response_type=token" +

            "&redirect_uri=" + "http://localhost:51855/callback/Index/" +
            "&state=&scope=" + "" +
            "&show_dialog=true";
        }

        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult App()
        {
            // 10 hour's in finally

            return View();
        }

        public RedirectResult Login()
        {
            return Redirect(getAuthUri());
        }


    }
}