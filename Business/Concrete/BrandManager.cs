using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IResult Add(Brand entity)
        {
            if (entity.BrandName.Length > 2 )
            {
                _brandDal.Add(entity);
                return new SuccessResult(Messages.ProductAdded);
            }
            else
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
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

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
