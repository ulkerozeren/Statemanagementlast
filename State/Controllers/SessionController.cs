using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace State.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Write()
        {
            HttpContext.Session.SetString("bilgeadam", "ba"+ DateTime.Now);
            return View("Ortak");
        }

        public IActionResult Read()
        {
            string bilgeadam= HttpContext.Session.GetString("bilgeadam");
            return View("Ortak",bilgeadam);
        }

        public IActionResult Delete()
        {
            HttpContext.Session.Remove("bilgeadam");
            return View("Ortak");
        }
    }
}