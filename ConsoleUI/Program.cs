﻿
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            // CarAdd();
            // CarGetAll();
            // CarGetById(3);
            // CarUpdate();
            // CarDelete(1003);

            //CustomerAdd();
            //UserAdd();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental {
                CarId = 1,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate =DateTime.Now
               
             };

            rentalManager.Add(rental);
            
            //var result = rentalManager.GetAll();
            
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine(item.CustomerId);
            //}
           
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            User user = new User
            {
                FirstName = "Ali",
                LastName = "Deneme",
                EMail = "alideneme@deneme.com",
                Password = "123456abc"
            };
            userManager.Add(user);
            var result = userManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer { UserId = 2, CompanyName = "Deneme A.Ş." };
            customerManager.Add(customer);
            var result = customerManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CompanyName);
            }
        }

        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.GetCarDetails();
        //    if (result.Success)
        //    {
        //        foreach (var item in result.Data)
        //        {
        //            Console.WriteLine(item.CarName + "/ " + item.BrandName + "/" + item.ColorName);

        //        }
        //         Console.WriteLine(result.Message);
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }

        //}

        //private static void CarDelete(int id)
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    Car car3 = new Car();
        //    car3.Id = id;

        //    carManager.Delete(car3);
        //    foreach (var car in carManager.GetAll())
        //        Console.WriteLine("CarId:" + car.Id + " Car Name: " + car.Name);
        //}

        //private static void CarUpdate()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    Car car2 = new Car();
        //    car2.Id = 2;
        //    car2.Name = "TOGG 10X";
        //    carManager.Update(car2);
        //    foreach (var car in carManager.GetAll())
        //        Console.WriteLine(car.Name);
        //}

        //private static void CarAdd()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    Car car1 = new Car();
        //    car1.BrandId = 1;
        //    car1.ColorId = 1;
        //    car1.DailyPrice = 100;
        //    car1.Description = "Honda Civic";
        //    car1.ModelYear = 1996;
        //    car1.Name = "Honda";
        //    carManager.Add(car1);
        //}

        //private static void CarGetAll()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Name);
        //    }
        //}

        //private static void CarGetById(int id)
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetById(id))
        //    {
        //        Console.WriteLine(
        //                         "ID:" + car.Id+
        //                         "Name: " +car.Name
        //                         );

        //    }
        //}
    }
}
