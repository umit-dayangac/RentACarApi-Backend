﻿using Entities.Concrete;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetAll();
    Car Get(int id);
    void Add(Car car);
    void Update(Car car);
    void Delete(Car car);
}