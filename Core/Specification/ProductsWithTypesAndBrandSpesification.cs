using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specification {
    public class ProductsWithTypesAndBrandSpesification : BaseSpecification<Product> {
        public ProductsWithTypesAndBrandSpesification () {
            AddInclude (x => x.ProductType);
            AddInclude (x => x.ProductBrand);
        }

        public ProductsWithTypesAndBrandSpesification (int id) : base (x => x.Id == id) {
            AddInclude (x => x.ProductType);
            AddInclude (x => x.ProductBrand);
        }
    }
}