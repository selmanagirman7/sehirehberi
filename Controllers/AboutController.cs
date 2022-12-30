using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AboutController : Controller
    {
       IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var result = _aboutService.GetAll();
            return View(result);
        }



        public IActionResult IndexEng()
        {
            var result = _aboutService.GetAll();
            return View(result);
        }



        public IActionResult Mission()
        {
            var result = _aboutService.GetAll();
            return View(result);
        }

        public IActionResult MissionEng()
        {
            var result = _aboutService.GetAll();
            return View(result);
        }

        public IActionResult Certificate()
        {
            var result = _aboutService.GetAll();
            return View(result);
        }

        public IActionResult CertificateEng()
        {
            var result = _aboutService.GetAll();
            return View(result);
        }




        [HttpGet]
        public IActionResult AboutAdd()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AboutAdd(About about)
        {
            return RedirectToAction("AdminList","About");
        }

        public IActionResult AdminList()
        {
            return View();
        }




    }
}
