using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car entity);
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCasByColorId(int id);
    }
}
