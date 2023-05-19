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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental entity)
        {
            var sonuc = GetCarAvailable(entity.CarId);
            if (sonuc.ReturnDate == null)
            {
               return new ErrorResult(Messages.CarNotReturned);
            }

            _rentalDal.Add(entity);
            Console.WriteLine(sonuc.ReturnDate); 
            return new SuccessResult(Messages.UserAdded);
        }


        public void Delete(Rental entity)
        {
            _rentalDal.Delete(entity);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.UserAdded);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=> r.RentalId == id),Messages.UserListed);
        }

        public void Update(Rental entity)
        {
            _rentalDal.Update(entity);       
        }

        public Rental GetCarAvailable(int carId)
        {

            return _rentalDal.Get(r => r.CarId == carId);
           
        }
    }
}
