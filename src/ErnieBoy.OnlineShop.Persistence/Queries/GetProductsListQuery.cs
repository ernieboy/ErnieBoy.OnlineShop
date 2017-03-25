using ErnieBoy.OnlineShop.Application.Abstractions.Queries;
using System;
using System.Collections.Generic;
using ErnieBoy.OnlineShop.Application.ViewModels;

namespace ErnieBoy.OnlineShop.Persistence.Queries
{
    public class GetProductsListQuery : IGetProductsListQuery
    {
        public IEnumerable<ProductViewModel> Execute()
        {
            throw new NotImplementedException();
        }
    }
}
