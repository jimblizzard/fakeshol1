// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation" file="OrderSummaryViewModel.cs">
//   Copyright Microsoft Corporation. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.
// </copyright>
// <summary>
//   The OrderSummaryViewModel
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Microsoft.ALMRangers.FakesGuide.MainWeb.Models
{
    using System.Collections.Generic;

    public class OrderSummaryViewModel
    {
        public Order Order { get; set; }

        public List<OrderLines> OrderLines { get; set; }

        public double Total { get; set; }
    }
}