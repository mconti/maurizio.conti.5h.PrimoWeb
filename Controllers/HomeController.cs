using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using maurizio.conti._5h.PrimoWeb.Models;

namespace maurizio.conti._5h.PrimoWeb.Controllers
{
    public class HomeController : Controller
    {
        // Versione 1
        // public string Index() {
        //     return "Hello World";
        // }    

        // Versione 2
        // public IActionResult Index() {
        //     int hour = DateTime.Now.Hour;
        //     string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
        //     return View("Index", viewModel);
        // }

        [HttpGet]
        public IActionResult Index() {
            return View();
        }
        

        [HttpGet] 
        public IActionResult Prenota() 
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Prenota(GuestResponse response) {
            if ( ModelState.IsValid ) {
                Repository.AddResponse(response);
                return View("Grazie", response);
            } 
            else 
                return View();
        }        

        public ViewResult ListaInvitati() {
            return View(Repository.Responses.Where(r => r.Partecipo == true));
        }
    }

    public static class Repository {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses => responses;
        public static void AddResponse(GuestResponse response) {
            responses.Add(response);
        } 
    }
}
