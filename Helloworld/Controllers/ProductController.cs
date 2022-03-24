using Helloworld.Models;
using Microsoft.AspNetCore.Mvc;

namespace Helloworld.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Repository.productObserve);
        }

        public IActionResult AddOrEdit(Guid? productId)
        {
            var product = Repository.Repository.GetProductById(productId);

            return View(product);
        }

        [HttpPost]
        public IActionResult AddOrEdit(Guid productId, [Bind("Id, Name, Category, Price")] Product model)
        {
            Repository.Repository.CreateOrUpdate(model);

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(Guid productId)
        {
            Repository.Repository.Delete(productId);

            return RedirectToAction(nameof(Index));

        }

    }
}