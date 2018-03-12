using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using BusinessLogic.Logic;
using BusinessLogic.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebApplication1;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
          
            var _OrganisationLogic = new Mock<OrganisationLogic>();

            var testdata = new OrganisationModel { Id = 3, OrganisationName = "My Test Class Organisation" };
          
            _OrganisationLogic.Setup(p => p.GetOrganisation()).Returns(testdata).Callback<OrganisationModel>(p=>p = testdata);

            HomeController controller = new HomeController(_OrganisationLogic.Object);
            ViewResult result = controller.Index() as ViewResult;
            OrganisationViewModel model = (OrganisationViewModel)result.Model; 
            
            Assert.AreEqual(testdata.OrganisationName,model.OrganisationName);
        }
    }
}
