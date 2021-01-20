using Abacode.Controllers;
using System;
using System.Collections.Generic;

namespace Abacode.Persistance
{
    public interface IProductBusiness
    {
        Product EditProduct(int id, EditProductDto bookDto);
        Product CreateProduct(ProductDto book);
        IEnumerable<Product> GetProducts(Filter filter);
        Product GetProduct(int id);
    }
}