using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car entity)
        {
            if (entity.Name.Length > 2 && entity.DailyPrice > 0)
                _carDal.Add(entity);
            else
                Console.WriteLine("Araba İsmi 2 Karakterden Küçük ve Günlük Fiyat 0 dan küçük olamaz");
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(c => c.Id == id);
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        //public List<Car> GetCarsByBrandId(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetCarsByColorId(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public void Update(Car entity)
        {
              _carDal.Update(entity);
        }
    }
}
