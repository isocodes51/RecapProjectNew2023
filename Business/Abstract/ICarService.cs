using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car entity);
        void Update(Car entity);
        void Delete(Car entity);
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        //List<Car> GetCarsByBrandId(int id);
        //List<Car> GetCarsByColorId(int id);
    }
}
