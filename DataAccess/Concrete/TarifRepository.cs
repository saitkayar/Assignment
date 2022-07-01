using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace DataAccess.Concrete
{
    public class TarifRepository : EfBaseRepository<Tarif, TariflerDbContext>, ITarifRepository
    {
        public List<TarifDto> GetTarifDto(Expression<Func<TarifDto, bool>> filter = null)
        {
            using (var context=new TariflerDbContext() )
            {
                var result = from t in context.Tarifler
                             join c in context.Categories
                             on t.CategoryId equals c.Id
                             select new TarifDto()
                             {
                                 Id = t.Id,
                                 Title=t.Title,
                                 CategoryName = c.Name,
                                 ImagePath = t.ImagePath,
                                 Slug = t.Slug

                             };

                return (filter == null) ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
