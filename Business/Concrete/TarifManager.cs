using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;

using System.Linq.Expressions;


namespace Business.Concrete
{
    public class TarifManager : ITarifService
    {

        private ITarifRepository _tarifRepository;

        public TarifManager(ITarifRepository tarifRepository)
        {
            _tarifRepository = tarifRepository;
        }
        [ValidationAspect(typeof(TarifValidator), Priority = 1)]
        public IResult Add(Tarif tarif)
        {
            _tarifRepository.Add(tarif);
            return new SuccessResult("yeni tarif eklendi");
        }

        public IResult Delete(Tarif tarif)
        {
            _tarifRepository.Delete(tarif);
            return new SuccessResult("tarif silindi");
        }

        public IDataResult<Tarif> Get(Expression<Func<Tarif, bool>> filter)
        {
            return new SuccessDataResult<Tarif>(_tarifRepository.Get(filter), "istenen tarif getirildi");
                }

        public IDataResult<List<TarifDto>> GetAll(Expression<Func<TarifDto, bool>> filter = null)
        {

            return new SuccessDataResult<List<TarifDto>>(_tarifRepository.GetTarifDto(filter), " tarifler getirildi");
        }
        [ValidationAspect(typeof(TarifValidator), Priority = 1)]
        public IResult Update(Tarif tarif)
        {
            _tarifRepository.Update(tarif);
            return new SuccessResult("güncelleme başarılı");
        }
    }
}
