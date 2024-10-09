using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName);
            }

            Console.WriteLine("-------------------------");

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName +" / "+ car.BrandName+ " / "+car.ColorName + " / " + car.DailyPrice);
            }


            Console.WriteLine("-------------------------");


            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var car in colorManager.GetAll())
            {
                Console.WriteLine(car.ColorName);
            }

            Console.WriteLine("-------------------------");

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var car in brandManager.GetAll())
            {
                Console.WriteLine(car.BrandName);
            }

           

        }
    }
}
