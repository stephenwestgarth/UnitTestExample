using BusinessLogic;
using BusinessLogic.Logic;
using BusinessLogic.Models;
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
        private ILogicRepository<OrganisationModel> _organisationLogic;

        public HomeController(ILogicRepository<OrganisationModel> logic)
        {
            _organisationLogic = logic;
        }

        public ActionResult Index()
        {
            var model = _organisationLogic.GetOrganisation().ToViewModel();
            return View(model);
        }
    }
}