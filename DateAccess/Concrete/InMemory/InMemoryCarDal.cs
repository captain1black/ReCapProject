using DateAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal() {
            _cars = new List<Car> {
             new Car{CarId=1,BrandId=2,ColorId=1,ModelYear=2005,DailyPrice=3000,Description="Dizel,Manuel Araç"},
             new Car{CarId=2,BrandId=4,ColorId=1,ModelYear=2016,DailyPrice=12360,Description="Sahibinden bakımlı temiz araç"},
             new Car{CarId=3,BrandId=3,ColorId=1,ModelYear=2000,DailyPrice=500,Description="Bakımlı,Orijinal boyalı"},
             new Car{CarId=4,BrandId=3,ColorId=1,ModelYear=2008,DailyPrice=2300,Description="Otomatik,İknci el ,Temiz araç"},
             new Car{CarId=5,BrandId=1,ColorId=1,ModelYear=2019,DailyPrice=25800,Description="Sıfır,Otomatik,Benzinli Araç"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.CarId == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
