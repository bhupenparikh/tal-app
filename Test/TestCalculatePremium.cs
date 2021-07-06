using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Web.Http.Results;
using Assert = NUnit.Framework.Assert;
using tal_app.Controllers;
using tal_app;
using System.Collections.Generic;

namespace tal_app.Test
{
    
    public class TestCalculatepremium
    { 
    
    [TestMethod]
        public void DepartmentGetByIdSuccess()
        {

            var testProducts = GetTestProducts();

            // Set up Prerequisites   
            var controller = new PremiumController();
            // Act on Test  
            var response = controller.Post(testProducts);
            var result = controller.Post(testProducts);

            Assert.IsNotNull(result);
        }


        private CalculatePremium GetTestProducts()
        {
            var testProducts = new  CalculatePremium();
            testProducts.Age = 70;
            testProducts.DeathSum = 7000;
            testProducts.Name = "bhupen";
            testProducts.Occupation = "Professional";



            return testProducts;
        }
    }

}





