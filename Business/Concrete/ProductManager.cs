using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IDataResult<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return new SuccessDataResult<List<Product>>(_productRepository.GetAll(filter),"Ürünler listelendi.");
        }
        public IDataResult<Product> Get(Expression<Func<Product, bool>> filter)
        {
            return new SuccessDataResult<Product>(_productRepository.Get(filter),"Ürün listelendi");
        }
        //return IResult add product
        public IResult Add(Product product)
        {
            _productRepository.Add(product);
            return new SuccessResult("Ürün eklendi");
        }
        //return IResult update product
        public IResult Update(Product product)
        {
            _productRepository.Update(product);
            return new SuccessResult("Ürün güncellendi");
        }
        //return IResult delete product
        public IResult Delete(Product product)
        {
            _productRepository.Delete(product);
            return new SuccessResult("Ürün silindi");
        }

    }
}
