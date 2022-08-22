using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
            new Car {Id=1,ColorId=1,BrandId=1,DailyPrice=250,ModelYear="2005",Description="Dizel"},
            new Car {Id=2,ColorId=1,BrandId=1,DailyPrice=500,ModelYear="2010",Description="Manuel"},
            new Car {Id=3,ColorId=2,BrandId=2,DailyPrice=150,ModelYear="2010",Description="Manuel"},
            new Car {Id=4,ColorId=3,BrandId=2,DailyPrice=300,ModelYear="2020",Description="Benzin"},
            new Car {Id=5,ColorId=3,BrandId=2,DailyPrice=450,ModelYear="2021",Description="Ücretsiz iptal"},
            new Car {Id=6,ColorId=3,BrandId=3,DailyPrice=275,ModelYear="2021",Description="Ücretsiz iptal"},
            };
        }
        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public List<CarDetailDto> carDetailDtos()
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.Id == entity.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public void Update(Car entity)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == entity.Id);
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.CarName = entity.CarName;
            carToUpdate.ModelYear = entity.ModelYear;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.Description = entity.Description;
        }
    }
}
