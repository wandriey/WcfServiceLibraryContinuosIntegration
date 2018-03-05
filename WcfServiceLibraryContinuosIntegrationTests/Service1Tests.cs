using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceLibraryContinuosIntegration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryContinuosIntegration.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetNameSoapTest()
        {
            //Arrange
            Service1 service = new Service1();
            //act 
            string name = service.GetNameSoap();
            //assert
            Assert.AreEqual(name, "Jonas");
        }
    }
}