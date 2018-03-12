using BusinessLogic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModelExtensions;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private OrganisationLogic _organisationLogic;
        public HomeController(OrganisationLogic logic)
        {
            _organisationLogic = new OrganisationLogic();
        }

        public ActionResult Index()
        {
            var model = _organisationLogic.GetOrganisation().ToViewModel();
            return View(model);
        }
    }
}