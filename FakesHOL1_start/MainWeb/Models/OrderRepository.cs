// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation" file="OrderRepository.cs">
//   Copyright Microsoft Corporation. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.
// </copyright>
// <summary>
//   The OrderRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Microsoft.ALMRangers.FakesGuide.MainWeb.Models
{
    using System;
    using System.Linq;

    public class OrderRepository : IOrderRepository
    {
        public IQueryable<Order> All
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryable<OrderLines> OrderLines(int id)
        {
            throw new NotImplementedException();
        }

        public Order Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
