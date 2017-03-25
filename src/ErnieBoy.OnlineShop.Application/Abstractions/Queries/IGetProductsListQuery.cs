using ErnieBoy.OnlineShop.Application.ViewModels;
using System.Collections.Generic;

namespace ErnieBoy.OnlineShop.Application.Abstractions.Queries
{
    public interface IGetProductsListQuery
    {
        IEnumerable<ProductViewModel> Execute();
    }
}
