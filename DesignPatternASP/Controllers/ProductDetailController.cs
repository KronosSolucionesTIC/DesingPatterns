using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesignPatternASP.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            //Factories
            ForeignEarnFactory foreignFactory = new ForeignEarnFactory(0.30m, 20);

            //Products
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = foreignFactory.GetEarn();

            //Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
