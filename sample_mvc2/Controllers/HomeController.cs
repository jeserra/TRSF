using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sample_mvc2.Models;

namespace sample_mvc2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
         public ViewResult RsvpForm ()
         {
             return View();
         }

        [HttpPost]
         public ViewResult RsvpForm(GuestResponse guestResponse)
         {
                if(ModelState.IsValid)
                {
                    Repositories.Repository.AddResponse(guestResponse);
                    return View("Thanks", guestResponse);
                }
                else 
                    return View();
         }

         public ViewResult ListResponses ()
         {
             return View(Repositories.Repository.Responses.Where(r=> r.WillAttend == true));
         }

        
    }
}
