// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation" file="Order.cs">
//   Copyright Microsoft Corporation. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.
// </copyright>
// <summary>
//   The Order
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Microsoft.ALMRangers.FakesGuide.MainWeb.Models
{
    using System.Collections.Generic;

    public class Order
    {
        public Order()
        {
            this.OrderLines = new HashSet<OrderLines>();
        }

        public int Id { get; set; }

        public string CustomerName { get; set; }

        public double TaxRate { get; set; }

        public ICollection<OrderLines> OrderLines { get; set; }
    }
}