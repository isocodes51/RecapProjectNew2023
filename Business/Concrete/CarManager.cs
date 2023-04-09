using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCasByColorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
