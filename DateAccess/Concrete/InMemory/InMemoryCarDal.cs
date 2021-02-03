using DateAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal() {
            _cars = new List<Car> {
             new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2005,DailyPrice=3000,Description="Kazasız,Parça değişimi yok"},
             new Car{Id=2,BrandId=2,ColorId=1,ModelYear=2016,DailyPrice=12360,Description="Sahibinden bakımlı temiz araç"},
             new Car{Id=3,BrandId=3,ColorId=1,ModelYear=2000,DailyPrice=500,Description="Bakımlı,Orijinal boyalı"},
             new Car{Id=4,BrandId=4,ColorId=1,ModelYear=2008,DailyPrice=2300,Description="Ön cam değişikliği,Boya değişimi"},
             new Car{Id=5,BrandId=5,ColorId=1,ModelYear=2019,DailyPrice=25800,Description="Sıfır Araç"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
