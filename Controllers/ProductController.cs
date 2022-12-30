using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class ProductController : Controller
    {

       IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var result = _productService.GetAll();
            return View(result);
        }

        public IActionResult IndexDe()
        {
            return View();
        }

        public IActionResult IndexEng()
        {
            return View();
        }


        public IActionResult GetDetail(int id)
        {
            return View();
        }

        public IActionResult GetByCategory(int id)
        {
            var result = _productService.GetByCategory(id);
            return View(result);
        }

        public IActionResult GetByCategoryEng(int id)
        {
            var result = _productService.GetByCategory(id);
            return View(result);
        }

        public IActionResult GetByCategoryDe(int categoryId)
        {
            var result = _productService.GetByCategory(categoryId);
            return View(result);
        }
    }
}
