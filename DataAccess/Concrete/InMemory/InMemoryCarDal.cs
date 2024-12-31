using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal : ICarDal
{
    private List<Car> _cars = new()
    {
        new Car {Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2015, DailyPrice = 150, Description = "Renault Clio"},
        new Car {Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2016, DailyPrice = 200, Description = "Audi A3"},
        new Car {Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2017, DailyPrice = 250, Description = "BMW 3.20"},
        new Car {Id = 4, BrandId = 4, ColorId = 4, ModelYear = 2018, DailyPrice = 300, Description = "Mercedes C180"},
        new Car {Id = 5, BrandId = 5, ColorId = 5, ModelYear = 2019, DailyPrice = 350, Description = "Toyota Corolla"}
    };

    public List<Car> GetAll()
    {
        return _cars;
    }

    public Car Get(int id)
    {
        return _cars.SingleOrDefault(x=>x.Id == id)!;
    }

    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Update(Car car)
    {
        var carToUpdate = _cars.SingleOrDefault(x => x.Id == car.Id)!;
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.ModelYear = car.ModelYear;
        carToUpdate.DailyPrice = car.DailyPrice;
        carToUpdate.Description = car.Description;
    }

    public void Delete(Car car)
    {
        var carToDelete = _cars.SingleOrDefault(x => x.Id == car.Id)!;
        _cars.Remove(carToDelete);
    }
}