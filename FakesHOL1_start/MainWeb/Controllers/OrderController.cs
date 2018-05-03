// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation" file="OrderController.cs">
//   Copyright Microsoft Corporation. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.
// </copyright>
// <summary>
//   The OrderController
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Microsoft.ALMRangers.FakesGuide.MainWeb.Controllers
{
    using System.Web.Mvc;
    using MainWeb.Models;
    using System.Linq;

    public class OrderController : Controller
    {
        private IOrderRepository repository;

        public OrderController() : this(new OrderRepository())
        {
        }

        public OrderController(IOrderRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult OrderLines(int id)
        {
            // replace this with code from Code 24
                var viewModel = new OrderSummaryViewModel(); 
                return this.View(viewModel);
            // replace this with code from Code 24


        }

    }
}
