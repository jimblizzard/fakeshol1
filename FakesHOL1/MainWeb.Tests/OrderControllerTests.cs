// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation" file="OrderControllerTests.cs">
//   Copyright Microsoft Corporation. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.
// </copyright>
// <summary>
//   The OrderControllerTests
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Microsoft.ALMRangers.FakesGuide.MainWeb.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using Microsoft.ALMRangers.FakesGuide.MainWeb.Controllers;
    using Microsoft.ALMRangers.FakesGuide.MainWeb.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ModelFakes = Microsoft.ALMRangers.FakesGuide.MainWeb.Models.Fakes;
    using Microsoft.QualityTools.Testing.Fakes;

    [TestClass]
    public class OrderControllerTests
    { 
        [TestMethod]
        public void OrderController_orderSummaryTotalCheck_equalsSum()
        { 
            // arrange
            const int TestOrderId = 10;

            IOrderRepository repository = new ModelFakes.StubIOrderRepository()
            {
                FindInt32 = id =>
                {
                    Order testOrder = new Order
                    {
                        Id = 1,
                        CustomerName = "jones",
                        TaxRate = 5
                    };

                    return testOrder;
                },

                OrderLinesInt32 = id =>
                {
                    var OrderLines = GetOrderLines();

                    return OrderLines.AsQueryable();
                }
            };

            var controller = new OrderController(repository);

            // act
            var result = controller.OrderLines(TestOrderId) as ViewResult;
            var data = result.Model as OrderSummaryViewModel;

            // assert
            Assert.AreEqual(5675, data.Total, "Order summary total not correct");
        }

        private static IQueryable<OrderLines> GetOrderLines()
        { 
            var orderLines = new List<OrderLines>
                        {
                            new OrderLines { Id = 10, IsTaxable = true, ProductName = "widget1", Quantity = 10, UnitCost = 10 },
                            new OrderLines { Id = 10, IsTaxable = false, ProductName = "widget2", Quantity = 20, UnitCost = 20 },
                            new OrderLines { Id = 10, IsTaxable = true, ProductName = "widget3", Quantity = 30, UnitCost = 30 },
                            new OrderLines { Id = 10, IsTaxable = false, ProductName = "widget4", Quantity = 40, UnitCost = 40 },
                            new OrderLines { Id = 10, IsTaxable = true, ProductName = "widget5", Quantity = 50, UnitCost = 50 },
                        };
            return orderLines.AsQueryable();
        }
    }
}
