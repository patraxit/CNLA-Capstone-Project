using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.

namespace UnitTestProject.Controllers
{
    class HomeControllerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new 
            var result = controller.Index as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }
    }
}
