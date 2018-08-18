using DemoCascadingProducts.Helper;
using System.Web.Mvc;

namespace DemoCascadingProducts.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            HomeHelper homeHelper = new HomeHelper();

            var listCompanies = homeHelper.GetCompanies();

            ViewBag.listCompanies = listCompanies;

            return View();
        }

        public JsonResult GetStores(int idCompany)
        {

            HomeHelper homeHelper = new HomeHelper();

            var listStores = homeHelper.GetStores(idCompany);

            return Json(listStores, JsonRequestBehavior.AllowGet);


        }
    }
}