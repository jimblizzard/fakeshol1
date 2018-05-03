// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation" file="OrderLines.cs">
//   Copyright Microsoft Corporation. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.
// </copyright>
// <summary>
//   The OrderLines
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Microsoft.ALMRangers.FakesGuide.MainWeb.Models
{
    public class OrderLines
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public double UnitCost { get; set; }

        public bool IsTaxable { get; set; }

        public int Quantity { get; set; }
    }
}