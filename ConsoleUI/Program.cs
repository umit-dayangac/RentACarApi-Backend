using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine($"Id: {car.Id}, BrandId: {car.BrandId}, ColorId: {car.ColorId}, ModelYear: {car.ModelYear}, DailyPrice: {car.DailyPrice}, Description: {car.Description}");
}
