using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace WebUI.Controllers
{
    public class ContactController : Controller
    {
        IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var result = _contactService.GetAll();
            return View(result);
        }



        public IActionResult IndexEng()
        {

            var result = _contactService.GetAll();
            return View(result);
        }
    }
}
