﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

       [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand entity)
        {
           
            _brandDal.Add(entity);
            return new SuccessResult(Messages.ProductAdded);   
        }

        public IResult Delete(Brand entity)
        {
            _brandDal.Delete(entity);
           return new SuccessResult(Messages.ProductDeleted) ;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == id));
        }

        public IResult Update(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
