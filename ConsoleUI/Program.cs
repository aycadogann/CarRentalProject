using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetailDtos().Data)
            //{
            //    Console.WriteLine("Model: " + car.CarName + "  Fiyat: " + car.ColorName + " Açıklama: " + car.BrandName);
            //}


            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //foreach (var item in rentalManager.GetAll().Data)
            //{
            //    Console.WriteLine(item.CarId + " " + item.RentDate.ToShortDateString());
            //}
        }
    }
}
