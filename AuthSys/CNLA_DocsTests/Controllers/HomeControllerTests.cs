using Microsoft.VisualStudio.TestTools.UnitTesting;
using AuthSys.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AuthSys.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {

        //Testing the index method's returning state
        [TestMethod()]
        public void IndexTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        //Testing the index method's return value
        [TestMethod()]
        public void Index_Returns_IndexView()
        {
            HomeController controller = new HomeController();
            string ExpectedViewName = "Index";

            ViewResult result = controller.Index() as ViewResult;
            string ActualViewName = result.ViewName;

            Assert.AreEqual(ExpectedViewName, ActualViewName);
        }


        //Testing the Privacy method
        [TestMethod()]
        public void Privacy_Returns_PrivacyView()
        {
            HomeController controller = new HomeController();
            string ExpectedViewName = "Privacy";

            ViewResult result = controller.Privacy() as ViewResult;
            string ActualViewName = result.ViewName;

            Assert.AreEqual(ExpectedViewName, ActualViewName);
        }

        //Testing the CnlaInnersExterior method
        [TestMethod()]
        public void CnlaInnersExterior_Returns_CnlaInnersExteriorView()
        {
            HomeController controller = new HomeController();
            string ExpectedViewName = "CnlaInnersExterior";

            ViewResult result = controller.CnlaInnersExterior() as ViewResult;
            string ActualViewName = result.ViewName;

            Assert.AreEqual(ExpectedViewName, ActualViewName);
        }

        //Testing the CnlaInnersRisk method
        [TestMethod()]
        public void CnlaInnersRisk_Returns_CnlaInnersRiskView()
        {
            HomeController controller = new HomeController();
            string ExpectedViewName = "CnlaInnersRisk";

            ViewResult result = controller.CnlaInnersRisk() as ViewResult;
            string ActualViewName = result.ViewName;

            Assert.AreEqual(ExpectedViewName, ActualViewName);
        }

        //Testing the CnlaInnersLeadership method
        [TestMethod()]
        public void CnlaInnersLeadership_Returns_CnlaInnersLeadershipView()
        {
            HomeController controller = new HomeController();
            string ExpectedViewName = "CnlaInnersLeadership";

            ViewResult result = controller.CnlaInnersLeadership() as ViewResult;
            string ActualViewName = result.ViewName;

            Assert.AreEqual(ExpectedViewName, ActualViewName);
        }






    }
}