using ApplicationCore.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using SimpleContact.Models;
using SimpleContact.ViewModels;
using System;
using System.Diagnostics;

namespace SimpleContact.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _config;
        private readonly IEmailService _email;

        public HomeController(IConfiguration config,ILogger<HomeController> logger,IEmailService email)
        {
            _logger = logger;
            _config = config;
            _email = email;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EmailNew(EmailNewViewModel model)
        {
            @ViewBag.Message = "";
            if (ModelState.IsValid)
            {
                try
                {
                    await _email.SendContactEmailAsync(model.Name!, model.Email!, model.Subject!, model.Message!, false);
                    @ViewBag.Message = "Email sent successfully";
                }
                catch (Exception ex) 
                {                   
                    string errMessage = $"Failed to send email to {model.Name}";
                    _logger.LogError(errMessage, ex.InnerException == null ? ex.Message : ex.InnerException.ToString(), ex.StackTrace);
                    @ViewBag.Message= errMessage;                  
                   //return RedirectToAction(nameof(EmailNew), new { err = errMessage });
                    //return RedirectToAction(nameof(Index), new { model.Name, err = errMessage });
                }
               
            }            
            return View("index", model);            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}