using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarRentalContext carRentalContext=new CarRentalContext())
            {
                var addedCar = carRentalContext.Entry(entity);
                addedCar.State = EntityState.Added;
                carRentalContext.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (CarRentalContext carRentalContext = new CarRentalContext())
            {
                var deletedCar = carRentalContext.Entry(entity);
                deletedCar.State = EntityState.Deleted;
                carRentalContext.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarRentalContext carRentalContext = new CarRentalContext())
            {
                return carRentalContext.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalContext carRentalContext=new CarRentalContext())
            {
                return filter == null
                    ? carRentalContext.Set<Car>().ToList()
                    : carRentalContext.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (CarRentalContext carRentalContext = new CarRentalContext())
            {
                var updatedCar = carRentalContext.Entry(entity);
                updatedCar.State = EntityState.Modified;
                carRentalContext.SaveChanges();
            }
        }
    }
}
