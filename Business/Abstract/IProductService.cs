using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IProductService
    {
        public IDataResult<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null);
        public IDataResult<Product> Get(Expression<Func<Product, bool>> filter);
        public IResult Add(Product product);
        public IResult Update(Product product);
        public IResult Delete(Product product);

    }
}
