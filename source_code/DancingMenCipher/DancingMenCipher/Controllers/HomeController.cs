using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

using DancingMenCipher.Models;

namespace DancingMenCipher.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // POST: Home/Form
        [HttpPost]
        public ActionResult Form(FormCollection form)
        {
            List<string> ListofKeys = new List<string>();
            List<string> ListofValues = new List<string>();
            List<string> ListofChanges = new List<string>();
            List<char> ListPlainText = new List<char>();
            string message = "";

            // get text from textarea which is in Index Page
            message = Regex.Replace(form["textarea"], @"[^\w]", String.Empty).Trim();
            ViewData["CodeBreaking"] = form["textarea"];

            // use Counting.cs in Models folder
            var counts = message.CharacterCount();
            foreach (var key in counts.Select(v => v.Key)) ListofKeys.Add(key.ToString());
            foreach (var value in counts.Select(v => v.Value.ToString())) ListofValues.Add(value);

            // use for Canvas
            ViewData["ListofKeys"] = ListofKeys;
            ViewData["ListofValues"] = ListofValues;
            ViewData["Length"] = ListofKeys.Count;

            // use to display plaintext
            foreach (var key in ((Regex.Replace(form["textarea"], @"[^\w]", String.Empty)).CharacterCount()).Select(v => v.Key))
                ListPlainText.Add(key);
            ViewData["PlainText"] = ListPlainText;



            return View();
        }
    }
}