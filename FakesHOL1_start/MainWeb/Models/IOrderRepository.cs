// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Microsoft Corporation" file="IOrderRepository.cs">
//   Copyright Microsoft Corporation. All Rights Reserved. This code released under the terms of the Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.) This is sample code only, do not use in production environments.
// </copyright>
// <summary>
//   The IOrderRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Microsoft.ALMRangers.FakesGuide.MainWeb.Models
{
    using System.Linq;

    public interface IOrderRepository
    {
        IQueryable<Order> All { get; }

        IQueryable<OrderLines> OrderLines(int id);

        Order Find(int id);
    }
}
