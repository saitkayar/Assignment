using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;

using System.Linq.Expressions;


namespace Business.Abstract
{
    public interface ITarifService
    {
        public IDataResult<List<TarifDto>> GetAll(Expression<Func<TarifDto, bool>> filter = null);
        public IDataResult<Tarif> Get(Expression<Func<Tarif, bool>> filter);
        public IResult Add(Tarif tarif);
        public IResult Update(Tarif tarif);
        public IResult Delete(Tarif tarif);
    }
}
