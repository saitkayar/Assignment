using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public IDataResult<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null);
        public IDataResult<Category> Get(Expression<Func<Category, bool>> filter);
        public IResult Add(Category category);
        public IResult Update(Category category);
        public IResult Delete(Category category);

    }
}
