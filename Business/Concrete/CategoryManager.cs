using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IDataResult<List<Category>> GetAll(Expression<Func<Category,bool>> filter=null)
        {
            return new SuccessDataResult<List<Category>>(_categoryRepository.GetAll(filter),"Kategoriler listelendi.");
        }
        public IDataResult<Category> Get(Expression<Func<Category,bool>> filter)
        {
            return new SuccessDataResult<Category>(_categoryRepository.Get(filter),"Kategori getirildi");
        }
        public IResult Add(Category category)
        {
            _categoryRepository.Add(category);
            return new SuccessResult("Kategori eklendi");
        }
        //return IResult update category
        public IResult Update(Category category)
        {
            _categoryRepository.Update(category);
            return new SuccessResult("Kategori güncellendi");
        }
        //return IResult delete category
        public IResult Delete(Category category)
        {
            _categoryRepository.Delete(category);
            return new SuccessResult("Kategori silindi");
        }
    }
}
