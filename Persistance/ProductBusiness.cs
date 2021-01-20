using Abacode.Controllers;
using Abacode.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abacode.Persistance
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly AdacodeDbContext _context;

        public ProductBusiness(AdacodeDbContext context)
        {
            _context = context;
        }

        public Product CreateProduct(ProductDto productDto)
        {
            var product = new Product()
            {
               CustomerCategory = productDto.CustomerCategory,
               Name = productDto.Name
            };
            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }

        public Product EditProduct(int id, EditProductDto productDto)
        {
            var product = GetProduct(id);
            _context.Products.Update(product);
            _context.SaveChanges();

            return product;
        }

        public Product GetProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(c => c.Id == id);
            if (product == null)
                throw new BadRequestException($"product with {id} doesn't exist");
            return product;
        }

        public IEnumerable<Product> GetProducts(Filter filter)
        {
            var query = _context.Products
                .AsQueryable();

            return query.ToList();
        }
    }
}
