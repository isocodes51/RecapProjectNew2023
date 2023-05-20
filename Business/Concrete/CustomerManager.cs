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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal carDal)
        {
            _customerDal = carDal;
        }

        public IResult Add(Customer entity)
        {
            _customerDal.Add(entity);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(b => b.CustomerId == id));
        }

        public void Update(Customer entity)
        {
            _customerDal.Update(entity);
        }    
    }
}
